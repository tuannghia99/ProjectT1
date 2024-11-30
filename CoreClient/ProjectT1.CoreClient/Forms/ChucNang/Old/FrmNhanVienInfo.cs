using DevExpress.Office.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjectT1.CoreClient.clsCommon;

namespace ProjectT1.CoreClient {
    public partial class FrmNhanVienInfo : DevExpress.XtraEditors.XtraForm {
        NhanVienDTO _curNhanVien;
        HttpClient _httpClient = new();
        CNNhanVienClient IBusObj;
        DMChucVuClient IBusObjChucVu;
        DMPhongBanClient IBusObjPhongBan;
        DMTrinhDoHocVanClient IBusObjHocVan; 
        NVAccountClient IBusObjAccount;
        const string defaultPassword = "123456";
        private MainStatusForm _mainStatus;

        public FrmNhanVienInfo(NhanVienDTO curNhanVien) {
            InitializeComponent();
            _curNhanVien = curNhanVien;
            IBusObj = new CNNhanVienClient(_httpClient);
            IBusObjChucVu = new DMChucVuClient(_httpClient);
            IBusObjPhongBan = new DMPhongBanClient(_httpClient);
            IBusObjHocVan = new DMTrinhDoHocVanClient(_httpClient);
            IBusObjAccount = new NVAccountClient(_httpClient);


        }
        private async void FrmNhanVienInfo_Load(object sender, EventArgs e) {
            ConfigControl();
            if (_curNhanVien == null) {
                _mainStatus = MainStatusForm.CREATE;
                ConfigControlStatus(_mainStatus);
                _curNhanVien = new NhanVienDTO();
            }
            else {
                _mainStatus = MainStatusForm.VIEW;
                ConfigControlStatus(_mainStatus);
                clsCommon.CommonHandler.SetValueToControl(_curNhanVien, this);
                fAvatar.EditValue = _curNhanVien.Avatar;
            }
            await LoadDataRepo();
        }
        void ConfigControl() {
            //Setting Nhap SDT
            fPhoneNumber.Properties.Mask.EditMask = "\\d{0,10}";
            fPhoneNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            fPhoneNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            // Setting Nhap Email
            clsCommon.CommonHandler.ConfigureDateEdits(fNgayCap, fNgaySinh, fCreateDate, fModifiedDate);
            fAvatar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;

        }
        private async Task LoadDataRepo() {
            var listChucVu = (await IBusObjChucVu.GetAllAsync()).Result.ToList();
            var listPhongBan = (await IBusObjPhongBan.GetAllAsync()).Result.ToList();
            var listHocVan = (await IBusObjHocVan.GetAllAsync()).Result.ToList();
            clsCommon.CommonHandler.LoadFromObject(fIdChucVu, listChucVu, "Oid", "Ten");
            clsCommon.CommonHandler.LoadFromObject(fIdPhongBan, listPhongBan, "Oid", "Ten");
            clsCommon.CommonHandler.LoadFromObject(fIdTrinhDoHocVan, listHocVan, "Oid", "Ten");

        }
        private void ConfigControlStatus(MainStatusForm status) {
            switch (status) {
                case MainStatusForm.VIEW:
                    clsCommon.CommonHandler.ConfigBarButtonEnable(true, btnThem, btnSua, btnXoa, btnLamMoi);
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnGhi, btnBoQua);
                    clsCommon.CommonHandler.SetReadOnlyControlData(layoutControlGroup1, true);
                    clsCommon.CommonHandler.SetReadOnlyControlData(layoutControlGroup2, true);

                    break;
                case MainStatusForm.CREATE:
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnThem, btnSua, btnXoa);
                    clsCommon.CommonHandler.ConfigBarButtonEnable(true, btnGhi, btnBoQua);
                    break;
                case MainStatusForm.EDIT:
                    clsCommon.CommonHandler.ConfigBarButtonEnable(false, btnThem, btnSua, btnXoa);
                    clsCommon.CommonHandler.ConfigBarButtonEnable(true, btnGhi, btnBoQua);
                    clsCommon.CommonHandler.SetReadOnlyControlData(layoutControlGroup1, false);
                    clsCommon.CommonHandler.SetReadOnlyControlData(layoutControlGroup2, false);

