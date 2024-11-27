using app.StdCommon;
using DevExpress.Spreadsheet;
using Microsoft.Extensions.Logging;
using ProjectX.Abstract.Bus;
using ProjectY4c.Client.ServerBusiness.Infrastructure.Contracts;
using System.Drawing;
using System.Text.RegularExpressions;
namespace ProjectY4c.ServerBusiness.Business.ExcelDataExchange.Group_QuyTrinhQuanLyThuNSX {
    public class Excel_ThucHienThuNganSachXaBus(
        IProjectY4cClient client, 
        ILogger logger,
        ISimpleBusinessObject<MLNSNN_ChuongDTO> iBusObjChuong,
        ISimpleBusinessObject<NguonVonDTO> iBusObjNguonVon,
        ISimpleBusinessObject<MLNSNN_MucTieuMucDTO> iBusObjMucTieuMuc,
        ISimpleBusinessObject<MLNSNN_CapNSDTO> iBusObjCapNganSach,
        ISimpleBusinessObject<DonViSuDungChuongTrinhChiTietDTO> iBusObjDonViSuDungChuongTrinhCT
            ) {
        private string tinhChat1 = "Thu chưa qua kho bạc trong năm ngân sách"; // kho bac: 0 thời gian chinh ly : 0
        private string tinhChat2 = "Thu chưa qua kho bạc trong thời gian chỉnh lý"; // kho bac:  0 thoi gian chinh ly : 1
        private string tinhChat3 = "Thu qua kho bạc trong năm ngân sách"; // kho bac: 1 thoi gian chinh ly: 0
        private string tinhChat4 = "Thu qua kho bạc trong thời gian chỉnh lý"; // kho bac: 1 thoi gian chinh ly: 1
        int number = 1;

        private void CreateHeaderExcel(Worksheet worksheet) {
            worksheet.Cells["A1"].Value = "Niên độ";
            worksheet.Cells["A2"].Value = "nsNienDo";
            worksheet.Cells["B1"].Value = "Số chứng từ";
            worksheet.Cells["B2"].Value = "nsSoChungTu";
            worksheet.Cells["C1"].Value = "Ngày chứng từ";
            worksheet.Cells["C2"].Value = "dNgayChungTu";
            worksheet.Cells["D1"].Value = "Diễn giải";
            worksheet.Cells["D2"].Value = "nsDienGiai";
            worksheet.Cells["E1"].Value = "Nguồn vốn";
            worksheet.Cells["E2"].Value = "nsNguonVon";
            worksheet.Cells["F1"].Value = "Cấp ngân sách";
            worksheet.Cells["F2"].Value = "nsCapNganSach";
            worksheet.Cells["G1"].Value = "Chương";
            worksheet.Cells["G2"].Value = "nsChuong";
            worksheet.Cells["H1"].Value = "Mục, tiểu mục";
            worksheet.Cells["H2"].Value = "nsMucTieuMuc";
            worksheet.Cells["I1"].Value = "Tính chất";
            worksheet.Cells["I2"].Value = "nsTinhChat";
            worksheet.Cells["J1"].Value = "Số tiền thu NSNN";
            worksheet.Cells["J2"].Value = "mnThuNSNN";
            worksheet.Cells["K1"].Value = "Số tiền thu NSX";
            worksheet.Cells["K2"].Value = "mnThuNSX";
            worksheet.Cells["L1"].Value = "Thuyết minh";
            worksheet.Cells["L2"].Value = "nsThuyetMinh";

            worksheet.Name = "Thực hiện thu ngân sách";
            worksheet.Range["A1:L1"].Font.Bold = true;
            worksheet.Columns.AutoFit(1, 100);
            worksheet.Cells["D1"].ColumnWidth = 700;
            worksheet.Cells["E1"].ColumnWidth = 700;
            worksheet.Cells["G1"].ColumnWidth = 700;
            worksheet.Cells["H1"].ColumnWidth = 700;
            worksheet.Cells["I1"].ColumnWidth = 700;
            worksheet.Cells["L1"].ColumnWidth = 1000;

            worksheet.Range["A1:L1"].Fill.BackgroundColor = ColorTranslator.FromHtml("#2F75B5");
            worksheet.Range["A1:L1"].Font.Color = Color.White;
            worksheet.Range["A1:L2"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            worksheet.Columns["A"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            worksheet.Columns["C"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            worksheet.Columns["C"].NumberFormat = "dd-MM-yyyy";
            worksheet.Columns["K"].NumberFormat = "#,##0.00";
            worksheet.Columns["J"].NumberFormat = "#,##0.00";
        }
        private void FillDataCellsValues(Worksheet worksheet, List<Excel_ThucHienThuNganSachXaDTO> listDatas) {
            int rowIndex = 2;
            PeriodOfTime2 periodOfTime = new PeriodOfTime2();
            foreach (var data in listDatas) {
                if (data.ListDataDetail.Count > 0) {
                    var check = periodOfTime.ConvertFromPeriodString(data.NienDo);
                    foreach (var item in data.ListDataDetail) {
                        var thuQuaKhoBac = item.DuocChonThuQuaKhoBac.ConvertToBool();
                        var thuThoiGianChinhLy = item.DuocChonThuThoiGianChinhLy.ConvertToBool();
                        worksheet.Cells[rowIndex, 0].Value = (check) ? periodOfTime.iFromYear.SafeToString() : string.Empty;
                        worksheet.Cells[rowIndex, 1].Value = data.SoChungTu.SafeToString();
                        worksheet.Cells[rowIndex, 2].Value = data.NgayChungTu.ConvertToNullableDateTimeDMY();
                        worksheet.Cells[rowIndex, 3].Value = data.DienGiai.SafeToString();
                        worksheet.Cells[rowIndex, 4].Value = item.NguonVon.SafeToString();
                        worksheet.Cells[rowIndex, 5].Value = item.CapNganSach.SafeToString();
                        worksheet.Cells[rowIndex, 6].Value = item.Chuong.SafeToString();
                        worksheet.Cells[rowIndex, 7].Value = item.MucTieuMuc.SafeToString();
                        worksheet.Cells[rowIndex, 8].Value = thuQuaKhoBac && !thuThoiGianChinhLy ? tinhChat3 : !
                                                             thuQuaKhoBac && !thuThoiGianChinhLy ? tinhChat1 : !
                                                             thuQuaKhoBac && !thuThoiGianChinhLy ? tinhChat4 : !
                                                             thuQuaKhoBac && !thuThoiGianChinhLy ? tinhChat2 : "Không xác định";
                        worksheet.Cells[rowIndex, 9].Value = item.SoTienNSNN.ConvertToNullableDecimal();
                        worksheet.Cells[rowIndex, 10].Value = item.SoTienXa.ConvertToNullableDecimal();
                        worksheet.Cells[rowIndex, 11].Value = item.ThuyetMinh.SafeToString();
                        rowIndex++;
                    }
                }
            }
        }
        #region ActionHandler
        public Workbook ExportDataExcel(List<Excel_ThucHienThuNganSachXaDTO> listData) {
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets[0];
            CreateHeaderExcel(worksheet);
            FillDataCellsValues(worksheet, listData);
            return workbook;
        }
        public async Task<bool> ImportDataExcel(IEnumerable<Excel_ThucHienThuNganSachXaDTO> lstObj) {
            var res = await client.ApiV1NghiepvuExcelQtquanlythunsxThuchienthungansachxaImportdataexcelAsync(lstObj);
            return res.Result;
        }
        #endregion
        #region ConvertExcel
        private async Task<ValidationResult<IEnumerable<Excel_ThucHienThuNganSachXaDTO>>> ConvertExcelToDTO(Guid idDonVi, Worksheet worksheet) {
            ValidationResult<IEnumerable<Excel_ThucHienThuNganSachXaDTO>> validationResult = new ValidationResult<IEnumerable<Excel_ThucHienThuNganSachXaDTO>>();
            try {
                Dictionary<string, Excel_ThucHienThuNganSachXaDTO> uniqueRows = new Dictionary<string, Excel_ThucHienThuNganSachXaDTO>();
                for (int rowIndex = 2; rowIndex <= worksheet.Rows.LastUsedIndex; rowIndex++) {
                    string key = $"{worksheet.Cells[rowIndex, 0].Value.SafeToString()}-{worksheet.Cells[rowIndex, 1].Value.SafeToString()}-" +
                        $"{worksheet.Cells[rowIndex, 2].Value.ConvertToNullableDateTimeDMY()}-{worksheet.Cells[rowIndex, 3].Value.SafeToString()}";
                    if (!uniqueRows.ContainsKey(key)) {
                        ValidationResult<Excel_ThucHienThuNganSachXaDTO> parentValidationResult = await ConvertRowToDTO(worksheet, rowIndex, idDonVi);
                        if (!parentValidationResult.Success) {
                            validationResult.Success = false;
                            validationResult.ErrorMessage = parentValidationResult.ErrorMessage;
                            return validationResult;
                        }
                        uniqueRows.Add(key, parentValidationResult.Result);
                        number++;
                    }
                    ValidationResult<Excel_ThucHienThuNganSachXaChiTietDTO> childValidationResult = await ConvertRowToDTODetail(worksheet, rowIndex, uniqueRows[key].Oid);
                    if (!childValidationResult.Success) {
                        validationResult.Success = false;
                        validationResult.ErrorMessage = childValidationResult.ErrorMessage;
                        return validationResult;
                    }
                    uniqueRows[key].ListDataDetail.Add(childValidationResult.Result);
                }
                validationResult.Result = uniqueRows.Values;
            }
            catch (Exception ex) {
                validationResult.Success = false;
                validationResult.ErrorMessage = "Đã có lỗi xảy ra trong quá trình xử lý.";
            }

            return validationResult;
        }
        private async Task<ValidationResult<Excel_ThucHienThuNganSachXaDTO>> ConvertRowToDTO(Worksheet worksheet, int rowIndex, Guid idDonVi) {
            ValidationResult<Excel_ThucHienThuNganSachXaDTO> validationResult = new ValidationResult<Excel_ThucHienThuNganSachXaDTO>();
            try {
                var lstPhongBan = (await iBusObjDonViSuDungChuongTrinhCT.GetListItem(true, null)).LstObjData.Where(x => x.PhanLoai == 2 && x.IdDonViSuDungChuongTrinh == idDonVi).ToList();
                int indexColNienDo = GetColumnIndexByName(worksheet, "nsNienDo");
                int indexColSoChungTu = GetColumnIndexByName(worksheet, "nsSoChungTu");
                int indexColNgayChungTu = GetColumnIndexByName(worksheet, "dNgayChungTu");
                int indexColDienGiai = GetColumnIndexByName(worksheet, "nsDienGiai");

                CellValue cellNienDo = worksheet.GetCellValue(indexColNienDo, rowIndex);
                PeriodOfTime2 nienDo = PeriodOfTime2.GetPeriodOfTime(PeriodOfTime2.PeriodOfTimeType.YO, cellNienDo.TextValue.ConvertToInt());
                Excel_ThucHienThuNganSachXaDTO data = new Excel_ThucHienThuNganSachXaDTO() {
                    Oid = Guid.NewGuid(),
                    IdDonViSuDungChuongTrinh = idDonVi,
                    NienDo = nienDo.ConvertPeriodObjectToString(),
                    SoChungTu = worksheet.Cells[rowIndex, indexColSoChungTu].Value.SafeToString(),
                    NgayChungTu = DateTime.Parse(worksheet.Cells[rowIndex, indexColNgayChungTu].Value.ToString()),
                    DienGiai = worksheet.Cells[rowIndex, indexColDienGiai].Value.SafeToString(),
                    ListDataDetail = new List<Excel_ThucHienThuNganSachXaChiTietDTO>(),
                    LoaiSoLieu = 1,
                    DuToan = 1,
                    IdDonViThucHien = lstPhongBan.FirstOrDefault().Oid,

                };
                validationResult.Result = data;
            }
            catch (Exception ex) {
                validationResult.Success = false;
                validationResult.ErrorMessage = "Đã có lỗi xảy ra trong quá trình xử lý.";
            }
            return validationResult;
        }

        private async Task<ValidationResult<Excel_ThucHienThuNganSachXaChiTietDTO>> ConvertRowToDTODetail(Worksheet worksheet, int rowIndex, Guid idCha) {
            ValidationResult<Excel_ThucHienThuNganSachXaChiTietDTO> validationResult = new ValidationResult<Excel_ThucHienThuNganSachXaChiTietDTO>();
            try {
                var lstNguonVon = (await iBusObjNguonVon.GetListItem(true, null)).LstObjData;
                var lstCapNS = (await iBusObjCapNganSach.GetListItem(true, null)).LstObjData;
                var lstChuong = (await iBusObjChuong.GetListItem(true, null)).LstObjData;
                var lstMucTieuMuc = (await iBusObjMucTieuMuc.GetListItem(true, null)).LstObjData;

                int indexNguonVon = GetColumnIndexByName(worksheet, "nsNguonVon");
                int indexChuong = GetColumnIndexByName(worksheet, "nsChuong");
                int indexMucTieuMuc = GetColumnIndexByName(worksheet, "nsMucTieuMuc");
                int indexCapNganSach = GetColumnIndexByName(worksheet, "nsCapNganSach");
                int indexTinhChat = GetColumnIndexByName(worksheet, "nsTinhChat");
                int indexThuNSNN = GetColumnIndexByName(worksheet, "mnThuNSNN");
                int indexThuNSX = GetColumnIndexByName(worksheet, "mnThuNSX");
                int indexThuyetMinh = GetColumnIndexByName(worksheet, "nsThuyetMinh");

                var maNguonVon = worksheet.Cells[rowIndex, indexNguonVon].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
                var maChuong = worksheet.Cells[rowIndex, indexChuong].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
                var maCapNS = worksheet.Cells[rowIndex, indexCapNganSach].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
                var maMucTieuMuc = worksheet.Cells[rowIndex, indexMucTieuMuc].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
                var mnThuNSNN = worksheet.Cells[rowIndex, indexThuNSNN].Value.SafeToString();
                var mnThuNSX = worksheet.Cells[rowIndex, indexThuNSX].Value.SafeToString();

                var checkNguonVon = ValidateMaSo(lstNguonVon, maNguonVon, x => x.MaSo);
                var checkCapNS = ValidateMaSo(lstCapNS, maCapNS, x => x.MaSo);
                var checkChuong = ValidateMaSo(lstChuong, maChuong, x => x.MaSo);
                var checkMucTieuMuc = ValidateMaSo(lstMucTieuMuc, maMucTieuMuc, x => x.MaSo);

                var checkMoney = ValidatorSoTien(mnThuNSNN, mnThuNSX);
                if (!checkCapNS.Success) {
                    validationResult.Success = false;
                    validationResult.ErrorMessage = checkCapNS.ErrorMessage + validationResult.ErrorMessage + "Kiểm tra lại mã số cấp ngân sách ";
                }
                if (!checkNguonVon.Success) {
                    validationResult.Success = false;
                    validationResult.ErrorMessage = checkNguonVon.ErrorMessage + validationResult.ErrorMessage + "Kiểm tra lại mã số nguồn vốn ";
                }
                if (!checkChuong.Success) {
                    validationResult.Success = false;
                    validationResult.ErrorMessage = checkChuong.ErrorMessage + validationResult.ErrorMessage + "Kiểm tra lại mã số chương ";
                }
                if (!checkMucTieuMuc.Success) {
                    validationResult.Success = false;
                    validationResult.ErrorMessage = checkMucTieuMuc.ErrorMessage + validationResult.ErrorMessage + "Kiểm tra lại mã số mục tiểu mục ";
                }
                if (!checkMoney.Success) {
                    validationResult.Success = false;
                    validationResult.ErrorMessage = validationResult.ErrorMessage + checkMoney.ErrorMessage;
                }
                else {
                    validationResult.Success = true;
                    var checkTinhChat = worksheet.Cells[rowIndex, indexTinhChat].Value.SafeToString();
                    Excel_ThucHienThuNganSachXaChiTietDTO child = new Excel_ThucHienThuNganSachXaChiTietDTO() {
                        Oid = Guid.NewGuid(),
                        IdThucHienThuNganSachXa = idCha,
                        IdCapNganSach = lstCapNS.FirstOrDefault(x => x.MaSo.Equals(maCapNS?.Trim()))?.Oid,
                        IdNguonVon = lstNguonVon.FirstOrDefault(x => x.MaSo.Equals(maNguonVon?.Trim()))?.Oid,
                        IdChuong = lstChuong.FirstOrDefault(x => x.MaSo.Equals(maChuong?.Trim()))?.Oid,
                        IdMucTieuMuc = lstMucTieuMuc.FirstOrDefault(x => x.MaSo.Equals(maMucTieuMuc?.Trim()))?.Oid,
                        DuocChonThuQuaKhoBac = (checkTinhChat.Equals(tinhChat3) || checkTinhChat.Equals(tinhChat4)) ? true : false,
                        DuocChonThuThoiGianChinhLy = (checkTinhChat.Equals(tinhChat4) || checkTinhChat.Equals(tinhChat2)) ? true : false,
                        SoTienNSNN = worksheet.Cells[rowIndex, indexThuNSNN].Value.ConvertToNullableDecimal(),
                        SoTienXa = worksheet.Cells[rowIndex, indexThuNSX].Value.ConvertToNullableDecimal(),
                        ThuyetMinh = worksheet.Cells[rowIndex, indexThuyetMinh].Value.SafeToString(),
                    };
                    validationResult.Result = child;
                }
            }
            catch (Exception ex) {
                validationResult.Success = false;
                validationResult.ErrorMessage = "Đã có lỗi xảy ra trong quá trình xử lý.";
            }

            return validationResult;
        }
        private int GetColumnIndexByName(Worksheet worksheet, string columnName) {
            Cell cell = worksheet.Rows[1].FirstOrDefault(c => c.Value != null && c.Value.ToString() == columnName);
            return cell != null ? cell.ColumnIndex : -1;
        }

        #endregion
        #region Validator
        private ValidationResult<bool> ValidateFieldNameColumn(Worksheet worksheet) {
            ValidationResult<bool> result = new ValidationResult<bool>();
            // Tên của các trường cần kiểm tra
            string[] fieldNames = { "nsNienDo", "nsSoChungTu", "dNgayChungTu", "nsNguonVon", "nsChuong", "nsMucTieuMuc", "nsCapNganSach", "mnThuNSNN", "mnThuNSX", "nsThuyetMinh" };
            foreach (string fieldName in fieldNames) {
                Cell foundCell = FindCellByFieldName(worksheet, fieldName);
                if (foundCell == null || string.IsNullOrEmpty(foundCell.Value.ToString())) {
                    var error = $"Thiếu cột: {fieldName}; ";
                    result.ErrorMessage = result.ErrorMessage + error;
                    result.Success = false;
                }
            }
            return result;
        }
        private Cell FindCellByFieldName(Worksheet worksheet, string fieldName) {
            for (int colIndex = 0; colIndex <= worksheet.Columns.LastUsedIndex; colIndex++) {
                Cell cell = worksheet.Cells[1, colIndex];
                if (cell.Value.ToString() == fieldName) {
                    return cell;
                }
            }
            return null;
        }
        private ValidationResult<bool> ValidateMaSo<T>(List<T>? listData, string code, Func<T, string> inputMaSo) {
            ValidationResult<bool> result = new ValidationResult<bool>();
            if (listData == null) {
                result.ErrorMessage = "Danh sách không được null ";
                return result;
            }
            if (string.IsNullOrWhiteSpace(code)) {
                result.ErrorMessage = "Mã số không được rỗng hoặc chỉ chứa khoảng trắng ";
                return result;
            }
            result.Success = listData.Any(x => inputMaSo(x).Equals(code.Trim()));
            if (!result.Success) {
                result.ErrorMessage = "Mã số không hợp lệ ";
            }
            return result;
        }
        private ValidationResult<bool> ValidatorSoTien(params string[] lstMoney) {
            ValidationResult<bool> result = new ValidationResult<bool>();
            Regex regex = new Regex("^[0-9]+$");
            foreach (var item in lstMoney) {
                if (!regex.IsMatch(item)) {
                    result.Success = false;
                    result.ErrorMessage = "Định dạng số tiền chưa chính xác. ";
                    return result;
                }
            }
            result.Success = true;
            return result;
        }
        public async Task<ValidationResult<IEnumerable<Excel_ThucHienThuNganSachXaDTO>>> ValidatorExcel(Guid idDonVi, Worksheet worksheet) {
            ValidationResult<IEnumerable<Excel_ThucHienThuNganSachXaDTO>> result = new ValidationResult<IEnumerable<Excel_ThucHienThuNganSachXaDTO>>();
            var validateFieldNameColumn = ValidateFieldNameColumn(worksheet);
            if (!validateFieldNameColumn.Success) {
                result.Success = validateFieldNameColumn.Success;
                result.ErrorMessage = validateFieldNameColumn.ErrorMessage;
                return result;
            }
            else {
                var validateConvertExcelToDTO = await ConvertExcelToDTO(idDonVi, worksheet);
                result.Success = validateConvertExcelToDTO.Success;
                result.ErrorMessage = validateConvertExcelToDTO.ErrorMessage;
                result.Result = validateConvertExcelToDTO.Result;
                return result;
            }
        }
        private void SetSheetFont(Worksheet worksheet, string fontName, int fontSize) {
            worksheet.Cells.Font.Name = fontName;
            worksheet.Cells.Font.Size = fontSize;
        }
        public class ValidationResult<T> {
            public bool Success { get; set; } = true;
            public string ErrorMessage { get; set; } = string.Empty;
            public T Result { get; set; }
        }
        #endregion
    }
}