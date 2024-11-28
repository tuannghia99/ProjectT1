using app.Common;
using DevExpress.XtraBars;
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
using static ProjectT1.Client.Winform.clsCommonY4c;

namespace Project.Client.Winform {
    public partial class FrmNhanVienInfo : DevExpress.XtraEditors.XtraForm {
        public FrmNhanVienInfo() {
            InitializeComponent();
        }
        private void ConfigControlStatus(MainStatusForm status) {
            switch (status) {
                case MainStatusForm.VIEW:
                    clsCommonY4c.CommonHandler.ConfigBarButtonEnable(true, btnThem, btnSua, btnXoa, btnLamMoi);
                    clsCommonY4c.CommonHandler.ConfigBarButtonEnable(false, btnGhi, btnBoQua);
                    break;
                case MainStatusForm.CREATE:
                    clsCommonY4c.CommonHandler.ConfigBarButtonEnable(false, btnThem, btnSua, btnXoa);
                    clsCommonY4c.CommonHandler.ConfigBarButtonEnable(true, btnGhi, btnBoQua);
                    break;
                case MainStatusForm.EDIT:
                    clsCommonY4c.CommonHandler.ConfigBarButtonEnable(false, btnThem, btnSua, btnXoa);
                    clsCommonY4c.CommonHandler.ConfigBarButtonEnable(true, btnGhi, btnBoQua);
                    break;
                default:
                    break;
            }
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e) {
            ConfigControlStatus(MainStatusForm.CREATE);
            clsCommonY4c.CommonHandler.ClearControlData(layoutControlGroup1);
            clsCommonY4c.CommonHandler.ClearControlData(layoutControlGroup2);
        }

        private void btnBoQua_ItemClick(object sender, ItemClickEventArgs e) {
            ConfigControlStatus(MainStatusForm.VIEW);
            // clsCommonY4c.CommonHandler.SetValueToControl(_curDataMain, this);
        }
    }
}