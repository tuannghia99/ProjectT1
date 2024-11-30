using FluentValidation;

namespace ProjectT1.CoreClient {
    public class NhanVienValidator : BaseValidator<NhanVienDTO> {
        public NhanVienValidator() {
            RuleFor(x => x.MaSo).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Mã số"));
            RuleFor(x => x.Ten).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Họ và tên"));
            RuleFor(x => x.NgaySinh).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Ngày sinh"));
            RuleFor(x => x.GioiTinh).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Giới tính"));
            RuleFor(x => x.NoiSinh).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Nơi sinh"));
            RuleFor(x => x.DiaChi).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Địa chỉ"));
            RuleFor(x => x.QuocTich).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Quốc tịch"));
            RuleFor(x => x.DanToc).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Dân tộc"));
            RuleFor(x => x.TonGiao).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Tôn giáo"));
            RuleFor(x => x.TinhTrangHonNhan).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Tình trạng hôn nhân"));

            RuleFor(x => x.IdPhongBan).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Phòng ban"));
            RuleFor(x => x.IdChucVu).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Chức vụ"));
            RuleFor(x => x.IdTrinhDoHocVan).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Trình độ học vấn"));

            RuleFor(x => x.Username).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Tên tài khoản"));
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Số điện thoại"));
            RuleFor(x => x.Email).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Email cá nhân"));
        }
    }
}