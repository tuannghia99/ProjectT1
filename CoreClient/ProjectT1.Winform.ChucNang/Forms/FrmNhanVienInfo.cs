using DevExpress.XtraBars;
using ProjectT1.Client.Winform;
using static ProjectT1.Client.Winform.clsCommon;

namespace Project.Client.Winform {
    public partial class FrmNhanVienInfo : DevExpress.XtraEditors.XtraForm {
        public FrmNhanVienInfo() {
            InitializeComponent();
        }
        private void ConfigControlStatus(MainStatusForm status) {
            switch (status) {
                case MainStatusForm.VIEW:
                    clsCommon.CommonHandler.ConfigBarButtonEnable(true, btnThem, btnSua, btnXoa, btnLamMoi);
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnGhi, btnBoQua);
                    break;
                case MainStatusForm.CREATE:
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnThem, btnSua, btnXoa);
                    clsCommon.CommonHandler.ConfigBarButtonEnable(true, btnGhi, btnBoQua);
                    break;
                case MainStatusForm.EDIT:
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnThem, btnSua, btnXoa);
                    clsCommon.CommonHandler.ConfigBarButtonEnable(true, btnGhi, btnBoQua);
                    break;
                default:
                    break;
            }
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e) {
            ConfigControlStatus(MainStatusForm.CREATE);
            clsCommon.CommonHandler.ClearControlData(layoutControlGroup1);
            clsCommon.CommonHandler.ClearControlData(layoutControlGroup2);
        }

        private void btnBoQua_ItemClick(object sender, ItemClickEventArgs e) {
            ConfigControlStatus(MainStatusForm.VIEW);
            // clsCommonY4c.CommonHandler.SetValueToControl(_curDataMain, this);
        }
    }
}