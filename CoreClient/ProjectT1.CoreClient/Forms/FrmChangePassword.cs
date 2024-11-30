using app.StdCommon;
using DevExpress.XtraEditors;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace ProjectT1.CoreClient {
    public partial class FrmChangePassword : DevExpress.XtraEditors.XtraForm {
        HttpClient _httpClient = new();
        NVAccountClient _clientAccount;

        public FrmChangePassword() {
            InitializeComponent();
            _clientAccount = new NVAccountClient(_httpClient);
        }

        private async void btnSubmit_Click(object sender, EventArgs e) {
            try {
                fOldPassword.ErrorText = "";
                fNewPassword.ErrorText = "";
                fConfirmPassword.ErrorText = "";

                var check1 = !(fOldPassword.EditValue.IsNullOrEmpty());
                var check2 = !(fNewPassword.EditValue.IsNullOrEmpty());
                var check3 = !(fConfirmPassword.EditValue.IsNullOrEmpty());

                if (!check1 || !check2 || !check3) {
                    if (!check1) fOldPassword.ErrorText = "Chưa nhập Mật khẩu cũ";
                    if (!check2) fNewPassword.ErrorText = "Chưa nhập Mật khẩu mới";
                    if (!check3) fConfirmPassword.ErrorText = "Chưa nhập Xác nhận mật khẩu";
                    return;
                }

                var resChangePassword = await _clientAccount.ChangePasswordAsync(new ChangePasswordRequestDTO {
                    IdAccount = FrmMain.g_IdAccount,
                    OldPassword = fOldPassword.EditValue.ToString(),
                    NewPassword = fNewPassword.EditValue.ToString(),
                    ConfirmPassword = fConfirmPassword.EditValue.ToString(),
                });

                if (resChangePassword.Result == false) {
                    XtraMessageBox.Show(resChangePassword.InfoMessage, "Đổi mật khẩu thành thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else {
                    XtraMessageBox.Show("Đổi mật khẩu thành công\nThực hiện đăng nhập lại vào hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
            }
            catch {
                throw;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}