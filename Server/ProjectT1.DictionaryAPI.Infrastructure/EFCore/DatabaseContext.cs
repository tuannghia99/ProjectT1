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
        public virtual DbSet<KhenThuong> KhenThuongs { get; set; }
        public virtual DbSet<KyLuat> KyLuats { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //                optionsBuilder.UseSqlServer("Data Source=.\\;Initial Catalog=Database;User ID=sa; Password=123456Aa");
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

            modelBuilder.Entity<KhenThuong>(entity => {
                entity.HasKey(e => e.Oid)
                    .HasName("KhenThuong_PK");

                entity.ToTable("KhenThuong");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NgayKhenThuong).HasColumnType("datetime");
            });

            modelBuilder.Entity<KyLuat>(entity => {
                entity.HasKey(e => e.Oid)
                    .HasName("KyLuat_PK");

                entity.ToTable("KyLuat");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NgayBatDauThiHanh).HasColumnType("datetime");

                entity.Property(e => e.NgayHetHieuLuc).HasColumnType("datetime");

                entity.Property(e => e.ThoiGianXayRa).HasColumnType("datetime");
            });

            modelBuilder.Entity<NhanVien>(entity => {
                entity.HasKey(e => e.Oid)
                    .HasName("NhanVien_PK");

                entity.ToTable("NhanVien");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.CanNang).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChieuCao).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NgayCap).HasColumnType("datetime");

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
