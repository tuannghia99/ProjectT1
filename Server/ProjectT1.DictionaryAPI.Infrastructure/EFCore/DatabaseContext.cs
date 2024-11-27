using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GenerateModelSQLServerEFCore.Models {
    public partial class DatabaseContext : DbContext {
        public DatabaseContext() {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options) {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryConfig> CategoryConfigs { get; set; }
        public virtual DbSet<Dm0002> Dm0002s { get; set; }
        public virtual DbSet<FileAttachment> FileAttachments { get; set; }
        public virtual DbSet<SyncHistory> SyncHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //                optionsBuilder.UseSqlServer("Data Source=192.168.1.10,1433\\SQL2012;Initial Catalog=Database;Persist Security Info=True;User ID=hungnd; Password=123456Aa@@");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Category>(entity => {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(255);

                entity.Property(e => e.Classify)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataVersion)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.LastUser).HasMaxLength(225);

                entity.Property(e => e.MapCategoryX)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MapDtoY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchemaVersion)
                    .HasMaxLength(225)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CategoryConfig>(entity => {
                entity.HasKey(e => e.Oid)
                    .HasName("CategoryConfig_PK");

                entity.ToTable("CategoryConfig");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.CategoryId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CategoryID");

                entity.Property(e => e.DataVersionConfig)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.HistoryId).HasColumnName("HistoryID");

                entity.Property(e => e.SchemaVersionConfig)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateUser).HasMaxLength(225);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryConfigs)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryConfig_Category");
            });

            modelBuilder.Entity<Dm0002>(entity => {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_DM0001");

                entity.ToTable("DM0002");

                entity.HasIndex(e => new { e.CategoryId, e.Sorting, e.Mscode, e.Oid }, "idx_DM0002");

                entity.Property(e => e.Oid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CategoryId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CategoryID");

                entity.Property(e => e.DataVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Decimal1).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Decimal10).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Decimal2).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Decimal3).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Decimal4).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Decimal5).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Decimal6).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Decimal7).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Decimal8).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Decimal9).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LinkString1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkString10)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkString2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkString3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkString4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkString5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkString6)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkString7)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkString8)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkString9)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mscode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MSCode");

                entity.Property(e => e.Msname)
                    .IsRequired()
                    .HasColumnName("MSName");

                entity.Property(e => e.Sorting).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<FileAttachment>(entity => {
                entity.HasKey(e => e.Oid)
                    .HasName("FileAttachment_PK");

                entity.ToTable("FileAttachment");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.CreateUser).HasMaxLength(255);

                entity.Property(e => e.FieldCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyncHistory>(entity => {
                entity.HasKey(e => e.Oid)
                    .HasName("History_PK");

                entity.ToTable("SyncHistory");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.CategoryId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CategoryID");

                entity.Property(e => e.HistoryBy).HasMaxLength(225);

                entity.Property(e => e.HistoryCode)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SyncHistories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_History_Category");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
