using app.StdCommon;
using DevExpress.Spreadsheet;
using Microsoft.Extensions.Logging;
using ProjectX.Abstract.Bus;
using ProjectY4c.Client.ServerBusiness.Infrastructure.Contracts;

namespace ProjectY4c.ServerBusiness.Business.ExcelDataExchange.Group_QuyTrinhQuanLyThuNSX {
    public class Excel_HoanTraKhoanThuNganSachXaBus(IProjectY4cClient client, ILogger logger,
        ISimpleBusinessObject<MLNSNN_ChuongDTO> iBusObjChuong,
        ISimpleBusinessObject<NguonVonDTO> iBusObjNguonVon,
        ISimpleBusinessObject<MLNSNN_MucTieuMucDTO> iBusObjMucTieuMuc,
        ISimpleBusinessObject<MLNSNN_CapNSDTO> iBusObjCapNganSach,
        ISimpleBusinessObject<DonViSuDungChuongTrinhChiTietDTO> iBusObjDonViSuDungChuongTrinhCT
            ) {
        private string tinhChat1 = "Thu chưa qua kho bạc ngoài thời gian chỉnh lý"; // kho bac: 0 thời gian chinh ly : 0
        private string tinhChat2 = "Thu chưa qua kho bạc trong thời gian chỉnh lý"; // kho bac:  0 thoi gian chinh ly : 1
        private string tinhChat3 = "Thu qua kho bạc trong thời gian chỉnh lý"; // kho bac: 1 thoi gian chinh ly: 1
        private string tinhChat4 = "Thu qua kho bạc ngoài thời gian chỉnh lý"; // kho bac: 1 thoi gian chinh ly: 0
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

            worksheet.Range["A1:L2"].Font.Bold = true;
            worksheet.Columns.AutoFit(1, 100);
            //worksheet.Range["A1:K1"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
        }
        private void FillDataCellsValues(Worksheet worksheet, List<Excel_HoanTraKhoanThuNganSachXaDTO> listDatas) {
            int rowIndex = 2;
            foreach (var data in listDatas) {
                if (data.ListDataDetail.Count > 0) {
                    foreach (var item in data.ListDataDetail) {
                        var thuQuaKhoBac = item.DuocChonThuQuaKhoBac.ConvertToBool();
                        var thuThoiGianChinhLy = item.DuocChonThuThoiGianChinhLy.ConvertToBool();
                        worksheet.Cells[rowIndex, 0].Value = data.NienDo.SafeToString();
                        worksheet.Cells[rowIndex, 1].Value = data.SoChungTu.SafeToString();
                        worksheet.Cells[rowIndex, 2].Value = data.NgayChungTu.ConvertToNullableDateTimeDMY();
                        worksheet.Cells[rowIndex, 3].Value = data.DienGiai.SafeToString();
                        worksheet.Cells[rowIndex, 4].Value = item.NguonVon.SafeToString();
                        worksheet.Cells[rowIndex, 5].Value = item.CapNganSach.SafeToString();
                        worksheet.Cells[rowIndex, 6].Value = item.Chuong.SafeToString();
                        worksheet.Cells[rowIndex, 7].Value = item.MucTieuMuc.SafeToString();
                        worksheet.Cells[rowIndex, 8].Value = thuQuaKhoBac && thuThoiGianChinhLy ? tinhChat3 : !thuQuaKhoBac && !thuThoiGianChinhLy ? tinhChat1
                                                : thuQuaKhoBac && !thuThoiGianChinhLy ? tinhChat4 : !thuQuaKhoBac && thuThoiGianChinhLy ? tinhChat2 : "Không xác định";
                        worksheet.Cells[rowIndex, 9].Value = item.SoTienThuNSNN.ConvertToNullableDecimal();
                        worksheet.Cells[rowIndex, 10].Value = item.SoTien.ConvertToNullableDecimal();
                        worksheet.Cells[rowIndex, 11].Value = item.ThuyetMinh.SafeToString();
                        rowIndex++;
                    }
                }
            }
        }

