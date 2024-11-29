namespace ProjectT1.DictionaryAPI.Infrastructure.DTOs {
    public class NhanVienDTO : IModifiedInfoDTO {
        public Guid Oid { get; set; }
        public string MaSo { get; set; }
        public string Ten { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string NoiSinh { get; set; }
        public string DiaChi { get; set; }
        public string QuocTich { get; set; }
        public string DanToc { get; set; }
        public string TonGiao { get; set; }
        public string TinhTrangHonNhan { get; set; }
        public string NgoaiNgu { get; set; }
        public string TinHoc { get; set; }

        public string SoCanCuoc { get; set; }
        public DateTime? NgayCap { get; set; }
        public string NoiCap { get; set; }

        public string TinhTrangSucKhoe { get; set; }
        public decimal? ChieuCao { get; set; }
        public decimal? CanNang { get; set; }

        public Guid? IdChucVu { get; set; }
        public Guid? IdPhongBan { get; set; }
        public Guid? IdTrinhDoHocVan { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public byte[] Avatar { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }

        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}