using app.StdCommon;
using DevExpress.Spreadsheet;
using Microsoft.Extensions.Logging;
using ProjectX.Abstract.Bus;
using ProjectY4c.Client.ServerBusiness.Infrastructure.Contracts;

namespace ProjectY4c.ServerBusiness.Business.ExcelDataExchange.Group_QuyTrinhQuanLyThuNSX {
    public class Excel_ThucHienDuToanChiThuongXuyenBus(IProjectY4cClient client, ILogger logger,
        ISimpleBusinessObject<MLNSNN_ChuongDTO> iBusObjChuong,
        ISimpleBusinessObject<NguonVonDTO> iBusObjNguonVon,
        ISimpleBusinessObject<MLNSNN_MucTieuMucDTO> iBusObjMucTieuMuc,
        ISimpleBusinessObject<MLNSNN_LoaiKhoanDTO> iBusObjLoaiKhoan,
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
            worksheet.Cells["C1"].Value = "Ngày chứng từ";
            worksheet.Cells["D1"].Value = "Ghi chú";
            worksheet.Cells["E1"].Value = "Nguồn vốn";
            worksheet.Cells["F1"].Value = "Chương";
            worksheet.Cells["G1"].Value = "Loại, khoản";
            worksheet.Cells["H1"].Value = "Mục, tiểu mục";
            worksheet.Cells["I1"].Value = "Cấp ngân sách";
            worksheet.Cells["J1"].Value = "Khối lượng";
            worksheet.Cells["K1"].Value = "Đơn giá";
            worksheet.Cells["L1"].Value = "Tính chất";
            worksheet.Cells["M1"].Value = "Phương thức giải ngân";
            worksheet.Cells["N1"].Value = "Diễn giải";
            worksheet.Cells["O1"].Value = "Số tiền giải ngân";
            worksheet.Range["A1:O1"].Font.Bold = true;
            CellRange range = worksheet["A1:O1000"];
            worksheet.AutoFilter.Apply(range);
            worksheet.AutoOutline();
            worksheet.Range["A1:O1"].AutoFitColumns();
            //worksheet.Columns.AutoFit(1, 200);
            //worksheet.Rows.Group(2, 10, true);
            //worksheet.Rows.Group(1, 35, false);
            worksheet.Cells["E1"].ColumnWidth = 700;
            worksheet.Cells["F1"].ColumnWidth = 700;

        }
        private void FillDataCellsValues(Worksheet worksheet, List<Excel_ThucHienDuToanChiThuongXuyenDTO> listDatas) {
            int rowIndex = 1;
            foreach (var data in listDatas) {
                if (data.ListDataDetail != null) {
                    var loaiDuToan = ItemDuToan.GetItems().Where(x => x.Id == data.DuToan.ConvertToNullableInt()).Select(x => x.Name).FirstOrDefault() ?? string.Empty;
                    foreach (var item in data.ListDataDetail) {
                        var thuQuaKhoBac = item.DuocChonThuQuaKhoBac.ConvertToBool();
                        var thuThoiGianChinhLy = item.DuocChonThuThoiGianChinhLy.ConvertToBool();
                        var phuongThucGiaiNgan = ItemPhuongThucGiaiNgan.GetItems().Where(x => x.Id == item.PhuongThucGiaiNgan.ConvertToNullableInt()).Select(x => x.Name).FirstOrDefault() ?? string.Empty;
                        worksheet.Cells[rowIndex, 0].Value = data.NienDo.SafeToString();
                        worksheet.Cells[rowIndex, 1].Value = data.SoChungTu.SafeToString();
                        worksheet.Cells[rowIndex, 2].Value = data.NgayChungTu.ConvertToNullableDateTimeDMY();
                        worksheet.Cells[rowIndex, 3].Value = data.GhiChu.SafeToString();
                        worksheet.Cells[rowIndex, 4].Value = item.IdNguonVon.SafeToString();
                        worksheet.Cells[rowIndex, 5].Value = item.IdChuong.SafeToString();
                        worksheet.Cells[rowIndex, 6].Value = item.IdLoaiKhoan.SafeToString();
                        worksheet.Cells[rowIndex, 7].Value = item.IdMucTieuMuc.SafeToString();
                        worksheet.Cells[rowIndex, 8].Value = item.IdCapNganSach.SafeToString();
                        worksheet.Cells[rowIndex, 9].Value = item.KhoiLuong.SafeToString();
                        worksheet.Cells[rowIndex, 10].Value = item.DonGia.ConvertToNullableDecimal();
                        worksheet.Cells[rowIndex, 11].Value = thuQuaKhoBac && thuThoiGianChinhLy ? tinhChat3 : !thuQuaKhoBac && !thuThoiGianChinhLy ? tinhChat1
                                                : thuQuaKhoBac && !thuThoiGianChinhLy ? tinhChat4 : !thuQuaKhoBac && thuThoiGianChinhLy ? tinhChat2 : "Không xác định";
                        worksheet.Cells[rowIndex, 12].Value = phuongThucGiaiNgan;
                        worksheet.Cells[rowIndex, 13].Value = item.DienGiai.SafeToString();
                        worksheet.Cells[rowIndex, 14].Value = item.SoTien.ConvertToNullableDecimal();
                        rowIndex++;
                    }
                }
            }
        }
        public Workbook ExportDataExcel(List<Excel_ThucHienDuToanChiThuongXuyenDTO> listData) {
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets[0];
            workbook.Worksheets.ActiveWorksheet = worksheet;
            CreateHeaderExcel(worksheet);
            FillDataCellsValues(worksheet, listData);
            return workbook;
        }
        private async Task<IEnumerable<Excel_ThucHienDuToanChiThuongXuyenDTO>> ConvertExcelToDTO(Guid idDonVi, Worksheet worksheet) {
            Dictionary<string, Excel_ThucHienDuToanChiThuongXuyenDTO> uniqueRows = new Dictionary<string, Excel_ThucHienDuToanChiThuongXuyenDTO>();

            for (int rowIndex = 2; rowIndex <= worksheet.Rows.LastUsedIndex; rowIndex++) {
                string key = $"{worksheet.Cells[rowIndex, 0].Value.SafeToString()}-{worksheet.Cells[rowIndex, 1].Value.SafeToString()}-{worksheet.Cells[rowIndex, 2].Value.ConvertToNullableDateTimeDMY()}";
                if (!uniqueRows.ContainsKey(key)) {
                    Excel_ThucHienDuToanChiThuongXuyenDTO parent = await ConvertRowToDTO(worksheet, rowIndex, idDonVi);
                    uniqueRows.Add(key, parent);
                    number++;
                }
                Excel_ThucHienDuToanChiThuongXuyenChiTietDTO child = await ConvertRowToDTODetail(worksheet, rowIndex, uniqueRows[key].Oid);
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
            var res = await client.ApiV1NghiepvuExcelQtquanlyctxThuchiendutoanchithuongxuyenImportdataexcelAsync(lstObj);
            return res.Result;
            //}
            //else return false;
        }
        public async Task<Excel_ThucHienDuToanChiThuongXuyenDTO> ConvertRowToDTO(Worksheet worksheet, int rowIndex, Guid idDonVi) {
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
            Excel_ThucHienDuToanChiThuongXuyenDTO data = new Excel_ThucHienDuToanChiThuongXuyenDTO() {
                Oid = Guid.NewGuid(),
                IdDonViSuDungChuongTrinh = idDonVi,
                NienDo = worksheet.Cells[rowIndex, columnIndex0].Value.SafeToString(),
                DuToan = ItemDuToan.GetItems().FirstOrDefault(x => x.Name.Trim().Equals(worksheet.Cells[rowIndex, columnIndex1].Value.SafeToString().Trim(), StringComparison.CurrentCultureIgnoreCase))?.Id,
                NgayChungTu = DateTime.Parse(worksheet.Cells[rowIndex, columnIndex2].Value.ToString()),
                // IdDonViThucHien = lstPhongBan.Select(x => x.Oid).First(),
                SoChungTu = "Số chứng từ" + $"{number}",
                TongSoTien = worksheet.Cells[rowIndex, columnIndex0].Value.ConvertToDecimal(),
                GhiChu = worksheet.Cells[rowIndex, columnIndex0].Value.SafeToString(),
                ListDataDetail = new List<Excel_ThucHienDuToanChiThuongXuyenChiTietDTO>(),
            };
            return data;
        }
        public async Task<Excel_ThucHienDuToanChiThuongXuyenChiTietDTO> ConvertRowToDTODetail(Worksheet worksheet, int rowIndex, Guid idCha) {
            var lstLoaiKhoan = (await iBusObjLoaiKhoan.GetListItem(true, null)).LstObjData;
            var lstCapNS = (await iBusObjCapNS.GetListItem(true, null)).LstObjData;
            var lstNguonVon = (await iBusObjNguonVon.GetListItem(true, null)).LstObjData;
            var lstChuong = (await iBusObjChuong.GetListItem(true, null)).LstObjData;
            var lstMucTieuMuc = (await iBusObjMucTieuMuc.GetListItem(true, null)).LstObjData;


            int columnIndex4 = GetColumnIndexByName(worksheet, "nsNguonVon");
            int columnIndex5 = GetColumnIndexByName(worksheet, "nsChuong");
            int columnIndex6 = GetColumnIndexByName(worksheet, "nsLoaiKhoan");
            int columnIndex7 = GetColumnIndexByName(worksheet, "nsMucTieuMuc");
            int columnIndex8 = GetColumnIndexByName(worksheet, "nsCapNganSach");
            int columnIndex9 = GetColumnIndexByName(worksheet, "nsKhoiLuong");
            int columnIndex10 = GetColumnIndexByName(worksheet, "mnDonGia");
            int columnIndex11 = GetColumnIndexByName(worksheet, "nsTinhChat");
            int columnIndex12 = GetColumnIndexByName(worksheet, "nsPhuongThucGiaiNgan");
            int columnIndex13 = GetColumnIndexByName(worksheet, "nsDienGiai");
            int columnIndex14 = GetColumnIndexByName(worksheet, "mnSoTien");

            var maNguonVon = worksheet.Cells[rowIndex, columnIndex4].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
            var maChuong = worksheet.Cells[rowIndex, columnIndex5].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
            var maMucTieuMuc = worksheet.Cells[rowIndex, columnIndex6].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
            var maLoaiKhoan = worksheet.Cells[rowIndex, columnIndex7].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();
            var maCapNS = worksheet.Cells[rowIndex, columnIndex8].Value.SafeToString()?.Split('-').FirstOrDefault()?.Trim();


            Excel_ThucHienDuToanChiThuongXuyenChiTietDTO data = new Excel_ThucHienDuToanChiThuongXuyenChiTietDTO() {
                Oid = Guid.NewGuid(),
                IdThucHienDuToanChiThuongXuyen = idCha,
                IdLoaiKhoan = lstLoaiKhoan.FirstOrDefault(x => x.MaSo.Equals(maLoaiKhoan?.Trim()))?.Oid,
                IdCapNganSach = lstCapNS.FirstOrDefault(x => x.MaSo.Equals(maCapNS?.Trim()))?.Oid,
                IdNguonVon = lstNguonVon.FirstOrDefault(x => x.MaSo.Equals(maNguonVon?.Trim()))?.Oid,
                IdChuong = lstChuong.FirstOrDefault(x => x.MaSo.Equals(maChuong?.Trim()))?.Oid,
                IdMucTieuMuc = lstMucTieuMuc.FirstOrDefault(x => x.MaSo.Equals(maMucTieuMuc?.Trim()))?.Oid,
                KhoiLuong = worksheet.Cells[rowIndex, columnIndex9].Value.ConvertToNullableDecimal(),
                DonGia = worksheet.Cells[rowIndex, columnIndex10].Value.ConvertToNullableDecimal(),
                DuocChonThuQuaKhoBac = worksheet.Cells[rowIndex, columnIndex11].Value.ConvertToBool(),
                DuocChonThuThoiGianChinhLy = worksheet.Cells[rowIndex, columnIndex11].Value.ConvertToBool(),
                PhuongThucGiaiNgan = ItemPhuongThucGiaiNgan.GetItems().FirstOrDefault(x => x.Name.Trim().Equals(worksheet.Cells[rowIndex, columnIndex12].Value.SafeToString().Trim(), StringComparison.CurrentCultureIgnoreCase))?.Id,
                DienGiai = worksheet.Cells[rowIndex, columnIndex13].Value.SafeToString(),
                SoTien = worksheet.Cells[rowIndex, columnIndex14].Value.ConvertToNullableDecimal(),
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

        private class ItemPhuongThucGiaiNgan {
            public int Id { get; set; }
            public string Name { get; set; }
            public ItemPhuongThucGiaiNgan(int id, string name) {
                Id = id;
                Name = name;
            }
            public static List<ItemPhuongThucGiaiNgan> GetItems() => new List<ItemPhuongThucGiaiNgan> {
                new ItemPhuongThucGiaiNgan(1, "Rút dự toán"),
                new ItemPhuongThucGiaiNgan(2, "Lệnh chi tiền"),
            };
        }
    }
}