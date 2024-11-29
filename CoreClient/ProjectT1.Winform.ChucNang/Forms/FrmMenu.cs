using DevExpress.XtraBars;
using ProjectY.Client.Winform;
using System.Data;
using System.Windows.Forms;

namespace Project.Client.Winform {
    public partial class FrmMenu : DevExpress.XtraEditors.XtraForm {
        public FrmMenu() {
            InitializeComponent();
        }
        List<string> _lstDanhMuc = new List<string>() { "Chức danh", "Phòng ban" };
        private void FrmMenu_Load(object sender, EventArgs e) {
            ConfigControl();
        }
        private void ConfigControl() {
            btnDanhMuc.Strings.AddRange(_lstDanhMuc.ToArray());
        }
        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e) {
            var formDsNhanVien = new FrmDanhSachNhanVien();
            formDsNhanVien.ShowDialog();
        }

        private void btnDanhMuc_ListItemClick(object sender, ListItemClickEventArgs e) {
            if (e.Index == 0) { // Chucdanh
                var frm = new FrmDMChucDanh();
                frm.ShowDialog();
            }
            if (e.Index == 1) { // PhongBan
                var frm = new FrmDMPhongBan();
                frm.ShowDialog();
            }
        }
    }
}