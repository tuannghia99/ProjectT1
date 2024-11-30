using System.Drawing;
using System.Windows.Forms;

namespace ProjectT1.CoreClient {
    partial class FrmKyLuat {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKyLuat));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            fDiaDiemXayRa = new DevExpress.XtraEditors.TextEdit();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            btnCreate = new DevExpress.XtraBars.BarButtonItem();
            btnEdit = new DevExpress.XtraBars.BarButtonItem();
            btnDelete = new DevExpress.XtraBars.BarButtonItem();
            btnSubmit = new DevExpress.XtraBars.BarButtonItem();
            btnCancel = new DevExpress.XtraBars.BarButtonItem();
            btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            btnClose = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            fThoiGianXayRa = new DevExpress.XtraEditors.DateEdit();
            fNgayHetHieuLuc = new DevExpress.XtraEditors.DateEdit();
            fHinhThucKyLuat = new DevExpress.XtraEditors.MemoEdit();
            fMoTaSuViec = new DevExpress.XtraEditors.MemoEdit();
            fIdNhanVien = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            fMaSo = new DevExpress.XtraEditors.TextEdit();
            gridControlMain = new DevExpress.XtraGrid.GridControl();
            gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            repoNhanVien = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroupMainData = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlGroupEditControl = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            fNgayBatDauThiHanh = new DevExpress.XtraEditors.DateEdit();
            layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            fNhungNguoiChungKien = new DevExpress.XtraEditors.TextEdit();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            fIsViPhamChinhSachCongTy = new DevExpress.XtraEditors.CheckEdit();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            fDienGiai = new DevExpress.XtraEditors.MemoEdit();
            layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fDiaDiemXayRa.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fThoiGianXayRa.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fThoiGianXayRa.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fNgayHetHieuLuc.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fNgayHetHieuLuc.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fHinhThucKyLuat.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fMoTaSuViec.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fIdNhanVien.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fMaSo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoNhanVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemSearchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroupMainData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroupEditControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitterItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fNgayBatDauThiHanh.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fNgayBatDauThiHanh.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fNhungNguoiChungKien.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fIsViPhamChinhSachCongTy.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fDienGiai.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(fDienGiai);
            layoutControl1.Controls.Add(fIsViPhamChinhSachCongTy);
            layoutControl1.Controls.Add(fNhungNguoiChungKien);
            layoutControl1.Controls.Add(fNgayBatDauThiHanh);
            layoutControl1.Controls.Add(fDiaDiemXayRa);
            layoutControl1.Controls.Add(fThoiGianXayRa);
            layoutControl1.Controls.Add(fNgayHetHieuLuc);
            layoutControl1.Controls.Add(fHinhThucKyLuat);
            layoutControl1.Controls.Add(fMoTaSuViec);
            layoutControl1.Controls.Add(fIdNhanVien);
            layoutControl1.Controls.Add(fMaSo);
            layoutControl1.Controls.Add(gridControlMain);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 24);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(1398, 724);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // fDiaDiemXayRa
            // 
            fDiaDiemXayRa.Location = new Point(457, 117);
            fDiaDiemXayRa.MenuManager = barManager1;
            fDiaDiemXayRa.Name = "fDiaDiemXayRa";
            fDiaDiemXayRa.Size = new Size(917, 20);
            fDiaDiemXayRa.StyleController = layoutControl1;
            fDiaDiemXayRa.TabIndex = 5;
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2, bar3 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnCreate, btnEdit, btnDelete, btnSubmit, btnCancel, btnRefresh, btnClose });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 8;
            barManager1.StatusBar = bar3;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnCreate), new DevExpress.XtraBars.LinkPersistInfo(btnEdit), new DevExpress.XtraBars.LinkPersistInfo(btnDelete), new DevExpress.XtraBars.LinkPersistInfo(btnSubmit), new DevExpress.XtraBars.LinkPersistInfo(btnCancel), new DevExpress.XtraBars.LinkPersistInfo(btnRefresh), new DevExpress.XtraBars.LinkPersistInfo(btnClose) });
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // btnCreate
            // 
            btnCreate.Caption = "Thêm";
            btnCreate.Id = 0;
            btnCreate.ImageOptions.Image = (Image)resources.GetObject("btnCreate.ImageOptions.Image");
            btnCreate.Name = "btnCreate";
            btnCreate.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnCreate.ItemClick += btnCreate_ItemClick;
            // 
            // btnEdit
            // 
            btnEdit.Caption = "Sửa";
            btnEdit.Id = 1;
            btnEdit.ImageOptions.Image = (Image)resources.GetObject("btnEdit.ImageOptions.Image");
            btnEdit.Name = "btnEdit";
            btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnEdit.ItemClick += btnEdit_ItemClick;
            // 
            // btnDelete
            // 
            btnDelete.Caption = "Xoá";
            btnDelete.Id = 2;
            btnDelete.ImageOptions.Image = (Image)resources.GetObject("btnDelete.ImageOptions.Image");
            btnDelete.Name = "btnDelete";
            btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnDelete.ItemClick += btnDelete_ItemClick;
            // 
            // btnSubmit
            // 
            btnSubmit.Caption = "Ghi";
            btnSubmit.Id = 3;
            btnSubmit.ImageOptions.Image = (Image)resources.GetObject("btnSubmit.ImageOptions.Image");
            btnSubmit.Name = "btnSubmit";
            btnSubmit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnSubmit.ItemClick += btnSubmit_ItemClick;
            // 
            // btnCancel
            // 
            btnCancel.Caption = "Bỏ qua";
            btnCancel.Id = 4;
            btnCancel.ImageOptions.Image = (Image)resources.GetObject("btnCancel.ImageOptions.Image");
            btnCancel.Name = "btnCancel";
            btnCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnCancel.ItemClick += btnCancel_ItemClick;
            // 
            // btnRefresh
            // 
            btnRefresh.Caption = "Làm mới";
            btnRefresh.Id = 5;
            btnRefresh.ImageOptions.Image = (Image)resources.GetObject("btnRefresh.ImageOptions.Image");
            btnRefresh.Name = "btnRefresh";
            btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnRefresh.ItemClick += btnRefresh_ItemClick;
            // 
            // btnClose
            // 
            btnClose.Caption = "Đóng";
            btnClose.Id = 6;
            btnClose.ImageOptions.Image = (Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnClose.ItemClick += btnClose_ItemClick;
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(1398, 24);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 748);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(1398, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 24);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 724);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1398, 24);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 724);
            // 
            // fThoiGianXayRa
            // 
            fThoiGianXayRa.EditValue = null;
            fThoiGianXayRa.Location = new Point(457, 93);
            fThoiGianXayRa.MenuManager = barManager1;
            fThoiGianXayRa.Name = "fThoiGianXayRa";
            fThoiGianXayRa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fThoiGianXayRa.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fThoiGianXayRa.Size = new Size(917, 20);
            fThoiGianXayRa.StyleController = layoutControl1;
            fThoiGianXayRa.TabIndex = 4;
            // 
            // fNgayHetHieuLuc
            // 
            fNgayHetHieuLuc.EditValue = null;
            fNgayHetHieuLuc.Location = new Point(457, 539);
            fNgayHetHieuLuc.MenuManager = barManager1;
            fNgayHetHieuLuc.Name = "fNgayHetHieuLuc";
            fNgayHetHieuLuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fNgayHetHieuLuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fNgayHetHieuLuc.Size = new Size(917, 20);
            fNgayHetHieuLuc.StyleController = layoutControl1;
            fNgayHetHieuLuc.TabIndex = 12;
            // 
            // fHinhThucKyLuat
            // 
            fHinhThucKyLuat.Location = new Point(457, 415);
            fHinhThucKyLuat.MenuManager = barManager1;
            fHinhThucKyLuat.Name = "fHinhThucKyLuat";
            fHinhThucKyLuat.Size = new Size(917, 96);
            fHinhThucKyLuat.StyleController = layoutControl1;
            fHinhThucKyLuat.TabIndex = 10;
            // 
            // fMoTaSuViec
            // 
            fMoTaSuViec.Location = new Point(457, 141);
            fMoTaSuViec.MenuManager = barManager1;
            fMoTaSuViec.Name = "fMoTaSuViec";
            fMoTaSuViec.Size = new Size(917, 96);
            fMoTaSuViec.StyleController = layoutControl1;
            fMoTaSuViec.TabIndex = 6;
            // 
            // fIdNhanVien
            // 
            fIdNhanVien.Location = new Point(457, 69);
            fIdNhanVien.MenuManager = barManager1;
            fIdNhanVien.Name = "fIdNhanVien";
            fIdNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fIdNhanVien.Properties.PopupView = searchLookUpEdit1View;
            fIdNhanVien.Size = new Size(917, 20);
            fIdNhanVien.StyleController = layoutControl1;
            fIdNhanVien.TabIndex = 3;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // fMaSo
            // 
            fMaSo.Location = new Point(457, 45);
            fMaSo.MenuManager = barManager1;
            fMaSo.Name = "fMaSo";
            fMaSo.Size = new Size(917, 20);
            fMaSo.StyleController = layoutControl1;
            fMaSo.TabIndex = 2;
            // 
            // gridControlMain
            // 
            gridControlMain.Location = new Point(24, 45);
            gridControlMain.MainView = gridViewMain;
            gridControlMain.MenuManager = barManager1;
            gridControlMain.Name = "gridControlMain";
            gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repoNhanVien });
            gridControlMain.Size = new Size(249, 655);
            gridControlMain.TabIndex = 0;
            gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewMain });
            // 
            // gridViewMain
            // 
            gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn16, gridColumn15, gridColumn14, gridColumn13, gridColumn8, gridColumn7, gridColumn6, gridColumn5, gridColumn4, gridColumn9, gridColumn10, gridColumn11, gridColumn12 });
            gridViewMain.GridControl = gridControlMain;
            gridViewMain.Name = "gridViewMain";
            gridViewMain.OptionsSelection.MultiSelect = true;
            gridViewMain.OptionsView.ShowGroupPanel = false;
            gridViewMain.FocusedRowChanged += gridViewMain_FocusedRowChanged;
            gridViewMain.RowCountChanged += gridViewMain_RowCountChanged;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Oid";
            gridColumn1.FieldName = "Oid";
            gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Mã số";
            gridColumn2.FieldName = "MaSo";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "Nhân viên";
            gridColumn3.ColumnEdit = repoNhanVien;
            gridColumn3.FieldName = "IdNhanVien";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 1;
            // 
            // repoNhanVien
            // 
            repoNhanVien.AutoHeight = false;
            repoNhanVien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repoNhanVien.Name = "repoNhanVien";
            repoNhanVien.PopupView = repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn16
            // 
            gridColumn16.Caption = "ThoiGianXayRa";
            gridColumn16.FieldName = "ThoiGianXayRa";
            gridColumn16.Name = "gridColumn16";
            // 
            // gridColumn15
            // 
            gridColumn15.Caption = "DiaDiemXayRa";
            gridColumn15.FieldName = "DiaDiemXayRa";
            gridColumn15.Name = "gridColumn15";
            // 
            // gridColumn14
            // 
            gridColumn14.Caption = "MoTaSuViec";
            gridColumn14.FieldName = "MoTaSuViec";
            gridColumn14.Name = "gridColumn14";
            // 
            // gridColumn13
            // 
            gridColumn13.Caption = "NhungNguoiChungKien";
            gridColumn13.FieldName = "NhungNguoiChungKien";
            gridColumn13.Name = "gridColumn13";
            // 
            // gridColumn8
            // 
            gridColumn8.Caption = "IsViPhamChinhSachCongTy";
            gridColumn8.FieldName = "IsViPhamChinhSachCongTy";
            gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "DienGiai";
            gridColumn7.FieldName = "DienGiai";
            gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "HinhThucKyLuat";
            gridColumn6.FieldName = "HinhThucKyLuat";
            gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "NgayBatDauThiHanh";
            gridColumn5.FieldName = "NgayBatDauThiHanh";
            gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "NgayHetHieuLuc";
            gridColumn4.FieldName = "NgayHetHieuLuc";
            gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn9
            // 
            gridColumn9.Caption = "CreateUser";
            gridColumn9.FieldName = "CreateUser";
            gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn10
            // 
            gridColumn10.Caption = "CreateDate";
            gridColumn10.FieldName = "CreateDate";
            gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn11
            // 
            gridColumn11.Caption = "ModifiedUser";
            gridColumn11.FieldName = "ModifiedUser";
            gridColumn11.Name = "gridColumn11";
            // 
            // gridColumn12
            // 
            gridColumn12.Caption = "ModifiedDate";
            gridColumn12.FieldName = "ModifiedDate";
            gridColumn12.Name = "gridColumn12";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroupMainData, layoutControlGroupEditControl, splitterItem1 });
            Root.Name = "Root";
            Root.Size = new Size(1398, 724);
            Root.TextVisible = false;
            // 
            // layoutControlGroupMainData
            // 
            layoutControlGroupMainData.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            layoutControlGroupMainData.Location = new Point(0, 0);
            layoutControlGroupMainData.Name = "layoutControlGroupMainData";
            layoutControlGroupMainData.Size = new Size(277, 704);
            layoutControlGroupMainData.Text = "Danh sách dữ liệu";
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gridControlMain;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(253, 659);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroupEditControl
            // 
            layoutControlGroupEditControl.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem8, layoutControlItem9, layoutControlItem10, layoutControlItem11, layoutControlItem6, layoutControlItem5, emptySpaceItem1, layoutControlItem7, layoutControlItem12, emptySpaceItem4, emptySpaceItem5 });
            layoutControlGroupEditControl.Location = new Point(287, 0);
            layoutControlGroupEditControl.Name = "layoutControlGroupEditControl";
            layoutControlGroupEditControl.Size = new Size(1091, 704);
            layoutControlGroupEditControl.Text = "Thông tin";
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = fMaSo;
            layoutControlItem2.Location = new Point(0, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(1067, 24);
            layoutControlItem2.Text = "Mã số (*)";
            layoutControlItem2.TextSize = new Size(134, 13);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = fIdNhanVien;
            layoutControlItem3.Location = new Point(0, 24);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(1067, 24);
            layoutControlItem3.Text = "Nhân viên bị kỷ luật (*)";
            layoutControlItem3.TextSize = new Size(134, 13);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            layoutControlItem4.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            layoutControlItem4.Control = fMoTaSuViec;
            layoutControlItem4.Location = new Point(0, 96);
            layoutControlItem4.MaxSize = new Size(0, 100);
            layoutControlItem4.MinSize = new Size(136, 100);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(1067, 100);
            layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem4.Text = "Mô tả sự việc (*)";
            layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            layoutControlItem4.TextSize = new Size(134, 13);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
            layoutControlItem5.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            layoutControlItem5.ContentVertAlignment = DevExpress.Utils.VertAlignment.Top;
            layoutControlItem5.Control = fHinhThucKyLuat;
            layoutControlItem5.Location = new Point(0, 370);
            layoutControlItem5.MaxSize = new Size(0, 100);
            layoutControlItem5.MinSize = new Size(136, 100);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(1067, 100);
            layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem5.Text = "Hình thức kỷ luật (*)";
            layoutControlItem5.TextSize = new Size(134, 13);
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.Control = fNgayHetHieuLuc;
            layoutControlItem8.Location = new Point(0, 494);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.Size = new Size(1067, 24);
            layoutControlItem8.Text = "Ngày hết hiệu lực (*)";
            layoutControlItem8.TextSize = new Size(134, 13);
            // 
            // layoutControlItem9
            // 
            layoutControlItem9.Control = fThoiGianXayRa;
            layoutControlItem9.Location = new Point(0, 48);
            layoutControlItem9.Name = "layoutControlItem9";
            layoutControlItem9.Size = new Size(1067, 24);
            layoutControlItem9.Text = "Thời gian xảy ra (*)";
            layoutControlItem9.TextSize = new Size(134, 13);
            // 
            // layoutControlItem10
            // 
            layoutControlItem10.Control = fDiaDiemXayRa;
            layoutControlItem10.Location = new Point(0, 72);
            layoutControlItem10.Name = "layoutControlItem10";
            layoutControlItem10.Size = new Size(1067, 24);
            layoutControlItem10.Text = "Địa điểm xảy ra (*)";
            layoutControlItem10.TextSize = new Size(134, 13);
            // 
            // splitterItem1
            // 
            splitterItem1.AllowHotTrack = true;
            splitterItem1.Location = new Point(277, 0);
            splitterItem1.Name = "splitterItem1";
            splitterItem1.Size = new Size(10, 704);
            // 
            // fNgayBatDauThiHanh
            // 
            fNgayBatDauThiHanh.EditValue = null;
            fNgayBatDauThiHanh.Location = new Point(457, 515);
            fNgayBatDauThiHanh.MenuManager = barManager1;
            fNgayBatDauThiHanh.Name = "fNgayBatDauThiHanh";
            fNgayBatDauThiHanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fNgayBatDauThiHanh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fNgayBatDauThiHanh.Size = new Size(917, 20);
            fNgayBatDauThiHanh.StyleController = layoutControl1;
            fNgayBatDauThiHanh.TabIndex = 11;
            // 
            // layoutControlItem11
            // 
            layoutControlItem11.Control = fNgayBatDauThiHanh;
            layoutControlItem11.Location = new Point(0, 470);
            layoutControlItem11.Name = "layoutControlItem11";
            layoutControlItem11.Size = new Size(1067, 24);
            layoutControlItem11.Text = "Ngày bắt đầu thi hành (*)";
            layoutControlItem11.TextSize = new Size(134, 13);
            // 
            // fNhungNguoiChungKien
            // 
            fNhungNguoiChungKien.Location = new Point(457, 241);
            fNhungNguoiChungKien.MenuManager = barManager1;
            fNhungNguoiChungKien.Name = "fNhungNguoiChungKien";
            fNhungNguoiChungKien.Size = new Size(917, 20);
            fNhungNguoiChungKien.StyleController = layoutControl1;
            fNhungNguoiChungKien.TabIndex = 7;
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = fNhungNguoiChungKien;
            layoutControlItem6.Location = new Point(0, 196);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(1067, 24);
            layoutControlItem6.Text = "Những người chứng kiến (*)";
            layoutControlItem6.TextSize = new Size(134, 13);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new Point(0, 220);
            emptySpaceItem2.MaxSize = new Size(0, 10);
            emptySpaceItem2.MinSize = new Size(10, 10);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new Size(1067, 10);
            emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            emptySpaceItem2.TextSize = new Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.AllowHotTrack = false;
            emptySpaceItem3.Location = new Point(0, 275);
            emptySpaceItem3.MaxSize = new Size(0, 10);
            emptySpaceItem3.MinSize = new Size(10, 10);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new Size(1067, 10);
            emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            emptySpaceItem3.TextSize = new Size(0, 0);
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.Location = new Point(0, 230);
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new Size(1067, 45);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 518);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(1067, 141);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // fIsViPhamChinhSachCongTy
            // 
            fIsViPhamChinhSachCongTy.Location = new Point(578, 275);
            fIsViPhamChinhSachCongTy.MenuManager = barManager1;
            fIsViPhamChinhSachCongTy.Name = "fIsViPhamChinhSachCongTy";
            fIsViPhamChinhSachCongTy.Properties.Caption = "";
            fIsViPhamChinhSachCongTy.Size = new Size(796, 20);
            fIsViPhamChinhSachCongTy.StyleController = layoutControl1;
            fIsViPhamChinhSachCongTy.TabIndex = 8;
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = fIsViPhamChinhSachCongTy;
            layoutControlItem7.Location = new Point(0, 230);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new Size(1067, 24);
            layoutControlItem7.Text = "Sự việc này có vi phạm chính sách của công ty không ?";
            layoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            layoutControlItem7.TextSize = new Size(262, 13);
            layoutControlItem7.TextToControlDistance = 5;
            // 
            // fDienGiai
            // 
            fDienGiai.Location = new Point(311, 317);
            fDienGiai.MenuManager = barManager1;
            fDienGiai.Name = "fDienGiai";
            fDienGiai.Size = new Size(1063, 84);
            fDienGiai.StyleController = layoutControl1;
            fDienGiai.TabIndex = 9;
            // 
            // layoutControlItem12
            // 
            layoutControlItem12.Control = fDienGiai;
            layoutControlItem12.Location = new Point(0, 254);
            layoutControlItem12.MaxSize = new Size(0, 106);
            layoutControlItem12.MinSize = new Size(369, 106);
            layoutControlItem12.Name = "layoutControlItem12";
            layoutControlItem12.Size = new Size(1067, 106);
            layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem12.Text = "Nếu có, nêu rõ sự việc này vi phạm chính sách nào và những phạm vi cụ thể";
            layoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            layoutControlItem12.TextLocation = DevExpress.Utils.Locations.Top;
            layoutControlItem12.TextSize = new Size(365, 13);
            layoutControlItem12.TextToControlDistance = 5;
            // 
            // emptySpaceItem4
            // 
            emptySpaceItem4.AllowHotTrack = false;
            emptySpaceItem4.Location = new Point(0, 220);
            emptySpaceItem4.MaxSize = new Size(0, 10);
            emptySpaceItem4.MinSize = new Size(10, 10);
            emptySpaceItem4.Name = "emptySpaceItem4";
            emptySpaceItem4.Size = new Size(1067, 10);
            emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            emptySpaceItem4.TextSize = new Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            emptySpaceItem5.AllowHotTrack = false;
            emptySpaceItem5.Location = new Point(0, 360);
            emptySpaceItem5.MaxSize = new Size(0, 10);
            emptySpaceItem5.MinSize = new Size(10, 10);
            emptySpaceItem5.Name = "emptySpaceItem5";
            emptySpaceItem5.Size = new Size(1067, 10);
            emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            emptySpaceItem5.TextSize = new Size(0, 0);
            // 
            // FrmKyLuat
            // 
            ClientSize = new Size(1398, 768);
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "FrmKyLuat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kỷ luật";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fDiaDiemXayRa.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fThoiGianXayRa.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fThoiGianXayRa.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fNgayHetHieuLuc.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fNgayHetHieuLuc.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fHinhThucKyLuat.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fMoTaSuViec.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fIdNhanVien.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)fMaSo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoNhanVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemSearchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroupMainData).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroupEditControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem10).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitterItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fNgayBatDauThiHanh.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fNgayBatDauThiHanh.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem11).EndInit();
            ((System.ComponentModel.ISupportInitialize)fNhungNguoiChungKien.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fIsViPhamChinhSachCongTy.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)fDienGiai.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem12).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnCreate;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnSubmit;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupMainData;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupEditControl;
        private DevExpress.XtraEditors.TextEdit fMaSo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repoNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.MemoEdit fMoTaSuViec;
        private DevExpress.XtraEditors.SearchLookUpEdit fIdNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.MemoEdit fHinhThucKyLuat;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.DateEdit fNgayHetHieuLuc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.DateEdit fThoiGianXayRa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.TextEdit fDiaDiemXayRa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.DateEdit fNgayBatDauThiHanh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraEditors.TextEdit fNhungNguoiChungKien;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.CheckEdit fIsViPhamChinhSachCongTy;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.MemoEdit fDienGiai;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
    }
}