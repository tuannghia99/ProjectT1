using app.Common;
using app.StdCommon;
using app.StdCommon.Serialization;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Mvvm.Native;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraVerticalGrid;
using Newtonsoft.Json.Linq;
using ProjectT1.Winform;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Reflection;

namespace ProjectT1.Client.Winform {
    public class clsCommonY4c {
        public enum MainCaseForm_KPSN_DADT {
            KinhPhiSuNghiep = 1,
            DuAnDauTu = 2
        }
        public enum MainCaseForm_GD_N {
            GiaiDoan = 1,
            Nam = 2
        }
        public enum CaseConvertData {
            GetOrRestore = 1,
            SendOrRecall = 2
        }
        public enum CaseConvertDataSubmit {
            Get = 1,
            Restore = 2,
            Send = 3,
            Recall = 4
        }
        public enum StatusChuyenDoiDuLieu {
            ChuaGui = 1,
            DaGui = 2,
            DaTiepNhan = 3,
            TraLai = 4
        }
        public enum MainStatusForm {
            WAIT = 0,
            VIEW = 1,
            CREATE = 2,
            EDIT = 3,
            //COPY = 4,
            //LOCK = 5
        }
        public class ReportLink {
            public int Id { get; set; }
            public string Name { get; set; }

            public ReportLink(int id, string name) {
                Id = id;
                Name = name;
            }
        }

        public partial class CommonHandler {
            public static void ChangeBandCaption(BandedGridView gridView, int year, params string[] bandNames) {
                if (gridView == null || bandNames == null || bandNames.Length == 0)
                    return;

                foreach (var bandName in bandNames) {
                    var band = FindBandByName(gridView.Bands, bandName);
                    if (band != null) {
                        UpdateBandCaptionRecursive(band, year);
                    }
                }
            }

            private static GridBand FindBandByName(GridBandCollection bands, string bandName) {
                foreach (GridBand band in bands) {
                    if (band.Name == bandName) {
                        return band;
                    }
                    var foundBand = FindBandByName(band.Children, bandName);
                    if (foundBand != null) {
                        return foundBand;
                    }
                }
                return null;
            }

            private static void UpdateBandCaptionRecursive(GridBand band, int year) {
                if (band.Tag != null) {
                    var tag = band.Tag.SafeToString().JsonDeserialize<Dictionary<string, string>>();
                    if (tag.ContainsKey("CaptionFormat")) {
                        var captionFormat = tag["CaptionFormat"];
                        band.Caption = captionFormat.Replace(@"{year}", year.ToString())
                                                    .Replace(@"{year-1}", (year - 1).ToString())
                                                    .Replace(@"{year-2}", (year - 2).ToString())
                                                    .Replace(@"{year+1}", (year + 1).ToString())
                                                    .Replace(@"{year+2}", (year + 2).ToString())
                                                    .Replace(@"{year+3}", (year + 3).ToString())
                                                    .Replace(@"{year+4}", (year + 4).ToString());
                    }
                }
                foreach (GridBand childBand in band.Children) {
                    UpdateBandCaptionRecursive(childBand, year);
                }
            }


