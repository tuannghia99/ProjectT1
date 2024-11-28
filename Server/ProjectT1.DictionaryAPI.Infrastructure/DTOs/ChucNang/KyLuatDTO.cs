namespace ProjectT1.DictionaryAPI.Infrastructure.DTOs {
    public class KyLuatDTO : IModifiedInfoDTO {
        public Guid Oid { get; set; }
        public string MaSo { get; set; }
        public Guid? IdNhanVien { get; set; }
        public DateTime? ThoiGianXayRa { get; set; }
        public string DiaDiemXayRa { get; set; }
        public string MoTaSuViec { get; set; }
        public string NhungNguoiChungKien { get; set; }
        public bool? IsViPhamChinhSachCongTy { get; set; }
        public string DienGiai { get; set; }
        public string HinhThucKyLuat { get; set; }
        public DateTime? NgayBatDauThiHanh { get; set; }
        public DateTime? NgayHetHieuLuc { get; set; }

        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}