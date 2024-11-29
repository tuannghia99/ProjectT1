using DevExpress.XtraEditors;
using System;
using System.Net.Http;
using static ProjectT1.CoreClient.clsCommon;

namespace ProjectT1.CoreClient {
    public partial class FrmKyLuat : XtraForm {

        #region Contructor & FormLoad
        public FrmKyLuat() {
            InitializeComponent();
        }

        private async void Form_Load(object sender, EventArgs e) {
        }
        private void ConfigControlStatus(MainStatusForm status) {
            switch (status) {
                case MainStatusForm.VIEW:
                    clsCommon.CommonHandler.ConfigBarButtonEnable(true, btnThemMoi, btnSua, btnXoa, btnLamMoi);
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnGhi, btnBoQua);
                    break;
                case MainStatusForm.CREATE:
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnThemMoi, btnSua, btnXoa);
                    clsCommon.CommonHandler.ConfigBarButtonEnable(true, btnGhi, btnBoQua);
                    break;
                case MainStatusForm.EDIT:
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnThemMoi, btnSua, btnXoa);
                    clsCommon.CommonHandler.ConfigBarButtonEnable(true, btnGhi, btnBoQua);
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}