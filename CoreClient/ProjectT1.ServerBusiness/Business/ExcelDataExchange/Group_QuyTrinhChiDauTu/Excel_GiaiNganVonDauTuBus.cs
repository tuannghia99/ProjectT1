using app.StdCommon;
using DevExpress.Spreadsheet;
using Microsoft.Extensions.Logging;
using ProjectX.Abstract.Bus;
using ProjectY4c.Client.ServerBusiness.Infrastructure.Contracts;

namespace ProjectY4c.ServerBusiness.Business.ExcelDataExchange.Group_QuyTrinhChiDauTu {
    public class Excel_GiaiNganVonDauTuBus(IProjectY4cClient client, ILogger logger,
        ISimpleBusinessObject<MLNSNN_ChuongDTO> iBusObjChuong,
        ISimpleBusinessObject<MLNSNN_LoaiKhoanDTO> iBusObjLoaiKhoan,
        ISimpleBusinessObject<NguonVonDTO> iBusObjNguonVon,
        ISimpleBusinessObject<MLNSNN_MucTieuMucDTO> iBusObjMucTieuMuc,
        ISimpleBusinessObject<DuAnDauTuDoXaQuanLyDTO> iBusObjDuAnDauTuDoXaQuanLy,
        ISimpleBusinessObject<NoiDungDauTuDTO> iBusObjNoiDungChiDauTu,
        ISimpleBusinessObject<MLNSNN_CapNSDTO> iBusObjCapNS, ISimpleBusinessObject<DonViSuDungChuongTrinhChiTietDTO> iBusObjDonViSuDungChuongTrinhCT) {
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
            worksheet.Cells["D1"].Value = "Ghi chú";
            worksheet.Cells["D2"].Value = "nsGhiChu";
            worksheet.Cells["E1"].Value = "Dự án công trình";
            worksheet.Cells["E2"].Value = "nsDuAnCongTrinh";
            worksheet.Cells["F1"].Value = "Nguồn vốn";
            worksheet.Cells["F2"].Value = "nsNguonVon";
            worksheet.Cells["G1"].Value = "Chương";
            worksheet.Cells["G2"].Value = "nsChuong";
            worksheet.Cells["H1"].Value = "Loại, khoản";
            worksheet.Cells["H2"].Value = "nsLoaiKhoan";
            worksheet.Cells["I1"].Value = "Mục, tiểu mục";
            worksheet.Cells["I2"].Value = "nsMucTieuMuc";
            worksheet.Cells["J1"].Value = "Cấp ngân sách";
            worksheet.Cells["J2"].Value = "nsCapNganSach";
            worksheet.Cells["K1"].Value = "Khối lượng";
            worksheet.Cells["K2"].Value = "nsKhoiLuong";
            worksheet.Cells["L1"].Value = "Đơn giá";
            worksheet.Cells["L2"].Value = "mnDonGia";
            worksheet.Cells["M1"].Value = "Tính chất";
            worksheet.Cells["M2"].Value = "nsTinhChat";
            worksheet.Cells["N1"].Value = "Số tiền";
            worksheet.Cells["N2"].Value = "nsSoTien";
            worksheet.Cells["O1"].Value = "Diễn giải";
            worksheet.Cells["O2"].Value = "nsDienGiai";
            worksheet.Range["A1:O2"].Font.Bold = true;
            CellRange range = worksheet["A1:O2000"];
            worksheet.AutoFilter.Apply(range);
            worksheet.AutoOutline();
            worksheet.Range["A1:O2"].AutoFitColumns();
            //worksheet.Columns.AutoFit(1, 200);
            //worksheet.Rows.Group(2, 10, true);
            //worksheet.Rows.Group(1, 35, false);
            worksheet.Cells["E1"].ColumnWidth = 700;
            worksheet.Cells["F1"].ColumnWidth = 700;

        }
        private void FillDataCellsValues(Worksheet worksheet, List<Excel_GiaiNganVonDauTuDTO> listDatas) {
            int rowIndex = 2;
            foreach (var data in listDatas) {
                if (data.ListDataDetail != null) {
                    // var loaiDuToan = ItemDuToan.GetItems().Where(x => x.Id == data.DuToan.ConvertToNullableInt()).Select(x => x.Name).FirstOrDefault() ?? string.Empty;
                    foreach (var item in data.ListDataDetail) {
                        var thuQuaKhoBac = item.DuocChonThuQuaKhoBac.ConvertToBool();
                        var thuThoiGianChinhLy = item.DuocChonThuThoiGianChinhLy.ConvertToBool();
                        worksheet.Cells[rowIndex, 0].Value = data.NienDo.SafeToString();
                        worksheet.Cells[rowIndex, 1].Value = data.SoChungTu.SafeToString();
                        worksheet.Cells[rowIndex, 2].Value = data.NgayChungTu.ConvertToNullableDateTimeDMY();
                        worksheet.Cells[rowIndex, 3].Value = data.GhiChu.SafeToString();
                        worksheet.Cells[rowIndex, 4].Value = item.IdDuAnCongTrinh.SafeToString();
                        worksheet.Cells[rowIndex, 5].Value = item.IdNguonVon.SafeToString();
                        worksheet.Cells[rowIndex, 6].Value = item.IdChuong.SafeToString();
                        worksheet.Cells[rowIndex, 7].Value = item.IdLoaiKhoan.SafeToString();
                        worksheet.Cells[rowIndex, 8].Value = item.IdMucTieuMuc.SafeToString();
                        worksheet.Cells[rowIndex, 9].Value = item.IdCapNganSach.SafeToString();
                        worksheet.Cells[rowIndex, 10].Value = item.KhoiLuong.ConvertToFloat();
                        worksheet.Cells[rowIndex, 11].Value = item.DonGia.ConvertToNullableDecimal();
                        worksheet.Cells[rowIndex, 12].Value = thuQuaKhoBac && thuThoiGianChinhLy ? tinhChat3 : !thuQuaKhoBac && !thuThoiGianChinhLy ? tinhChat1
                                                : thuQuaKhoBac && !thuThoiGianChinhLy ? tinhChat4 : !thuQuaKhoBac && thuThoiGianChinhLy ? tinhChat2 : "Không xác định";
                        worksheet.Cells[rowIndex, 13].Value = item.SoTien.ConvertToNullableDecimal();
                        worksheet.Cells[rowIndex, 14].Value = item.DienGiai.SafeToString();
                        rowIndex++;
                    }
                }
            }
        }
        public Workbook ExportDataExcel(List<Excel_GiaiNganVonDauTuDTO> listData) {
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets[0];
            workbook.Worksheets.ActiveWorksheet = worksheet;
            CreateHeaderExcel(worksheet);
            FillDataCellsValues(worksheet, listData);
            return workbook;
        }
        private async Task<IEnumerable<Excel_GiaiNganVonDauTuDTO>> ConvertExcelToDTO(Guid idDonVi, Worksheet worksheet) {
            Dictionary<string, Excel_GiaiNganVonDauTuDTO> uniqueRows = new Dictionary<string, Excel_GiaiNganVonDauTuDTO>();

            for (int rowIndex = 2; rowIndex <= worksheet.Rows.LastUsedIndex; rowIndex++) {
                string key = $"{worksheet.Cells[rowIndex, 0].Value.SafeToString()}-{worksheet.Cells[rowIndex, 1].Value.SafeToString()}-{worksheet.Cells[rowIndex, 2].Value.ConvertToNullableDateTimeDMY()}";
                if (!uniqueRows.ContainsKey(key)) {
                    Excel_GiaiNganVonDauTuDTO parent = await ConvertRowToDTO(worksheet, rowIndex, idDonVi);
                    uniqueRows.Add(key, parent);
                    number++;
                }
                Excel_GiaiNganVonDauTuChiTietDTO child = await ConvertRowToDTODetail(worksheet, rowIndex, uniqueRows[key].Oid);
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
            var res = await client.ApiV1NghiepvuExcelQtquanlycdtGiainganvondautuImportdataexcelAsync(lstObj);
            return res.Result;
            //}
            //else return false;
        }
        public async Task<Excel_GiaiNganVonDauTuDTO> ConvertRowToDTO(Worksheet worksheet, int rowIndex, Guid idDonVi) {
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
            Excel_GiaiNganVonDauTuDTO data = new Excel_GiaiNganVonDauTuDTO() {
                Oid = Guid.NewGuid(),
                IdDonViSuDungChuongTrinh = idDonVi,
                NienDo = "Niên độ" + $"{number}",
                //DuToan = ItemDuToan.GetItems().FirstOrDefault(x => x.Name.Trim().Equals(worksheet.Cells[rowIndex, columnIndex1].Value.SafeToString().Trim(), StringComparison.CurrentCultureIgnoreCase))?.Id,
                SoChungTu = worksheet.Cells[rowIndex, columnIndex0].Value.SafeToString(),
                NgayChungTu = DateTime.Parse(worksheet.Cells[rowIndex, columnIndex1].Value.ToString()),
                // IdDonViThucHien = lstPhongBan.Select(x => x.Oid).First(),
                // QuyetDinhSo = "Quyết định số" + $"{number}",
                //GhiChu = .Value.SafeToString(),
                ListDataDetail = new List<Excel_GiaiNganVonDauTuChiTietDTO>(),
            };
            return data;
        }
        public async Task<Excel_GiaiNganVonDauTuChiTietDTO> ConvertRowToDTODetail(Worksheet worksheet, int rowIndex, Guid idCha) {
            var lstDuAnCongTrinh = (await iBusObjDuAnDauTuDoXaQuanLy.GetListItem(true, null)).LstObjData;
            var lstCapNS = (await iBusObjCapNS.GetListItem(true, null)).LstObjData;
            var lstNguonVon = (await iBusObjNguonVon.GetListItem(true, null)).LstObjData;
            var lstLoaiKhoan = (await iBusObjLoaiKhoan.GetListItem(true, null)).LstObjData;
            var lstChuong = (await iBusObjChuong.GetListItem(true, null)).LstObjData;
            var lstMucTieuMuc = (await iBusObjMucTieuMuc.GetListItem(true, null)).LstObjData;
            var lstNoiDungChiDauTu = (await iBusObjNoiDungChiDauTu.GetListItem(true, null)).LstObjData;


            int columnIndex4 = GetColumnIndexByName(worksheet, "nsDuAnCongTrinh");
            int columnIndex5 = GetColumnIndexByName(worksheet, "nsNguonVon");
            int columnIndex6 = GetColumnIndexByName(worksheet, "nsChuong");
            int columnIndex7 = GetColumnIndexByName(worksheet, "nsLoaiKhoan");
            int columnIndex8 = GetColumnIndexByName(worksheet, "nsMucTieuMuc");
            int columnIndex9 = GetColumnIndexByName(worksheet, "nsCapNganSach");
            int columnIndex10 = GetColumnIndexByName(worksheet, "nsKhoiLuong");
            int columnIndex11 = GetColumnIndexByName(worksheet, "mnDonGia");
            int columnIndex12 = GetColumnIndexByName(worksheet, "nsTinhChat");
            int columnIndex13 = GetColumnIndexByName(worksheet, "mnSoTien");
            int columnIndex14 = GetColumnIndexByName(worksheet, "nsDienGiai");

            var maDuAnCongTrinh = worksheet.Cells[rowIndex, columnIndex4].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
            var maNguonVon = worksheet.Cells[rowIndex, columnIndex5].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
            var maChuong = worksheet.Cells[rowIndex, columnIndex6].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
            var maLoaiKhoan = worksheet.Cells[rowIndex, columnIndex7].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
            var maMucTieuMuc = worksheet.Cells[rowIndex, columnIndex8].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
            var maCapNS = worksheet.Cells[rowIndex, columnIndex9].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();

            Excel_GiaiNganVonDauTuChiTietDTO data = new Excel_GiaiNganVonDauTuChiTietDTO() {
                Oid = Guid.NewGuid(),
                IdGiaiNganVonDauTu = idCha,
                IdDuAnCongTrinh = lstDuAnCongTrinh.FirstOrDefault(x => x.MaSo.Equals(maDuAnCongTrinh?.Trim()))?.Oid,
                IdCapNganSach = lstCapNS.FirstOrDefault(x => x.MaSo.Equals(maCapNS?.Trim()))?.Oid,
                IdNguonVon = lstNguonVon.FirstOrDefault(x => x.MaSo.Equals(maNguonVon?.Trim()))?.Oid,
                IdLoaiKhoan = lstLoaiKhoan.FirstOrDefault(x => x.MaSo.Equals(maLoaiKhoan?.Trim()))?.Oid,
                IdChuong = lstChuong.FirstOrDefault(x => x.MaSo.Equals(maChuong?.Trim()))?.Oid,
                IdMucTieuMuc = lstMucTieuMuc.FirstOrDefault(x => x.MaSo.Equals(maMucTieuMuc?.Trim()))?.Oid,
                KhoiLuong = worksheet.Cells[rowIndex, columnIndex10].Value.ConvertToNullableFloat(),
                DonGia = worksheet.Cells[rowIndex, columnIndex11].Value.ConvertToNullableDecimal(),
                DuocChonThuQuaKhoBac = worksheet.Cells[rowIndex, columnIndex12].Value.ConvertToBool(),
                DuocChonThuThoiGianChinhLy = worksheet.Cells[rowIndex, columnIndex12].Value.ConvertToBool(),
                SoTien = worksheet.Cells[rowIndex, columnIndex13].Value.ConvertToNullableDecimal(),
                DienGiai = worksheet.Cells[rowIndex, columnIndex14].Value.SafeToString(),
            };
            return data;
        }
        private int GetColumnIndexByName(Worksheet worksheet, string columnName) {
            Cell cell = worksheet.Rows[1].FirstOrDefault(c => c.Value != null && c.Value.ToString() == columnName);
            return cell != null ? cell.ColumnIndex : -1;
        }
    }
}