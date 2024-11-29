using DevExpress.XtraEditors;
using ProjectT1.Client.Winform;
using static ProjectT1.Client.Winform.clsCommon;

namespace ProjectT1.CoreClient {
    public partial class FrmKhenThuong : XtraForm {

        #region Contructor & FormLoad
        public FrmKhenThuong() {
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
        private async void gridViewMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            if (gridViewMain.RowCount > 0) {
                //clsCommonY4c.CommonHandler.SetValueToControl(_curDataMain, this);
            }
        }
        #endregion
    }
}