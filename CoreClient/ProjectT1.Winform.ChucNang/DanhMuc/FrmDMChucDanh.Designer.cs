namespace ProjectY.Client.Winform {
    partial class FrmDMChucDanh {
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
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
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
            fKyHieuDanhMuc = new DevExpress.XtraEditors.TextEdit();
            fTen = new DevExpress.XtraEditors.TextEdit();
            fMaSo = new DevExpress.XtraEditors.TextEdit();
            gridControlMain = new DevExpress.XtraGrid.GridControl();
            gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroupMainData = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlGroupEditControl = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fKyHieuDanhMuc.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fTen.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fMaSo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroupMainData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroupEditControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitterItem1).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(fKyHieuDanhMuc);
            layoutControl1.Controls.Add(fTen);
            layoutControl1.Controls.Add(fMaSo);
            layoutControl1.Controls.Add(gridControlMain);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 20);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(1398, 728);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
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
            btnCreate.Name = "btnCreate";
            btnCreate.ItemClick += btnCreate_ItemClick;
            // 
            // btnEdit
            // 
            btnEdit.Caption = "Sửa";
            btnEdit.Id = 1;
            btnEdit.Name = "btnEdit";
            btnEdit.ItemClick += btnEdit_ItemClick;
            // 
            // btnDelete
            // 
            btnDelete.Caption = "Xoá";
            btnDelete.Id = 2;
            btnDelete.Name = "btnDelete";
            btnDelete.ItemClick += btnDelete_ItemClick;
            // 
            // btnSubmit
            // 
            btnSubmit.Caption = "Ghi";
            btnSubmit.Id = 3;
            btnSubmit.Name = "btnSubmit";
            btnSubmit.ItemClick += btnSubmit_ItemClick;
            // 
            // btnCancel
            // 
            btnCancel.Caption = "Bỏ qua";
            btnCancel.Id = 4;
            btnCancel.Name = "btnCancel";
            btnCancel.ItemClick += btnCancel_ItemClick;
            // 
            // btnRefresh
            // 
            btnRefresh.Caption = "Làm mới";
            btnRefresh.Id = 5;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ItemClick += btnRefresh_ItemClick;
            // 
            // btnClose
            // 
            btnClose.Caption = "Đóng";
            btnClose.Id = 6;
            btnClose.Name = "btnClose";
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
            barDockControlTop.Size = new Size(1398, 20);
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
            barDockControlLeft.Location = new Point(0, 20);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 728);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1398, 20);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 728);
            // 
            // fKyHieuDanhMuc
            // 
            fKyHieuDanhMuc.Location = new Point(432, 93);
            fKyHieuDanhMuc.MenuManager = barManager1;
            fKyHieuDanhMuc.Name = "fKyHieuDanhMuc";
            fKyHieuDanhMuc.Size = new Size(942, 20);
            fKyHieuDanhMuc.StyleController = layoutControl1;
            fKyHieuDanhMuc.TabIndex = 4;
            // 
            // fTen
            // 
            fTen.Location = new Point(432, 69);
            fTen.MenuManager = barManager1;
            fTen.Name = "fTen";
            fTen.Size = new Size(942, 20);
            fTen.StyleController = layoutControl1;
            fTen.TabIndex = 3;
            // 
            // fMaSo
            // 
            fMaSo.Location = new Point(432, 45);
            fMaSo.MenuManager = barManager1;
            fMaSo.Name = "fMaSo";
            fMaSo.Size = new Size(942, 20);
            fMaSo.StyleController = layoutControl1;
            fMaSo.TabIndex = 2;
            // 
            // gridControlMain
            // 
            gridControlMain.Location = new Point(24, 45);
            gridControlMain.MainView = gridViewMain;
            gridControlMain.MenuManager = barManager1;
            gridControlMain.Name = "gridControlMain";
            gridControlMain.Size = new Size(313, 659);
            gridControlMain.TabIndex = 0;
            gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewMain });
            // 
            // gridViewMain
            // 
            gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6 });
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
            gridColumn3.Caption = "Tên";
            gridColumn3.FieldName = "Ten";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "KyHieuDanhMuc";
            gridColumn4.FieldName = "KyHieuDanhMuc";
            gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "IdLinhVucApDung";
            gridColumn5.FieldName = "IdLinhVucApDung";
            gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "DuocApDung";
            gridColumn6.FieldName = "DuocApDung";
            gridColumn6.Name = "gridColumn6";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroupMainData, layoutControlGroupEditControl, splitterItem1 });
            Root.Name = "Root";
            Root.Size = new Size(1398, 728);
            Root.TextVisible = false;
            // 
            // layoutControlGroupMainData
            // 
            layoutControlGroupMainData.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            layoutControlGroupMainData.Location = new Point(0, 0);
            layoutControlGroupMainData.Name = "layoutControlGroupMainData";
            layoutControlGroupMainData.Size = new Size(341, 708);
            layoutControlGroupMainData.Text = "Danh sách dữ liệu";
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gridControlMain;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(317, 663);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroupEditControl
            // 
            layoutControlGroupEditControl.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2, layoutControlItem10, layoutControlItem16, emptySpaceItem1 });
            layoutControlGroupEditControl.Location = new Point(351, 0);
            layoutControlGroupEditControl.Name = "layoutControlGroupEditControl";
            layoutControlGroupEditControl.Size = new Size(1027, 708);
            layoutControlGroupEditControl.Text = "Thông tin";
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = fMaSo;
            layoutControlItem2.Location = new Point(0, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(1003, 24);
            layoutControlItem2.Text = "Mã số (*)";
            layoutControlItem2.TextSize = new Size(45, 13);
            // 
            // layoutControlItem10
            // 
            layoutControlItem10.Control = fTen;
            layoutControlItem10.Location = new Point(0, 24);
            layoutControlItem10.Name = "layoutControlItem10";
            layoutControlItem10.Size = new Size(1003, 24);
            layoutControlItem10.Text = "Tên (*)";
            layoutControlItem10.TextSize = new Size(45, 13);
            // 
            // layoutControlItem16
            // 
            layoutControlItem16.Control = fKyHieuDanhMuc;
            layoutControlItem16.Location = new Point(0, 48);
            layoutControlItem16.Name = "layoutControlItem16";
            layoutControlItem16.Size = new Size(1003, 24);
            layoutControlItem16.Text = "Viết tắt";
            layoutControlItem16.TextSize = new Size(45, 13);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 72);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(1003, 591);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // splitterItem1
            // 
            splitterItem1.AllowHotTrack = true;
            splitterItem1.Location = new Point(341, 0);
            splitterItem1.Name = "splitterItem1";
            splitterItem1.Size = new Size(10, 708);
            // 
            // FrmDMChucDanh
            // 
            ClientSize = new Size(1398, 768);
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "FrmDMChucDanh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DM Hình thức quản lý";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fKyHieuDanhMuc.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fTen.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fMaSo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroupMainData).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroupEditControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem10).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem16).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
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
        private DevExpress.XtraEditors.TextEdit fKyHieuDanhMuc;
        private DevExpress.XtraEditors.TextEdit fTen;
        private DevExpress.XtraEditors.TextEdit fMaSo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
    }
}