        public Workbook ExportDataExcel(List<Excel_HoanTraKhoanThuNganSachXaDTO> listData) {
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets[0];
            workbook.Worksheets.ActiveWorksheet = worksheet;
            CreateHeaderExcel(worksheet);
            FillDataCellsValues(worksheet, listData);
            return workbook;
        }
        private async Task<IEnumerable<Excel_HoanTraKhoanThuNganSachXaDTO>> ConvertExcelToDTO(Guid idDonVi, Worksheet worksheet) {
            Dictionary<string, Excel_HoanTraKhoanThuNganSachXaDTO> uniqueRows = new Dictionary<string, Excel_HoanTraKhoanThuNganSachXaDTO>();

            for (int rowIndex = 2; rowIndex <= worksheet.Rows.LastUsedIndex; rowIndex++) {
                string key = $"{worksheet.Cells[rowIndex, 0].Value.SafeToString()}-{worksheet.Cells[rowIndex, 1].Value.SafeToString()}-{worksheet.Cells[rowIndex, 2].Value.ConvertToNullableDateTimeDMY()}";
                if (!uniqueRows.ContainsKey(key)) {
                    Excel_HoanTraKhoanThuNganSachXaDTO parent = await ConvertRowToDTO(worksheet, rowIndex, idDonVi);
                    uniqueRows.Add(key, parent);
                    number++;
                }
                Excel_HoanTraKhoanThuNganSachXaChiTietDTO child = await ConvertRowToDTODetail(worksheet, rowIndex, uniqueRows[key].Oid);
                uniqueRows[key].ListDataDetail.Add(child);
            }
            return uniqueRows.Values;
        }
        public async Task<bool> ImportDataExcel(Guid idDonVi, Worksheet worksheet) {
            //Workbook workbook = new Workbook();
            //var check = workbook.LoadDocument(fileName);
            //if (check) {
            //    Worksheet worksheet = workbook.Worksheets[0];
            //    var headerRow = worksheet.Rows[0];
            //    //for (int i = 0; i < 11; i++) {
            //    //    var checkValue = headerRow[i].Value.SafeToString().ToLower();
            //    //    if (checkValue != "niên độ" &&
            //    //        checkValue != "số chứng từ" &&
            //    //        checkValue != "ngày chứng từ" &&
            //    //        checkValue != "diễn giải" &&
            //    //        checkValue != "nguồn vốn" &&
            //    //        checkValue != "chương" &&
            //    //        checkValue != "tính chất" &&
            //    //        checkValue != "mục, tiểu mục" &&
            //    //        checkValue != "số tiền thu nsnn" &&
            //    //        checkValue != "số tiền thu nsx" &&
            //    //        checkValue != "thuyết minh"
            //    //    ) {
            //    //        return false;
            //    //    }
            //    //}
            var lstObj = await ConvertExcelToDTO(idDonVi, worksheet);
            var res = await client.ApiV1NghiepvuExcelQtquanlythunsxHoantrakhoanthungansachxaImportdataexcelAsync(lstObj);
            return res.Result;
            //}
            //else return false;
        }
        public async Task<Excel_HoanTraKhoanThuNganSachXaDTO> ConvertRowToDTO(Worksheet worksheet, int rowIndex, Guid idDonVi) {
            var lstPhongBan = (await iBusObjDonViSuDungChuongTrinhCT.GetListItem(true, null)).LstObjData;
            var duToan = worksheet.Cells[rowIndex, 1].Value.SafeToString().Trim().ToLower();
            int columnIndex0 = GetColumnIndexByName(worksheet, "nsSoChungTu");
            int columnIndex1 = GetColumnIndexByName(worksheet, "dNgayChungTu");
            // int columnIndex2 = GetColumnIndexByName(worksheet, "dNgayQuyetDinh");
            if (columnIndex0 == -1) {

            }
            if (columnIndex1 == -1) {

            }
            //if (columnIndex2 == -1)
            //{

            //}
            Excel_HoanTraKhoanThuNganSachXaDTO data = new Excel_HoanTraKhoanThuNganSachXaDTO() {
                Oid = Guid.NewGuid(),
                IdDonViSuDungChuongTrinh = idDonVi,
                NienDo = "Niên độ" + $"{number}",
                //DuToan = ItemDuToan.GetItems().FirstOrDefault(x => x.Name.Trim().Equals(worksheet.Cells[rowIndex, columnIndex1].Value.SafeToString().Trim(), StringComparison.CurrentCultureIgnoreCase))?.Id,
                SoChungTu = worksheet.Cells[rowIndex, columnIndex0].Value.SafeToString(),
                NgayChungTu = DateTime.Parse(worksheet.Cells[rowIndex, columnIndex1].Value.ToString()),
                // IdDonViThucHien = lstPhongBan.Select(x => x.Oid).First(),
                // QuyetDinhSo = "Quyết định số" + $"{number}",
                //GhiChu = .Value.SafeToString(),
                ListDataDetail = new List<Excel_HoanTraKhoanThuNganSachXaChiTietDTO>(),
            };
            return data;
        }

