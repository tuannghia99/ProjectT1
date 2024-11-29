using DevExpress.XtraBars;
using ProjectT1.Client.Winform;
using System.Data;
using System.Net.Http;
using System.Windows.Forms;

namespace ProjectT1.CoreClient {
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
           
        }
    }
}