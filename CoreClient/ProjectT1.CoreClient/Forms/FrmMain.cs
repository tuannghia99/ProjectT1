using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectT1.CoreClient {
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm {
        public FrmMain() {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) {

        }

        private void btnThongTinNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            // TODO
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
            var form = new FrmDanhSachNhanVien();
            form.ShowDialog();
        }

        private void btnCnKhenThuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            // TODO
        }

        private void btnCnKyLuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            // TODO
        }

        private void btnCnTroGiup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            // TODO
        }
    }
}
