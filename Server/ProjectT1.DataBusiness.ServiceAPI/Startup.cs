using Asp.Versioning;
using AutoMapper;
using GenerateModelSQLServerEFCore.Models;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using System;
using System.Linq;
using ProjectT1.DictionaryAPI.Infrastructure.Mappings;

[assembly: ApiConventionType(typeof(DefaultApiConventions))]
namespace ProjectT1.DataBusiness.ServiceAPI {
    public class Startup {
        public Startup(IConfiguration configuration) {
            //LogManager.LoadConfiguration(String.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            // ApiVersioing Configurations
            services.AddControllers();
            services.AddApiVersioning(options => {
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.ReportApiVersions = true;
                options.ApiVersionReader = ApiVersionReader.Combine(new UrlSegmentApiVersionReader(),
                                                                    new HeaderApiVersionReader("x-api-version"),
                                                                    new MediaTypeApiVersionReader("x-api-version"));
            }).AddApiExplorer(setup => {
                setup.GroupNameFormat = "'v'VVV";
                setup.SubstituteApiVersionInUrl = true;
            });
            services.AddEndpointsApiExplorer();
            //services.AddSwaggerGen();

            services.AddLogging(config => {
                config.ClearProviders();
                config.AddNLog();
                config.AddDebug();
                config.AddConsole();
            });

            services.AddDbContext<DatabaseContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("ProjectT1Database"));
            }, ServiceLifetime.Transient);

            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc => {
                mc.AddProfile(new MappingProfile_ChucNang());
                mc.AddProfile(new MappingProfile_DanhMuc());
            });

            var cacheEntryOptions = new DistributedCacheEntryOptions();

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddSingleton<IDistributedCache, MemoryDistributedCache>();

            // inject Services & Validators
            services.ConfigServices();
            services.ConfigValidators();

            // Multiple API versions - OpenAPI generation
            var versions = new[] {
                new Version(1,0),
                new Version(2,0),
            };

            foreach (var version in versions) {
                services.AddOpenApiDocument(options => {
                    options.AddSecurity("Bearer", Enumerable.Empty<string>(), new NSwag.OpenApiSecurityScheme() {
                        Description = "JWT Authorization header using the Bearer scheme (Example: 'Bearer 12345abcdef')",
                        Name = "Authorization",
                        In = NSwag.OpenApiSecurityApiKeyLocation.Header,
                        Type = NSwag.OpenApiSecuritySchemeType.ApiKey,
                        Scheme = "Bearer"
                    });

                    options.Title = "QuanLyNhanSu ServiceAPI";
                    options.Description = "An ASP.NET Core Web API for managing ServiceAPI items";
                    options.DocumentName = "v" + version.Major;
                    options.ApiGroupNames = new string[] { "v" + version.Major };
                    options.Version = version.Major + "." + version.Minor;
                    options.AllowReferencesWithProperties = true;
                });
            }

            services.AddCors(options => {
                options.AddPolicy("AllowAll", builder => {
                    builder.AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                });
            });

            // Cache
            services.AddDistributedMemoryCache();

            // health checks
            services.AddHealthChecks()
                .AddCheck("self", () => HealthCheckResult.Healthy())
                .AddSqlServer(Configuration.GetConnectionString("ProjectT1Database"),
                                name: "ProjectX1DB-check",
                                tags: new string[] { "ProjectX1DB" });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment() || env.IsProduction()) {
                app.UseDeveloperExceptionPage();
                app.UseOpenApi();
                app.UseSwaggerUi3();
                app.UseReDoc(c => {
                    c.DocumentTitle = "REDOC API Documentation";
                    c.SpecUrl = "/swagger/v1/swagger.json";
                });
            }
            else {
                app.UseExceptionHandler("/error");
            }

            app.UseCors("AllowAll");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });

            app.UseHealthChecks("/liveness",
                new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions {
                    Predicate = r => r.Name.Contains("self")
                }).UseHealthChecks("/hc",
                new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions {
                    Predicate = _ => true,
                    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
                });
        }
    }
}