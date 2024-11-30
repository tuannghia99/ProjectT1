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
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjectT1.CoreClient.clsCommon;

namespace ProjectT1.CoreClient {
    public partial class FrmNhanVien : XtraForm {
        HttpClient _httpClient = new();
        CNNhanVienClient IBusObj;
        NVAccountClient IBusObjAccount;
        DMPhongBanClient IBusObjPhongBan;
        DMChucVuClient IBusObjChucVu;
        DMTrinhDoHocVanClient IBusObjTrinhDoHocVan;

        private MainStatusForm _mainStatus;
        private Guid _curIdMain = new();
        private Guid _tempNewIdMain = new();
        private BindingList<NhanVienDTO> _bindingListMain = new();

        const string _cst_defaultPassword = "123456Aa";

        #region Contructor & FormLoad
        public FrmNhanVien() {
            InitializeComponent();
            IBusObj = new CNNhanVienClient(_httpClient);
            IBusObjAccount = new NVAccountClient(_httpClient);
            IBusObjPhongBan = new DMPhongBanClient(_httpClient);
            IBusObjChucVu = new DMChucVuClient(_httpClient);
            IBusObjTrinhDoHocVan = new DMTrinhDoHocVanClient(_httpClient);
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

            fNgaySinh.SetDefaultDateEditSettings();
            fNgayCap.SetDefaultDateEditSettings();
            fCreateDate.SetDefaultDateEditSettings();
            fModifiedDate.SetDefaultDateEditSettings();

            fChieuCao.SetNumberInputTextEdit();
            fCanNang.SetDecimalInputTextEdit();

            // config fPhoneNumber
            fPhoneNumber.Properties.Mask.EditMask = "\\d{0,10}";
            fPhoneNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            fPhoneNumber.Properties.Mask.UseMaskAsDisplayFormat = true;

            // config fAvatar
            fAvatar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;

            // config repo
            fIdPhongBan.Properties.NullText = "";
            fIdChucVu.Properties.NullText = "";
            fIdTrinhDoHocVan.Properties.NullText = "";

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
            btnUploadAvatar.Enabled = btnRemoveAvatar.Enabled = false;
            switch (status) {
                case MainStatusForm.WAIT:
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnCreate, btnEdit, btnDelete, btnSubmit, btnCancel, btnRefresh, btnClose);
                    break;
                case MainStatusForm.CREATE:
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnCreate, btnEdit, btnDelete, btnRefresh, btnClose);
                    clsCommon.CommonHandler.SetReadOnlyControlData(layoutControlGroupEditControl, false);
                    btnUploadAvatar.Enabled = btnRemoveAvatar.Enabled = true;
                    break;
                case MainStatusForm.EDIT:
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnCreate, btnEdit, btnDelete, btnRefresh, btnClose);
                    clsCommon.CommonHandler.SetReadOnlyControlData(layoutControlGroupEditControl, false);
                    btnUploadAvatar.Enabled = btnRemoveAvatar.Enabled = true;
                    break;
                default: // MainStatusForm.VIEW
                    clsCommon.CommonHandler.ClearEditControlErrorText(layoutControlGroupEditControl);
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnSubmit, btnCancel);
                    gridViewMain.Focus();
                    break;
            }
            fCreateDate.ReadOnly = fModifiedDate.ReadOnly = true;
        }
        private async Task LoadDataRepo() {
            try {
                var viewCols = new List<Tuple<string, string>> { new("MaSo", "Mã số"), new("Ten", "Tên") };
                var dataPhongBan = (await IBusObjPhongBan.GetAllAsync()).Result.OrderBy(x => x.MaSo).ToList();
                var dataChucVu = (await IBusObjChucVu.GetAllAsync()).Result.OrderBy(x => x.MaSo).ToList();
                var dataTrinhDoHocVan = (await IBusObjTrinhDoHocVan.GetAllAsync()).Result.OrderBy(x => x.MaSo).ToList();

                fIdPhongBan.LoadFromObject(dataPhongBan, viewCols, "Oid", "Ten");
                fIdChucVu.LoadFromObject(dataChucVu, viewCols, "Oid", "Ten");
                fIdTrinhDoHocVan.LoadFromObject(dataTrinhDoHocVan, viewCols, "Oid", "Ten");

                fGioiTinh.Properties.Items.AddRange(["Nam", "Nữ"]);
                fGioiTinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
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
                var data = res.Result.OrderBy(x => x.MaSo).ToList();
                data.ForEach(x => {
                    x.Avatar = x.Avatar != null ? x.Avatar.DecompressBytes() : null;
                });

                _bindingListMain = new BindingList<NhanVienDTO>(data);

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
            fCreateDate.EditValue = DateTime.Now.ConvertToDateTimeDMY();
            fMaSo.Focus();
        }
        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (_curIdMain == Guid.Empty) {
                clsCommon.CommonHandler.ShowXtraMessageBox_NeedToSelectRecord();
                return;
            }
            ConfigControlStatus(_mainStatus = MainStatusForm.EDIT);
            fModifiedDate.EditValue = DateTime.Now.ConvertToDateTimeDMY();
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
                var obj = new NhanVienDTO {
                    Oid = (_mainStatus == MainStatusForm.CREATE) ? _tempNewIdMain : _curIdMain,
                    MaSo = fMaSo.EditValue.SafeToString(),
                    Ten = fTen.EditValue.SafeToString(),
                    NgaySinh = fNgaySinh.EditValue.ConvertToNullableDateTimeDMY(),
                    GioiTinh = fGioiTinh.EditValue.SafeToString(),
                    NoiSinh = fNoiSinh.EditValue.SafeToString(),
                    DiaChi = fDiaChi.EditValue.SafeToString(),
                    QuocTich = fQuocTich.EditValue.SafeToString(),
                    DanToc = fDanToc.EditValue.SafeToString(),
                    TonGiao = fTonGiao.EditValue.SafeToString(),
                    TinhTrangHonNhan = fTinhTrangHonNhan.EditValue.SafeToString(),

                    IdPhongBan = fIdPhongBan.EditValue.ConvertToNullableGuid(),
                    IdChucVu = fIdChucVu.EditValue.ConvertToNullableGuid(),
                    IdTrinhDoHocVan = fIdTrinhDoHocVan.EditValue.ConvertToNullableGuid(),
                    NgoaiNgu = fNgoaiNgu.EditValue.SafeToString(),
                    TinHoc = fTinHoc.EditValue.SafeToString(),

                    Username = fUsername.EditValue.SafeToString(),
                    PhoneNumber = fPhoneNumber.EditValue.SafeToString(),
                    Email = fEmail.EditValue.SafeToString(),
                    CreateDate = fCreateDate.EditValue.ConvertToNullableDateTimeDMY(),
                    ModifiedDate = fModifiedDate.EditValue.ConvertToNullableDateTimeDMY(),

                    SoCanCuoc = fSoCanCuoc.EditValue.SafeToString(),
                    NgayCap = fNgayCap.EditValue.ConvertToNullableDateTimeDMY(),
                    NoiCap = fNoiCap.EditValue.SafeToString(),

                    TinhTrangSucKhoe = fTinhTrangSucKhoe.EditValue.SafeToString(),
                    ChieuCao = fChieuCao.EditValue.ConvertToNullableDecimal(),
                    CanNang = fCanNang.EditValue.ConvertToNullableDecimal(),

                    Avatar = fAvatar?.Image?.ToByteArray()?.CompressBytes()
                };

                // Validate
                clsCommon.CommonHandler.ClearEditControlErrorText(layoutControlGroupEditControl);
                var validator = new NhanVienValidator();
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

                //  Check Username
                var oldUsername = (_mainStatus == MainStatusForm.EDIT) ? _bindingListMain.FirstOrDefault(x => x.Oid == _curIdMain)?.Username : null;
                var checkUsername = MsCodeValidator.CheckValidMsCode(_bindingListMain.Select(x => x.Username), obj.Username, _mainStatus == MainStatusForm.CREATE, oldUsername);
                if (!checkUsername) {
                    fUsername.ErrorText = "Tên tài khoản đã được sử dụng, vui lòng nhập tên tài khoản khác.";

                    clsCommon.CommonHandler.SetEditControlErrorText_DuplicateMsCode(fUsername);
                    return;
                }

                // Submit
                if (_mainStatus == MainStatusForm.CREATE) {
                    obj.Password = (await IBusObjAccount.HashPasswordAsync(_cst_defaultPassword)).Result;
                    List<NhanVienDTO> data = new List<NhanVienDTO>();
                    data.Add(obj);
                    var res = await IBusObj.PostAsync(data);
                    if (res.IsSuccess) clsCommon.CommonHandler.ShowNotificationForm_CreatedSuccessfully();
                    _bindingListMain.Add(obj);
                    gridViewMain.RefreshData();
                    gridViewMain.FocusedRowHandle = gridViewMain.LocateByValue("Oid", obj.Oid);
                }
                else if (_mainStatus == MainStatusForm.EDIT) {
                    obj.Password = gridViewMain.GetFocusedRowCellValue("Password").SafeToString();
                    var res = await IBusObj.PutAsync(obj.Oid, obj);
                    if (res.IsSuccess) clsCommon.CommonHandler.ShowNotificationForm_UpdatedSuccessfully();
                    var objToEdit = (NhanVienDTO)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
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
                var objMain = (NhanVienDTO)gridViewMain.GetFocusedRow();
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
                var objMain = (NhanVienDTO)gridViewMain.GetFocusedRow();
                clsCommon.CommonHandler.SetValueToControl(objMain, this);
                fAvatar.EditValue = objMain.Avatar;
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
        private void btnUploadAvatar_Click(object sender, EventArgs e) {
            try {
                var openFileDialog1 = new XtraOpenFileDialog {
                    InitialDirectory = @"C:\",
                    Title = "Chọn hình ảnh đại diện",
                    CheckFileExists = true,
                    CheckPathExists = true,
                    Filter = "Image files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*",
                    RestoreDirectory = true,
                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                    var pathImage = openFileDialog1.FileName;
                    fAvatar.Image = Image.FromFile(pathImage);
                }
            }
            catch {
                throw;
            }
        }
        private void btnRemoveAvatar_Click(object sender, EventArgs e) {
            try {
                if (fAvatar.Image == null) {
                    XtraMessageBox.Show("Chưa có ảnh đại diện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (XtraMessageBox.Show("Chắc chắn muốn xoá ảnh đại diện?", "Xác nhân", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    fAvatar.Image = null;
                }
            }
            catch {
                throw;
            }
        }
    }
    #endregion
}
