using app.StdCommon;
using DevExpress.Spreadsheet;
using Microsoft.Extensions.Logging;
using ProjectX.Abstract.Bus;
using ProjectY4c.Client.ServerBusiness.Infrastructure.Contracts;

namespace ProjectY4c.ServerBusiness.Business.ExcelDataExchange.Group_QuyTrinhChiThuongXuyen {
    public class Excel_DuToanChiDuocHDNDThongQuaCTXBus(IProjectY4cClient client, ILogger logger,
        ISimpleBusinessObject<MLNSNN_ChuongDTO> iBusObjChuong,
        ISimpleBusinessObject<NguonVonDTO> iBusObjNguonVon,
        ISimpleBusinessObject<MLNSNN_MucTieuMucDTO> iBusObjMucTieuMuc,
        ISimpleBusinessObject<MLNSNN_LoaiKhoanDTO> iBusObjLoaiKHoan,
        ISimpleBusinessObject<MLNSNN_CapNSDTO> iBusObjCapNS, ISimpleBusinessObject<DonViSuDungChuongTrinhChiTietDTO> iBusObjDonViSuDungChuongTrinhCT) {
        int number = 1;

        private void CreateHeaderExcel(Worksheet worksheet) {
            worksheet.Cells["A1"].Value = "Niên độ";
            worksheet.Cells["A2"].Value = "nsNienDo";
            worksheet.Cells["B1"].Value = "Loại dự toán";
            worksheet.Cells["B2"].Value = "nsLoaiDuToan";
            worksheet.Cells["C1"].Value = "Ngày quyết định";
            worksheet.Cells["C2"].Value = "dNgayQuyetDinh";
            worksheet.Cells["D1"].Value = "Cấp ngân sách";
            worksheet.Cells["D2"].Value = "nsCapNganSach";
            worksheet.Cells["E1"].Value = "Nguồn vốn";
            worksheet.Cells["E2"].Value = "nsNguonVon";
            worksheet.Cells["F1"].Value = "Chương";
            worksheet.Cells["F2"].Value = "nsChuong";
            worksheet.Cells["G1"].Value = "Loại khoản";
            worksheet.Cells["G2"].Value = "nsLoaiKhoan";
            worksheet.Cells["H1"].Value = "Mục, tiểu mục";
            worksheet.Cells["H2"].Value = "nsMucTieuMuc";
            worksheet.Cells["I1"].Value = "Số tiền";
            worksheet.Cells["I2"].Value = "mnSoTien";
            worksheet.Range["A1:I2"].Font.Bold = true;
            CellRange range = worksheet["A1:I2000"];
            worksheet.AutoFilter.Apply(range);
            worksheet.AutoOutline();
            worksheet.Range["A1:I2"].AutoFitColumns();
            //worksheet.Columns.AutoFit(1, 200);
            //worksheet.Rows.Group(2, 10, true);
            //worksheet.Rows.Group(1, 35, false);
            worksheet.Cells["E1"].ColumnWidth = 700;
            worksheet.Cells["F1"].ColumnWidth = 700;
            worksheet.Cells["G1"].ColumnWidth = 700;
            worksheet.Cells["H1"].ColumnWidth = 700;

        }
        private void FillDataCellsValues(Worksheet worksheet, List<Excel_DuToanChiDuocHDNDThongQuaCTXDTO> listDatas) {
            int rowIndex = 2;
            foreach (var data in listDatas) {
                if (data.ListDataDetail != null) {
                    var loaiDuToan = ItemDuToan.GetItems().Where(x => x.Id == data.LoaiDuToan.ConvertToNullableInt()).Select(x => x.Name).FirstOrDefault() ?? string.Empty;
                    foreach (var item in data.ListDataDetail) {
                        worksheet.Cells[rowIndex, 0].Value = data.NienDo.SafeToString();
                        worksheet.Cells[rowIndex, 1].Value = loaiDuToan;
                        worksheet.Cells[rowIndex, 2].Value = data.NgayQuyetDinh.ConvertToNullableDateTimeDMY();
                        worksheet.Cells[rowIndex, 3].Value = item.IdCapNganSach.SafeToString();
                        worksheet.Cells[rowIndex, 4].Value = item.IdNguonVon.SafeToString();
                        worksheet.Cells[rowIndex, 5].Value = item.IdChuong.SafeToString();
                        worksheet.Cells[rowIndex, 6].Value = item.IdLoaiKhoan.SafeToString();
                        worksheet.Cells[rowIndex, 7].Value = item.IdMucTieuMuc.SafeToString();
                        worksheet.Cells[rowIndex, 8].Value = item.SoTien.ConvertToNullableDecimal();
                        rowIndex++;
                    }
                }
            }
        }
        public Workbook ExportDataExcel(List<Excel_DuToanChiDuocHDNDThongQuaCTXDTO> listData) {
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets[0];
            workbook.Worksheets.ActiveWorksheet = worksheet;
            CreateHeaderExcel(worksheet);
            FillDataCellsValues(worksheet, listData);
            return workbook;
        }
        private async Task<IEnumerable<Excel_DuToanChiDuocHDNDThongQuaCTXDTO>> ConvertExcelToDTO(Guid idDonVi, Worksheet worksheet) {
            Dictionary<string, Excel_DuToanChiDuocHDNDThongQuaCTXDTO> uniqueRows = new Dictionary<string, Excel_DuToanChiDuocHDNDThongQuaCTXDTO>();

            for (int rowIndex = 2; rowIndex <= worksheet.Rows.LastUsedIndex; rowIndex++) {
                string key = $"{worksheet.Cells[rowIndex, 0].Value.SafeToString()}-{worksheet.Cells[rowIndex, 1].Value.SafeToString()}-{worksheet.Cells[rowIndex, 2].Value.ConvertToNullableDateTimeDMY()}";
                if (!uniqueRows.ContainsKey(key)) {
                    Excel_DuToanChiDuocHDNDThongQuaCTXDTO parent = await ConvertRowToDTO(worksheet, rowIndex, idDonVi);
                    uniqueRows.Add(key, parent);
                    number++;
                }
                Excel_DuToanChiDuocHDNDThongQuaCTXChiTietDTO child = await ConvertRowToDTODetail(worksheet, rowIndex, uniqueRows[key].Oid);
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
            var res = await client.ApiV1NghiepvuExcelQtquanlyctxDutoanchiduochdndthongquactxImportdataexcelAsync(lstObj);
            return res.Result;
            //}
            //else return false;
        }
        public async Task<Excel_DuToanChiDuocHDNDThongQuaCTXDTO> ConvertRowToDTO(Worksheet worksheet, int rowIndex, Guid idDonVi) {
            var lstPhongBan = (await iBusObjDonViSuDungChuongTrinhCT.GetListItem(true, null)).LstObjData;
            var duToan = worksheet.Cells[rowIndex, 1].Value.SafeToString().Trim().ToLower();
            int columnIndex0 = GetColumnIndexByName(worksheet, "nsNienDo");
            int columnIndex1 = GetColumnIndexByName(worksheet, "nsLoaiDuToan");
            int columnIndex2 = GetColumnIndexByName(worksheet, "dNgayQuyetDinh");
            if (columnIndex0 == -1) {

            }
            if (columnIndex1 == -1) {

            }
            if (columnIndex2 == -1) {

            }
            Excel_DuToanChiDuocHDNDThongQuaCTXDTO data = new Excel_DuToanChiDuocHDNDThongQuaCTXDTO() {
                Oid = Guid.NewGuid(),
                IdDonViSuDungChuongTrinh = idDonVi,
                NienDo = worksheet.Cells[rowIndex, columnIndex0].Value.SafeToString(),
                LoaiDuToan = ItemDuToan.GetItems().FirstOrDefault(x => x.Name.Trim().Equals(worksheet.Cells[rowIndex, columnIndex1].Value.SafeToString().Trim(), StringComparison.CurrentCultureIgnoreCase))?.Id,
                NgayQuyetDinh = DateTime.Parse(worksheet.Cells[rowIndex, columnIndex2].Value.ToString()),
                // IdDonViThucHien = lstPhongBan.Select(x => x.Oid).First(),
                NghiQuyetSo = "Quyết định số" + $"{number}",
                GhiChu = "Dự toán chi ngân sach xã năm " + worksheet.Cells[rowIndex, columnIndex0].Value.SafeToString(),
                ListDataDetail = new List<Excel_DuToanChiDuocHDNDThongQuaCTXChiTietDTO>(),
            };
            return data;
        }
        public async Task<Excel_DuToanChiDuocHDNDThongQuaCTXChiTietDTO> ConvertRowToDTODetail(Worksheet worksheet, int rowIndex, Guid idCha) {
            var lstLoaiKhoan = (await iBusObjLoaiKHoan.GetListItem(true, null)).LstObjData;
            var lstCapNS = (await iBusObjCapNS.GetListItem(true, null)).LstObjData;
            var lstNguonVon = (await iBusObjNguonVon.GetListItem(true, null)).LstObjData;
            var lstChuong = (await iBusObjChuong.GetListItem(true, null)).LstObjData;
            var lstMucTieuMuc = (await iBusObjMucTieuMuc.GetListItem(true, null)).LstObjData;

            int columnIndex3 = GetColumnIndexByName(worksheet, "nsCapNganSach");
            int columnIndex4 = GetColumnIndexByName(worksheet, "nsNguonVon");
            int columnIndex5 = GetColumnIndexByName(worksheet, "nsChuong");
            int columnIndex6 = GetColumnIndexByName(worksheet, "nsLoaiKhoan");
            int columnIndex7 = GetColumnIndexByName(worksheet, "nsMucTieuMuc");
            int columnIndex8 = GetColumnIndexByName(worksheet, "mnSoTien");


            var maCapNS = worksheet.Cells[rowIndex, columnIndex3].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
            var maNguonVon = worksheet.Cells[rowIndex, columnIndex4].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
            var maChuong = worksheet.Cells[rowIndex, columnIndex5].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
            var maLoaiKhoan = worksheet.Cells[rowIndex, columnIndex6].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
            var maMucTieuMuc = worksheet.Cells[rowIndex, columnIndex7].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();

            Excel_DuToanChiDuocHDNDThongQuaCTXChiTietDTO data = new Excel_DuToanChiDuocHDNDThongQuaCTXChiTietDTO() {
                Oid = Guid.NewGuid(),
                IdDuToanChiDuocHDNDThongQuaCDT = idCha,
                IdLoaiKhoan = lstLoaiKhoan.FirstOrDefault(x => x.MaSo.Equals(maLoaiKhoan?.Trim()))?.Oid,
                IdCapNganSach = lstCapNS.FirstOrDefault(x => x.MaSo.Equals(maCapNS?.Trim()))?.Oid,
                IdNguonVon = lstNguonVon.FirstOrDefault(x => x.MaSo.Equals(maNguonVon?.Trim()))?.Oid,
                IdChuong = lstChuong.FirstOrDefault(x => x.MaSo.Equals(maChuong?.Trim()))?.Oid,
                IdMucTieuMuc = lstMucTieuMuc.FirstOrDefault(x => x.MaSo.Equals(maMucTieuMuc?.Trim()))?.Oid,
                SoTien = worksheet.Cells[rowIndex, columnIndex8].Value.ConvertToNullableDecimal(),
            };
            return data;
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
                new ItemDuToan(0, "Tất cả"),
            };
        }
    }
}