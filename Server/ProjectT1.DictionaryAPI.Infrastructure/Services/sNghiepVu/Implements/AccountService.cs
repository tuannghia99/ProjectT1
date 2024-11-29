using AutoMapper;
using GenerateModelSQLServerEFCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectT1.DictionaryAPI.Infrastructure.DTOs;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectT1.DictionaryAPI.Infrastructure.Services {
    public class AccountService(
        DatabaseContext _context,
        IMapper _mapper,
        ILogger<AccountService> _logger
        ) : IAccountService {
        public async Task<(string Result, int Code, string Message)> HashPassword(string password) {
            _logger.LogInformation("HashPassword called");
            try {
                var hPassword = HashPasswordByMD5(password);
                _logger.LogTrace("HashPassword success");
                return (hPassword, StatusCodes.Status200OK, null);
            }
            catch (Exception ex) {
                _logger.LogError(ex, nameof(HashPassword));
                return (null, StatusCodes.Status400BadRequest, ex.Message);
            }
        }
        public async Task<(bool Result, int Code, string Message)> Login(LoginRequestDTO request) {
            _logger.LogInformation("Login called");
            try {
                var user = await _context.NhanViens.AsNoTracking().FirstOrDefaultAsync(x => x.Username == request.UserName);
                if (user == null) {
                    return (false, StatusCodes.Status400BadRequest, "Tài khoản không tồn tại");
                }
                if (HashPasswordByMD5(request.Password) != user.Password) {
                    return (false, StatusCodes.Status400BadRequest, "Mật khẩu không đúng");
                }
                _logger.LogTrace("Login success");
                return (true, StatusCodes.Status200OK, "Đăng nhập thành công");
            }
            catch (Exception ex) {
                _logger.LogError(ex, nameof(Login));
                return (false, StatusCodes.Status400BadRequest, ex.Message);
            }
        }
        public async Task<(bool Result, int Code, string Message)> ChangePassword(ChangePasswordRequestDTO request) {
            _logger.LogInformation("ChangePassword called");
            using var transaction = await _context.Database.BeginTransactionAsync();
            try {
                var user = await _context.NhanViens.FirstOrDefaultAsync(x => x.Oid == request.IdAccount);
                if (user == null) {
                    return (false, StatusCodes.Status400BadRequest, "Tài khoản không tồn tại");
                }
                if (HashPasswordByMD5(request.OldPassword) != user.Password) {
                    return (false, StatusCodes.Status400BadRequest, "Mật khẩu cũ không đúng");
                }
                else {
                    if (request.OldPassword == request.NewPassword) {
                        return (false, StatusCodes.Status400BadRequest, "Mật khẩu mới trùng mật khẩu cũ");
                    }
                    else if (request.ConfirmPassword != request.NewPassword) {
                        return (false, StatusCodes.Status400BadRequest, "Mật khẩu mới và xác nhận mật khẩu không khớp");
                    }
                }
                user.Password = HashPasswordByMD5(request.NewPassword);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                _logger.LogTrace("ChangePassword success");
                return (true, StatusCodes.Status200OK, "Đổi mật khẩu thành công");
            }
            catch (Exception ex) {
                await transaction.RollbackAsync();
                _logger.LogError(ex, nameof(ChangePassword));
                return (false, StatusCodes.Status400BadRequest, ex.Message);
            }
        }
        public async Task<(bool Result, int Code, string Message)> ResetPassword(ResetPasswordRequestDTO request) {
            _logger.LogInformation("ResetPassword called");
            using var transaction = await _context.Database.BeginTransactionAsync();
            try {
                var user = await _context.NhanViens.FirstOrDefaultAsync(x => x.Oid == request.IdAccount);
                if (user == null) {
                    return (false, StatusCodes.Status400BadRequest, "Tài khoản không tồn tại");
                }
                user.Password = HashPasswordByMD5(request.DefaultPassword);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                _logger.LogTrace("ResetPassword success");
                return (true, StatusCodes.Status200OK, "Đặt lại mật khẩu thành công");
            }
            catch (Exception ex) {
                await transaction.RollbackAsync();
                _logger.LogError(ex, nameof(ResetPassword));
                return (false, StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        private string HashPasswordByMD5(string password) {
            using MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashBytes) {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}