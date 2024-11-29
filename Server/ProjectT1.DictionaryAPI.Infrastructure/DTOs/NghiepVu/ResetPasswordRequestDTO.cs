namespace ProjectT1.DictionaryAPI.Infrastructure.DTOs {
    public class ResetPasswordRequestDTO {
        public Guid IdAccount { get; set; }
        public string DefaultPassword { get; set; }
    }
}