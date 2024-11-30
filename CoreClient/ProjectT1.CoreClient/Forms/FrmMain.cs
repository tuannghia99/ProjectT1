using System;
using System.Windows.Forms;

namespace ProjectT1.CoreClient {
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm {
        public static Guid g_IdAccount = Guid.Empty;

        public FrmMain() {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) {

        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            var form = new FrmChangePassword();
            form.ShowDialog();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Application.Restart();
        }

        private void btnDmChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            var form = new FrmDMChucVu();
            form.ShowDialog();
        }

        private void btnDmPhongBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            var form = new FrmDMPhongBan();
            form.ShowDialog();
        }

        private void btnDmTrinhDoHocVan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            var form = new FrmDMTrinhDoHocVan();
            form.ShowDialog();
        }

        private void btnCnDsNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //var form = new FrmDanhSachNhanVien();
            var form = new FrmNhanVien();
            form.ShowDialog();
        }

        private void btnCnKhenThuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            var form = new FrmKhenThuong();
            form.ShowDialog();
        }

        private void btnCnKyLuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            var form = new FrmKyLuat();
            form.ShowDialog();
        }

        private void btnCnTroGiup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            // TODO
        }
    }
}
