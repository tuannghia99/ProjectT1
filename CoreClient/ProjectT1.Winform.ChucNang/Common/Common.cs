using app.Common;
using app.StdCommon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace ProjectT1.Winform {
    public static class Common {
        public static bool g_ShowExceptionError = true;
        public static string g_MsCodeDiaBan = string.Empty;
        //public static int CurrentYear;
        public class TrangThaiDuLieu(int id, string trangthai) {
            public int Id { get; set; } = id;
            public string TrangThai { get; set; } = trangthai;

            public static List<TrangThaiDuLieu> GetItems() => new List<TrangThaiDuLieu> {
                new TrangThaiDuLieu(1, "Chưa gửi"),
                new TrangThaiDuLieu(2, "Đã gửi"),
                new TrangThaiDuLieu(3, "Đã tiếp nhận"),
                new TrangThaiDuLieu(4, "Trả lại"),
                new TrangThaiDuLieu(5, "Được giao"),
            };
        }
        public class ItemLoaiSoLieu(int id, string name) {
            public int Id { get; set; } = id;
            public string Name { get; set; } = name;

            public static List<ItemLoaiSoLieu> GetItems() => new List<ItemLoaiSoLieu> {
                new ItemLoaiSoLieu(1, "Nhập chứng từ"),
                new ItemLoaiSoLieu(2, "Nhập theo báo cáo"),
            };
        }
        public class ItemLoaiDuToan(int id, string name) {
            public int Id { get; set; } = id;
            public string Name { get; set; } = name;

            public static List<ItemLoaiDuToan> GetItems() => new List<ItemLoaiDuToan> {
                new ItemLoaiDuToan(1, "Hằng năm"),
                new ItemLoaiDuToan(3, "03 Năm"),
                new ItemLoaiDuToan(5, "05 Năm"),
            };
        }

        public class ItemLoaiDieuChinh(int id, string name) {
            public int Id { get; set; } = id;
            public string Name { get; set; } = name;

            public static List<ItemLoaiDieuChinh> GetItems() => new List<ItemLoaiDieuChinh> {
                new ItemLoaiDieuChinh(1, "Điều chỉnh chuyển"),
                new ItemLoaiDieuChinh(2, "Điều chỉnh tăng"),
                new ItemLoaiDieuChinh(3, "Điều chỉnh giảm"),
            };
        }
        public class ItemLoaiChiTieuDuToan(int id, string name) {
            public int Id { get; set; } = id;
            public string Name { get; set; } = name;

            public static List<ItemLoaiChiTieuDuToan> GetItems() => new List<ItemLoaiChiTieuDuToan> {
                new ItemLoaiChiTieuDuToan(1, "Chi tiêu thu"),
                new ItemLoaiChiTieuDuToan(2, "Vay nợ"),
            };
        }
        public class ItemThucHienKeHoach(int id, string name) {
            public int Id { get; set; } = id;
            public string Name { get; set; } = name;

            public static List<ItemThucHienKeHoach> GetItems() => new List<ItemThucHienKeHoach> {
                new ItemThucHienKeHoach(1, "Thu khác"),
                new ItemThucHienKeHoach(2, "Chi khác"),
            };
        }
        public class ItemDuToan(int id, string name) {
            public int Id { get; set; } = id;
            public string Name { get; set; } = name;

            public static List<ItemDuToan> GetItems() => new List<ItemDuToan> {
                new ItemDuToan(1, "Dự toán giao đầu năm"),
                new ItemDuToan(2, "Dự toán bổ sung trong năm"),
            };
        }
        public class ItemLoaiDuToanDieuChinh(int id, string name) {
            public int Id { get; set; } = id;
            public string Name { get; set; } = name;

            public static List<ItemLoaiDuToanDieuChinh> GetItems() => new List<ItemLoaiDuToanDieuChinh> {
                new ItemLoaiDuToanDieuChinh(1, "Dự toán bổ sung"),
                new ItemLoaiDuToanDieuChinh(2, "Dự toán điều chỉnh"),
            };
        }
        public class ItemDuToanEBG(int id, string name) {
            public int Id { get; set; } = id;
            public string Name { get; set; } = name;

            public static List<ItemDuToanEBG> GetItems() => new List<ItemDuToanEBG> {
                new ItemDuToanEBG(1, "Dự toán giao đầu năm"),
                new ItemDuToanEBG(2, "Dự toán bổ sung trong năm"),
            };
        }
        public class ItemDuToanChi(int id, string name) {
            public int Id { get; set; } = id;
            public string Name { get; set; } = name;

            public static List<ItemDuToanChi> GetItems() => new List<ItemDuToanChi> {
                new ItemDuToanChi(1, "Đầu tư"),
                new ItemDuToanChi(2, "Thường xuyên"),
            };
        }
        public class ItemLoaiHoatDong(int id, string name) {
            public int Id { get; set; } = id;
            public string Name { get; set; } = name;

            public static List<ItemLoaiHoatDong> GetItems() => new List<ItemLoaiHoatDong> {
                new ItemLoaiHoatDong(1, "Các quỹ tài chính ngoài ngân sách"),
                new ItemLoaiHoatDong(2, "Hoạt động sự nghiệp có thu"),
                new ItemLoaiHoatDong(3, "Hoạt động khác"),
            };
        }

        public class ItemHinhThuc(int id, string name) {
            public int Id { get; set; } = id;
            public string Name { get; set; } = name;

            public static List<ItemHinhThuc> GetItems() => new List<ItemHinhThuc> {
                new ItemHinhThuc(1, "Tạm ứng"),
                new ItemHinhThuc(2, "Thực chi"),
                new ItemHinhThuc(3, "Thanh toán tạm ứng"),
            };
        }
        public class ItemPhuongThucGiaiNgan(int id, string name) {
            public int Id { get; set; } = id;
            public string Name { get; set; } = name;

            public static List<ItemPhuongThucGiaiNgan> GetItems() => new List<ItemPhuongThucGiaiNgan> {
                new ItemPhuongThucGiaiNgan(1, "Rút dự toán"),
                new ItemPhuongThucGiaiNgan(2, "Lệnh chi tiền"),
            };
        }
        public enum TrangThaiChuyenDoiDuLieu {
            ChuaGui = 1,
            DaGui = 2,
            DaTiepNhan = 3,
            TraLai = 4
        }

        /// <summary>
        /// Viết lại cấu trúc cây cha - con cho dataSource
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataSource"></param>
        public static List<T>? ConfigureParentChildTreePrim<T>(this List<T>? dataSource, string displayMember = "Ten") where T : class {
            if (dataSource?.Count > 1) {
                var level = 0;
                var multi = 2;
                var descCount = 999;
                for (var index = 1; index < dataSource.Count; ++index) {
                    var currentValue = dataSource[index].GetType().GetProperty("MaSo")?.GetValue(dataSource[index]).SafeToString() ?? string.Empty;
                    var previousValue = dataSource[index - 1].GetType().GetProperty("MaSo")?.GetValue(dataSource[index - 1]).SafeToString() ?? string.Empty;
                    if (currentValue.Length != previousValue.Length) {
                        descCount = descCount <= Math.Abs(currentValue.Length - previousValue.Length) ? descCount : Math.Abs(currentValue.Length - previousValue.Length);
                    }
                }
                for (var index = 1; index < dataSource.Count; ++index) {
                    var currentValue = dataSource[index].GetType().GetProperty("MaSo")?.GetValue(dataSource[index]).SafeToString() ?? string.Empty;
                    var previousValue = dataSource[index - 1].GetType().GetProperty("MaSo")?.GetValue(dataSource[index - 1]).SafeToString() ?? string.Empty;
                    if (currentValue.Length > previousValue.Length) {
                        level += multi * (int)Math.Ceiling((decimal)((currentValue.Length - previousValue.Length) / descCount));
                    }
                    else if (currentValue.Length < previousValue.Length) {
                        level -= multi * (int)Math.Ceiling((decimal)((previousValue.Length - currentValue.Length) / descCount));
                        level = level < 0 ? 0 : level;
                    }
                    var nameProp = dataSource[index].GetType().GetProperty(displayMember);
                    if (nameProp != null) {
                        var name = nameProp.GetValue(dataSource[index]).SafeToString();
                        nameProp.SetValue(dataSource[index], name.PadLeft(level + name.Length));
                    }
                }
            }
            return dataSource;
        }
        public static void customDisplayText(object sender, CustomDisplayTextEventArgs e) {
            e.DisplayText = e.DisplayText.SafeToString().Trim();
        }
        /// <summary>
        /// Event Handler for Validating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void CheckTheMostDetail(object? sender, System.ComponentModel.CancelEventArgs e) {
            if (sender != null) {
                if (sender is LookUpEditBase lookUp) {
                    CheckTheMostDetail(lookUp);
                }
            }
        }
        /// <summary>
        /// Kiểm tra chi tiết nhất cho các lookup editor, đối với chọn nhiều bắt buộc phải có thuộc tính Data và CheckBox
        /// </summary>
        /// <param name="lookups">Các lookup editor cần kiểm tra</param>
        /// <returns></returns>
        public static bool CheckTheMostDetail(params LookUpEditBase[] lookups) {
            var noError = true;
            foreach (var lookup in lookups) {
                var multi = false;
                if (lookup is SearchLookUpEdit se) {
                    multi = se.Properties.View.IsMultiSelect;
                }
                var dataSource = (lookup.Properties.DataSource as IEnumerable<object>)?.Cast<object>().ToList();
                var vals = new List<Guid>();
                if (!multi) {
                    vals.Add(lookup.EditValue.ConvertToGuid());
                }
                else {
                    vals.AddRange(lookup.EditValue.SafeToString().Split(",").Select(s => s.Trim().ConvertToGuid()).ToList());
                }
                var errorText = string.Empty;
                foreach (var val in vals) {
                    if (val != Guid.Empty && dataSource?.Count > 1) {
                        var hasData = false;
                        var hasCheckBox = false;
                        foreach (var prop in dataSource[0].GetType().GetProperties().ToList()) {
                            if (prop.Name.StartsWith("Data")) {
                                hasData = true;
                            }
                            if (prop.Name.StartsWith("CheckBox")) {
                                hasCheckBox = true;
                            }
                        }
                        List<object>? data = dataSource;
                        if (hasData && hasCheckBox) {
                            data = dataSource.Select(s => s.GetType().GetProperty("Data")?.GetValue(s) ?? new object()).ToList();
                        }
                        var ms = data.Where(s => s.GetType().GetProperty("Oid")?.GetValue(s).ConvertToGuid() == val).FirstOrDefault();
                        if (ms != null) {
                            var maSo = ms.GetType().GetProperty("MaSo")?.GetValue(ms).SafeToString() ?? string.Empty;
                            if (!maSo.IsNullOrEmpty()) {
                                var listSubMaSo = data.Where(s => (s.GetType().GetProperty("MaSo")?.GetValue(s).SafeToString() ?? string.Empty).StartsWith(maSo) && (s.GetType().GetProperty("MaSo")?.GetValue(s).SafeToString() ?? string.Empty).Length > maSo.Length).ToList();
                                if (listSubMaSo.Count > 0) {
                                    errorText = "Yêu cầu chọn thông tin có mã số chi tiết nhất";
                                    noError = false;
                                }
                            }
                        }
                    }
                }
                lookup.ErrorText = errorText;
            }
            return noError;
        }
    }
}
