namespace ProjectT1.DictionaryAPI.Infrastructure.DTOs {
    public interface IModifiedInfoDTO {
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
