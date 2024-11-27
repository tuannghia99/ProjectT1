using app.StdCommon;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraSplashScreen;
using NLog;
using ProjectX.Abstract;
using System.Data;
using System.IO;

namespace ProjectX.Client.Winform.Common {
    public class WinformCommon {
        public static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        public enum eDateTimeType {
            Thang,
            Nam
        }
        public static OverlayWindowOptions optionsOverlay = new OverlayWindowOptions(
            backColor: Color.Transparent,
            startupDelay: 0,
            opacity: 0.5,
            fadeIn: false,
            fadeOut: false,
            imageSize: new Size(30, 30)
        );

        public static void ShowMessage<T>(ServerResponseModel<T> serverResponseModel) {
            if (serverResponseModel == null) {
                MessageBox.Show("Hệ thống xảy ra lỗi 900, vui lòng liên hệ quản trị viên để được hỗ trợ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (serverResponseModel.MessResponseType == MessageResponseType.ShowForClientWithYesNoQuestion) {
                MessageBox.Show(serverResponseModel.MessageContent, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else if (serverResponseModel.MessResponseType == MessageResponseType.NotShowForClient) {
                return;
            }
            else if (serverResponseModel.MessResponseType == MessageResponseType.ShowForClientWithWarningIcon) {
                MessageBox.Show(serverResponseModel.MessageContent, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (serverResponseModel.MessResponseType == MessageResponseType.ShowForClientWithErrorIcon) {
                MessageBox.Show(serverResponseModel.MessageContent, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (serverResponseModel.MessResponseType == MessageResponseType.ShowForClientWithInfoIcon) {
                MessageBox.Show(serverResponseModel.MessageContent, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    else if (type == typeof(SearchLookUpEdit)) {
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
        public static void AssignValue(object ObjValue, Type TypeofData, LookUpEdit ObjToAssign) {
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

        public static void ClearControlData(LayoutControl layoutControl) {
            foreach (var li in layoutControl.Items) {
                if (li is LayoutControlGroup layGr) {
                    ClearSubControlData(layGr);
                }
                else {
                    if (li is LayoutControlItem li2) {
                        if (li2.Control == null) continue;
                        Type type = li2.Control.GetType();
                        if (type == typeof(TextEdit)) {
                            TextEdit txtEdit = li2.Control as TextEdit;
                            txtEdit.EditValue = null;
                        }
                        else if (type == typeof(DateEdit)) {
                            DateEdit dEdit = li2.Control as DateEdit;
                            dEdit.EditValue = null;
                        }
                        else if (type == typeof(MemoEdit)) {
                            MemoEdit mEdit = li2.Control as MemoEdit;
                            mEdit.EditValue = null;
                        }
                        else if (type == typeof(SpinEdit)) {
                            SpinEdit sEdit = li2.Control as SpinEdit;
                            sEdit.Text = string.Empty;
                        }
                        else if (type == typeof(CalcEdit)) {
                            CalcEdit sEdit = li2.Control as CalcEdit;
                            sEdit.Text = string.Empty;
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
                            btEdit.Text = string.Empty;
                        }
                        else if (type == typeof(PictureEdit)) {
                            PictureEdit picEdit = li2.Control as PictureEdit;
                            picEdit.Image = null;
                        }
                        else if (type == typeof(CheckedComboBoxEdit)) {
                            CheckedComboBoxEdit CheckCBO = li2.Control as CheckedComboBoxEdit;
                            CheckCBO.EditValue = null;
                            CheckCBO.Refresh();
                        }
                        else {
                        }
                    }
                }
            }
        }
        private static void ClearSubControlData(LayoutControlGroup layoutControlGroup) {
            foreach (var li in layoutControlGroup.Items) {
                if (li is LayoutControlItem li2) {
                    if (li2.Control == null) continue;
                    Type type = li2.Control.GetType();
                    if (type == typeof(TextEdit)) {
                        TextEdit txtEdit = li2.Control as TextEdit;
                        txtEdit.Text = string.Empty;
                    }
                    else if (type == typeof(DateEdit)) {
                        DateEdit dEdit = li2.Control as DateEdit;
                        dEdit.Text = string.Empty;
                    }
                    else if (type == typeof(MemoEdit)) {
                        MemoEdit mEdit = li2.Control as MemoEdit;
                        mEdit.Text = string.Empty;
                    }
                    else if (type == typeof(SpinEdit)) {
                        SpinEdit sEdit = li2.Control as SpinEdit;
                        sEdit.Text = string.Empty;
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
                        btEdit.Text = string.Empty;
                    }
                    else if (type == typeof(PictureEdit)) {
                        PictureEdit picEdit = li2.Control as PictureEdit;
                        picEdit.Image = null;
                    }
                }
                else {
                    if (li is LayoutControlGroup li3) {
                        ClearSubControlData(li3);
                    }
                }

            }
        }
    }
}