                    break;
                default:
                    break;
            }
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e) {
            ConfigControlStatus(MainStatusForm.CREATE);
            clsCommon.CommonHandler.ClearControlData(layoutControlGroup1);
            clsCommon.CommonHandler.ClearControlData(layoutControlGroup2);
            fCreateDate.EditValue = DateTime.Now;

        }
        private void btnSua_ItemClick(object sender, ItemClickEventArgs e) {
            _mainStatus = MainStatusForm.EDIT;
            ConfigControlStatus(_mainStatus);
        }
        private void btnBoQua_ItemClick(object sender, ItemClickEventArgs e) {
            _mainStatus = MainStatusForm.VIEW;
            ConfigControlStatus(_mainStatus);
            clsCommon.CommonHandler.SetValueToControl(_curNhanVien, this);
        }
        private void btnChonAnh_Click_1(object sender, EventArgs e) {
            OpenFileDialog openFileDialog1 = new OpenFileDialog {
                InitialDirectory = @"C:\",
                Title = "Chọn hình ảnh đại diện",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "Image files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*",
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                var pathImage = openFileDialog1.FileName;

                try {
                    fAvatar.Image = Image.FromFile(pathImage);
                }
                catch (Exception ex) {
                    MessageBox.Show($"Không thể tải hình ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnGoAnh_Click(object sender, EventArgs e) {
            if (fAvatar.Image == null) {
                MessageBox.Show("Bạn chưa thêm ảnh đại diện !!");
            }
            else {
                var dialog = XtraMessageBox.Show("Bạn có chắc chắn muốn gỡ ảnh đại diện?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes) {
                    fAvatar.Image = null;
                }
            }
        }

        private async void btnGhi_ItemClick(object sender, ItemClickEventArgs e) {
            var isCreate = _mainStatus == MainStatusForm.CREATE;
            var objNhanVien = isCreate ? new NhanVienDTO { Oid = Guid.NewGuid() } : _curNhanVien;
            SetNhanVienValues(objNhanVien);
            objNhanVien.Avatar = fAvatar?.Image?.ToByteArray()?.CompressBytes();
            objNhanVien.ModifiedDate = !isCreate ? DateTime.Now : null;
            var pass = (await IBusObjAccount.HashPasswordAsync(defaultPassword)).Result;
            if (_mainStatus == MainStatusForm.CREATE) {
                objNhanVien.Password = pass;
                var res = await IBusObj.PostAsync(new List<NhanVienDTO> { objNhanVien });
                if (res != null) {
                    XtraMessageBox.Show("Thêm mới thông tin thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else if (_mainStatus == MainStatusForm.EDIT) {
                var res = await IBusObj.PutAsync(objNhanVien.Oid, objNhanVien);
                if (res != null) {
                    XtraMessageBox.Show("Chỉnh sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        private void SetNhanVienValues(NhanVienDTO objNhanVien) {

            objNhanVien.Ten = fTen.EditValue?.ToString();
            objNhanVien.MaSo = fMaSo.EditValue?.ToString();
            objNhanVien.Username = fUsername.EditValue?.ToString();
            objNhanVien.Email = fEmail.EditValue?.ToString();
            objNhanVien.PhoneNumber = fPhoneNumber.EditValue?.ToString();
            objNhanVien.CreateDate = fCreateDate.EditValue as DateTime?;
            objNhanVien.ModifiedDate = fModifiedDate.EditValue as DateTime?;

            objNhanVien.NgaySinh = fNgaySinh.EditValue as DateTime?;
            objNhanVien.GioiTinh = fGioiTinh.EditValue?.ToString();
            objNhanVien.QuocTich = fQuocTich.EditValue?.ToString();
            objNhanVien.TonGiao = fTonGiao.EditValue?.ToString();
            objNhanVien.DanToc = fDanToc.EditValue?.ToString();
            objNhanVien.NoiSinh = fNoiSinh.EditValue?.ToString();
            objNhanVien.DiaChi = fDiaChi.EditValue?.ToString();

            objNhanVien.IdChucVu = fIdChucVu.EditValue as Guid?;
            objNhanVien.IdPhongBan = fIdPhongBan.EditValue as Guid?;
            objNhanVien.IdTrinhDoHocVan = fIdTrinhDoHocVan.EditValue as Guid?;

            objNhanVien.TinhTrangHonNhan = fTinhTrangHonNhan.EditValue?.ToString();
            objNhanVien.SoCanCuoc = fSoCanCuoc.EditValue?.ToString();

            objNhanVien.NgayCap = fNgayCap.EditValue as DateTime?;
            objNhanVien.NoiCap = fNoiCap.EditValue?.ToString();
            objNhanVien.TinhTrangSucKhoe = fTinhTrangSucKhoe.EditValue?.ToString();
            objNhanVien.ChieuCao = fChieuCao.EditValue != null ? Convert.ToDecimal(fChieuCao.EditValue) : (decimal?)null;
            objNhanVien.CanNang = fCanNang.EditValue != null ? Convert.ToDecimal(fCanNang.EditValue) : (decimal?)null;
        }

    }

}