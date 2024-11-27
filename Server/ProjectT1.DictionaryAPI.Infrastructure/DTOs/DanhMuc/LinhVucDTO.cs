namespace ProjectT1.DictionaryAPI.Infrastructure.DTOs {
    public class LinhVucDTO {
        public Guid Oid { get; set; }
        public Guid? IdDonViSuDungChuongTrinh { get; set; }
        public string MaSo { get; set; }
        public string Ten { get; set; }
    }
}