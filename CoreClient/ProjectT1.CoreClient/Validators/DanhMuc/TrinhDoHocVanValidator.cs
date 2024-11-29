using FluentValidation;
using ProjectT1.CoreClient;

namespace ProjectT1.CoreClient {
    public class TrinhDoHocVanValidator : BaseValidator<TrinhDoHocVanDTO> {
        public TrinhDoHocVanValidator() {
            RuleFor(x => x.MaSo).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Mã số"));
            RuleFor(x => x.Ten).NotEmpty().WithMessage(string.Format(strMess_MissingRequirements, "Tên"));
        }
    }
}