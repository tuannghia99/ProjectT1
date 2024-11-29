using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectT1.CoreClient {
    public partial class FrmDanhSachNhanVien : DevExpress.XtraEditors.XtraForm {
        HttpClient _httpClient;
        public FrmDanhSachNhanVien() {
            InitializeComponent();
            _httpClient = new HttpClient();
        }
        private void gridViewMain_RowCountChanged(object sender, EventArgs e) {
            if (gridViewMain.RowCount == 0) {

            }
            else {
                //clsCommonY4c.CommonHandler.SetValueToControl(_curDataMain, this);
            }
        }

        private async void FrmDanhSachNhanVien_Load(object sender, EventArgs e) {
            var busNhanVien = new CNNhanVienClient(_httpClient);
            var dataSource = (await busNhanVien.GetAllAsync()).Result.ToList();
            gridControlMain.DataSource = dataSource;
        }

        private void repoChiTiet_Click(object sender, EventArgs e) {
            var objNhanVien = gridViewMain.GetFocusedRow() as NhanVienDTO;
            if (objNhanVien == null) { return; }
            var frm = new FrmNhanVienInfo(objNhanVien);
            frm.ShowDialog();
        }
    }
}