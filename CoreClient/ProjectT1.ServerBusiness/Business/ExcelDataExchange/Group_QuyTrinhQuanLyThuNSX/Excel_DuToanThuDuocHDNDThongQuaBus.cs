using app.StdCommon;
using DevExpress.Spreadsheet;
using Microsoft.Extensions.Logging;
using ProjectX.Abstract.Bus;
using ProjectY4c.Client.ServerBusiness.Infrastructure.Contracts;
using System.Text.RegularExpressions;

namespace ProjectY4c.ServerBusiness.Business.ExcelDataExchange.Group_QuyTrinhQuanLyThuNSX {
    public class Excel_DuToanThuDuocHDNDThongQuaBus {
        private readonly ILogger _logger;
        private readonly IProjectY4cClient _client;
        readonly ISimpleBusinessObject<MLNSNN_ChuongDTO> IBusObjChuong;
        readonly ISimpleBusinessObject<MLNSNN_MucTieuMucDTO> IBusObjMucTieuMuc;
        readonly ISimpleBusinessObject<NguonVonDTO> IBusObjNguonVon;
        readonly ISimpleBusinessObject<PhanLoaiKhoanThuDTO> IBusObjPhanLoaiKhoanThu;
        readonly ISimpleBusinessObject<MLNSNN_CapNSDTO> IBusObjCapNS;
        readonly ISimpleBusinessObject<DonViSuDungChuongTrinhChiTietDTO> IBusObjDonViSuDungChuongTrinhCT;
        int number = 1;
        public Excel_DuToanThuDuocHDNDThongQuaBus(IProjectY4cClient client, ILogger logger,
            ISimpleBusinessObject<MLNSNN_ChuongDTO> iBusObjChuong,
            ISimpleBusinessObject<NguonVonDTO> iBusObjNguonVon,
            ISimpleBusinessObject<MLNSNN_MucTieuMucDTO> iBusObjMucTieuMuc,
            ISimpleBusinessObject<PhanLoaiKhoanThuDTO> iBusObjPhanLoaiKhoanThu,
            ISimpleBusinessObject<MLNSNN_CapNSDTO> iBusObjCapNS, ISimpleBusinessObject<DonViSuDungChuongTrinhChiTietDTO> iBusObjDonViSuDungChuongTrinhCT) {
            _logger = logger;
            _client = client;
            IBusObjChuong = iBusObjChuong;
            IBusObjNguonVon = iBusObjNguonVon;
            IBusObjMucTieuMuc = iBusObjMucTieuMuc;
            IBusObjPhanLoaiKhoanThu = iBusObjPhanLoaiKhoanThu;
            IBusObjCapNS = iBusObjCapNS;
            IBusObjDonViSuDungChuongTrinhCT = iBusObjDonViSuDungChuongTrinhCT;
        }
        private void CreateHeaderExcel(Worksheet worksheet) {
            worksheet.Cells["A1"].Value = "Niên độ";
            worksheet.Cells["A2"].Value = "nsNienDo";
            worksheet.Cells["B1"].Value = "Loại dự toán";
            worksheet.Cells["B2"].Value = "nsLoaiDuToan";
            worksheet.Cells["C1"].Value = "Ngày quyết định";
            worksheet.Cells["C2"].Value = "dNgayQuyetDinh";
            worksheet.Cells["D1"].Value = "Khoản thu";
            worksheet.Cells["D2"].Value = "nsKhoanThu";
            worksheet.Cells["E1"].Value = "Cấp ngân sách";
            worksheet.Cells["E2"].Value = "nsCapNganSach";
            worksheet.Cells["F1"].Value = "Nguồn vốn";
            worksheet.Cells["F2"].Value = "nsNguonVon";
            worksheet.Cells["G1"].Value = "Chương";
            worksheet.Cells["G2"].Value = "nsChuong";
            worksheet.Cells["H1"].Value = "Mục, tiểu mục";
            worksheet.Cells["H2"].Value = "nsMucTieuMuc";
            worksheet.Cells["I1"].Value = "Thu NSNN";
            worksheet.Cells["I2"].Value = "mnThuNSNN";
            worksheet.Cells["J1"].Value = "Thu NSX";
            worksheet.Cells["J2"].Value = "mnThuNSX";
            worksheet.Range["A1:J1"].Font.Bold = true;
            CellRange range = worksheet["A1:J1000"];
            worksheet.AutoFilter.Apply(range);
            worksheet.AutoOutline();
            worksheet.Range["A1:J1"].AutoFitColumns();
            worksheet.Cells["E1"].ColumnWidth = 700;
            worksheet.Cells["F1"].ColumnWidth = 700;

        }
        private void FillDataCellsValues(Worksheet worksheet, List<Excel_DuToanThuDuocHDNDThongQuaDTO> listDatas) {
            int rowIndex = 2;// Tu A3
            PeriodOfTime2 periodOfTime = new PeriodOfTime2();
            foreach (var data in listDatas) {
                if (data.ListDataDetail != null) {
                    var check = periodOfTime.ConvertFromPeriodString(data.NienDo);
                    var loaiDuToan = ItemDuToan.GetItems().Where(x => x.Id == data.DuToan.ConvertToNullableInt()).Select(x => x.Name).FirstOrDefault() ?? string.Empty;
                    foreach (var item in data.ListDataDetail) {
                        worksheet.Cells[rowIndex, 0].Value = (check) ? periodOfTime.iFromYear.SafeToString() : "";
                        worksheet.Cells[rowIndex, 1].Value = loaiDuToan;
                        worksheet.Cells[rowIndex, 2].Value = data.NgayQuyetDinh.ConvertToNullableDateTimeDMY();
                        worksheet.Cells[rowIndex, 3].Value = item.KhoanThu.SafeToString();
                        worksheet.Cells[rowIndex, 4].Value = item.CapNganSach.SafeToString();
                        worksheet.Cells[rowIndex, 5].Value = item.NguonVon.SafeToString();
                        worksheet.Cells[rowIndex, 6].Value = item.Chuong.SafeToString();
                        worksheet.Cells[rowIndex, 7].Value = item.MucTieuMuc.SafeToString();
                        worksheet.Cells[rowIndex, 8].Value = item.ThuNSNN.ConvertToNullableDecimal();
                        worksheet.Cells[rowIndex, 9].Value = item.ThuNSX.ConvertToNullableDecimal();
                        rowIndex++;
                    }
                }
            }
        }
        public Workbook ExportDataExcel(List<Excel_DuToanThuDuocHDNDThongQuaDTO> listData) {
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets[0];
            workbook.Worksheets.ActiveWorksheet = worksheet;
            CreateHeaderExcel(worksheet);
            FillDataCellsValues(worksheet, listData);
            return workbook;
        }
        public async Task<bool> ImportDataExcel(IEnumerable<Excel_DuToanThuDuocHDNDThongQuaDTO> lstObj) {
            var res = await _client.ApiV1NghiepvuExcelQtquanlythunsxDutoanthuduochdndthongquaImportdataexcelAsync(lstObj);
            return res.Result;
        }
        private int GetColumnIndexByName(Worksheet worksheet, string columnName) {
            Cell cell = worksheet.Rows[1].FirstOrDefault(c => c.Value != null && c.Value.ToString() == columnName);
            return cell != null ? cell.ColumnIndex : -1;
        }
        private class ItemDuToan {
            public int Id { get; set; }
            public string Name { get; set; }
            public ItemDuToan(int id, string name) {
                Id = id;
                Name = name;
            }
            public static List<ItemDuToan> GetItems() => new List<ItemDuToan> {
                new ItemDuToan(1, "Dự toán giao đầu năm"),
                new ItemDuToan(2, "Dự toán bổ sung trong năm"),
            };
        }

