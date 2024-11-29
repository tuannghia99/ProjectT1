namespace ProjectT1.DictionaryAPI.Infrastructure.DTOs {
    public class ChangePasswordRequestDTO {
        public Guid IdAccount { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}