using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Microsoft.Extensions.Logging;
using ProjectT1.CoreClient;
using VCSCASStdLib;

namespace ProjectX.CoreClient {
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm {
        private XtraForm? _formCurrent;
        public static SessionAPI _sessionAPI;
        private readonly ILogger<FormMain> _logger;
        public FormMain(ILogger<FormMain> logger) {
            InitializeComponent();
            _logger = logger;
        }
        private async void FormMain_LoadAsync(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Maximized;
            var formLogIn = new FormLogIn(_logger);
            formLogIn.ShowDialog();
            txtBusVersion.Caption = BusInstance._strBusVersion + " - Đơn vị sử dụng chương trình: " + _sessionAPI?.CurrentUser?.ServiceCustomerName;
        }

        private void btnCTMTQG_ItemClick(object sender, ItemClickEventArgs e) {
            var btnItem = e.Item as BarButtonItem;

            if (btnItem == btnMenuY1) _formCurrent = new FormMenu(_sessionAPI, _logger);
            else _formCurrent = null;

            if (_formCurrent != null) {
                _formCurrent.MdiParent = this;
                _formCurrent.Show();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
            //
        }

        private void btnSwitchUser_Click(object sender, EventArgs e) {
            if (XtraMessageBox.Show("Switch User???", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Restart();
        }
    }
}