using app.Common;
using app.StdCommon;
using DevExpress.Spreadsheet;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjectT1.CoreClient.clsCommon;

namespace ProjectT1.CoreClient {
    public partial class FrmKhenThuong : XtraForm {
        HttpClient _httpClient = new();
        CNKhenThuongClient IBusObj;
        CNNhanVienClient IBusObjNhanVien;

        private MainStatusForm _mainStatus;
        private Guid _curIdMain = new();
        private Guid _tempNewIdMain = new();
        private BindingList<KhenThuongDTO> _bindingListMain = new();

        #region Contructor & FormLoad
        public FrmKhenThuong() {
            InitializeComponent();
            IBusObj = new CNKhenThuongClient(_httpClient);
            IBusObjNhanVien = new CNNhanVienClient(_httpClient);
        }
        private async void Form_Load(object sender, EventArgs e) {
            ConfigControlStatus(_mainStatus = MainStatusForm.WAIT);
            CommonConfig();
            await LoadDataRepo();
            await LoadDataMainGrid();
        }
        #endregion
        #region ConfigHandler & LoadData
        private void CommonConfig() {
            clsCommon.CommonHandler.ConfigBarButtonFormat(btnCreate, btnEdit, btnDelete, btnSubmit, btnCancel, btnRefresh, btnClose);
            clsCommon.CommonHandler.PreventMouseWheelForDropdown(this);
            clsCommon.CommonHandler.ConfigForGridViewHeader(this, layoutControlGroupMainData, gridViewMain);
            ConfigShorthandEvent();

            fMucKhenThuong.SetMoneyInputTextEdit();
            fNgayKhenThuong.SetDefaultDateEditSettings();

            gridViewMain.OptionsBehavior.Editable = false;
        }
        private void ConfigShorthandEvent() {
            gridViewMain.MouseDown += (s, e) => {
                if (_mainStatus == MainStatusForm.CREATE || _mainStatus == MainStatusForm.EDIT) {
                    GridView view = s as GridView;
                    GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
                    DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            };
        }
        private void ConfigControlStatus(MainStatusForm status) {
            gridViewMain.OptionsBehavior.Editable = false;
            clsCommon.CommonHandler.SetReadOnlyControlData(layoutControlGroupEditControl, true);
            clsCommon.CommonHandler.ConfigBarButtonEnable(true, btnCreate, btnEdit, btnDelete, btnSubmit, btnCancel, btnRefresh, btnClose);
            switch (status) {
                case MainStatusForm.WAIT:
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnCreate, btnEdit, btnDelete, btnSubmit, btnCancel, btnRefresh, btnClose);
                    break;
                case MainStatusForm.CREATE:
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnCreate, btnEdit, btnDelete, btnRefresh, btnClose);
                    clsCommon.CommonHandler.SetReadOnlyControlData(layoutControlGroupEditControl, false);
                    break;
                case MainStatusForm.EDIT:
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnCreate, btnEdit, btnDelete, btnRefresh, btnClose);
                    clsCommon.CommonHandler.SetReadOnlyControlData(layoutControlGroupEditControl, false);
                    break;
                default: // MainStatusForm.VIEW
                    clsCommon.CommonHandler.ClearEditControlErrorText(layoutControlGroupEditControl);
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnSubmit, btnCancel);
                    gridViewMain.Focus();
                    break;
            }
        }
        private async Task LoadDataRepo() {
            try {
                var dataNhanVien = (await IBusObjNhanVien.GetAllAsync()).Result.OrderBy(x => x.MaSo).ToList();
                var viewCols = new List<Tuple<string, string>> { new("MaSo", "Mã số"), new("Ten", "Tên") };
                repoNhanVien.LoadFromObject(dataNhanVien, viewCols, "Oid", "Ten");
                fIdNhanVien.LoadFromObject(dataNhanVien, viewCols, "Oid", "Ten");
            }
            catch {
                throw;
            }
        }
        private async Task LoadDataMainGrid() {
            try {
                ConfigControlStatus(_mainStatus = MainStatusForm.WAIT);
                clsCommon.CommonHandler.ClearControlData(layoutControlGroupEditControl);
                _bindingListMain = new();

                var res = await IBusObj.GetAllAsync();
                _bindingListMain = new BindingList<KhenThuongDTO>(res.Result.OrderBy(x => x.MaSo).ToList());

                gridControlMain.DataSource = null;
                gridControlMain.DataSource = _bindingListMain;
                clsCommon.CommonHandler.GridViewMain_CheckThenFocusAndSelectZeroIndexRow(gridViewMain);
                ConfigControlStatus(_mainStatus = MainStatusForm.VIEW);
            }
            catch {
                throw;
            }
        }
        #endregion
        #region ActionHandler
        private void btnCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ConfigControlStatus(_mainStatus = MainStatusForm.CREATE);
            clsCommon.CommonHandler.ClearControlData(layoutControlGroupEditControl);
            _tempNewIdMain = Guid.NewGuid();
            fMaSo.Focus();
        }
        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (_curIdMain == Guid.Empty) {
                clsCommon.CommonHandler.ShowXtraMessageBox_NeedToSelectRecord();
                return;
            }
            ConfigControlStatus(_mainStatus = MainStatusForm.EDIT);
            fMaSo.Focus();
        }
        private async void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            IOverlaySplashScreenHandle? handle = default;
            try {
                var lstObjId = clsCommon.CommonHandler.GridView_GetSelectedRowOid_RemovedGuidEmptyItems(gridViewMain);
                if (lstObjId.Count == 0) {
                    clsCommon.CommonHandler.ShowXtraMessageBox_NeedToSelectRecord();
                    return;
                }
                if (clsCommon.CommonHandler.ShowXtraMessageBox_SubmitToDelete() == DialogResult.Yes) {
                    var res = await IBusObj.DeleteAsync(lstObjId.First());
                    if (res.IsSuccess) {
                        clsCommon.CommonHandler.ShowNotificationForm_DeletedSuccessfully();
                        foreach (var oid in lstObjId) {
                            var objToDelete = _bindingListMain.First(x => x.Oid == oid);
                            _bindingListMain.Remove(objToDelete);
                        }
                        _curIdMain = gridViewMain.GetFocusedRowCellValue("Oid").ConvertToGuid();
                        if (_curIdMain == Guid.Empty) {
                            // nothing
                        }
                        else {
                            gridViewMain.SelectRow(gridViewMain.FocusedRowHandle);
                        }
                    }
                    gridViewMain.RefreshData();
                }
            }
            catch {
                throw;
            }
        }
        private async void btnSubmit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            IOverlaySplashScreenHandle handle = null;
            try {
                gridViewMain.Focus();
                if (_mainStatus == MainStatusForm.CREATE) _curIdMain = _tempNewIdMain;
                var obj = new KhenThuongDTO {
                    Oid = (_mainStatus == MainStatusForm.CREATE) ? _tempNewIdMain : _curIdMain,
                    MaSo = fMaSo.EditValue.SafeToString(),
                    IdNhanVien = fIdNhanVien.EditValue.ConvertToNullableGuid(),
                    CanCuKhenThuong = fCanCuKhenThuong.EditValue.SafeToString(),
                    LyDoKhenThuong = fLyDoKhenThuong.EditValue.SafeToString(),
                    HinhThucKhenThuong = fHinhThucKhenThuong.EditValue.SafeToString(),
                    MucKhenThuong = fMucKhenThuong.EditValue.ConvertToNullableDecimal(),
                    NgayKhenThuong = fNgayKhenThuong.EditValue.ConvertToNullableDateTimeDMY(),
                };

                // Validate
                clsCommon.CommonHandler.ClearEditControlErrorText(layoutControlGroupEditControl);
                var validator = new KhenThuongValidator();
                var validateResult = await validator.ValidateAsync(obj);
                if (!validateResult.IsValid) {
                    var fieldWithMessage = validateResult.Errors.Select(x => new Tuple<string, string>(x.PropertyName, x.ErrorMessage)).ToArray();
                    clsCommon.CommonHandler.SetEditControlErrorText_ValidateResult(this, fieldWithMessage);
                    return;
                }

                //  Check MsCode
                var oldMsCode = (_mainStatus == MainStatusForm.EDIT) ? _bindingListMain.FirstOrDefault(x => x.Oid == _curIdMain)?.MaSo : null;
                var checkMsCode = MsCodeValidator.CheckValidMsCode(_bindingListMain.Select(x => x.MaSo), obj.MaSo, _mainStatus == MainStatusForm.CREATE, oldMsCode);
                if (!checkMsCode) {
                    clsCommon.CommonHandler.SetEditControlErrorText_DuplicateMsCode(fMaSo);
                    return;
                }

                // Submit
                if (_mainStatus == MainStatusForm.CREATE) {
                    List<KhenThuongDTO> data = new List<KhenThuongDTO>();
                    data.Add(obj);
                    var res = await IBusObj.PostAsync(data);
                    if (res.IsSuccess) clsCommon.CommonHandler.ShowNotificationForm_CreatedSuccessfully();
                    _bindingListMain.Add(obj);
                    gridViewMain.RefreshData();
                    gridViewMain.FocusedRowHandle = gridViewMain.LocateByValue("Oid", obj.Oid);
                }
                else if (_mainStatus == MainStatusForm.EDIT) {
                    var res = await IBusObj.PutAsync(obj.Oid, obj);
                    if (res.IsSuccess) clsCommon.CommonHandler.ShowNotificationForm_UpdatedSuccessfully();
                    var objToEdit = (KhenThuongDTO)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
                    clsCommon.CommonHandler.MemberwiseClone(obj, ref objToEdit);
                    gridViewMain.RefreshData();
                }
                ConfigControlStatus(_mainStatus = MainStatusForm.VIEW);
            }
            catch {
                throw;
            }
        }
        private async void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            clsCommon.CommonHandler.ClearControlData(layoutControlGroupEditControl);
            if (gridViewMain.RowCount > 0) {
                var objMain = (KhenThuongDTO)gridViewMain.GetFocusedRow();
                clsCommon.CommonHandler.SetValueToControl(objMain, this);
            }
            ConfigControlStatus(_mainStatus = MainStatusForm.VIEW);
        }
        private async void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => await LoadDataMainGrid();
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => this.Close();
        #endregion
        #region EventHandler
        private async void gridViewMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            if (gridViewMain.RowCount > 0) {
                _curIdMain = gridViewMain.GetFocusedRowCellValue("Oid").ConvertToGuid();
                var objMain = (KhenThuongDTO)gridViewMain.GetFocusedRow();
                clsCommon.CommonHandler.SetValueToControl(objMain, this);
            }
        }
        private void gridViewMain_RowCountChanged(object sender, EventArgs e) {
            if (gridViewMain.RowCount == 0) {
                btnDelete.Enabled = false;
                clsCommon.CommonHandler.ClearControlData(layoutControlGroupEditControl);
            }
            else { // nothing
            }
        }
    }
    #endregion
}