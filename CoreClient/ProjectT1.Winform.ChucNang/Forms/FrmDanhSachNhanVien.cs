using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using ProjectT1.Client.Winform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.Winform {
    public partial class FrmDanhSachNhanVien : DevExpress.XtraEditors.XtraForm {
        public FrmDanhSachNhanVien() {
            InitializeComponent();
        }
        private void gridViewMain_RowCountChanged(object sender, EventArgs e) {
            if (gridViewMain.RowCount == 0) {
               
            }
            else {
                //clsCommonY4c.CommonHandler.SetValueToControl(_curDataMain, this);
            }
        }
    }
}