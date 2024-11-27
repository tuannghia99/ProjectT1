using app.StdCommon;
using DevExpress.Spreadsheet;
using Microsoft.Extensions.Logging;
using ProjectX.Abstract.Bus;
using ProjectY4c.Client.ServerBusiness.Infrastructure.Contracts;
using System.Drawing;
using System.Text.RegularExpressions;
namespace ProjectY4c.ServerBusiness.Business.ExcelDataExchange.Group_QuyTrinhQuanLyThuNSX {
    public class Excel_PhanBoDuToanThuBus(IProjectY4cClient client, ILogger logger,
        ISimpleBusinessObject<MLNSNN_ChuongDTO> iBusObjChuong,
        ISimpleBusinessObject<NguonVonDTO> iBusObjNguonVon,
        ISimpleBusinessObject<MLNSNN_MucTieuMucDTO> iBusObjMucTieuMuc,
        ISimpleBusinessObject<MLNSNN_CapNSDTO> iBusObjCapNganSach,
        ISimpleBusinessObject<DonViSuDungChuongTrinhChiTietDTO> iBusObjDonViSuDungChuongTrinhCT
            ) {
        int number = 1;

        private void CreateHeaderExcel(Worksheet worksheet) {
            worksheet.Cells["A1"].Value = "Niên độ";
            worksheet.Cells["A2"].Value = "nsNienDo";
            worksheet.Cells["B1"].Value = "Loại dự toán";
            worksheet.Cells["B2"].Value = "nsLoaiDuToan";
            worksheet.Cells["C1"].Value = "Ngày quyết định";
            worksheet.Cells["C2"].Value = "dNgayQuyetDinh";
            worksheet.Cells["D1"].Value = "Khoản thu";
            worksheet.Cells["D2"].Value = "nsKhoanThu";
            worksheet.Cells["E1"].Value = "Nguồn vốn";
            worksheet.Cells["E2"].Value = "nsNguonVon";
            worksheet.Cells["F1"].Value = "Cấp ngân sách";
            worksheet.Cells["F2"].Value = "nsCapNganSach";
            worksheet.Cells["G1"].Value = "Chương";
            worksheet.Cells["G2"].Value = "nsChuong";
            worksheet.Cells["H1"].Value = "Mục, tiểu mục";
            worksheet.Cells["H2"].Value = "nsMucTieuMuc";
            worksheet.Cells["I1"].Value = "Thu NSNN";
            worksheet.Cells["I2"].Value = "mnThuNSNN";
            worksheet.Cells["J1"].Value = "Thu NSX";
            worksheet.Cells["J2"].Value = "mnThuNSX";

            worksheet.Name = "Dự toán thu";
            worksheet.Range["A1:J1"].Font.Bold = true;
            SetSheetFont(worksheet, "Times New Roman", 11);
            worksheet.Columns.AutoFit(1, 100);
            worksheet.Cells["D1"].ColumnWidth = 700;
            worksheet.Cells["E1"].ColumnWidth = 700;
            worksheet.Cells["F1"].ColumnWidth = 700;
            worksheet.Cells["G1"].ColumnWidth = 700;
            worksheet.Cells["H1"].ColumnWidth = 700;
            worksheet.Cells["I1"].ColumnWidth = 500;
            worksheet.Cells["J1"].ColumnWidth = 500;

            worksheet.Range["A1:J1"].Fill.BackgroundColor = ColorTranslator.FromHtml("#2F75B5");
            worksheet.Range["A1:J1"].Font.Color = Color.White;
            worksheet.Range["A1:J2"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            worksheet.Columns["A"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            worksheet.Columns["C"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            worksheet.Columns["C"].NumberFormat = "dd-MM-yyyy";
            worksheet.Columns["I"].NumberFormat = "#,##0.00";
            worksheet.Columns["J"].NumberFormat = "#,##0.00";


        }
        private void FillDataCellsValues(Worksheet worksheet, List<Excel_PhanBoDuToanThuDTO> listDatas) {
            int rowIndex = 2;
            PeriodOfTime2 periodOfTime = new PeriodOfTime2();
            foreach (var data in listDatas) {
                if (data.ListDataDetail.Count > 0) {
                    var check = periodOfTime.ConvertFromPeriodString(data.NienDo);
                    foreach (var item in data.ListDataDetail) {
                        worksheet.Cells[rowIndex, 0].Value = (check) ? periodOfTime.iFromYear.SafeToString() : string.Empty;
                        worksheet.Cells[rowIndex, 1].Value = data.DuToan.ConvertToNullableInt();
                        worksheet.Cells[rowIndex, 2].Value = data.NgayQuyetDinh.ConvertToNullableDateTimeDMY();
                        worksheet.Cells[rowIndex, 3].Value = item.KhoanThu.SafeToString();
                        worksheet.Cells[rowIndex, 4].Value = item.NguonVon.SafeToString();
                        worksheet.Cells[rowIndex, 5].Value = item.CapNganSach.SafeToString();
                        worksheet.Cells[rowIndex, 6].Value = item.Chuong.SafeToString();
                        worksheet.Cells[rowIndex, 7].Value = item.MucTieuMuc.SafeToString();
                        worksheet.Cells[rowIndex, 8].Value = item.DuToanDuocGiaoTongThu.ConvertToNullableDecimal();
                        worksheet.Cells[rowIndex, 9].Value = item.DuToanDuocGiaoDuocHuong.ConvertToNullableDecimal();
                        rowIndex++;
                    }
                }
            }
        }
        #region ActionHandler
        public Workbook ExportDataExcel(List<Excel_PhanBoDuToanThuDTO> listData) {
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets[0];
            CreateHeaderExcel(worksheet);
            FillDataCellsValues(worksheet, listData);
            return workbook;
        }
        public async Task<bool> ImportDataExcel(IEnumerable<Excel_PhanBoDuToanThuDTO> lstObj) {
            var res = await client.ApiV1NghiepvuExcelQtquanlythunsxPhanbodutoanthuImportdataexcelAsync(lstObj);
            return res.Result;
        }
        #endregion
        #region ConvertExcel
        private async Task<ValidationResult<IEnumerable<Excel_PhanBoDuToanThuDTO>>> ConvertExcelToDTO(Guid idDonVi, Worksheet worksheet) {
            ValidationResult<IEnumerable<Excel_PhanBoDuToanThuDTO>> validationResult = new ValidationResult<IEnumerable<Excel_PhanBoDuToanThuDTO>>();
            try {
                Dictionary<string, Excel_PhanBoDuToanThuDTO> uniqueRows = new Dictionary<string, Excel_PhanBoDuToanThuDTO>();
                for (int rowIndex = 2; rowIndex <= worksheet.Rows.LastUsedIndex; rowIndex++) {
                    string key = $"{worksheet.Cells[rowIndex, 0].Value.SafeToString()}-{worksheet.Cells[rowIndex, 1].Value.SafeToString()}-" +
                        $"{worksheet.Cells[rowIndex, 2].Value.ConvertToNullableDateTimeDMY()}-{worksheet.Cells[rowIndex, 3].Value.SafeToString()}";
                    if (!uniqueRows.ContainsKey(key)) {
                        ValidationResult<Excel_PhanBoDuToanThuDTO> parentValidationResult = await ConvertRowToDTO(worksheet, rowIndex, idDonVi);
                        if (!parentValidationResult.Success) {
                            validationResult.Success = false;
                            validationResult.ErrorMessage = parentValidationResult.ErrorMessage;
                            return validationResult;
                        }
                        uniqueRows.Add(key, parentValidationResult.Result);
                        number++;
                    }
                    ValidationResult<Excel_PhanBoDuToanThuChiTietDTO> childValidationResult = await ConvertRowToDTODetail(worksheet, rowIndex, uniqueRows[key].Oid);
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
        private async Task<ValidationResult<Excel_PhanBoDuToanThuDTO>> ConvertRowToDTO(Worksheet worksheet, int rowIndex, Guid idDonVi) {
            ValidationResult<Excel_PhanBoDuToanThuDTO> validationResult = new ValidationResult<Excel_PhanBoDuToanThuDTO>();
            try {
                var lstPhongBan = (await iBusObjDonViSuDungChuongTrinhCT.GetListItem(true, null)).LstObjData.Where(x => x.PhanLoai == 2 && x.IdDonViSuDungChuongTrinh == idDonVi).ToList();
                int indexColNienDo = GetColumnIndexByName(worksheet, "nsNienDo");
                int indexColLoaiDuToan = GetColumnIndexByName(worksheet, "nsLoaiDuToan");
                int indexColQuyetDinhSo = GetColumnIndexByName(worksheet, "nsQuyetDinhSo");
                int indexColNgayQuyetDinh = GetColumnIndexByName(worksheet, "dNgayQuyetDinh");
                int indexColDienGiai = GetColumnIndexByName(worksheet, "nsDienGiai");

                CellValue cellNienDo = worksheet.GetCellValue(indexColNienDo, rowIndex);
                PeriodOfTime2 nienDo = PeriodOfTime2.GetPeriodOfTime(PeriodOfTime2.PeriodOfTimeType.YO, cellNienDo.TextValue.ConvertToInt());
                Excel_PhanBoDuToanThuDTO data = new Excel_PhanBoDuToanThuDTO() {
                    Oid = Guid.NewGuid(),
                    IdDonViSuDungChuongTrinh = idDonVi,
                    NienDo = nienDo.ConvertPeriodObjectToString(),
                    QuyetDinhSo = worksheet.Cells[rowIndex, indexColQuyetDinhSo].Value.SafeToString(),
                    NgayQuyetDinh = DateTime.Parse(worksheet.Cells[rowIndex, indexColNgayQuyetDinh].Value.ToString()),
                    DienGiai = worksheet.Cells[rowIndex, indexColDienGiai].Value.SafeToString(),
                    ListDataDetail = new List<Excel_PhanBoDuToanThuChiTietDTO>(),
                    IdDonViThucHien = lstPhongBan.FirstOrDefault().Oid,
                    DuToan = worksheet.Cells[rowIndex, indexColLoaiDuToan].Value.ConvertToInt(),
                };
                validationResult.Result = data;
            }
            catch (Exception ex) {
                validationResult.Success = false;
                validationResult.ErrorMessage = "Đã có lỗi xảy ra trong quá trình xử lý.";
            }
            return validationResult;
        }

        private async Task<ValidationResult<Excel_PhanBoDuToanThuChiTietDTO>> ConvertRowToDTODetail(Worksheet worksheet, int rowIndex, Guid idCha) {
            ValidationResult<Excel_PhanBoDuToanThuChiTietDTO> validationResult = new ValidationResult<Excel_PhanBoDuToanThuChiTietDTO>();
            try {
                var lstNguonVon = (await iBusObjNguonVon.GetListItem(true, null)).LstObjData;
                var lstCapNS = (await iBusObjCapNganSach.GetListItem(true, null)).LstObjData;
                var lstChuong = (await iBusObjChuong.GetListItem(true, null)).LstObjData;
                var lstMucTieuMuc = (await iBusObjMucTieuMuc.GetListItem(true, null)).LstObjData;

                int indexKhoanThu = GetColumnIndexByName(worksheet, "nsKhoanThu");
                int indexNguonVon = GetColumnIndexByName(worksheet, "nsNguonVon");
                int indexChuong = GetColumnIndexByName(worksheet, "nsChuong");
                int indexMucTieuMuc = GetColumnIndexByName(worksheet, "nsMucTieuMuc");
                int indexCapNganSach = GetColumnIndexByName(worksheet, "nsCapNganSach");
                int indexTinhChat = GetColumnIndexByName(worksheet, "nsTinhChat");
                int indexThuNSNN = GetColumnIndexByName(worksheet, "mnThuNSNN");
                int indexThuNSX = GetColumnIndexByName(worksheet, "mnThuNSX");
                int indexThuyetMinh = GetColumnIndexByName(worksheet, "nsThuyetMinh");

                var khoanThu = worksheet.Cells[rowIndex, indexKhoanThu].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
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
                    Excel_PhanBoDuToanThuChiTietDTO child = new Excel_PhanBoDuToanThuChiTietDTO() {
                        Oid = Guid.NewGuid(),
                        IdPhanBoDuToanThu = idCha,
                        KhoanThu = worksheet.Cells[rowIndex, indexKhoanThu].Value.SafeToString(),
                        IdCapNganSach = lstCapNS.FirstOrDefault(x => x.MaSo.Equals(maCapNS?.Trim()))?.Oid,
                        IdNguonVon = lstNguonVon.FirstOrDefault(x => x.MaSo.Equals(maNguonVon?.Trim()))?.Oid,
                        IdChuong = lstChuong.FirstOrDefault(x => x.MaSo.Equals(maChuong?.Trim()))?.Oid,
                        IdMucTieuMuc = lstMucTieuMuc.FirstOrDefault(x => x.MaSo.Equals(maMucTieuMuc?.Trim()))?.Oid,
                        DuToanDuocGiaoTongThu = worksheet.Cells[rowIndex, indexThuNSNN].Value.ConvertToNullableDecimal(),
                        DuToanDuocGiaoDuocHuong = worksheet.Cells[rowIndex, indexThuNSX].Value.ConvertToNullableDecimal(),
                        GhiChu = worksheet.Cells[rowIndex, indexThuyetMinh].Value.SafeToString(),
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
            string[] fieldNames = { "nsNienDo", "nsLoaiDuToan", "dNgayQuyetDinh", "nsNguonVon", "nsChuong", "nsMucTieuMuc", "nsCapNganSach", "mnThuNSNN", "mnThuNSX", "nsThuyetMinh" };
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
        public async Task<ValidationResult<IEnumerable<Excel_PhanBoDuToanThuDTO>>> ValidatorExcel(Guid idDonVi, Worksheet worksheet) {
            ValidationResult<IEnumerable<Excel_PhanBoDuToanThuDTO>> result = new ValidationResult<IEnumerable<Excel_PhanBoDuToanThuDTO>>();
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