        private async Task<ValidationResult<IEnumerable<Excel_DuToanThuDuocHDNDThongQuaDTO>>> ConvertExcelToDTO(Guid idDonVi, Worksheet worksheet) {
            ValidationResult<IEnumerable<Excel_DuToanThuDuocHDNDThongQuaDTO>> validationResult = new ValidationResult<IEnumerable<Excel_DuToanThuDuocHDNDThongQuaDTO>>();
            try {
                Dictionary<string, Excel_DuToanThuDuocHDNDThongQuaDTO> uniqueRows = new Dictionary<string, Excel_DuToanThuDuocHDNDThongQuaDTO>();
                for (int rowIndex = 2; rowIndex <= worksheet.Rows.LastUsedIndex; rowIndex++) {
                    string key = $"{worksheet.Cells[rowIndex, 0].Value.SafeToString()}-{worksheet.Cells[rowIndex, 1].Value.SafeToString()}-{worksheet.Cells[rowIndex, 2].Value.ConvertToNullableDateTimeDMY()}";
                    if (!uniqueRows.ContainsKey(key)) {
                        ValidationResult<Excel_DuToanThuDuocHDNDThongQuaDTO> parentValidationResult = await ConvertRowToDTO(worksheet, rowIndex, idDonVi);
                        if (!parentValidationResult.Success) {
                            validationResult.Success = false;
                            validationResult.ErrorMessage = parentValidationResult.ErrorMessage;
                            return validationResult;
                        }
                        uniqueRows.Add(key, parentValidationResult.Result);
                        number++;
                    }
                    ValidationResult<Excel_DuToanThuDuocHDNDThongQuaChiTietDTO> childValidationResult = await ConvertRowToDTODetail(worksheet, rowIndex, uniqueRows[key].Oid);
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

        private async Task<ValidationResult<Excel_DuToanThuDuocHDNDThongQuaDTO>> ConvertRowToDTO(Worksheet worksheet, int rowIndex, Guid idDonVi) {
            ValidationResult<Excel_DuToanThuDuocHDNDThongQuaDTO> validationResult = new ValidationResult<Excel_DuToanThuDuocHDNDThongQuaDTO>();
            try {
                var lstPhongBan = (await IBusObjDonViSuDungChuongTrinhCT.GetListItem(true, null)).LstObjData;
                var duToan = worksheet.Cells[rowIndex, 1].Value.SafeToString().Trim().ToLower();
                int columnIndex0 = GetColumnIndexByName(worksheet, "nsNienDo");
                int columnIndex1 = GetColumnIndexByName(worksheet, "nsLoaiDuToan");
                int columnIndex2 = GetColumnIndexByName(worksheet, "dNgayQuyetDinh");
                PeriodOfTime2 nienDo = PeriodOfTime2.GetPeriodOfTime(PeriodOfTime2.PeriodOfTimeType.YO, [worksheet.Cells[rowIndex, columnIndex0].ConvertToInt()]);

                Excel_DuToanThuDuocHDNDThongQuaDTO data = new Excel_DuToanThuDuocHDNDThongQuaDTO() {
                    Oid = Guid.NewGuid(),
                    IdDonViSuDungChuongTrinh = idDonVi,
                    NienDo = nienDo.ConvertPeriodObjectToString(),
                    DuToan = ItemDuToan.GetItems().FirstOrDefault(x => x.Name.Trim().
                            Equals(worksheet.Cells[rowIndex, columnIndex1].Value.SafeToString().Trim(), StringComparison.CurrentCultureIgnoreCase))?.Id,
                    NgayQuyetDinh = DateTime.Parse(worksheet.Cells[rowIndex, columnIndex2].Value.ToString()),
                    QuyetDinhSo = "Quyết định số" + $"{number}",
                    GhiChu = "Thu ngân sách xã " + worksheet.Cells[rowIndex, columnIndex0].Value.SafeToString(),
                    ListDataDetail = new List<Excel_DuToanThuDuocHDNDThongQuaChiTietDTO>(),
                };

                validationResult.Result = data;
            }
            catch (Exception ex) {
                validationResult.Success = false;
                validationResult.ErrorMessage = "Đã có lỗi xảy ra trong quá trình xử lý.";
            }

            return validationResult;
        }

        private async Task<ValidationResult<Excel_DuToanThuDuocHDNDThongQuaChiTietDTO>> ConvertRowToDTODetail(Worksheet worksheet, int rowIndex, Guid idCha) {
            ValidationResult<Excel_DuToanThuDuocHDNDThongQuaChiTietDTO> validationResult = new ValidationResult<Excel_DuToanThuDuocHDNDThongQuaChiTietDTO>();
            try {
                var lstKhoanThu = (await IBusObjPhanLoaiKhoanThu.GetListItem(true, null)).LstObjData;
                var lstCapNS = (await IBusObjCapNS.GetListItem(true, null)).LstObjData;
                var lstNguonVon = (await IBusObjNguonVon.GetListItem(true, null)).LstObjData;
                var lstChuong = (await IBusObjChuong.GetListItem(true, null)).LstObjData;
                var lstMucTieuMuc = (await IBusObjMucTieuMuc.GetListItem(true, null)).LstObjData;
                int columnIndex3 = GetColumnIndexByName(worksheet, "nsKhoanThu");
                int columnIndex4 = GetColumnIndexByName(worksheet, "nsCapNganSach");
                int columnIndex5 = GetColumnIndexByName(worksheet, "nsNguonVon");
                int columnIndex6 = GetColumnIndexByName(worksheet, "nsChuong");
                int columnIndex7 = GetColumnIndexByName(worksheet, "nsMucTieuMuc");
                int columnIndex8 = GetColumnIndexByName(worksheet, "mnThuNSNN");
                int columnIndex9 = GetColumnIndexByName(worksheet, "mnThuNSX");
                var maKhoanThu = worksheet.Cells[rowIndex, columnIndex3].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
                var maCapNS = worksheet.Cells[rowIndex, columnIndex4].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
                var maNguonVon = worksheet.Cells[rowIndex, columnIndex5].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
                var maChuong = worksheet.Cells[rowIndex, columnIndex6].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
                var maMucTieuMuc = worksheet.Cells[rowIndex, columnIndex7].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
                var mnThuNSNN = worksheet.Cells[rowIndex, columnIndex8].Value.SafeToString();
                var mnThuNSX = worksheet.Cells[rowIndex, columnIndex9].Value.SafeToString();

                var checkKhoanThu = ValidateMaSo(lstKhoanThu, maKhoanThu, x => x.MaSo);
                var checkCapNS = ValidateMaSo(lstCapNS, maCapNS, x => x.MaSo);
                var checkNguonVon = ValidateMaSo(lstNguonVon, maNguonVon, x => x.MaSo);
                var checkChuong = ValidateMaSo(lstChuong, maChuong, x => x.MaSo);
                var checkMucTieuMuc = ValidateMaSo(lstMucTieuMuc, maMucTieuMuc, x => x.MaSo);
                var checkMoney = ValidatorSoTien(mnThuNSNN, mnThuNSX);
                if (!checkKhoanThu.Success) {
                    validationResult.Success = false;
                    validationResult.ErrorMessage = checkKhoanThu.ErrorMessage + "Kiểm tra lại mã số khoản thu ";
                }
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
                    Excel_DuToanThuDuocHDNDThongQuaChiTietDTO child = new Excel_DuToanThuDuocHDNDThongQuaChiTietDTO() {
                        Oid = Guid.NewGuid(),
                        IdDuToanThuDuocHDNDThongQua = idCha,
                        IdKhoanThu = lstKhoanThu.FirstOrDefault(x => x.MaSo.Equals(maKhoanThu?.Trim()))?.Oid,
                        IdCapNganSach = lstCapNS.FirstOrDefault(x => x.MaSo.Equals(maCapNS?.Trim()))?.Oid,
                        IdNguonVon = lstNguonVon.FirstOrDefault(x => x.MaSo.Equals(maNguonVon?.Trim()))?.Oid,
                        IdChuong = lstChuong.FirstOrDefault(x => x.MaSo.Equals(maChuong?.Trim()))?.Oid,
                        IdMucTieuMuc = lstMucTieuMuc.FirstOrDefault(x => x.MaSo.Equals(maMucTieuMuc?.Trim()))?.Oid,
                        ThuNSNN = mnThuNSNN.ConvertToNullableDecimal(),
                        ThuNSX = mnThuNSX.ConvertToNullableDecimal(),
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
        #region Validator
        private ValidationResult<bool> ValidateFieldNameColumn(Worksheet worksheet) {
            ValidationResult<bool> result = new ValidationResult<bool>();
            // Tên của các trường cần kiểm tra
            string[] fieldNames = { "nsNienDo", "nsLoaiDuToan", "dNgayQuyetDinh", "nsKhoanThu", "nsCapNganSach",
                "nsNguonVon", "nsChuong", "nsMucTieuMuc", "mnThuNSNN", "mnThuNSX" };
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
        public async Task<ValidationResult<IEnumerable<Excel_DuToanThuDuocHDNDThongQuaDTO>>> ValidatorExcel(Guid idDonVi, Worksheet worksheet) {
            ValidationResult<IEnumerable<Excel_DuToanThuDuocHDNDThongQuaDTO>> result = new ValidationResult<IEnumerable<Excel_DuToanThuDuocHDNDThongQuaDTO>>();
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
        public class ValidationResult<T> {
            public bool Success { get; set; } = true;
            public string ErrorMessage { get; set; } = "";
            public T Result { get; set; }
        }
        #endregion
    }
}