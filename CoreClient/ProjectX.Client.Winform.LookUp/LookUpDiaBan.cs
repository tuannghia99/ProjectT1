using app.Common;
using app.StdCommon;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using ProjectY.Client.ServerBusiness;
using BusinessClassPrimOfGuid = ProjectX2.ServerBusiness.Infrastructure.Contracts.BusinessClassPrimOfGuid;

namespace ProjectX.Client.Winform.LookUp {
    public static class LookUpDiaBan {
        private static Guid? temp_idDiaBan;
        private static SearchLookUpEdit? fIdTinh;
        private static SearchLookUpEdit? fIdHuyen;
        private static SearchLookUpEdit? fIdXa;
        private static SearchLookUpEdit? fIdThon;
        /// <summary>
        /// Tạo panel Địa bàn
        /// </summary>
        /// <param name="popupContainerEdit"></param>
        /// <param name="diaBanBus"></param>
        /// <param name="GridDataRow"></param>
        /// <param name="diaBanName">Tên trường id địa bàn</param>
        /// <param name="tinhName">Tên trường id tỉnh</param>
        /// <param name="huyenName">Tên trường id huyện</param>
        /// <param name="xaName">Tên trường id xã</param>
        /// <param name="thonName">Tên trường id thôn</param>
        /// <returns>fIdTinh, fIdHuyen, fIdXa, fIdThon</returns>
        public static async Task CreateDiaBanLookup(PopupContainerEdit popupContainerEdit, DiaBanBus diaBanBus, IEnumerable<string>? RegDiaBan, object? GridDataRow, string diaBanName = "IdDiaBan", string tinhName = "IdTinh", string huyenName = "IdHuyen", string xaName = "IdXa", string thonName = "IdThon") {
            var popupContainerControl = new PopupContainerControl();
            var layoutControl = new LayoutControl();
            var layoutRoot = new LayoutControlGroup();
            var layoutControlItemTinh = new LayoutControlItem();
            var layoutControlItemHuyen = new LayoutControlItem();
            var layoutControlItemXa = new LayoutControlItem();
            var layoutControlItemThon = new LayoutControlItem();
            var gridViewTinh = new GridView();
            var gridViewHuyen = new GridView();
            var gridViewXa = new GridView();
            var gridViewThon = new GridView();
            var col = new List<Tuple<string, string>> {
                new(nameof(BusinessClassPrimOfGuid.Ten), "Tên"),
            };
            var listTinh = new List<BusinessClassPrimOfGuid>();
            var listHuyen = new List<BusinessClassPrimOfGuid>();
            var listXa = new List<BusinessClassPrimOfGuid>();
            var listThon = new List<BusinessClassPrimOfGuid>();
            fIdTinh = new SearchLookUpEdit();
            fIdHuyen = new SearchLookUpEdit();
            fIdXa = new SearchLookUpEdit();
            fIdThon = new SearchLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)popupContainerControl).BeginInit();
            popupContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl).BeginInit();
            layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fIdThon.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewThon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fIdXa.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewXa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fIdHuyen.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewHuyen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fIdTinh.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewTinh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutRoot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemTinh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemHuyen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemXa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemThon).BeginInit();
            popupContainerEdit.Properties.ShowPopupCloseButton = false;
            popupContainerEdit.Properties.PopupSizeable = false;
            popupContainerEdit.Properties.PopupControl = popupContainerControl;
            popupContainerEdit.QueryPopUp += (s, e) => {
                var obj = s as PopupContainerEdit;
                if (obj != null) {
                    var popup = obj.Properties.PopupControl;
                    if (popup != null) {
                        popup.Width = obj.Width - 2;
                    }
                }
            };
            popupContainerEdit.QueryResultValue += (s, e) => {
                var idTinh = fIdTinh.EditValue.ConvertToGuid();
                var idHuyen = fIdHuyen.EditValue.ConvertToGuid();
                var idXa = fIdXa.EditValue.ConvertToGuid();
                var idThon = fIdThon.EditValue.ConvertToGuid();
                var text = string.Empty;
                if (idThon != Guid.Empty) {
                    temp_idDiaBan = idThon;
                    text = fIdThon.Text;
                }
                else {
                    if (idXa != Guid.Empty) {
                        temp_idDiaBan = idXa;
                        text = fIdXa.Text;
                    }
                    else {
                        if (idHuyen != Guid.Empty) {
                            temp_idDiaBan = idHuyen;
                            text = fIdHuyen.Text;
                        }
                        else {
                            if (idTinh != Guid.Empty) {
                                temp_idDiaBan = idTinh;
                                text = fIdTinh.Text;
                            }
                            else {
                                temp_idDiaBan = null;
                                text = string.Empty;
                            }
                        }
                    }
                }
                e.Value = text;
            };

            popupContainerControl.AutoSize = true;
            popupContainerControl.Controls.Add(layoutControl);
            popupContainerControl.Size = new Size(299, 103);
            popupContainerControl.Name = "popupContainerControl";

            layoutControl.Controls.Add(fIdThon);
            layoutControl.Controls.Add(fIdXa);
            layoutControl.Controls.Add(fIdHuyen);
            layoutControl.Controls.Add(fIdTinh);
            layoutControl.Dock = DockStyle.Fill;
            layoutControl.Location = new System.Drawing.Point(0, 0);
            layoutControl.Name = "layoutControl";
            layoutControl.Root = layoutRoot;
            layoutControl.Size = new Size(299, 103);
            layoutControl.TabIndex = 0;

            fIdThon.Enabled = false;
            fIdThon.Location = new System.Drawing.Point(76, 77);
            fIdThon.Name = "fIdThon";
            fIdThon.Properties.NullText = string.Empty;
            fIdThon.Properties.PopupView = gridViewThon;
            fIdThon.Size = new Size(218, 20);
            fIdThon.StyleController = layoutControl;
            fIdThon.TabIndex = 4;

            gridViewThon.FocusRectStyle = DrawFocusRectStyle.RowFocus;
            gridViewThon.Name = "gridViewThon";
            gridViewThon.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridViewThon.OptionsView.ShowGroupPanel = false;

            fIdXa.Enabled = false;
            fIdXa.Location = new System.Drawing.Point(76, 53);
            fIdXa.Name = "fIdXa";
            fIdXa.Properties.NullText = string.Empty;
            fIdXa.Properties.PopupView = gridViewXa;
            fIdXa.Size = new Size(218, 20);
            fIdXa.StyleController = layoutControl;
            fIdXa.TabIndex = 3;
            fIdXa.EditValueChanged += async (s, e) => {
                fIdThon.EditValue = null;
                var id = fIdXa.EditValue.ConvertToNullableGuid();
                var _superMS = listXa.FirstOrDefault(s => s.Id == id)?.MaSo;
                if (_superMS != null) {
                    listThon = (await diaBanBus.GetAllPrimByLevel(5, _superMS))?.ToList() ?? [];
                    if (RegDiaBan?.Any(s => listThon.Any(x => x.Ten == s)) == true) {
                        listThon = listThon.Where(s => RegDiaBan.Contains(s.Ten)).ToList();
                    }
                    fIdThon.LoadFromObject(listThon, col, nameof(BusinessClassPrimOfGuid.Id), nameof(BusinessClassPrimOfGuid.Ten));
                    if (listThon.Count == 1) {
                        fIdThon.EditValue = listThon[0].Id;
                    }
                    fIdThon.Enabled = true;
                }
                else {
                    fIdThon.Enabled = false;
                }
            };

            gridViewXa.FocusRectStyle = DrawFocusRectStyle.RowFocus;
            gridViewXa.Name = "gridViewXa";
            gridViewXa.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridViewXa.OptionsView.ShowGroupPanel = false;

            fIdHuyen.Enabled = false;
            fIdHuyen.Location = new System.Drawing.Point(76, 29);
            fIdHuyen.Name = "fIdHuyen";
            fIdHuyen.Properties.NullText = string.Empty;
            fIdHuyen.Properties.PopupView = gridViewHuyen;
            fIdHuyen.Size = new Size(218, 20);
            fIdHuyen.StyleController = layoutControl;
            fIdHuyen.TabIndex = 2;
            fIdHuyen.EditValueChanged += async (s, e) => {
                fIdXa.EditValue = null;
                var id = fIdHuyen.EditValue.ConvertToNullableGuid();
                var _superMS = listHuyen.FirstOrDefault(s => s.Id == id)?.MaSo;
                if (_superMS != null) {
                    listXa = (await diaBanBus.GetAllPrimByLevel(4, _superMS))?.ToList() ?? [];
                    if (RegDiaBan?.Any(s => listXa.Any(x => x.Ten == s)) == true) {
                        listXa = listXa.Where(s => RegDiaBan.Contains(s.Ten)).ToList();
                    }
                    fIdXa.LoadFromObject(listXa, col, nameof(BusinessClassPrimOfGuid.Id), nameof(BusinessClassPrimOfGuid.Ten));
                    if (listXa.Count == 1) {
                        fIdXa.EditValue = listXa[0].Id;
                    }
                    fIdXa.Enabled = true;
                }
                else {
                    fIdXa.Enabled = false;
                }
            };

            gridViewHuyen.FocusRectStyle = DrawFocusRectStyle.RowFocus;
            gridViewHuyen.Name = "gridViewHuyen";
            gridViewHuyen.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridViewHuyen.OptionsView.ShowGroupPanel = false;

            fIdTinh.Location = new System.Drawing.Point(76, 5);
            fIdTinh.Name = "fIdTinh";
            fIdTinh.Properties.NullText = string.Empty;
            fIdTinh.Properties.PopupView = gridViewTinh;
            fIdTinh.Size = new Size(218, 20);
            fIdTinh.StyleController = layoutControl;
            fIdTinh.TabIndex = 0;
            fIdTinh.EditValueChanged += async (s, e) => {
                fIdHuyen.EditValue = null;
                var id = fIdTinh.EditValue.ConvertToNullableGuid();
                var _superMS = listTinh.FirstOrDefault(s => s.Id == id)?.MaSo;
                if (_superMS != null) {
                    listHuyen = (await diaBanBus.GetAllPrimByLevel(3, _superMS))?.ToList() ?? [];
                    if (RegDiaBan?.Any(s => listHuyen.Any(x => x.Ten == s)) == true) {
                        listHuyen = listHuyen.Where(s => RegDiaBan.Contains(s.Ten)).ToList();
                    }
                    fIdHuyen.LoadFromObject(listHuyen, col, nameof(BusinessClassPrimOfGuid.Id), nameof(BusinessClassPrimOfGuid.Ten));
                    if (listHuyen.Count == 1) {
                        fIdHuyen.EditValue = listHuyen[0].Id;
                    }
                    fIdHuyen.Enabled = true;
                }
                else {
                    fIdHuyen.Enabled = false;
                }
            };

            gridViewTinh.FocusRectStyle = DrawFocusRectStyle.RowFocus;
            gridViewTinh.Name = "gridViewTinh";
            gridViewTinh.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridViewTinh.OptionsView.ShowGroupPanel = false;

            layoutRoot.EnableIndentsWithoutBorders = DefaultBoolean.True;
            layoutRoot.GroupBordersVisible = false;
            layoutRoot.Items.AddRange(new BaseLayoutItem[] { layoutControlItemTinh, layoutControlItemHuyen, layoutControlItemXa, layoutControlItemThon });
            layoutRoot.Name = "layoutRoot";
            layoutRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            layoutRoot.Size = new Size(299, 103);
            layoutRoot.TextVisible = false;

            layoutControlItemTinh.Control = fIdTinh;
            layoutControlItemTinh.Location = new System.Drawing.Point(0, 0);
            layoutControlItemTinh.Name = "layoutControlItemTinh";
            layoutControlItemTinh.Size = new Size(293, 24);
            layoutControlItemTinh.Text = "Chọn Tỉnh";
            layoutControlItemTinh.TextSize = new Size(59, 13);

            layoutControlItemHuyen.Control = fIdHuyen;
            layoutControlItemHuyen.Location = new System.Drawing.Point(0, 24);
            layoutControlItemHuyen.Name = "layoutControlItemHuyen";
            layoutControlItemHuyen.Size = new Size(293, 24);
            layoutControlItemHuyen.Text = "Chọn Huyện";
            layoutControlItemHuyen.TextSize = new Size(59, 13);

            layoutControlItemXa.Control = fIdXa;
            layoutControlItemXa.Location = new System.Drawing.Point(0, 48);
            layoutControlItemXa.Name = "layoutControlItemXa";
            layoutControlItemXa.Size = new Size(293, 24);
            layoutControlItemXa.Text = "Chọn Xã";
            layoutControlItemXa.TextSize = new Size(59, 13);

            layoutControlItemThon.Control = fIdThon;
            layoutControlItemThon.Location = new System.Drawing.Point(0, 72);
            layoutControlItemThon.Name = "layoutControlItemThon";
            layoutControlItemThon.Size = new Size(293, 24);
            layoutControlItemThon.Text = "Chọn Thôn";
            layoutControlItemThon.TextSize = new Size(59, 13);
            ((System.ComponentModel.ISupportInitialize)popupContainerControl).EndInit();
            popupContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl).EndInit();
            layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fIdThon.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewThon).EndInit();
            ((System.ComponentModel.ISupportInitialize)fIdXa.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewXa).EndInit();
            ((System.ComponentModel.ISupportInitialize)fIdHuyen.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewHuyen).EndInit();
            ((System.ComponentModel.ISupportInitialize)fIdTinh.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewTinh).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutRoot).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemTinh).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemHuyen).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemXa).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemThon).EndInit();
            listTinh = (await diaBanBus.GetAllPrimByLevel(2))?.ToList() ?? [];
            if (RegDiaBan?.Any(s => listTinh.Any(x => x.Ten == s)) == true) {
                listTinh = listTinh.Where(s => RegDiaBan.Contains(s.Ten)).ToList();
            }
            fIdTinh.LoadFromObject(listTinh, col, nameof(BusinessClassPrimOfGuid.Id), nameof(BusinessClassPrimOfGuid.Ten));
            if (listTinh.Count == 1) {
                fIdTinh.EditValue = listTinh[0].Id;
            }
            if (listTinh.Count > 0) {
                var _superMS = listTinh.FirstOrDefault(s => s.Id == GridDataRow?.GetType().GetProperty(tinhName)?.GetValue(GridDataRow, null).ConvertToNullableGuid())?.MaSo;
                if (_superMS != null) {
                    listHuyen = (await diaBanBus.GetAllPrimByLevel(3, _superMS))?.ToList() ?? [];
                    if (RegDiaBan?.Any(s => listHuyen.Any(x => x.Ten == s)) == true) {
                        listHuyen = listHuyen.Where(s => RegDiaBan.Contains(s.Ten)).ToList();
                    }
                    fIdHuyen.LoadFromObject(listHuyen, col, nameof(BusinessClassPrimOfGuid.Id), nameof(BusinessClassPrimOfGuid.Ten));
                    if (listHuyen.Count == 1) {
                        fIdHuyen.EditValue = listHuyen[0].Id;
                    }
                }
            }
            if (listHuyen.Count > 0) {
                var _superMS = listHuyen.FirstOrDefault(s => s.Id == GridDataRow?.GetType().GetProperty(huyenName)?.GetValue(GridDataRow, null).ConvertToNullableGuid())?.MaSo;
                if (_superMS != null) {
                    listXa = (await diaBanBus.GetAllPrimByLevel(4, _superMS))?.ToList() ?? [];
                    if (RegDiaBan?.Any(s => listXa.Any(x => x.Ten == s)) == true) {
                        listXa = listXa.Where(s => RegDiaBan.Contains(s.Ten)).ToList();
                    }
                    fIdXa.LoadFromObject(listXa, col, nameof(BusinessClassPrimOfGuid.Id), nameof(BusinessClassPrimOfGuid.Ten));
                    if (listXa.Count == 1) {
                        fIdXa.EditValue = listXa[0].Id;
                    }
                }
            }
            if (listXa.Count > 0) {
                var _superMS = listXa.FirstOrDefault(s => s.Id == GridDataRow?.GetType().GetProperty(xaName)?.GetValue(GridDataRow, null).ConvertToNullableGuid())?.MaSo;
                if (_superMS != null) {
                    listThon = (await diaBanBus.GetAllPrimByLevel(5, _superMS))?.ToList() ?? [];
                    if (RegDiaBan?.Any(s => listThon.Any(x => x.Ten == s)) == true) {
                        listThon = listThon.Where(s => RegDiaBan.Contains(s.Ten)).ToList();
                    }
                    fIdThon.LoadFromObject(listThon, col, nameof(BusinessClassPrimOfGuid.Id), nameof(BusinessClassPrimOfGuid.Ten));
                    if (listThon.Count == 1) {
                        fIdThon.EditValue = listThon[0].Id;
                    }
                }
            }

            temp_idDiaBan = GridDataRow?.GetType().GetProperty(diaBanName)?.GetValue(GridDataRow, null).ConvertToNullableGuid();
            if (GridDataRow != null) {
                if (GridDataRow?.GetType().GetProperty(tinhName)?.GetValue(GridDataRow, null).ConvertToNullableGuid() == temp_idDiaBan) {
                    popupContainerEdit.EditValue = listTinh?.Where(s => s.Id == GridDataRow?.GetType().GetProperty(tinhName)?.GetValue(GridDataRow, null).ConvertToNullableGuid()).FirstOrDefault()?.Ten;
                }
                if (GridDataRow?.GetType().GetProperty(huyenName)?.GetValue(GridDataRow, null).ConvertToNullableGuid() == temp_idDiaBan) {
                    popupContainerEdit.EditValue = listHuyen?.Where(s => s.Id == GridDataRow?.GetType().GetProperty(huyenName)?.GetValue(GridDataRow, null).ConvertToNullableGuid()).FirstOrDefault()?.Ten;
                }
                if (GridDataRow?.GetType().GetProperty(xaName)?.GetValue(GridDataRow, null).ConvertToNullableGuid() == temp_idDiaBan) {
                    popupContainerEdit.EditValue = listXa?.Where(s => s.Id == GridDataRow?.GetType().GetProperty(xaName)?.GetValue(GridDataRow, null).ConvertToNullableGuid()).FirstOrDefault()?.Ten;
                }
                if (GridDataRow?.GetType().GetProperty(thonName)?.GetValue(GridDataRow, null).ConvertToNullableGuid() == temp_idDiaBan) {
                    popupContainerEdit.EditValue = listThon?.Where(s => s.Id == GridDataRow?.GetType().GetProperty(thonName)?.GetValue(GridDataRow, null).ConvertToNullableGuid()).FirstOrDefault()?.Ten;
                }
            }
        }
        public static Guid? GetIdDiaBanLookup() {
            return temp_idDiaBan;
        }
        public static Guid? GetIdTinh_DiaBanLookup() {
            return fIdTinh?.EditValue.ConvertToNullableGuid();
        }
        public static Guid? GetIdHuyen_DiaBanLookup() {
            return fIdHuyen?.EditValue.ConvertToNullableGuid();
        }
        public static Guid? GetIdXa_DiaBanLookup() {
            return fIdXa?.EditValue.ConvertToNullableGuid();
        }
        public static Guid? GetIdThon_DiaBanLookup() {
            return fIdThon?.EditValue.ConvertToNullableGuid();
        }
        public static void SetEmptyDiaBanLookup() {
            temp_idDiaBan = null;
            if (fIdTinh != null) fIdTinh.EditValue = null;
            if (fIdHuyen != null) fIdHuyen.EditValue = null;
            if (fIdXa != null) fIdXa.EditValue = null;
            if (fIdThon != null) fIdThon.EditValue = null;
        }
    }
}