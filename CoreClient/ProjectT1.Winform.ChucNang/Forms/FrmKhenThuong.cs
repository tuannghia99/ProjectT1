using app.StdCommon;
using DevExpress.XtraEditors;
using ProjectT1.Client.Winform;
using static ProjectT1.Client.Winform.clsCommonY4c;

namespace Project.Client.Winform {
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
                    clsCommonY4c.CommonHandler.ConfigBarButtonEnable(true, btnThemMoi, btnSua, btnXoa, btnLamMoi);
                    clsCommonY4c.CommonHandler.ConfigBarButtonEnable(false, btnGhi, btnBoQua);
                    break;
                case MainStatusForm.CREATE:
                    clsCommonY4c.CommonHandler.ConfigBarButtonEnable(false, btnThemMoi, btnSua, btnXoa);
                    clsCommonY4c.CommonHandler.ConfigBarButtonEnable(true, btnGhi, btnBoQua);
                    break;
                case MainStatusForm.EDIT:
                    clsCommonY4c.CommonHandler.ConfigBarButtonEnable(false, btnThemMoi, btnSua, btnXoa);
                    clsCommonY4c.CommonHandler.ConfigBarButtonEnable(true, btnGhi, btnBoQua);
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