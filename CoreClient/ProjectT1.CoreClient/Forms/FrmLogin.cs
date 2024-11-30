using app.StdCommon;
using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace ProjectT1.CoreClient {
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm {
        HttpClient _httpClient = new();
        NVAccountClient _clientAccount;
        CNNhanVienClient _clientNhanVien;

        public FrmLogin() {
            InitializeComponent();
            _clientAccount = new NVAccountClient(_httpClient);
            _clientNhanVien = new CNNhanVienClient(_httpClient);
        }

        private async void btnLogin_Click(object sender, EventArgs e) {
            try {
                fUsername.ErrorText = "";
                fPassword.ErrorText = "";

                var check1 = !(fUsername.EditValue.IsNullOrEmpty());
                var check2 = !(fPassword.EditValue.IsNullOrEmpty());

                if (!check1 || !check2) {
                    if (!check1) fUsername.ErrorText = "Chưa nhập Tên đăng nhập";
                    if (!check2) fPassword.ErrorText = "Chưa nhập Mật khẩu";
                    return;
                }

                var resLogin = await _clientAccount.LoginAsync(new LoginRequestDTO {
                    UserName = fUsername.EditValue.ToString(),
                    Password = fPassword.EditValue.ToString()
                });

                if (resLogin.Result == false) {
                    XtraMessageBox.Show(resLogin.InfoMessage, "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmMain.g_IdAccount = (await _clientNhanVien.GetAllAsync()).Result.First(x => x.Username == fUsername.EditValue.SafeToString()).Oid;

                this.Hide();
                var formMain = new FrmMain();
                formMain.ShowDialog();
                this.Close();
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