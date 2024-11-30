namespace ProjectT1.CoreClient {
    partial class FrmMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar1 = new DevExpress.XtraBars.Bar();
            btnCnNguoiDung = new DevExpress.XtraBars.BarSubItem();
            btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            btnCnDanhMuc = new DevExpress.XtraBars.BarSubItem();
            btnDmChucVu = new DevExpress.XtraBars.BarButtonItem();
            btnDmPhongBan = new DevExpress.XtraBars.BarButtonItem();
            btnDmTrinhDoHocVan = new DevExpress.XtraBars.BarButtonItem();
            btnCnDsNhanVien = new DevExpress.XtraBars.BarButtonItem();
            btnCnKhenThuong = new DevExpress.XtraBars.BarButtonItem();
            btnCnKyLuat = new DevExpress.XtraBars.BarButtonItem();
            btnCnTroGiup = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(pictureBox1);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 24);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(1198, 724);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.background;
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1174, 700);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(1198, 724);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = pictureBox1;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(1178, 704);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1, bar3 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnCnDsNhanVien, btnCnKhenThuong, btnCnKyLuat, btnCnTroGiup, btnCnDanhMuc, btnDmChucVu, btnDmPhongBan, btnDmTrinhDoHocVan, btnCnNguoiDung, btnDoiMatKhau, btnDangXuat });
            barManager1.MaxItemId = 15;
            barManager1.StatusBar = bar3;
            // 
            // bar1
            // 
            bar1.BarName = "Tools";
            bar1.DockCol = 0;
            bar1.DockRow = 0;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnCnNguoiDung), new DevExpress.XtraBars.LinkPersistInfo(btnCnDanhMuc), new DevExpress.XtraBars.LinkPersistInfo(btnCnDsNhanVien), new DevExpress.XtraBars.LinkPersistInfo(btnCnKhenThuong), new DevExpress.XtraBars.LinkPersistInfo(btnCnKyLuat), new DevExpress.XtraBars.LinkPersistInfo(btnCnTroGiup) });
            bar1.Text = "Tools";
            // 
            // btnCnNguoiDung
            // 
            btnCnNguoiDung.Caption = "Người dùng";
            btnCnNguoiDung.Id = 12;
            btnCnNguoiDung.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnCnNguoiDung.ImageOptions.Image");
            btnCnNguoiDung.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnDoiMatKhau), new DevExpress.XtraBars.LinkPersistInfo(btnDangXuat) });
            btnCnNguoiDung.Name = "btnCnNguoiDung";
            btnCnNguoiDung.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Caption = "Đổi mật khẩu";
            btnDoiMatKhau.Id = 13;
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.ItemClick += btnDoiMatKhau_ItemClick;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Caption = "Đăng xuất";
            btnDangXuat.Id = 14;
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.ItemClick += btnDangXuat_ItemClick;
            // 
            // btnCnDanhMuc
            // 
            btnCnDanhMuc.Caption = "Danh mục";
            btnCnDanhMuc.Id = 7;
            btnCnDanhMuc.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnCnDanhMuc.ImageOptions.Image");
            btnCnDanhMuc.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnDmChucVu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(btnDmPhongBan), new DevExpress.XtraBars.LinkPersistInfo(btnDmTrinhDoHocVan) });
            btnCnDanhMuc.Name = "btnCnDanhMuc";
            btnCnDanhMuc.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnDmChucVu
            // 
            btnDmChucVu.Caption = "Chức vụ";
            btnDmChucVu.Id = 8;
            btnDmChucVu.Name = "btnDmChucVu";
            btnDmChucVu.ItemClick += btnDmChucVu_ItemClick;
            // 
            // btnDmPhongBan
            // 
            btnDmPhongBan.Caption = "Phòng ban";
            btnDmPhongBan.Id = 9;
            btnDmPhongBan.Name = "btnDmPhongBan";
            btnDmPhongBan.ItemClick += btnDmPhongBan_ItemClick;
            // 
            // btnDmTrinhDoHocVan
            // 
            btnDmTrinhDoHocVan.Caption = "Trình độ học vấn";
            btnDmTrinhDoHocVan.Id = 10;
            btnDmTrinhDoHocVan.Name = "btnDmTrinhDoHocVan";
            btnDmTrinhDoHocVan.ItemClick += btnDmTrinhDoHocVan_ItemClick;
            // 
            // btnCnDsNhanVien
            // 
            btnCnDsNhanVien.Caption = "DS Nhân viên";
            btnCnDsNhanVien.Id = 3;
            btnCnDsNhanVien.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnCnDsNhanVien.ImageOptions.Image");
            btnCnDsNhanVien.Name = "btnCnDsNhanVien";
            btnCnDsNhanVien.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnCnDsNhanVien.ItemClick += btnCnDsNhanVien_ItemClick;
            // 
            // btnCnKhenThuong
            // 
            btnCnKhenThuong.Caption = "Khen thưởng";
            btnCnKhenThuong.Id = 4;
            btnCnKhenThuong.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnCnKhenThuong.ImageOptions.Image");
            btnCnKhenThuong.Name = "btnCnKhenThuong";
            btnCnKhenThuong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnCnKhenThuong.ItemClick += btnCnKhenThuong_ItemClick;
            // 
            // btnCnKyLuat
            // 
            btnCnKyLuat.Caption = "Kỷ luật";
            btnCnKyLuat.Id = 5;
            btnCnKyLuat.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnCnKyLuat.ImageOptions.Image");
            btnCnKyLuat.Name = "btnCnKyLuat";
            btnCnKyLuat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnCnKyLuat.ItemClick += btnCnKyLuat_ItemClick;
            // 
            // btnCnTroGiup
            // 
            btnCnTroGiup.Caption = "Trợ giúp";
            btnCnTroGiup.Id = 6;
            btnCnTroGiup.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnCnTroGiup.ImageOptions.Image");
            btnCnTroGiup.Name = "btnCnTroGiup";
            btnCnTroGiup.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnCnTroGiup.ItemClick += btnCnTroGiup_ItemClick;
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
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new System.Drawing.Size(1198, 24);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 748);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new System.Drawing.Size(1198, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new System.Drawing.Size(0, 724);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(1198, 24);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new System.Drawing.Size(0, 724);
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1198, 768);
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "FrmMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ NHÂN SỰ";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnCnDsNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnCnKhenThuong;
        private DevExpress.XtraBars.BarButtonItem btnCnKyLuat;
        private DevExpress.XtraBars.BarButtonItem btnCnTroGiup;
        private DevExpress.XtraBars.BarSubItem btnCnDanhMuc;
        private DevExpress.XtraBars.BarButtonItem btnDmChucVu;
        private DevExpress.XtraBars.BarButtonItem btnDmPhongBan;
        private DevExpress.XtraBars.BarButtonItem btnDmTrinhDoHocVan;
        private DevExpress.XtraBars.BarSubItem btnCnNguoiDung;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}

