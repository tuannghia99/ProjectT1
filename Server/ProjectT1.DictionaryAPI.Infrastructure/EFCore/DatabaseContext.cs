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

        public virtual DbSet<CommonCategory> CommonCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=VCS70;Initial Catalog=Database;User ID=sa; Password=123456Aa");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CommonCategory>(entity => {
                entity.HasKey(e => e.Oid)
                    .HasName("CommonCategory_PK");

                entity.ToTable("CommonCategory");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DateTime1).HasColumnType("datetime");

                entity.Property(e => e.DateTime2).HasColumnType("datetime");

                entity.Property(e => e.DateTime3).HasColumnType("datetime");

                entity.Property(e => e.DateTime4).HasColumnType("datetime");

                entity.Property(e => e.DateTime5).HasColumnType("datetime");

                entity.Property(e => e.Decimal1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Decimal2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Decimal3).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Decimal4).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Decimal5).HasColumnType("decimal(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
