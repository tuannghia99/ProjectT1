using FluentValidation;
using System;

namespace ProjectT1.CoreClient {
    public class BaseValidator<T> : AbstractValidator<T> {
        protected readonly string strMess_MissingRequirements = "Thiếu trường thông tin \"{0}\"";
        protected readonly string strMess_InvalidMaSo = "Mã số đã bị trùng, vui lòng kiểm tra lại";
        protected readonly string strMess_InvalidPeriodOfTime = "{0}";


        protected bool CheckValidPeriodOfTime(int? timeFrom, int? timeTo) {
            try {
                if (timeFrom == null || timeTo == null) return false;
                if (timeFrom > timeTo) return false;
                return true;
            }
            catch (Exception ex) {
                throw new Exception(ex.Message, ex);
            }
        }
        protected bool CheckValidPeriodOfTime(DateTime? timeFrom, DateTime? timeTo) {
            try {
                if (timeFrom == null || timeTo == null) return false;
                if (timeFrom > timeTo) return false;
                return true;
            }
            catch (Exception ex) {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
