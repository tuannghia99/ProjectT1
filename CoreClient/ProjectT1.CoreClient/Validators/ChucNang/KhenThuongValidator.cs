using FluentValidation;

namespace ProjectT1.CoreClient {
    public class KhenThuongValidator : BaseValidator<KhenThuongDTO> {
        public KhenThuongValidator() {
            RuleFor(x => x.MaSo).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Mã số"));
            RuleFor(x => x.IdNhanVien).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Nhân viên được khen thưởng"));
            RuleFor(x => x.CanCuKhenThuong).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Căn cứ khen thưởng"));
            RuleFor(x => x.LyDoKhenThuong).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Lý do khen thưởng"));
            RuleFor(x => x.HinhThucKhenThuong).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Hình thức khen thưởng"));
            RuleFor(x => x.MucKhenThuong).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Mức khen thưởng"));
            RuleFor(x => x.NgayKhenThuong).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Ngày khen thưởng"));
        }
    }
}