using ProjectT1.DictionaryAPI.Infrastructure.DTOs;
using System.Threading.Tasks;

namespace ProjectT1.DictionaryAPI.Infrastructure.Services {
    public interface IAccountService {
        Task<(string Result, int Code, string Message)> HashPassword(string password);
        Task<(bool Result, int Code, string Message)> Login(LoginRequestDTO request);
        Task<(bool Result, int Code, string Message)> ChangePassword(ChangePasswordRequestDTO request);
        Task<(bool Result, int Code, string Message)> ResetPassword(ResetPasswordRequestDTO request);
    }
}