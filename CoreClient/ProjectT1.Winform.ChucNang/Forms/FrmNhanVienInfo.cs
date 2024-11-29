using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using ProjectT1.Client.Winform;
using static ProjectT1.Client.Winform.clsCommon;

namespace Project.Client.Winform {
    public partial class FrmNhanVienInfo : DevExpress.XtraEditors.XtraForm {
        NhanVienDTO _curNhanVien = new();
        public FrmNhanVienInfo(NhanVienDTO curNhanVien) {
            InitializeComponent();
            _curNhanVien = curNhanVien;
        }
        private void FrmNhanVienInfo_Load(object sender, EventArgs e) {
            ConfigControlStatus(MainStatusForm.VIEW);
            clsCommon.CommonHandler.SetValueToControl(_curNhanVien, this);
        }
        void ConfigControl() {

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
            clsCommon.CommonHandler.SetValueToControl(_curNhanVien, this);
        }
        private void btnChonAnh_Click_1(object sender, EventArgs e) {
            OpenFileDialog openFileDialog1 = new OpenFileDialog {
                InitialDirectory = @"C:\",
                Title = "Chọn hình ảnh đại diện",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "jpg files (*.png, *.jpg)|*.jpg|All files (*.*)| *.*",
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            var pathImgage = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                pathImgage = openFileDialog1.FileName;

            }
            else {
                return;
            }
            if (pathImgage != string.Empty) {
                fAvatar.LoadAsync(pathImgage);
            }
        }

        private void btnGoAnh_Click(object sender, EventArgs e) {
            if (fAvatar.Image == null) {
                MessageBox.Show("Bạn chưa thêm ảnh đại diện !!");
            }
            else {
                var dialog = XtraMessageBox.Show("Bạn có chắc chắn muốn gỡ ảnh đại diện?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes) {
                    fAvatar.Image = null;
                }
            }
        }
    }
}