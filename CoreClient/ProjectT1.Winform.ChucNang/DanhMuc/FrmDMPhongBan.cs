using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ProjectT1.Client.Winform;
using static ProjectT1.Client.Winform.clsCommon;

namespace ProjectY.Client.Winform {
    public partial class FrmDMPhongBan : XtraForm {
        private MainStatusForm _mainStatus;
        private Guid _curIdMain = new();
        private Guid _tempNewIdMain = new();

        #region Contructor & FormLoad
        public FrmDMPhongBan() {
            InitializeComponent();
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
            ConfigShorthandEvent();

            gridViewMain.OptionsBehavior.Editable = false;
            gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
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
           
        }
        private async Task LoadDataMainGrid() {
            //try {
            //    ConfigControlStatus(_mainStatus = MainStatusForm.WAIT);
            //    clsCommon.CommonHandler.ClearControlData(layoutControlGroupEditControl);
            //    _bindingListMain = [];

            //    var res = await IBusObj.GetListItem(true, null);
            //    _bindingListMain = new BindingList<HinhThucQuanLyDTO>(IBusObj.LstDataSource.OrderBy(x => x.MaSo).ToList());

            //    gridControlMain.DataSource = null;
            //    gridControlMain.DataSource = _bindingListMain;
            //    clsCommon.CommonHandler.GridViewMain_CheckThenFocusAndSelectZeroIndexRow(gridViewMain);
            //    ConfigControlStatus(_mainStatus = MainStatusForm.VIEW);
            //}
            //catch (Exception ex) {
            //    WinformCommon.Logger.Error(ex); if (Common.g_ShowExceptionError == true) throw;
            //}
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
            
        }
        private async void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //IOverlaySplashScreenHandle? handle = default;
            //try {
            //    var lstObjId = clsCommon.CommonHandler.GridView_GetSelectedRowOid_RemovedGuidEmptyItems(gridViewMain);
            //    if (lstObjId.Count == 0) {
            //        clsCommon.CommonHandler.ShowXtraMessageBox_NeedToSelectRecord();
            //        return;
            //    }
            //    if (clsCommon.CommonHandler.ShowXtraMessageBox_SubmitToDelete() == DialogResult.Yes) {
            //        handle = SplashScreenManager.ShowOverlayForm(this, WinformCommon.optionsOverlay);
            //        var res = await IBusObj.DeleteMultiple(lstObjId);
            //        if (res.Code == 200) {
            //            clsCommon.CommonHandler.ShowNotificationForm_DeletedSuccessfully();
            //            foreach (var oid in lstObjId) {
            //                var objToDelete = _bindingListMain.First(x => x.Oid == oid);
            //                _bindingListMain.Remove(objToDelete);
            //            }
            //            _curIdMain = gridViewMain.GetFocusedRowCellValue("Oid").ConvertToGuid();
            //            if (_curIdMain.IsNullOrEmpty()) {
            //                // nothing
            //            }
            //            else {
            //                gridViewMain.SelectRow(gridViewMain.FocusedRowHandle);
            //            }
            //        }
            //        gridViewMain.RefreshData();
            //    }
            //}
            //catch (Exception ex) {
            //    WinformCommon.Logger.Error(ex); if (Common.g_ShowExceptionError == true) throw;
            //}
            //handle?.Close();
        }
        private async void btnSubmit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            
        }
        private async void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
        }
        private async void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => await LoadDataMainGrid();
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => this.Close();
        #endregion
        #region EventHandler
        private async void gridViewMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
           
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