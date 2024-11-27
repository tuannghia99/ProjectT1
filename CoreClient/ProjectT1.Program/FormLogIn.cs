using app.Common;
using app.StdCommon;
using DevExpress.XtraEditors;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using ProjectX.CoreClient;
using System.IO;
using VCSCASStdLib;

namespace ProjectT1.CoreClient {
    public partial class FormLogIn : DevExpress.XtraEditors.XtraForm {
        IEnumerable<Account> _dataAccount;
        bool _isLoginSucess = false;
        SessionAPI _session;
        private readonly ILogger _logger;

        public FormLogIn(ILogger logger) {
            InitializeComponent();
            _logger = logger;
        }

        private void FormLogIn_Load(object sender, EventArgs e) {
            LoadDataRepo();
        }

        private void LoadDataRepo() {
            _dataAccount = Account.GetListAccounts();
            edAccName.LoadFromObject(_dataAccount, "Oid", "AccName");
            edAccName.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
        }

        private void edAccName_EditValueChanged(object sender, EventArgs e) {
            var editor = sender as LookUpEdit;
            var oid = editor.EditValue.ConvertToGuid();
            var acc = _dataAccount.FirstOrDefault(x => x.Oid == oid);

            edUrl.EditValue = acc?.Url.SafeToString();
            edUsername.EditValue = acc?.Username.SafeToString();
            edPassword.EditValue = "vpm@2022+1";
        }

        private async void btnLogin_ClickAsync(object sender, EventArgs e) {
            try {
                btnLogin.Enabled = false;
                var url = edUrl.EditValue.SafeToString();
                var username = edUsername.EditValue.SafeToString();
                var password = edPassword.EditValue.SafeToString();
                var hPassword = VCSCASStdLib.Utility.HashPassword(password);

                _session = new SessionAPI();
                _session.SetCurrentUrl(url);
                var result = await _session.EstablishConnectionAsync(username, hPassword);
                await _session.AuthenticateServiceAsync();
                if (result != null) {
                    BusInstance.InitApiClient(_session.ServiceToken, _session.CurrentUser.BaseServiceUri, _logger);
                    _isLoginSucess = true;

                    var args = new XtraMessageBoxArgs();
                    args.Showing += (s, e) => {
                        e.Buttons[DialogResult.Continue].Text = "Copy userId";
                        e.Buttons[DialogResult.Yes].Text = "Copy Id đơn vị";
                        e.Buttons[DialogResult.No].Text = "Copy token";
                    };
                    args.Text = "Đăng nhập thành công !!!\nChào mừng đến với chương trình ❤️";
                    args.Caption = "THÔNG BÁO";
                    args.Buttons = [DialogResult.OK, DialogResult.Continue, DialogResult.Yes, DialogResult.No];
                    args.MessageBeepSound = MessageBeepSound.Information;
                    args.ImageOptions.MessageBoxIcon = MessageBoxIcon.Information;


                    var cont = true;
                    while (cont) {
                        var s = XtraMessageBox.Show(args);
                        if (s == DialogResult.Continue) {
                            Clipboard.SetText(_session.CurrentUser.UserID.SafeToString());
                        }
                        if (s == DialogResult.Yes) {
                            Clipboard.SetText(_session.CurrentUser.ServiceWebCustomerID.SafeToString());
                        }
                        if (s == DialogResult.No) {
                            Clipboard.SetText(_session.ServiceToken);
                        }
                        if (s == DialogResult.OK) {
                            cont = false;
                        }
                    }
                    this.Visible = false;
                    FormMain._sessionAPI = _session;
                }
                else {
                    _isLoginSucess = false;
                    XtraMessageBox.Show("Đăng nhập thất bại !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) {

            }
            finally {
                btnLogin.Enabled = true;
            }
        }

        private void FormLogIn_FormClosing(object sender, FormClosingEventArgs e) {
            if (!_isLoginSucess) {
                Application.Exit();
            }
        }
    }
}