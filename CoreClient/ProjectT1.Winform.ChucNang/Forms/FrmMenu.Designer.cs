namespace ProjectT1.CoreClient {
    partial class FrmMenu {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar1 = new DevExpress.XtraBars.Bar();
            btnHome = new DevExpress.XtraBars.BarButtonItem();
            btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            btnDanhMuc = new DevExpress.XtraBars.BarListItem();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
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
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnHome, btnNhanVien, barButtonItem1, btnDanhMuc });
            barManager1.MaxItemId = 4;
            barManager1.StatusBar = bar3;
            // 
            // bar1
            // 
            bar1.BarName = "Tools";
            bar1.DockCol = 0;
            bar1.DockRow = 0;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.FloatLocation = new Point(49, 134);
            bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnHome, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnNhanVien, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnDanhMuc, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph) });
            bar1.Text = "Tools";
            // 
            // btnHome
            // 
            btnHome.Caption = "Home";
            btnHome.Id = 0;
            btnHome.ImageOptions.Image = (Image)resources.GetObject("btnHome.ImageOptions.Image");
            btnHome.ImageOptions.LargeImage = (Image)resources.GetObject("btnHome.ImageOptions.LargeImage");
            btnHome.Name = "btnHome";
            // 
            // btnNhanVien
            // 
            btnNhanVien.Caption = "Quản lý nhân viên";
            btnNhanVien.Id = 1;
            btnNhanVien.ImageOptions.Image = (Image)resources.GetObject("btnNhanVien.ImageOptions.Image");
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.ItemClick += btnNhanVien_ItemClick;
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.Caption = "Quản lý danh mục";
            btnDanhMuc.Id = 3;
            btnDanhMuc.ImageOptions.Image = (Image)resources.GetObject("btnDanhMuc.ImageOptions.Image");
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.ListItemClick += btnDanhMuc_ListItemClick;
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
            barDockControlTop.Size = new Size(1297, 24);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 669);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(1297, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 24);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 645);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1297, 24);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 645);
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "barButtonItem1";
            barButtonItem1.Id = 2;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 689);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "FrmMenu";
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnHome;
        private DevExpress.XtraBars.BarListItem btnDanhMuc;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}