using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
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
using static ProjectT1.CoreClient.clsCommon;

namespace ProjectT1.CoreClient {
    public partial class FrmDanhSachNhanVien : DevExpress.XtraEditors.XtraForm {
        HttpClient _httpClient = new();
        CNNhanVienClient IBusObj;
        DMChucVuClient IBusObjChucVu;
        DMPhongBanClient IBusObjPhongBan;

        private MainStatusForm _mainStatus;
        public FrmDanhSachNhanVien() {
            InitializeComponent();
            IBusObj = new CNNhanVienClient(_httpClient);
            IBusObjChucVu = new DMChucVuClient(_httpClient);
            IBusObjPhongBan = new DMPhongBanClient(_httpClient);

        }
        private void gridViewMain_RowCountChanged(object sender, EventArgs e) {
            if (gridViewMain.RowCount == 0) {

            }
            else {
                //clsCommonY4c.CommonHandler.SetValueToControl(_curDataMain, this);
            }
        }

        private async void FrmDanhSachNhanVien_Load(object sender, EventArgs e) {
            ConfigControl();
            await LoadDataMainGrid();
            await LoadDataRepo();
        }
        private void ConfigControl() {
            gridViewMain.RowHeight = 60;
            repoNgay.Mask.EditMask = "dd/MM/yyyy"; 
            repoNgay.Mask.UseMaskAsDisplayFormat = true;  
            repoNgay.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;  
            repoNgay.DisplayFormat.FormatString = "dd/MM/yyyy";  
            repoNgay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;  

        }
        private async Task LoadDataMainGrid() {
            try {
                ConfigControlStatus(_mainStatus = MainStatusForm.WAIT);
                var res = await IBusObj.GetAllAsync();
                if (res.Result != null) {
                    var dataList = res.Result.Select(item => {
                        item.Avatar = item.Avatar != null ? item.Avatar.DecompressBytes() : null;
                        return item;
                    }).ToList();
                    gridControlMain.DataSource = null;  
                    gridControlMain.DataSource = dataList;  
                }
                clsCommon.CommonHandler.GridViewMain_CheckThenFocusAndSelectZeroIndexRow(gridViewMain);
                ConfigControlStatus(_mainStatus = MainStatusForm.VIEW);
            }
            catch {
                throw;
            }
        }
        private async Task LoadDataRepo() {
            try {
                var listChucVu = (await IBusObjChucVu.GetAllAsync()).Result.ToList();
                var listPhongBan = (await IBusObjPhongBan.GetAllAsync()).Result.ToList();
                clsCommon.CommonHandler.LoadFromObject(repoIdChucDanh, listChucVu, "Oid", "Ten");
                clsCommon.CommonHandler.LoadFromObject(repoIdPhongBan, listPhongBan, "Oid", "Ten");
            }
            catch {
            }
        }

        private void ConfigControlStatus(MainStatusForm status) {
            //gridViewMain.OptionsBehavior.Editable = false;
            clsCommon.CommonHandler.ConfigBarButtonEnable(true, btnCreate, btnEdit, btnDelete, btnRefresh, btnClose);
            switch (status) {
                case MainStatusForm.WAIT:
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnCreate, btnEdit, btnDelete, btnRefresh, btnClose);
                    break;
                case MainStatusForm.CREATE:
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnCreate, btnEdit, btnDelete, btnRefresh, btnClose);
                    break;
                case MainStatusForm.EDIT:
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnCreate, btnEdit, btnDelete, btnRefresh, btnClose);
                    break;
                default: // MainStatusForm.VIEW
                    gridViewMain.Focus();
                    break;
            }
        }
        private void repoChiTiet_Click(object sender, EventArgs e) {
            var objNhanVien = gridViewMain.GetFocusedRow() as NhanVienDTO;
            if (objNhanVien == null) { return; }
            var frm = new FrmNhanVienInfo(objNhanVien);
            frm.ShowDialog();
        }

        private void gridControlMain_Click(object sender, EventArgs e) {

        }

        private void btnCreate_ItemClick(object sender, ItemClickEventArgs e) {
            var form = new FrmNhanVienInfo(null);
            form.ShowDialog();
        }
    }
}