            public static void ConfigBarButtonFormat(BarItem btnCreate = null, BarItem btnEdit = null, BarItem btnDelete = null, BarItem btnSubmit = null, BarItem btnCancel = null, BarItem btnRefresh = null, BarItem btnClose = null, BarItem btnSearch = null, BarItem btnPrint = null, BarItem btnGetOrRestoreData = null, BarItem btnSendOrRecallData = null, BarItem btnUpdateDataReport = null, BarItem btnApprove = null, BarItem btnKeThua = null, BarItem btnYear = null) {
                if (btnCreate != null) {
                    btnCreate.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
                    btnCreate.ImageOptions.Image = (Bitmap)(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.add_16x16));
                    btnCreate.ItemShortcut = new BarShortcut((Keys.Control | Keys.N));
                    btnCreate.Hint = "Ctrl + N";
                    btnCreate.Caption = "Thêm";
                }
                if (btnEdit != null) {
                    btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
                    btnEdit.ImageOptions.Image = (Bitmap)(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.edit_16x16));
                    btnEdit.ItemShortcut = new BarShortcut((Keys.Control | Keys.E));
                    btnEdit.Hint = "Ctrl + E";
                    btnEdit.Caption = "Sửa";
                }
                if (btnDelete != null) {
                    btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
                    btnDelete.ImageOptions.Image = (Bitmap)(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.remove_16x16));
                    btnDelete.ItemShortcut = new BarShortcut((Keys.Control | Keys.Delete));
                    btnDelete.Hint = "Ctrl + Delete";
                    btnDelete.Caption = "Xoá";
                }
                if (btnSubmit != null) {
                    btnSubmit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
                    btnSubmit.ImageOptions.Image = (Bitmap)(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.apply_16x16));
                    btnSubmit.ItemShortcut = new BarShortcut((Keys.Control | Keys.S));
                    btnSubmit.Hint = "Ctrl + S";
                    btnSubmit.Caption = "Ghi";
                }
                if (btnCancel != null) {
                    btnCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
                    btnCancel.ImageOptions.Image = (Bitmap)(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.cancel_16x16));
                    btnCancel.ItemShortcut = new BarShortcut((Keys.Control | Keys.Z));
                    btnCancel.Hint = "Ctrl + Z";
                    btnCancel.Caption = "Bỏ qua";
                }
                if (btnRefresh != null) {
                    btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
                    btnRefresh.ImageOptions.Image = (Bitmap)(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.refresh_16x16));
                    btnRefresh.ItemShortcut = new BarShortcut((Keys.Control | Keys.F5));
                    btnRefresh.Hint = "Ctrl + F5";
                    btnRefresh.Caption = "Làm mới";
                }
                if (btnClose != null) {
                    btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
                    btnClose.ImageOptions.Image = (Bitmap)(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.close_16x16));
                    btnClose.ItemShortcut = new BarShortcut((Keys.Control | Keys.Q));
                    btnClose.Hint = "Ctrl + Q";
                    btnClose.Caption = "Đóng";
                }
                if (btnSearch != null) {
                    btnSearch.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
                    btnSearch.ImageOptions.Image = (Bitmap)(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.find_16x16));
                    btnSearch.ItemShortcut = new BarShortcut((Keys.Control | Keys.Shift | Keys.F));
                    btnSearch.Hint = "Ctrl + Shift + F";
                    btnSearch.Caption = "Tìm kiếm";
                }
                if (btnPrint != null) {
                    btnPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
                    btnPrint.ImageOptions.Image = (Bitmap)(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.print_16x16));
                    btnPrint.ItemShortcut = new BarShortcut((Keys.Control | Keys.P));
                    btnPrint.Hint = "Ctrl + P";
                    btnPrint.Caption = "In báo cáo";
                    btnPrint.Visibility = BarItemVisibility.Never;
                }
                if (btnGetOrRestoreData != null) {
                    btnGetOrRestoreData.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
                    btnGetOrRestoreData.ImageOptions.Image = (Bitmap)(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.Article_16x16));
                    btnGetOrRestoreData.ItemShortcut = new BarShortcut((Keys.Control | Keys.Shift | Keys.F1));
                    btnGetOrRestoreData.Hint = "Ctrl + Shift + F1";
                    btnGetOrRestoreData.Caption = "Cập nhật/Hoàn trả dữ liệu";
                }
                if (btnSendOrRecallData != null) {
                    btnSendOrRecallData.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
                    btnSendOrRecallData.ImageOptions.Image = (Bitmap)(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.SortGroupHeader_16x16));
                    btnSendOrRecallData.ItemShortcut = new BarShortcut((Keys.Control | Keys.Shift | Keys.F2));
                    btnSendOrRecallData.Hint = "Ctrl + Shift + F2";
                    btnSendOrRecallData.Caption = "Gửi/Thu hồi dữ liệu";
                }
                if (btnUpdateDataReport != null) {
                    btnUpdateDataReport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
                    btnUpdateDataReport.ImageOptions.Image = (Bitmap)(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.EditDataSource_16x16));
                    btnUpdateDataReport.Caption = "Cập nhật dữ liệu báo cáo";
                }
                if (btnApprove != null) {
                    btnApprove.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
                    btnApprove.ImageOptions.Image = (Bitmap)(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.Task_16x16));
                    btnApprove.Caption = "Phê duyệt";
                }
                if (btnKeThua != null) {
                    btnKeThua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
                    btnKeThua.ImageOptions.Image = (Bitmap)(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.CopyModelDifferences_16x16));
                    btnKeThua.Caption = "Kế thừa";
                }
            }
            public static void ConfigBarButtonEnable(bool isEnable, params BarButtonItem[] btns) {
                foreach (var btn in btns) {
                    btn.Enabled = isEnable;
                }
            }
            public static void ConfigBarSubItemEnable(bool isEnable, params BarSubItem[] subItems) {
                foreach (var item in subItems) {
                    item.Enabled = isEnable;
                }
            }
            //public static void ConfigForGridViewHeader(XtraForm? thisForm, LayoutControlGroup? layoutControlGroupMainData, params GridView[] grids) {
            //    if (thisForm != null) {
            //        thisForm.Size = new Size(1400, 800);
            //        thisForm.StartPosition = FormStartPosition.CenterScreen;
            //        //thisForm.WindowState = FormWindowState.Maximized;
            //    }

            //    if (layoutControlGroupMainData != null) {
            //        layoutControlGroupMainData.Width = 300;
            //    }

            //    foreach (var grid in grids) {
            //        if (grid is BandedGridView bandedGrid) {
            //            foreach (var band in bandedGrid.Bands.ToList()) {
            //                band.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //                band.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            //                band.AppearanceHeader.BackColor = Color.White;
            //            }
            //        }
            //        else if (grid is GridView) {
            //            foreach (var band in grid.Columns.ToList()) {
            //                band.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //                band.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            //                band.AppearanceHeader.BackColor = Color.White;
            //            }
            //        }
            //    }
            //}
            public static void ConfigForGridViewHeader(XtraForm? thisForm, LayoutControlGroup? layoutControlGroupMainData, params GridView[] grids) {
                if (thisForm != null) {
                    thisForm.Size = new Size(1400, 800);
                    thisForm.StartPosition = FormStartPosition.CenterScreen;
                    //thisForm.WindowState = FormWindowState.Maximized;
                }
                if (layoutControlGroupMainData != null) {
                    layoutControlGroupMainData.Width = 300;
                }

                foreach (var grid in grids) {
                    if (grid is BandedGridView bandedGrid) {
                        void ApplyAppearanceToBands(GridBand band) {
                            band.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                            band.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                            band.AppearanceHeader.BackColor = Color.White;
                            foreach (var childBand in band.Children) {
                                ApplyAppearanceToBands((GridBand)childBand);
                            }
                        }
                        foreach (var band in bandedGrid.Bands.ToList()) {
                            ApplyAppearanceToBands(band);
                        }
                    }
                    else if (grid is GridView) {
                        foreach (var column in grid.Columns.ToList()) {
                            column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                            column.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                            column.AppearanceHeader.BackColor = Color.White;
                        }
                    }
                }
            }

            public static void ConfigForGridViewHeader(XtraForm? thisForm, LayoutControlGroup? layoutControlGroupMainData, LayoutControlItem? layoutControlItemNotification, params GridView[] grids) {
                if (thisForm != null) {
                    thisForm.Size = new Size(1400, 800);
                    thisForm.StartPosition = FormStartPosition.CenterScreen;
                    //thisForm.WindowState = FormWindowState.Maximized;
                }

                if (layoutControlGroupMainData != null) {
                    layoutControlGroupMainData.Width = 300;
                }

                if (layoutControlItemNotification != null) {
                    layoutControlItemNotification.Height = 300;
                }

                foreach (var grid in grids) {
                    if (grid is BandedGridView bandedGrid) {
                        foreach (var band in bandedGrid.Bands.ToList()) {
                            band.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                            band.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                            band.AppearanceHeader.BackColor = Color.White;
                        }
                    }
                    else if (grid is GridView) {
                        foreach (var band in grid.Columns.ToList()) {
                            band.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                            band.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                            band.AppearanceHeader.BackColor = Color.White;
                        }
                    }
                }
            }
            public static void ConfigMemoEditNotification(MemoEdit memoEditNotification) {
                memoEditNotification.ReadOnly = true;
                memoEditNotification.Properties.Appearance.BackColor = Color.White;
            }
            public static void MemberwiseClone<T>(T objSource, ref T? objDest, IList<string> lstInclude = null, IList<string> lstExclude = null) where T : new() {
                try {
                    var props = typeof(T).GetProperties().Select(x => x.Name);

                    if (lstInclude != null) {
                        props = props.Where(x => lstInclude.Contains(x));
                    }
                    if (lstExclude != null) {
                        var include = props.Where(x => !lstExclude.Contains(x));
                        props = props.Where(x => include.Contains(x));
                    }

                    foreach (var item in props) {
                        var propInfo = objSource.GetType().GetProperty(item);
                        var value = objSource.GetType().GetProperty(item).GetValue(objSource, null);
                        propInfo.SetValue(objDest, value, null);
                    }
                }
                catch (Exception ex) {
                    throw new ApplicationException(ex.Message);
                }
            }
            public static void ShowNotificationForm(string content) {
                var timer = new System.Windows.Forms.Timer();
                var formThongBao = new NotificationForm(content);
                formThongBao.Show();
            }
            public static void ShowNotificationForm_CustomMessage_Successfully(string message) => ShowNotificationForm(message);
            public static void ShowNotificationForm_CreatedSuccessfully() => ShowNotificationForm("Thêm mới thành công");
            public static void ShowNotificationForm_UpdatedSuccessfully() => ShowNotificationForm("Cập nhật thành công");
            public static void ShowNotificationForm_DeletedSuccessfully() => ShowNotificationForm("Xoá thành công");
            public static void ShowNotificationForm_ApprovedSuccessfully() => ShowNotificationForm("Phê duyệt dữ liệu thành công");
            public static void ShowNotificationForm_InheritedSuccessfully() => ShowNotificationForm("Kế thừa dữ liệu thành công");
            public static DialogResult ShowXtraMessageBox_NeedToSelectRecord() => MessageBox.Show("Cần chọn bản ghi dữ liệu trước khi thực hiện thao tác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            public static DialogResult ShowXtraMessageBox_NoDataDelete() => MessageBox.Show("Không có dữ liệu để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            public static DialogResult ShowXtraMessageBox_ConvertDataSuccess() => MessageBox.Show("Chuyển đổi dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            public static DialogResult ShowXtraMessageBox_ConvertDataFail() => MessageBox.Show("Chuyển đổi dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            public static DialogResult ShowXtraMessageBox_CannotDeleteMainRecord_BecauseOfDetailData() => MessageBox.Show("Không thể xoá bản ghi đang chọn do tồn tại dữ liệu chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            public static DialogResult ShowXtraMessageBox_SubmitToDelete() => MessageBox.Show("Chắc chắn xoá dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            public static DialogResult ShowXtraMessageBox_SubmitToDeleteAll() => MessageBox.Show("Chắc chắn xoá tất cả dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            public static DialogResult ShowXtraMessageBox_SubmitToUpdate() => MessageBox.Show("Mã số vừa sửa đã phát sinh dữ liệu trong cơ sở dữ liệu, có thể làm thay đổi bản chất của dữ liệu liên quan.\nChắc chắn sửa dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            public static DialogResult ShowXtraMessageBox_SubmitToConvertData() => MessageBox.Show("Chắc chắn chuyển đổi dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            public static DialogResult ShowXtraMessageBox_PleaseConfigMsCodeDiaBan() => MessageBox.Show("Chưa chọn dữ liệu địa bàn trong form Admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            public static void SetGroupingGridView(GridView view, string groupColFieldName) {
                view.Columns[groupColFieldName].Group();
                GridGroupSummaryItem item = new GridGroupSummaryItem();
                item.FieldName = groupColFieldName;
                item.SummaryType = DevExpress.Data.SummaryItemType.Count;
                view.GroupSummary.Add(item);
                view.CustomDrawGroupRow += (s, e) => {
                    var info = e.Info as DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo;
                    info.GroupText = info.GroupText.Replace("Count=", string.Empty);
                };
                view.ExpandAllGroups();
            }
            public static void SetReadOnlyControlData(LayoutControlGroup layoutControlGroup, bool isReadOnly) {
                foreach (var li in layoutControlGroup.Items) {
                    if (li is LayoutControlItem li2) {
                        if (li2.Control == null) continue;
                        Type type = li2.Control.GetType();
                        if (type == typeof(TextEdit)) {
                            TextEdit txtEdit = li2.Control as TextEdit;
                            txtEdit.ReadOnly = isReadOnly;
                        }
                        else if (type == typeof(DateEdit)) {
                            DateEdit dEdit = li2.Control as DateEdit;
                            dEdit.ReadOnly = isReadOnly;
                            dEdit.QueryPopUp += (s, e) => e.Cancel = isReadOnly;
                        }
                        else if (type == typeof(MemoEdit)) {
                            MemoEdit mEdit = li2.Control as MemoEdit;
                            mEdit.ReadOnly = isReadOnly;
                        }
                        else if (type == typeof(SpinEdit)) {
                            SpinEdit sEdit = li2.Control as SpinEdit;
                            sEdit.ReadOnly = isReadOnly;
                        }
                        else if (type == typeof(CheckEdit)) {
                            CheckEdit cEdit = li2.Control as CheckEdit;
                            cEdit.ReadOnly = isReadOnly;
                        }
                        else if (type == typeof(LookUpEdit)) {
                            LookUpEdit lEdit = li2.Control as LookUpEdit;
                            lEdit.ReadOnly = isReadOnly;
                        }
                        else if (type == typeof(SearchLookUpEdit)) {
                            SearchLookUpEdit slEdit = li2.Control as SearchLookUpEdit;
                            slEdit.ReadOnly = isReadOnly;
                        }
                        else if (type == typeof(ButtonEdit)) {
                            ButtonEdit btEdit = li2.Control as ButtonEdit;
                            btEdit.ReadOnly = isReadOnly;
                        }
                        else if (type == typeof(PictureEdit)) {
                            PictureEdit picEdit = li2.Control as PictureEdit;
                            picEdit.ReadOnly = isReadOnly;
                        }
                        else if (type == typeof(ComboBoxEdit)) {
                            ComboBoxEdit cbbEdit = li2.Control as ComboBoxEdit;
                            cbbEdit.ReadOnly = isReadOnly;
                        }
                        else if (type == typeof(CheckedComboBoxEdit)) {
                            CheckedComboBoxEdit ccbbEdit = li2.Control as CheckedComboBoxEdit;
                            ccbbEdit.ReadOnly = isReadOnly;
                        }
                        else if (type == typeof(GridLookUpEdit)) {
                            GridLookUpEdit glEdit = li2.Control as GridLookUpEdit;
                            glEdit.ReadOnly = isReadOnly;
                        }
                    }
                    else {
                        if (li is LayoutControlGroup li3) {
                            SetReadOnlyControlData(li3, isReadOnly);
                        }
                    }
                }
            }
            public static bool CheckValidControlData(LayoutControlGroup layoutControlGroup) {
                foreach (var li in layoutControlGroup.Items) {
                    if (li is LayoutControlItem li2) {
                        if (li2.Control == null) continue;
                        Type type = li2.Control.GetType();
                        if (type == typeof(TextEdit)) {
                            TextEdit txtEdit = li2.Control as TextEdit;
                            if (!txtEdit.ErrorText.IsNullOrEmpty()) return false;
                        }
                        else if (type == typeof(DateEdit)) {
                            DateEdit dEdit = li2.Control as DateEdit;
                            if (!dEdit.ErrorText.IsNullOrEmpty()) return false;
                        }
                        else if (type == typeof(MemoEdit)) {
                            MemoEdit mEdit = li2.Control as MemoEdit;
                            if (!mEdit.ErrorText.IsNullOrEmpty()) return false;
                        }
                        else if (type == typeof(SpinEdit)) {
                            SpinEdit sEdit = li2.Control as SpinEdit;
                            if (!sEdit.ErrorText.IsNullOrEmpty()) return false;
                        }
                        else if (type == typeof(CheckEdit)) {
                            CheckEdit cEdit = li2.Control as CheckEdit;
                            if (!cEdit.ErrorText.IsNullOrEmpty()) return false;
                        }
                        else if (type == typeof(LookUpEdit)) {
                            LookUpEdit lEdit = li2.Control as LookUpEdit;
                            if (!lEdit.ErrorText.IsNullOrEmpty()) return false;
                        }
                        else if (type == typeof(SearchLookUpEdit)) {
                            SearchLookUpEdit slEdit = li2.Control as SearchLookUpEdit;
                            if (!slEdit.ErrorText.IsNullOrEmpty()) return false;
                        }
                        else if (type == typeof(ButtonEdit)) {
                            ButtonEdit btEdit = li2.Control as ButtonEdit;
                            if (!btEdit.ErrorText.IsNullOrEmpty()) return false;
                        }
                        else if (type == typeof(PictureEdit)) {
                            PictureEdit picEdit = li2.Control as PictureEdit;
                            if (!picEdit.ErrorText.IsNullOrEmpty()) return false;
                        }
                        else if (type == typeof(ComboBoxEdit)) {
                            ComboBoxEdit cbbEdit = li2.Control as ComboBoxEdit;
                            if (!cbbEdit.ErrorText.IsNullOrEmpty()) return false;
                        }
                        else if (type == typeof(CheckedComboBoxEdit)) {
                            CheckedComboBoxEdit ccbbEdit = li2.Control as CheckedComboBoxEdit;
                            if (!ccbbEdit.ErrorText.IsNullOrEmpty()) return false;
                        }
                        else if (type == typeof(GridLookUpEdit)) {
                            GridLookUpEdit glEdit = li2.Control as GridLookUpEdit;
                            if (!glEdit.ErrorText.IsNullOrEmpty()) return false;
                        }
                    }
                    else {
                        if (li is LayoutControlGroup li3) {
                            return CheckValidControlData(li3);
                        }
                    }
                }
                return true;
            }
            public static void GridViewMain_CheckThenFocusAndSelectZeroIndexRow(GridView view) {
                if (view.RowCount > 0) {
                    view.FocusedRowHandle = 0;
                    view.ClearSelection();
                    view.SelectRow(0);
                }
            }
            public static List<Guid> GridView_GetSelectedRowOid_RemovedGuidEmptyItems(GridView view) {
                var lstObjId = view.GetSelectedRows().Select(rowId => view.GetRowCellValue(rowId, "Oid").ConvertToGuid()).ToList();
                lstObjId.RemoveAll(item => item == Guid.Empty);
                return lstObjId;
            }
            public static void ClearControlData(LayoutControlGroup layoutControlGroup) {
                foreach (var li in layoutControlGroup.Items) {
                    if (li is LayoutControlItem li2) {
                        if (li2.Control == null) continue;
                        Type type = li2.Control.GetType();
                        if (type == typeof(TextEdit)) {
                            TextEdit txtEdit = li2.Control as TextEdit;
                            txtEdit.Text = null;
                        }
                        else if (type == typeof(DateEdit)) {
                            DateEdit dEdit = li2.Control as DateEdit;
                            dEdit.Text = null;
                        }
                        else if (type == typeof(MemoEdit)) {
                            MemoEdit mEdit = li2.Control as MemoEdit;
                            mEdit.Text = null;
                        }
                        else if (type == typeof(SpinEdit)) {
                            SpinEdit sEdit = li2.Control as SpinEdit;
                            sEdit.Text = null;
                        }
                        else if (type == typeof(CheckEdit)) {
                            CheckEdit cEdit = li2.Control as CheckEdit;
                            cEdit.Checked = false;
                        }
                        else if (type == typeof(LookUpEdit)) {
                            LookUpEdit lEdit = li2.Control as LookUpEdit;
                            lEdit.EditValue = null;
                        }
                        else if (type == typeof(SearchLookUpEdit)) {
                            SearchLookUpEdit slEdit = li2.Control as SearchLookUpEdit;
                            slEdit.EditValue = null;
                        }
                        else if (type == typeof(ButtonEdit)) {
                            ButtonEdit btEdit = li2.Control as ButtonEdit;
                            btEdit.Text = null;
                        }
                        else if (type == typeof(PictureEdit)) {
                            PictureEdit picEdit = li2.Control as PictureEdit;
                            picEdit.Image = null;
                        }
                        else if (type == typeof(ComboBoxEdit)) {
                            ComboBoxEdit cbbEdit = li2.Control as ComboBoxEdit;
                            cbbEdit.Text = null;
                        }
                        else if (type == typeof(CheckedComboBoxEdit)) {
                            CheckedComboBoxEdit ccbbEdit = li2.Control as CheckedComboBoxEdit;
                            ccbbEdit.Text = null;
                        }
                        else if (type == typeof(GridLookUpEdit)) {
                            GridLookUpEdit glEdit = li2.Control as GridLookUpEdit;
                            glEdit.Text = null;
                        }
                    }
                    else {
                        if (li is LayoutControlGroup li3) {
                            ClearControlData(li3);
                        }
                    }
                }
            }
            public static void SetValueToControl<T>(T? TObject, XtraForm f) {
                if (TObject == null) return;
                foreach (var property in TObject.GetType().GetProperties()) {
                    string sName = "f" + property.Name;
                    Control[] control = f.Controls.Find(sName, true);
                    if (control.Length > 0) {
                        Type type = control[0].GetType();
                        if (type == typeof(TextEdit)) {
                            if (control[0] is TextEdit txtEdit) {
                                txtEdit.EditValue = property.GetValue(TObject, null);
                            }
                        }
                        else if (type == typeof(DateEdit)) {
                            if (control[0] is DateEdit dateEdit) {
                                dateEdit.EditValue = property.GetValue(TObject, null);
                            }
                        }
                        else if (type == typeof(ComboBoxEdit)) {
                            if (control[0] is ComboBoxEdit comboBoxEdit) {
                                comboBoxEdit.EditValue = property.GetValue(TObject, null);
                            }
                        }
                        else if (type == typeof(CheckedComboBoxEdit)) {
                            if (control[0] is CheckedComboBoxEdit checkedComboBoxEdit) {
                                checkedComboBoxEdit.EditValue = property.GetValue(TObject, null);
                            }
                        }
                        else if (type == typeof(TimeSpanEdit)) {
                            if (control[0] is TimeSpanEdit timeSpanEdit) {
                                // timeSpanEdit.EditValue = property.GetValue(TObject, null).ToTime(); // TODO: ADD ConvertToTimeSpan
                                throw new NotSupportedException();
                            }
                        }
                        else if (type == typeof(MemoEdit)) {
                            if (control[0] is MemoEdit memoEdit) {
                                memoEdit.EditValue = property.GetValue(TObject, null);
                            }
                        }
                        else if (type == typeof(SpinEdit)) {
                            if (control[0] is SpinEdit spinEdit) {
                                spinEdit.EditValue = property.GetValue(TObject, null);
                            }
                        }
                        else if (type == typeof(CalcEdit)) {
                            if (control[0] is CalcEdit calcEdit) {
                                calcEdit.EditValue = property.GetValue(TObject, null);
                            }
                        }
                        else if (type == typeof(CheckEdit)) {
                            if (control[0] is CheckEdit checkEdit) {
                                checkEdit.EditValue = property.GetValue(TObject, null);
                            }
                        }
                        else if (type == typeof(LookUpEdit)) {
                            if (control[0] is LookUpEdit lookUpEdit) {
                                //lookUpEdit.EditValue = property.GetValue(TObject, null);
                                Object? objValue = property.GetValue(TObject, null);
                                if (objValue != null) {
                                    Type TypeofData = objValue.GetType();
                                    AssignValue(objValue, TypeofData, lookUpEdit);
                                }
                            }
                        }
                        else if (type == typeof(SearchLookUpEdit)) {
                            if (control[0] is SearchLookUpEdit searchLookUpEdit) {
                                searchLookUpEdit.EditValue = property.GetValue(TObject, null);
                            }
                            //searchLookupEdit.ShowPopup();
                            //searchLookupEdit.ClosePopup();
                        }
                        else if (type == typeof(GridLookUpEdit)) {
                            if (control[0] is GridLookUpEdit gridLookUpEdit) {
                                gridLookUpEdit.EditValue = property.GetValue(TObject, null);
                            }
                            //searchLookupEdit.ShowPopup();
                            //searchLookupEdit.ClosePopup();
                        }
                        else if (type == typeof(TreeListLookUpEdit)) {
                            if (control[0] is TreeListLookUpEdit treeListLookUpEdit) {
                                treeListLookUpEdit.EditValue = property.GetValue(TObject, null);
                            }
                        }
                        else if (type == typeof(ButtonEdit)) {
                            if (control[0] is ButtonEdit buttonEdit) {
                                buttonEdit.EditValue = property.GetValue(TObject, null);
                            }
                        }
                        else if (type == typeof(PictureEdit)) {
                            if (control[0] is PictureEdit pictureEdit) {
                                using (MemoryStream mStream = new MemoryStream((byte[])property.GetValue(TObject, null))) {
                                    Bitmap bitMap = new Bitmap(mStream);
                                    pictureEdit.Image = bitMap;
                                }
                            }
                        }
                        else if (type == typeof(HyperLinkEdit)) {
                            if (control[0] is HyperLinkEdit hyperLinkEdit) {
                                hyperLinkEdit.EditValue = property.GetValue(TObject, null);
                            }
                        }
                        else if (type == typeof(CheckedListBoxControl)) {
                            if (control[0] is CheckedListBoxControl checkedListBoxControl) {
                                var array = property.GetValue(TObject, null).SafeToString().Split(';');
                                for (int i = 0; i < checkedListBoxControl.ItemCount; i++) {
                                    DataRowView? rowView = checkedListBoxControl.GetItem(i) as DataRowView;
                                    if (array.Contains(rowView.Row.ItemArray[0].ToString())) {
                                        checkedListBoxControl.SetItemChecked(i, true);
                                    }
                                }
                            }
                        }
                        else if (type == typeof(HyperlinkLabelControl)) {
                            if (control[0] is HyperlinkLabelControl hyperlinkLabelControl) {
                                hyperlinkLabelControl.Text = property.GetValue(TObject, null).SafeToString();
                            }
                        }
                    }
                }
            }
            private static void AssignValue(object ObjValue, Type TypeofData, LookUpEdit ObjToAssign) {
                if (ObjValue == null) {
                    return;
                }
                if (TypeofData == typeof(Int16) || TypeofData == typeof(Int32) || TypeofData == typeof(Int64) || TypeofData == typeof(UInt16) || TypeofData == typeof(UInt32) || TypeofData == typeof(UInt64) || TypeofData == typeof(IntPtr) || TypeofData == typeof(UIntPtr) || TypeofData == typeof(Byte) || TypeofData == typeof(SByte)) {
                    ObjToAssign.EditValue = ObjValue.ConvertToNullableInt();
                }
                else if (TypeofData == typeof(Double) || TypeofData == typeof(Decimal) || TypeofData == typeof(Single)) {
                    ObjToAssign.EditValue = ObjValue.ConvertToDouble();
                }
                else if (TypeofData == typeof(Char) || TypeofData == typeof(String)) {
                    ObjToAssign.EditValue = ObjValue.SafeToString();
                }
                else if (TypeofData == typeof(Boolean)) {
                    ObjToAssign.EditValue = ObjValue.ConvertToBool();
                }
                else if (TypeofData == typeof(DateTime) || TypeofData == typeof(DateTimeOffset)) {
                    ObjToAssign.EditValue = ObjValue.ConvertToDateTimeDMY();
                }
                else if (TypeofData == typeof(TimeSpan)) {
                    // ObjToAssign.EditValue = ObjValue.ToTime();  // TODO: ADD ConvertToTimeSpan
                    throw new NotSupportedException();
                }
                else if (TypeofData == typeof(Guid)) {
                    ObjToAssign.EditValue = ObjValue.ConvertToGuid();
                }
            }

            public static void ClearEditControlErrorText(LayoutControlGroup layoutControlGroup) {
                foreach (var li in layoutControlGroup.Items) {
                    if (li is LayoutControlItem li2) {
                        if (li2.Control == null) continue;
                        Type type = li2.Control.GetType();
                        if (type == typeof(TextEdit)) {
                            TextEdit txtEdit = li2.Control as TextEdit;
                            txtEdit.ErrorText = string.Empty;
                        }
                        else if (type == typeof(DateEdit)) {
                            DateEdit dEdit = li2.Control as DateEdit;
                            dEdit.ErrorText = string.Empty;
                        }
                        else if (type == typeof(MemoEdit)) {
                            MemoEdit mEdit = li2.Control as MemoEdit;
                            mEdit.ErrorText = string.Empty;
                        }
                        else if (type == typeof(SpinEdit)) {
                            SpinEdit sEdit = li2.Control as SpinEdit;
                            sEdit.ErrorText = string.Empty;
                        }
                        else if (type == typeof(CheckEdit)) {
                            CheckEdit cEdit = li2.Control as CheckEdit;
                            cEdit.ErrorText = string.Empty;
                        }
                        else if (type == typeof(LookUpEdit)) {
                            LookUpEdit lEdit = li2.Control as LookUpEdit;
                            lEdit.ErrorText = string.Empty;
                        }
                        else if (type == typeof(SearchLookUpEdit)) {
                            SearchLookUpEdit slEdit = li2.Control as SearchLookUpEdit;
                            slEdit.ErrorText = string.Empty;
                        }
                        else if (type == typeof(ButtonEdit)) {
                            ButtonEdit btEdit = li2.Control as ButtonEdit;
                            btEdit.ErrorText = string.Empty;
                        }
                        else if (type == typeof(PictureEdit)) {
                            PictureEdit picEdit = li2.Control as PictureEdit;
                            picEdit.ErrorText = string.Empty;
                        }
                        else if (type == typeof(ComboBoxEdit)) {
                            ComboBoxEdit cbbEdit = li2.Control as ComboBoxEdit;
                            cbbEdit.ErrorText = string.Empty;
                        }
                        else if (type == typeof(CheckedComboBoxEdit)) {
                            CheckedComboBoxEdit ccbbEdit = li2.Control as CheckedComboBoxEdit;
                            ccbbEdit.ErrorText = string.Empty;
                        }
                        else if (type == typeof(GridLookUpEdit)) {
                            GridLookUpEdit glEdit = li2.Control as GridLookUpEdit;
                            glEdit.ErrorText = string.Empty;
                        }
                    }
                    else {
                        if (li is LayoutControlGroup li3) {
                            ClearEditControlErrorText(li3);
                        }
                    }
                }
            }
            public static void SetEditControlErrorText_ValidateResult(XtraForm f, params Tuple<string, string>[] lstFieldWithMessage) {
                foreach (var item in lstFieldWithMessage) {
                    string sName = "f" + item.Item1;
                    var control = f.Controls.Find(sName, true).FirstOrDefault();
                    if (control != null && control is BaseEdit baseEdit) {
                        baseEdit.ErrorText = item.Item2;
                    }
                }
            }
            public static void SetEditControlErrorText_DuplicateMsCode(BaseEdit baseEdit) {
                baseEdit.ErrorText = "Mã số bị trùng, vui lòng kiểm tra lại";
            }
            public static void SetGridViewColumnError_MostDetailMsCode(GridView view, params string[] fieldNames) {
                foreach (string item in fieldNames) {
                    view.SetColumnError(view.Columns[item], "Yêu cầu chọn mã số chi tiết nhất");
                }
            }
            public static void SetGridViewColumnError_ValidateResult(GridView view, params Tuple<string, string>[] lstFieldWithMessage) {
                foreach (var item in lstFieldWithMessage) {
                    view.SetColumnError(view.Columns[item.Item1], item.Item2);
                }
            }
            public static string GetActiveFilterStringFromCheckedComboboxEditStatus(CheckedComboBoxEdit checkedComboboxEdit) {
                var value = checkedComboboxEdit.EditValue.SafeToString();
                var status = value.Trim().Replace(" ", string.Empty).Split(',').Select(x => $"[TrangThai] = {x}");
                return string.Join(" OR ", status);
            }
            public static string GetActiveFilterStringFromCaseConvertDataSubmit(CaseConvertDataSubmit caseConvertDataSubmit) {
                var filterString = string.Empty;
                if (caseConvertDataSubmit == CaseConvertDataSubmit.Get) {
                    filterString = $"[TrangThai] = {Convert.ToInt32(clsCommonY4c.StatusChuyenDoiDuLieu.DaGui)}";
                }
                else if (caseConvertDataSubmit == CaseConvertDataSubmit.Restore) {
                    filterString = $"[TrangThai] = {Convert.ToInt32(clsCommonY4c.StatusChuyenDoiDuLieu.ChuaGui)}";
                }
                else if (caseConvertDataSubmit == CaseConvertDataSubmit.Send) {
                    filterString = $"[TrangThai] = {Convert.ToInt32(clsCommonY4c.StatusChuyenDoiDuLieu.ChuaGui)} OR [TrangThai] = {Convert.ToInt32(clsCommonY4c.StatusChuyenDoiDuLieu.TraLai)}";
                }
                else if (caseConvertDataSubmit == CaseConvertDataSubmit.Recall) {
                    filterString = $"[TrangThai] = {Convert.ToInt32(clsCommonY4c.StatusChuyenDoiDuLieu.DaGui)}";
                }
                return filterString;
            }
            public static void ConfigEditableGridViewDetail(bool isEditable, params GridView[] gridViews) {
                foreach (var gridView in gridViews) {
                    for (int i = 0; i < gridView.Columns.Count; i++) {
                        var column = gridView.Columns[i];
                        if (isEditable) {
                            column.OptionsColumn.ReadOnly = false;
                        }
                        else {
                            column.OptionsColumn.ReadOnly = !column.FieldName.StartsWith("Ref");
                        }
                    }
                    gridView.RefreshData();
                }
            }
            public static void PreventMouseWheelForDropdown(XtraForm form) {
                if (form == null || form.Controls == null || form.Controls.Count == 0) return;
                var list = new List<PopupBaseAutoSearchEdit>();
                var layouts = new List<LayoutControl>();
                foreach (var control in form.Controls) {
                    if (control != null && control is LayoutControl) {
                        layouts.Add((LayoutControl)control);
                    }
                }
                foreach (var layout in layouts) {
                    if (layout.Controls != null && layout.Controls.Count > 0) {
                        foreach (var control in layout.Controls) {
                            if (control != null && control is PopupBaseAutoSearchEdit) {
                                list.Add((PopupBaseAutoSearchEdit)control);
                            }
                        }
                    }
                }
                PreventMouseWheelForDropdown(list.ToArray());
            }
            public static void PreventMouseWheelForDropdown(params PopupBaseAutoSearchEdit[] lookups) {
                foreach (var lookup in lookups) {
                    lookup.Properties.AllowMouseWheel = false;
                }
            }
            public static (bool isTheMostDetail, List<T> result) GetTheMostDetail<T>(List<T> dataSource, string? startFrom, string configMember = "MaSo") where T : class {
                if (startFrom.IsNullOrEmpty()) return (true, []);
                var propConfig = typeof(T).GetProperty(configMember);
                if (propConfig == null) return (true, []);

                var maxLengthCharacter = dataSource.Aggregate(startFrom?.Length ?? 0, (curr, next) => {
                    var value = propConfig.GetValue(next).SafeToString();
                    return curr > value.Length ? curr : value.Length;
                });

                var _data = dataSource.Where((s, i) => {
                    var value = propConfig.GetValue(s).SafeToString();
                    return value.StartsWith(startFrom ?? "") && value.Length > startFrom?.Length && !dataSource.Any(x => {
                        var xvalue = propConfig.GetValue(x).SafeToString();
                        return xvalue.StartsWith(value) && xvalue.Length > value.Length;
                    });
                }).ToList();
                var _dataE = dataSource.Where(s => {
                    var value = propConfig.GetValue(s).SafeToString();
                    return value == startFrom;
                }).ToList();
                return _data.Count > 0 ? (false, _data) : (_dataE.Count > 0 ? (true, _dataE) : (true, []));
            }
            public static string SetUnboundExpressionChenhLechTru(string fieldName1, string fieldName2) {
                return $"Iif(({fieldName1} ?? 0) = 0 And ({fieldName2} ?? 0) = 0, null, ({fieldName1} ?? 0) - ({fieldName2} ?? 0))";
            }
            public static string SetUnboundExpressionChenhLechCong(string fieldName1, string fieldName2) {
                return $"Iif(({fieldName1} ?? 0) = 0 And ({fieldName2} ?? 0) = 0, null, ({fieldName1} ?? 0) + ({fieldName2} ?? 0))";
            }
            public static string SetUnboundExpressionDuToanConLai(string customDuToan, string thucHienDaQuaKhoBac, string thucHienChuaQuaKhoBac) {
                return  $"Iif(IsNull({customDuToan}, 0) = 0 And IsNull({thucHienDaQuaKhoBac}, 0) = 0 " +
                    $"And IsNull({thucHienChuaQuaKhoBac}, 0) = 0, null, " +
                    $"IsNull({customDuToan}, 0) - (IsNull({thucHienDaQuaKhoBac}, 0) + IsNull({thucHienChuaQuaKhoBac}, 0)))";
            }

        }

        public class EventHandler {
            public static void GridView_CellValueChanging_AutoCalculateThanhTien(object s, CellValueChangedEventArgs e, string fNguyenTe, string fTyGia, string fThanhTien) {
                var view = s as BandedGridView;
                var commaOrDot = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                if (e.Column.FieldName.Equals(fNguyenTe) && view.GetRowCellValue(e.RowHandle, view.Columns[fTyGia]) != null) {
                    var nguyente = e.Value.SafeToString().Replace(".", commaOrDot).Replace(",", commaOrDot).ConvertToDecimal();
                    var tygia = view.GetRowCellValue(e.RowHandle, view.Columns[fTyGia]).ConvertToNullableDecimal();
                    if (tygia != null) {
                        //view.SetRowCellValue(e.RowHandle, view.Columns[fThanhTien], nguyente * tygia.ConvertToDecimal() / 100);
                        view.SetRowCellValue(e.RowHandle, view.Columns[fThanhTien], nguyente * tygia.ConvertToDecimal());
                    }
                }
                else if (e.Column.FieldName.Equals(fTyGia) && view.GetRowCellValue(e.RowHandle, view.Columns[fNguyenTe]) != null) {
                    var tygia = e.Value.SafeToString().Replace(".", commaOrDot).Replace(",", commaOrDot).ConvertToDecimal();
                    var nguyente = view.GetRowCellValue(e.RowHandle, view.Columns[fNguyenTe]).ConvertToNullableDecimal();
                    if (nguyente != null) {
                        //view.SetRowCellValue(e.RowHandle, view.Columns[fThanhTien], tygia * nguyente.ConvertToDecimal() / 100);
                        view.SetRowCellValue(e.RowHandle, view.Columns[fThanhTien], tygia * nguyente.ConvertToDecimal());
                    }
                }
            }
            public static void RepoMoney_KeyDown(object sender, KeyEventArgs e) {
                var editor = sender as TextEdit;
                if (editor != null) {
                    var value = editor.EditValue;
                    if (editor.ReadOnly)
                        return;

                    if (e.KeyCode == Keys.Multiply)
                        editor.EditValue = value.ConvertToDecimal() * 1000;
                    else if (e.KeyCode == Keys.Divide)
                        editor.EditValue = value.ConvertToDecimal() / 1000;
                }
            }
            public static void SetIconWarningOnCellAppearance(RowCellCustomDrawEventArgs e, decimal displayValue) {
                e.Appearance.BackColor = Color.Orange;
                e.Appearance.ForeColor = Color.Black;

                var icon = (Bitmap)(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.Warning_16x16));
                int iconX = e.Bounds.X + 2;
                int iconY = e.Bounds.Y + (e.Bounds.Height - icon.Height) / 2;
                e.Graphics.DrawImage(icon, iconX, iconY);

                Rectangle textRect = new Rectangle(iconX + icon.Width + 2, e.Bounds.Y, e.Bounds.Width - icon.Width - 4, e.Bounds.Height);
                string displayValueStr = displayValue.ToString("N0");
                e.Appearance.DrawString(e.Cache, displayValueStr, textRect);
            }
            public static void SearchLookUpEdit_Popup_SetFilterString(object sender, EventArgs e, string activeFilterString) {
                var lookUp = sender as SearchLookUpEdit;
                lookUp.Properties.View.ActiveFilterString = activeFilterString;
                lookUp.Properties.View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            }
            public static void GridViewDetail_ShowingEditor(object sender, CancelEventArgs e) {
                var view = sender as GridView;
                e.Cancel = view.IsNewItemRow(view.FocusedRowHandle) && view.FocusedColumn.FieldName == "Ref";
            }
            public static void GridViewDetail_RowCellStyle(object sender, RowCellStyleEventArgs e) {
                if (e.RowHandle == GridControl.NewItemRowHandle && e.Column.FieldName == "Ref")
                    e.Appearance.BackColor = Color.LightSlateGray;
                else
                    e.Appearance.BackColor = default;
            }
            public static void fMultiSelectIdRef_Closed(object sender, ClosedEventArgs e) => (sender as SearchLookUpEdit)?.LookAndFeel.UpdateStyleSettings();
            public static void fMultiSelectIdRef_QueryPopUp<TObjMain, TObjRef>(object sender, CancelEventArgs e, ref bool status, GridView gridViewMain, MainStatusForm mainStatusForm, SearchLookUpEdit fMultiSelectIdRef, string field) where TObjMain : class where TObjRef : class {
                if (status) {
                    status = false;
                    var editor = sender as SearchLookUpEdit;
                    var view = editor?.Properties.View;
                    if (view != null) {
                        if (mainStatusForm == MainStatusForm.EDIT) {
                            var objMain = (TObjMain)gridViewMain.GetFocusedRow();
                            var content = (objMain != null) ? objMain.GetType().GetProperty(field)?.GetValue(objMain, null).SafeToString() : null;
                            foreach (var item in (content ?? string.Empty).Split(",").Select(s => s.Trim()).ToList() ?? []) {
                                var index = (view.DataSource as List<TObjRef> ?? []).FindIndex(s => s.GetType().GetProperty("Oid")?.GetValue(s, null).SafeToString() == (item ?? string.Empty).Trim());
                                if (index > -1) {
                                    view.SelectRow(index);
                                }
                            }
                        }
                        if (mainStatusForm == MainStatusForm.CREATE) {
                            foreach (var item in (fMultiSelectIdRef.EditValue.SafeToString() ?? string.Empty).Split(",").Select(s => s.Trim()).ToList() ?? []) {
                                var index = (view.DataSource as List<TObjRef> ?? []).FindIndex(s => s.GetType().GetProperty("Oid")?.GetValue(s, null).SafeToString() == (item ?? string.Empty).Trim());
                                if (index > -1) {
                                    view.SelectRow(index);
                                }
                            }
                        }
                    }
                }
            }
            public static void InitializeUnboundGridBanded(BandedGridView gridView, List<(string fieldName, string caption, int visibleIndex, RepositoryItem columnEdit)> columns) {
                GridBand CreateBand(string name, string caption) {
                    var band = new GridBand {
                        Name = name,
                        Caption = caption
                    };
                    band.AppearanceHeader.BackColor = Color.White;
                    band.AppearanceHeader.ForeColor = Color.Black;
                    band.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                    band.AppearanceHeader.TextOptions.VAlignment = VertAlignment.Center;

                    return band;
                }
                BandedGridColumn CreateColumn(string fieldName, string caption, RepositoryItem edit) {
                    var column = gridView.Columns.AddField(fieldName);
                    column.Caption = caption;
                    column.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
                    column.ColumnEdit = edit;
                    column.Visible = true;
                    return column;
                }
                foreach (var item in columns) {
                    var newBand = CreateBand(item.fieldName, item.caption);
                    newBand.VisibleIndex = item.visibleIndex;
                    gridView.Bands.Insert(item.visibleIndex, newBand);
                    var bandColumns = columns.Where(c => c.caption == item.caption).ToList();
                    foreach (var (fieldName, caption, visibleIndex, columnEdit) in bandColumns) {
                        var column = CreateColumn(fieldName, caption, columnEdit);
                        newBand.Columns.Add(column);
                    }
                }
            }
            public static void AddCopyStrategyAfterSetBasicEmbededNavigator<T>(GridControl control) where T : class {
                control.KeyDown -= Control_ProcessGridKey;
                control.KeyDown += Control_ProcessGridKey;
                control.EmbeddedNavigator.ButtonClick -= Control_EmbeddedNavigator_ButtonClick<T>;
                control.EmbeddedNavigator.ButtonClick += Control_EmbeddedNavigator_ButtonClick<T>;
                var list = new ImageCollection();
                list.TransparentColor = Color.Transparent;
                list.AddImage(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.Copy_16x16) as Bitmap, "copy");
                list.AddImage(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.Delete_16x16) as Bitmap, "delete");
                list.AddImage(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.Paste_16x16) as Bitmap, "paste");
                control.EmbeddedNavigator.Buttons.ImageList = list;
                var buttonCopy = new NavigatorCustomButton(0, "Sao chép bản ghi (Ctrl + C)");
                buttonCopy.Tag = "copy";
                var buttonPaste = new NavigatorCustomButton(2, "Dán bản ghi (Ctrl + V)");
                buttonPaste.Tag = "paste";
                control.EmbeddedNavigator.Buttons.CustomButtons.AddRange([buttonCopy, buttonPaste]);
            }
            private static void Control_ProcessGridKey(object? sender, KeyEventArgs e) {
                var control = sender as GridControl;
                if (control != null) {
                    if (e.Control && e.KeyCode == Keys.C) {
                        foreach (var button in control.EmbeddedNavigator.Buttons.CustomButtons) {
                            if (button is NavigatorCustomButton _b && "copy".Equals(_b?.Tag)) {
                                control.EmbeddedNavigator.Buttons.DoClick(_b);
                                e.Handled = true;
                                break;
                            }
                        }
                    }
                    else if (e.Control && e.KeyCode == Keys.V) {
                        foreach (var button in control.EmbeddedNavigator.Buttons.CustomButtons) {
                            if (button is NavigatorCustomButton _b && "paste".Equals(_b?.Tag)) {
                                control.EmbeddedNavigator.Buttons.DoClick(_b);
                                e.Handled = true;
                                break;
                            }
                        }
                    }
                }
            }
            private static void Control_EmbeddedNavigator_ButtonClick<T>(object sender, NavigatorButtonClickEventArgs e) where T : class {
                var view = ((sender as GridControlNavigator)?.NavigatableControl as GridControl)?.FocusedView as GridView;
                if (view != null) {
                    if ("copy".Equals(e.Button.Tag)) {
                        Copy(view);
                        e.Handled = true;
                    }
                    else if ("paste".Equals(e.Button.Tag)) {
                        Paste<T>(view);
                        e.Handled = true;
                    }
                }
            }
            private static void Copy(GridView view) {
                var handles = view.GetSelectedRows();
                if (handles != null) {
                    var data = new List<object>();
                    foreach (var handle in handles) {
                        var d = view.GetRow(handle);
                        data.Add(d);
                    }
                    var text = data.JsonSerialize();
                    Clipboard.SetText(text);
                }
            }
            private static void Paste<T>(GridView view) where T : class {
                var text = Clipboard.GetText();
                List<T>? data = null;
                try {
                    data = text.JsonDeserialize<List<T>>();
                }
                catch { }
                AddDataToView(view, data);
            }
            public static void AddDataToView<T>(GridView view, List<T>? data) where T : class {
                var type = typeof(T);
                if (data != null && view.OptionsBehavior.Editable && !view.OptionsBehavior.ReadOnly && view.OptionsBehavior.AllowAddRows != DefaultBoolean.False) {
                    foreach (var d in data) {
                        view.AddNewRow();
                        foreach (var col in view.VisibleColumns.ToList()) {
                            if (col != null) {
                                var prop = type.GetProperty(col.FieldName);
                                if (prop != null) {
                                    view.SetFocusedRowCellValue(col, prop.GetValue(d));
                                }
                            }
                        }
                        view.FocusInvalidRow();
                    }
                }
            }
            private void SetCellAppearance(RowCellCustomDrawEventArgs e, decimal displayValue) {
                e.Appearance.BackColor = Color.Orange;
                e.Appearance.ForeColor = Color.Black;

                var icon = (Bitmap)(new ImageConverter().ConvertFrom(app.StdAppResources.DXIconPack.Warning_16x16));
                int iconX = e.Bounds.X + 2;
                int iconY = e.Bounds.Y + (e.Bounds.Height - icon.Height) / 2;
                e.Graphics.DrawImage(icon, iconX, iconY);

                Rectangle textRect = new Rectangle(iconX + icon.Width + 2, e.Bounds.Y, e.Bounds.Width - icon.Width - 4, e.Bounds.Height);
                string displayValueStr = displayValue.ToString("N0");
                e.Appearance.DrawString(e.Cache, displayValueStr, textRect);
            }
        }
    }
}
