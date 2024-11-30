using System.Drawing;
using System.Windows.Forms;

namespace ProjectT1.CoreClient {
    partial class FrmKhenThuong {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhenThuong));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            fNgayKhenThuong = new DevExpress.XtraEditors.DateEdit();
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
            fMucKhenThuong = new DevExpress.XtraEditors.TextEdit();
            fLyDoKhenThuong = new DevExpress.XtraEditors.MemoEdit();
            fHinhThucKhenThuong = new DevExpress.XtraEditors.MemoEdit();
            fCanCuKhenThuong = new DevExpress.XtraEditors.MemoEdit();
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
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroupMainData = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlGroupEditControl = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fNgayKhenThuong.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fNgayKhenThuong.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fMucKhenThuong.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fLyDoKhenThuong.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fHinhThucKhenThuong.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fCanCuKhenThuong.Properties).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitterItem1).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(fNgayKhenThuong);
            layoutControl1.Controls.Add(fMucKhenThuong);
            layoutControl1.Controls.Add(fLyDoKhenThuong);
            layoutControl1.Controls.Add(fHinhThucKhenThuong);
            layoutControl1.Controls.Add(fCanCuKhenThuong);
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
            // fNgayKhenThuong
            // 
            fNgayKhenThuong.EditValue = null;
            fNgayKhenThuong.Location = new Point(479, 417);
            fNgayKhenThuong.MenuManager = barManager1;
            fNgayKhenThuong.Name = "fNgayKhenThuong";
            fNgayKhenThuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fNgayKhenThuong.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fNgayKhenThuong.Size = new Size(895, 20);
            fNgayKhenThuong.StyleController = layoutControl1;
            fNgayKhenThuong.TabIndex = 8;
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
            // fMucKhenThuong
            // 
            fMucKhenThuong.Location = new Point(479, 393);
            fMucKhenThuong.MenuManager = barManager1;
            fMucKhenThuong.Name = "fMucKhenThuong";
            fMucKhenThuong.Size = new Size(895, 20);
            fMucKhenThuong.StyleController = layoutControl1;
            fMucKhenThuong.TabIndex = 7;
            // 
            // fLyDoKhenThuong
            // 
            fLyDoKhenThuong.Location = new Point(479, 193);
            fLyDoKhenThuong.MenuManager = barManager1;
            fLyDoKhenThuong.Name = "fLyDoKhenThuong";
            fLyDoKhenThuong.Size = new Size(895, 96);
            fLyDoKhenThuong.StyleController = layoutControl1;
            fLyDoKhenThuong.TabIndex = 5;
            // 
            // fHinhThucKhenThuong
            // 
            fHinhThucKhenThuong.Location = new Point(479, 293);
            fHinhThucKhenThuong.MenuManager = barManager1;
            fHinhThucKhenThuong.Name = "fHinhThucKhenThuong";
            fHinhThucKhenThuong.Size = new Size(895, 96);
            fHinhThucKhenThuong.StyleController = layoutControl1;
            fHinhThucKhenThuong.TabIndex = 6;
            // 
            // fCanCuKhenThuong
            // 
            fCanCuKhenThuong.Location = new Point(479, 93);
            fCanCuKhenThuong.MenuManager = barManager1;
            fCanCuKhenThuong.Name = "fCanCuKhenThuong";
            fCanCuKhenThuong.Size = new Size(895, 96);
            fCanCuKhenThuong.StyleController = layoutControl1;
            fCanCuKhenThuong.TabIndex = 4;
            // 
            // fIdNhanVien
            // 
            fIdNhanVien.Location = new Point(479, 69);
            fIdNhanVien.MenuManager = barManager1;
            fIdNhanVien.Name = "fIdNhanVien";
            fIdNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fIdNhanVien.Properties.PopupView = searchLookUpEdit1View;
            fIdNhanVien.Size = new Size(895, 20);
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
            fMaSo.Location = new Point(479, 45);
            fMaSo.MenuManager = barManager1;
            fMaSo.Name = "fMaSo";
            fMaSo.Size = new Size(895, 20);
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
            gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn7, gridColumn8, gridColumn9, gridColumn10, gridColumn11, gridColumn12 });
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
            // gridColumn4
            // 
            gridColumn4.Caption = "CanCuKhenThuong";
            gridColumn4.FieldName = "CanCuKhenThuong";
            gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "LyDoKhenThuong";
            gridColumn5.FieldName = "LyDoKhenThuong";
            gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "HinhThucKhenThuong";
            gridColumn6.FieldName = "HinhThucKhenThuong";
            gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "MucKhenThuong";
            gridColumn7.FieldName = "MucKhenThuong";
            gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            gridColumn8.Caption = "NgayKhenThuong";
            gridColumn8.FieldName = "NgayKhenThuong";
            gridColumn8.Name = "gridColumn8";
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
            layoutControlGroupEditControl.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2, emptySpaceItem1, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6, layoutControlItem7, layoutControlItem8 });
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
            layoutControlItem2.TextSize = new Size(156, 13);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 396);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(1067, 263);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = fIdNhanVien;
            layoutControlItem3.Location = new Point(0, 24);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(1067, 24);
            layoutControlItem3.Text = "Nhân viên được khen thưởng (*)";
            layoutControlItem3.TextSize = new Size(156, 13);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            layoutControlItem4.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            layoutControlItem4.Control = fCanCuKhenThuong;
            layoutControlItem4.Location = new Point(0, 48);
            layoutControlItem4.MaxSize = new Size(0, 100);
            layoutControlItem4.MinSize = new Size(136, 100);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(1067, 100);
            layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem4.Text = "Căn cứ khen thưởng (*)";
            layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            layoutControlItem4.TextSize = new Size(156, 13);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
            layoutControlItem5.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            layoutControlItem5.ContentVertAlignment = DevExpress.Utils.VertAlignment.Top;
            layoutControlItem5.Control = fHinhThucKhenThuong;
            layoutControlItem5.Location = new Point(0, 248);
            layoutControlItem5.MaxSize = new Size(0, 100);
            layoutControlItem5.MinSize = new Size(136, 100);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(1067, 100);
            layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem5.Text = "Hình thức khen thưởng (*)";
            layoutControlItem5.TextSize = new Size(156, 13);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            layoutControlItem6.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            layoutControlItem6.Control = fLyDoKhenThuong;
            layoutControlItem6.Location = new Point(0, 148);
            layoutControlItem6.MaxSize = new Size(0, 100);
            layoutControlItem6.MinSize = new Size(136, 100);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(1067, 100);
            layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem6.Text = "Lý do khen thưởng (*)";
            layoutControlItem6.TextSize = new Size(156, 13);
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = fMucKhenThuong;
            layoutControlItem7.Location = new Point(0, 348);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new Size(1067, 24);
            layoutControlItem7.Text = "Mức khen thưởng (*)";
            layoutControlItem7.TextSize = new Size(156, 13);
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.Control = fNgayKhenThuong;
            layoutControlItem8.Location = new Point(0, 372);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.Size = new Size(1067, 24);
            layoutControlItem8.Text = "Ngày khen thưởng (*)";
            layoutControlItem8.TextSize = new Size(156, 13);
            // 
            // splitterItem1
            // 
            splitterItem1.AllowHotTrack = true;
            splitterItem1.Location = new Point(277, 0);
            splitterItem1.Name = "splitterItem1";
            splitterItem1.Size = new Size(10, 704);
            // 
            // FrmKhenThuong
            // 
            ClientSize = new Size(1398, 768);
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "FrmKhenThuong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khen thưởng";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fNgayKhenThuong.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fNgayKhenThuong.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fMucKhenThuong.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fLyDoKhenThuong.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fHinhThucKhenThuong.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fCanCuKhenThuong.Properties).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitterItem1).EndInit();
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
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repoNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.MemoEdit fCanCuKhenThuong;
        private DevExpress.XtraEditors.SearchLookUpEdit fIdNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.MemoEdit fHinhThucKhenThuong;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.MemoEdit fLyDoKhenThuong;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.DateEdit fNgayKhenThuong;
        private DevExpress.XtraEditors.TextEdit fMucKhenThuong;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}