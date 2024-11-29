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

namespace ProjectT1.Client.Winform {
    public class clsCommon {
        public enum MainStatusForm {
            WAIT = 0,
            VIEW = 1,
            CREATE = 2,
            EDIT = 3,
            //COPY = 4,
            //LOCK = 5
        }
        public partial class CommonHandler {
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
            public static void GridViewMain_CheckThenFocusAndSelectZeroIndexRow(GridView view) {
                if (view.RowCount > 0) {
                    view.FocusedRowHandle = 0;
                    view.ClearSelection();
                    view.SelectRow(0);
                }
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
                                var array = property.GetValue(TObject, null).ToString().Split(';');
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
                                hyperlinkLabelControl.Text = property.GetValue(TObject, null).ToString();
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
                    ObjToAssign.EditValue = (int?)ObjValue;
                }
                else if (TypeofData == typeof(Double) || TypeofData == typeof(Decimal) || TypeofData == typeof(Single)) {
                    ObjToAssign.EditValue = (double?)ObjValue;
                }
                else if (TypeofData == typeof(Char) || TypeofData == typeof(String)) {
                    ObjToAssign.EditValue = ObjValue.ToString();
                }
                else if (TypeofData == typeof(Boolean)) {
                    ObjToAssign.EditValue = (bool)ObjValue;
                }
                else if (TypeofData == typeof(DateTime) || TypeofData == typeof(DateTimeOffset)) {
                    ObjToAssign.EditValue = (DateTime)ObjValue;
                }
                else if (TypeofData == typeof(TimeSpan)) {
                    // ObjToAssign.EditValue = ObjValue.ToTime();  // TODO: ADD ConvertToTimeSpan
                    throw new NotSupportedException();
                }
                else if (TypeofData == typeof(Guid)) {
                    ObjToAssign.EditValue = (Guid)ObjValue;
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
        }
    }
}
