using FluentValidation;

namespace ProjectT1.CoreClient {
    public class KyLuatValidator : BaseValidator<KyLuatDTO> {
        public KyLuatValidator() {
            RuleFor(x => x.MaSo).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Mã số"));
            RuleFor(x => x.IdNhanVien).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Nhân viên bị kỷ luật"));
            RuleFor(x => x.ThoiGianXayRa).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Thời gian xảy ra"));
            RuleFor(x => x.DiaDiemXayRa).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Địa điểm xảy ra"));
            RuleFor(x => x.MoTaSuViec).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Mô tả sự việc"));
            RuleFor(x => x.NhungNguoiChungKien).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Những người chứng kiến"));
            RuleFor(x => x.HinhThucKyLuat).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Hình thức kỷ luật"));
            RuleFor(x => x.NgayBatDauThiHanh).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Thời gian xảy ra"));
            RuleFor(x => x.NgayHetHieuLuc).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Thời gian xảy ra"));
        }
    }
}