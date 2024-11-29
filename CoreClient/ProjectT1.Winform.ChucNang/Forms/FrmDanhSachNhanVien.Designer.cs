namespace Project.Client.Winform {
    partial class FrmDanhSachNhanVien {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhSachNhanVien));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar1 = new DevExpress.XtraBars.Bar();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            gridControlMain = new DevExpress.XtraGrid.GridControl();
            gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            repoNgay = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            repoChiTiet = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            repoIdPhongBan = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            repoIdChucDanh = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            repositoryItemSearchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoNgay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoNgay.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoChiTiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoIdPhongBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemSearchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoIdChucDanh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemSearchLookUpEdit2View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            SuspendLayout();
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1, bar3 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItem1 });
            barManager1.MaxItemId = 1;
            barManager1.StatusBar = bar3;
            // 
            // bar1
            // 
            bar1.BarName = "Tools";
            bar1.DockCol = 0;
            bar1.DockRow = 0;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph) });
            bar1.Text = "Tools";
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Home";
            barButtonItem1.Id = 0;
            barButtonItem1.ImageOptions.Image = (Image)resources.GetObject("barButtonItem1.ImageOptions.Image");
            barButtonItem1.Name = "barButtonItem1";
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
            barDockControlTop.Size = new Size(1207, 24);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 642);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(1207, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 24);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 618);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1207, 24);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 618);
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(gridControlMain);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 24);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(1207, 618);
            layoutControl1.TabIndex = 4;
            layoutControl1.Text = "layoutControl1";
            // 
            // gridControlMain
            // 
            gridControlMain.Location = new Point(12, 12);
            gridControlMain.MainView = gridViewMain;
            gridControlMain.MenuManager = barManager1;
            gridControlMain.Name = "gridControlMain";
            gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repoIdPhongBan, repoIdChucDanh, repoChiTiet, repoNgay });
            gridControlMain.Size = new Size(1183, 594);
            gridControlMain.TabIndex = 3;
            gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewMain });
            // 
            // gridViewMain
            // 
            gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn7, gridColumn2, gridColumn8 });
            gridViewMain.GridControl = gridControlMain;
            gridViewMain.Name = "gridViewMain";
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Oid";
            gridColumn1.FieldName = "Oid";
            gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "Tên nhân viên";
            gridColumn3.FieldName = "Ten";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "Giới tính";
            gridColumn4.FieldName = "GioiTinh";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "Ngày sinh";
            gridColumn5.ColumnEdit = repoNgay;
            gridColumn5.FieldName = "NgaySinh";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 2;
            // 
            // repoNgay
            // 
            repoNgay.AutoHeight = false;
            repoNgay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repoNgay.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repoNgay.Name = "repoNgay";
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "Phòng ban";
            gridColumn6.FieldName = "IdPhongBan";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 3;
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "Chức danh";
            gridColumn7.FieldName = "IdChucDanh";
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 4;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Hình ảnh";
            gridColumn2.FieldName = "Avatar";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 5;
            // 
            // gridColumn8
            // 
            gridColumn8.Caption = "Chi tiết";
            gridColumn8.ColumnEdit = repoChiTiet;
            gridColumn8.FieldName = "ChiTiet";
            gridColumn8.Name = "gridColumn8";
            gridColumn8.Visible = true;
            gridColumn8.VisibleIndex = 6;
            // 
            // repoChiTiet
            // 
            repoChiTiet.AutoHeight = false;
            editorButtonImageOptions1.ImageUri.Uri = "Show";
            editorButtonImageOptions1.SvgImageSize = new Size(15, 15);
            repoChiTiet.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            repoChiTiet.Name = "repoChiTiet";
            repoChiTiet.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repoChiTiet.Click += repoChiTiet_Click;
            // 
            // repoIdPhongBan
            // 
            repoIdPhongBan.AutoHeight = false;
            repoIdPhongBan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repoIdPhongBan.Name = "repoIdPhongBan";
            repoIdPhongBan.NullText = "";
            repoIdPhongBan.PopupView = repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // repoIdChucDanh
            // 
            repoIdChucDanh.AutoHeight = false;
            repoIdChucDanh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repoIdChucDanh.Name = "repoIdChucDanh";
            repoIdChucDanh.NullText = "";
            repoIdChucDanh.PopupView = repositoryItemSearchLookUpEdit2View;
            // 
            // repositoryItemSearchLookUpEdit2View
            // 
            repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
            repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new Size(1207, 618);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gridControlMain;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(1187, 598);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // FrmDanhSachNhanVien
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 662);
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "FrmDanhSachNhanVien";
            Text = "FrmNhanVien";
            Load += FrmDanhSachNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoNgay.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoNgay).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoChiTiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoIdPhongBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemSearchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoIdChucDanh).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemSearchLookUpEdit2View).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoChiTiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repoIdPhongBan;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repoIdChucDanh;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repoNgay;
    }
}