        public async Task<Excel_HoanTraKhoanThuNganSachXaChiTietDTO> ConvertRowToDTODetail(Worksheet worksheet, int rowIndex, Guid idCha) {
            var lstCapNS = (await iBusObjCapNganSach.GetListItem(true, null)).LstObjData;
            var lstNguonVon = (await iBusObjNguonVon.GetListItem(true, null)).LstObjData;
            var lstChuong = (await iBusObjChuong.GetListItem(true, null)).LstObjData;
            var lstMucTieuMuc = (await iBusObjMucTieuMuc.GetListItem(true, null)).LstObjData;


            int columnIndex4 = GetColumnIndexByName(worksheet, "nsNguonVon");
            int columnIndex5 = GetColumnIndexByName(worksheet, "nsChuong");
            int columnIndex6 = GetColumnIndexByName(worksheet, "nsMucTieuMuc");
            int columnIndex7 = GetColumnIndexByName(worksheet, "nsCapNganSach");
            int columnIndex8 = GetColumnIndexByName(worksheet, "nsTinhChat");
            int columnIndex9 = GetColumnIndexByName(worksheet, "mnThuNSNN");
            int columnIndex10 = GetColumnIndexByName(worksheet, "mnThuNSX");
            int columnIndex11 = GetColumnIndexByName(worksheet, "nsThuyetMinh");

            var maNguonVon = worksheet.Cells[rowIndex, columnIndex4].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
            var maCapNS = worksheet.Cells[rowIndex, columnIndex5].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
            var maChuong = worksheet.Cells[rowIndex, columnIndex6].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
            var maMucTieuMuc = worksheet.Cells[rowIndex, columnIndex7].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();

            Excel_HoanTraKhoanThuNganSachXaChiTietDTO data = new Excel_HoanTraKhoanThuNganSachXaChiTietDTO() {
                Oid = Guid.NewGuid(),
                IdHoanTraKhoanThuNganSachXa = idCha,
                IdCapNganSach = lstCapNS.FirstOrDefault(x => x.MaSo.Equals(maCapNS?.Trim()))?.Oid,
                IdNguonVon = lstNguonVon.FirstOrDefault(x => x.MaSo.Equals(maNguonVon?.Trim()))?.Oid,
                IdChuong = lstChuong.FirstOrDefault(x => x.MaSo.Equals(maChuong?.Trim()))?.Oid,
                IdMucTieuMuc = lstMucTieuMuc.FirstOrDefault(x => x.MaSo.Equals(maMucTieuMuc?.Trim()))?.Oid,
                DuocChonThuQuaKhoBac = worksheet.Cells[rowIndex, columnIndex8].Value.ConvertToBool(),
                DuocChonThuThoiGianChinhLy = worksheet.Cells[rowIndex, columnIndex8].Value.ConvertToBool(),
                SoTienThuNSNN = worksheet.Cells[rowIndex, columnIndex9].Value.ConvertToNullableDecimal(),
                SoTien = worksheet.Cells[rowIndex, columnIndex10].Value.ConvertToNullableDecimal(),
                ThuyetMinh = worksheet.Cells[rowIndex, columnIndex11].Value.SafeToString(),
            };
            return data;
        }


        private int GetColumnIndexByName(Worksheet worksheet, string columnName) {
            Cell cell = worksheet.Rows[1].FirstOrDefault(c => c.Value != null && c.Value.ToString() == columnName);
            return cell != null ? cell.ColumnIndex : -1;
        }

        //public async Task<bool> WriteExcelFile(byte[] data, string fileName) {
        //    using var stream = new MemoryStream(data);
        //    using var workbook = new Workbook();
        //    workbook.LoadDocument(stream);
        //    workbook.SaveDocument(fileName);
        //    return true;
        //}

        //public async Task<byte[]?> ExportDataExcel(List<TExternalApp> listData) {
        //    throw new NotImplementedException();
        //}

        //public async Task<List<Excel_QTQuanLyThuNSX_ThucHienThuNganSachXaDTO>?> ImportDataExcel(byte[] files) {
        //    throw new NotImplementedException();
        //}

        //public async Task<TExternalApp> ExportDataExcel(List<TThisApp> listData, string fileName) {
        //    // B1:
        //    var res = new List<TExternalApp>();

        //    // B2:
        //    var bytesArray = ExportDataExcel(res);

        //    // B3:
        //    var res = WriteExcelFile(bytesArray, fileName);
        //}
    }
}