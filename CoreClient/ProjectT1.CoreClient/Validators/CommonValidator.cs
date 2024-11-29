using DevExpress.XtraEditors;
using FluentValidation.Results;
using System.Linq;
using System.Windows.Forms;

namespace ProjectT1.CoreClient {
    public class CommonValidator {
        public static void ShowValidationErrorMessage(ValidationResult validationResult) {
            if (validationResult.IsValid) return;
            var errorMessage = string.Join("\n", validationResult.Errors.Select(x => $"- {x.ErrorMessage}"));
            XtraMessageBox.Show(errorMessage, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}