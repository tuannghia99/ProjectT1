using System.Drawing;
using System.Windows.Forms;

namespace ProjectT1.CoreClient {
    partial class FrmNhanVien {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            fModifiedDate = new DevExpress.XtraEditors.DateEdit();
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
            fCreateDate = new DevExpress.XtraEditors.DateEdit();
            fEmail = new DevExpress.XtraEditors.TextEdit();
            fPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            fUsername = new DevExpress.XtraEditors.TextEdit();
            btnRemoveAvatar = new DevExpress.XtraEditors.SimpleButton();
            btnUploadAvatar = new DevExpress.XtraEditors.SimpleButton();
            fCanNang = new DevExpress.XtraEditors.TextEdit();
            fChieuCao = new DevExpress.XtraEditors.TextEdit();
            fTinhTrangSucKhoe = new DevExpress.XtraEditors.TextEdit();
            fNoiCap = new DevExpress.XtraEditors.TextEdit();
            fNgayCap = new DevExpress.XtraEditors.DateEdit();
            fSoCanCuoc = new DevExpress.XtraEditors.TextEdit();
            fIdTrinhDoHocVan = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            fIdChucVu = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            fIdPhongBan = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            fTinHoc = new DevExpress.XtraEditors.TextEdit();
            fNgoaiNgu = new DevExpress.XtraEditors.TextEdit();
            fTinhTrangHonNhan = new DevExpress.XtraEditors.TextEdit();
            fDiaChi = new DevExpress.XtraEditors.TextEdit();
            fTonGiao = new DevExpress.XtraEditors.TextEdit();
            fDanToc = new DevExpress.XtraEditors.TextEdit();
            fQuocTich = new DevExpress.XtraEditors.TextEdit();
            fNoiSinh = new DevExpress.XtraEditors.TextEdit();
            fGioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            fNgaySinh = new DevExpress.XtraEditors.DateEdit();
            fTen = new DevExpress.XtraEditors.TextEdit();
            fMaSo = new DevExpress.XtraEditors.TextEdit();
            gridControlMain = new DevExpress.XtraGrid.GridControl();
            gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            repoNhanVien = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroupMainData = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlGroupEditControl = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem26 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem27 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem28 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem29 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem31 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            fAvatar = new DevExpress.XtraEditors.PictureEdit();
            layoutControlItem24 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fModifiedDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fModifiedDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fCreateDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fCreateDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fPhoneNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fUsername.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fCanNang.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fChieuCao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fTinhTrangSucKhoe.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fNoiCap.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fNgayCap.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fNgayCap.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fSoCanCuoc.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fIdTrinhDoHocVan.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit3View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fIdChucVu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit2View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fIdPhongBan.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fTinHoc.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fNgoaiNgu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fTinhTrangHonNhan.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fDiaChi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fTonGiao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fDanToc.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fQuocTich.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fNoiSinh.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fGioiTinh.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fNgaySinh.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fNgaySinh.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fTen.Properties).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem23).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem26).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem27).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem28).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem29).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem31).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitterItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateTimeChartRangeControlClient1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fAvatar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem24).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(fAvatar);
            layoutControl1.Controls.Add(fModifiedDate);
            layoutControl1.Controls.Add(fCreateDate);
            layoutControl1.Controls.Add(fEmail);
            layoutControl1.Controls.Add(fPhoneNumber);
            layoutControl1.Controls.Add(fUsername);
            layoutControl1.Controls.Add(btnRemoveAvatar);
            layoutControl1.Controls.Add(btnUploadAvatar);
            layoutControl1.Controls.Add(fCanNang);
            layoutControl1.Controls.Add(fChieuCao);
            layoutControl1.Controls.Add(fTinhTrangSucKhoe);
            layoutControl1.Controls.Add(fNoiCap);
            layoutControl1.Controls.Add(fNgayCap);
            layoutControl1.Controls.Add(fSoCanCuoc);
            layoutControl1.Controls.Add(fIdTrinhDoHocVan);
            layoutControl1.Controls.Add(fIdChucVu);
            layoutControl1.Controls.Add(fIdPhongBan);
            layoutControl1.Controls.Add(fTinHoc);
            layoutControl1.Controls.Add(fNgoaiNgu);
            layoutControl1.Controls.Add(fTinhTrangHonNhan);
            layoutControl1.Controls.Add(fDiaChi);
            layoutControl1.Controls.Add(fTonGiao);
            layoutControl1.Controls.Add(fDanToc);
            layoutControl1.Controls.Add(fQuocTich);
            layoutControl1.Controls.Add(fNoiSinh);
            layoutControl1.Controls.Add(fGioiTinh);
            layoutControl1.Controls.Add(fNgaySinh);
            layoutControl1.Controls.Add(fTen);
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
            // fModifiedDate
            // 
            fModifiedDate.EditValue = null;
            fModifiedDate.Location = new Point(998, 414);
            fModifiedDate.MenuManager = barManager1;
            fModifiedDate.Name = "fModifiedDate";
            fModifiedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fModifiedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fModifiedDate.Size = new Size(364, 20);
            fModifiedDate.StyleController = layoutControl1;
            fModifiedDate.TabIndex = 23;
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
            // fCreateDate
            // 
            fCreateDate.EditValue = null;
            fCreateDate.Location = new Point(998, 390);
            fCreateDate.MenuManager = barManager1;
            fCreateDate.Name = "fCreateDate";
            fCreateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fCreateDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fCreateDate.Size = new Size(364, 20);
            fCreateDate.StyleController = layoutControl1;
            fCreateDate.TabIndex = 22;
            // 
            // fEmail
            // 
            fEmail.Location = new Point(998, 366);
            fEmail.MenuManager = barManager1;
            fEmail.Name = "fEmail";
            fEmail.Size = new Size(364, 20);
            fEmail.StyleController = layoutControl1;
            fEmail.TabIndex = 21;
            // 
            // fPhoneNumber
            // 
            fPhoneNumber.Location = new Point(998, 342);
            fPhoneNumber.MenuManager = barManager1;
            fPhoneNumber.Name = "fPhoneNumber";
            fPhoneNumber.Size = new Size(364, 20);
            fPhoneNumber.StyleController = layoutControl1;
            fPhoneNumber.TabIndex = 20;
            // 
            // fUsername
            // 
            fUsername.Location = new Point(998, 318);
            fUsername.MenuManager = barManager1;
            fUsername.Name = "fUsername";
            fUsername.Size = new Size(364, 20);
            fUsername.StyleController = layoutControl1;
            fUsername.TabIndex = 19;
            // 
            // btnRemoveAvatar
            // 
            btnRemoveAvatar.ImageOptions.Image = (Image)resources.GetObject("btnRemoveAvatar.ImageOptions.Image");
            btnRemoveAvatar.Location = new Point(397, 259);
            btnRemoveAvatar.Name = "btnRemoveAvatar";
            btnRemoveAvatar.Size = new Size(77, 22);
            btnRemoveAvatar.StyleController = layoutControl1;
            btnRemoveAvatar.TabIndex = 12;
            btnRemoveAvatar.Text = "Xoá ảnh";
            btnRemoveAvatar.Click += btnRemoveAvatar_Click;
            // 
            // btnUploadAvatar
            // 
            btnUploadAvatar.ImageOptions.Image = (Image)resources.GetObject("btnUploadAvatar.ImageOptions.Image");
            btnUploadAvatar.Location = new Point(311, 259);
            btnUploadAvatar.Name = "btnUploadAvatar";
            btnUploadAvatar.Size = new Size(82, 22);
            btnUploadAvatar.StyleController = layoutControl1;
            btnUploadAvatar.TabIndex = 11;
            btnUploadAvatar.Text = "Tải ảnh";
            btnUploadAvatar.Click += btnUploadAvatar_Click;
            // 
            // fCanNang
            // 
            fCanNang.Location = new Point(998, 531);
            fCanNang.MenuManager = barManager1;
            fCanNang.Name = "fCanNang";
            fCanNang.Size = new Size(364, 20);
            fCanNang.StyleController = layoutControl1;
            fCanNang.TabIndex = 29;
            // 
            // fChieuCao
            // 
            fChieuCao.Location = new Point(998, 507);
            fChieuCao.MenuManager = barManager1;
            fChieuCao.Name = "fChieuCao";
            fChieuCao.Size = new Size(364, 20);
            fChieuCao.StyleController = layoutControl1;
            fChieuCao.TabIndex = 28;
            // 
            // fTinhTrangSucKhoe
            // 
            fTinhTrangSucKhoe.Location = new Point(998, 483);
            fTinhTrangSucKhoe.MenuManager = barManager1;
            fTinhTrangSucKhoe.Name = "fTinhTrangSucKhoe";
            fTinhTrangSucKhoe.Size = new Size(364, 20);
            fTinhTrangSucKhoe.StyleController = layoutControl1;
            fTinhTrangSucKhoe.TabIndex = 27;
            // 
            // fNoiCap
            // 
            fNoiCap.Location = new Point(453, 531);
            fNoiCap.MenuManager = barManager1;
            fNoiCap.Name = "fNoiCap";
            fNoiCap.Size = new Size(387, 20);
            fNoiCap.StyleController = layoutControl1;
            fNoiCap.TabIndex = 26;
            // 
            // fNgayCap
            // 
            fNgayCap.EditValue = null;
            fNgayCap.Location = new Point(453, 507);
            fNgayCap.MenuManager = barManager1;
            fNgayCap.Name = "fNgayCap";
            fNgayCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fNgayCap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fNgayCap.Size = new Size(387, 20);
            fNgayCap.StyleController = layoutControl1;
            fNgayCap.TabIndex = 25;
            // 
            // fSoCanCuoc
            // 
            fSoCanCuoc.Location = new Point(453, 483);
            fSoCanCuoc.MenuManager = barManager1;
            fSoCanCuoc.Name = "fSoCanCuoc";
            fSoCanCuoc.Size = new Size(387, 20);
            fSoCanCuoc.StyleController = layoutControl1;
            fSoCanCuoc.TabIndex = 24;
            // 
            // fIdTrinhDoHocVan
            // 
            fIdTrinhDoHocVan.Location = new Point(453, 366);
            fIdTrinhDoHocVan.MenuManager = barManager1;
            fIdTrinhDoHocVan.Name = "fIdTrinhDoHocVan";
            fIdTrinhDoHocVan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fIdTrinhDoHocVan.Properties.PopupView = searchLookUpEdit3View;
            fIdTrinhDoHocVan.Size = new Size(387, 20);
            fIdTrinhDoHocVan.StyleController = layoutControl1;
            fIdTrinhDoHocVan.TabIndex = 16;
            // 
            // searchLookUpEdit3View
            // 
            searchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit3View.Name = "searchLookUpEdit3View";
            searchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // fIdChucVu
            // 
            fIdChucVu.Location = new Point(453, 342);
            fIdChucVu.MenuManager = barManager1;
            fIdChucVu.Name = "fIdChucVu";
            fIdChucVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fIdChucVu.Properties.PopupView = searchLookUpEdit2View;
            fIdChucVu.Size = new Size(387, 20);
            fIdChucVu.StyleController = layoutControl1;
            fIdChucVu.TabIndex = 15;
            // 
            // searchLookUpEdit2View
            // 
            searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // fIdPhongBan
            // 
            fIdPhongBan.Location = new Point(453, 318);
            fIdPhongBan.MenuManager = barManager1;
            fIdPhongBan.Name = "fIdPhongBan";
            fIdPhongBan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fIdPhongBan.Properties.PopupView = searchLookUpEdit1View;
            fIdPhongBan.Size = new Size(387, 20);
            fIdPhongBan.StyleController = layoutControl1;
            fIdPhongBan.TabIndex = 14;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // fTinHoc
            // 
            fTinHoc.Location = new Point(453, 414);
            fTinHoc.MenuManager = barManager1;
            fTinHoc.Name = "fTinHoc";
            fTinHoc.Size = new Size(387, 20);
            fTinHoc.StyleController = layoutControl1;
            fTinHoc.TabIndex = 18;
            // 
            // fNgoaiNgu
            // 
            fNgoaiNgu.Location = new Point(453, 390);
            fNgoaiNgu.MenuManager = barManager1;
            fNgoaiNgu.Name = "fNgoaiNgu";
            fNgoaiNgu.Size = new Size(387, 20);
            fNgoaiNgu.StyleController = layoutControl1;
            fNgoaiNgu.TabIndex = 17;
            // 
            // fTinhTrangHonNhan
            // 
            fTinhTrangHonNhan.Location = new Point(608, 261);
            fTinhTrangHonNhan.MenuManager = barManager1;
            fTinhTrangHonNhan.Name = "fTinhTrangHonNhan";
            fTinhTrangHonNhan.Size = new Size(766, 20);
            fTinhTrangHonNhan.StyleController = layoutControl1;
            fTinhTrangHonNhan.TabIndex = 13;
            // 
            // fDiaChi
            // 
            fDiaChi.Location = new Point(608, 165);
            fDiaChi.MenuManager = barManager1;
            fDiaChi.Name = "fDiaChi";
            fDiaChi.Size = new Size(766, 20);
            fDiaChi.StyleController = layoutControl1;
            fDiaChi.TabIndex = 7;
            // 
            // fTonGiao
            // 
            fTonGiao.Location = new Point(608, 237);
            fTonGiao.MenuManager = barManager1;
            fTonGiao.Name = "fTonGiao";
            fTonGiao.Size = new Size(766, 20);
            fTonGiao.StyleController = layoutControl1;
            fTonGiao.TabIndex = 10;
            // 
            // fDanToc
            // 
            fDanToc.Location = new Point(608, 213);
            fDanToc.MenuManager = barManager1;
            fDanToc.Name = "fDanToc";
            fDanToc.Size = new Size(766, 20);
            fDanToc.StyleController = layoutControl1;
            fDanToc.TabIndex = 9;
            // 
            // fQuocTich
            // 
            fQuocTich.Location = new Point(608, 189);
            fQuocTich.MenuManager = barManager1;
            fQuocTich.Name = "fQuocTich";
            fQuocTich.Size = new Size(766, 20);
            fQuocTich.StyleController = layoutControl1;
            fQuocTich.TabIndex = 8;
            // 
            // fNoiSinh
            // 
            fNoiSinh.Location = new Point(608, 141);
            fNoiSinh.MenuManager = barManager1;
            fNoiSinh.Name = "fNoiSinh";
            fNoiSinh.Size = new Size(766, 20);
            fNoiSinh.StyleController = layoutControl1;
            fNoiSinh.TabIndex = 6;
            // 
            // fGioiTinh
            // 
            fGioiTinh.Location = new Point(608, 117);
            fGioiTinh.MenuManager = barManager1;
            fGioiTinh.Name = "fGioiTinh";
            fGioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fGioiTinh.Size = new Size(766, 20);
            fGioiTinh.StyleController = layoutControl1;
            fGioiTinh.TabIndex = 5;
            // 
            // fNgaySinh
            // 
            fNgaySinh.EditValue = null;
            fNgaySinh.Location = new Point(608, 93);
            fNgaySinh.MenuManager = barManager1;
            fNgaySinh.Name = "fNgaySinh";
            fNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            fNgaySinh.Size = new Size(766, 20);
            fNgaySinh.StyleController = layoutControl1;
            fNgaySinh.TabIndex = 4;
            // 
            // fTen
            // 
            fTen.Location = new Point(608, 69);
            fTen.MenuManager = barManager1;
            fTen.Name = "fTen";
            fTen.Size = new Size(766, 20);
            fTen.StyleController = layoutControl1;
            fTen.TabIndex = 3;
            // 
            // fMaSo
            // 
            fMaSo.Location = new Point(608, 45);
            fMaSo.MenuManager = barManager1;
            fMaSo.Name = "fMaSo";
            fMaSo.Size = new Size(766, 20);
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
            gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn17, gridColumn16, gridColumn15, gridColumn14, gridColumn13, gridColumn8, gridColumn7, gridColumn6, gridColumn5, gridColumn4, gridColumn3, gridColumn26, gridColumn25, gridColumn24, gridColumn23, gridColumn22, gridColumn21, gridColumn20, gridColumn19, gridColumn18, gridColumn32, gridColumn31, gridColumn30, gridColumn29, gridColumn28, gridColumn27, gridColumn9, gridColumn10, gridColumn11, gridColumn12 });
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
            // gridColumn17
            // 
            gridColumn17.Caption = "Tên";
            gridColumn17.FieldName = "Ten";
            gridColumn17.Name = "gridColumn17";
            gridColumn17.Visible = true;
            gridColumn17.VisibleIndex = 1;
            // 
            // gridColumn16
            // 
            gridColumn16.Caption = "NgaySinh";
            gridColumn16.FieldName = "NgaySinh";
            gridColumn16.Name = "gridColumn16";
            // 
            // gridColumn15
            // 
            gridColumn15.Caption = "GioiTinh";
            gridColumn15.FieldName = "GioiTinh";
            gridColumn15.Name = "gridColumn15";
            // 
            // gridColumn14
            // 
            gridColumn14.Caption = "NoiSinh";
            gridColumn14.FieldName = "NoiSinh";
            gridColumn14.Name = "gridColumn14";
            // 
            // gridColumn13
            // 
            gridColumn13.Caption = "DiaChi";
            gridColumn13.FieldName = "DiaChi";
            gridColumn13.Name = "gridColumn13";
            // 
            // gridColumn8
            // 
            gridColumn8.Caption = "QuocTich";
            gridColumn8.FieldName = "QuocTich";
            gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "DanToc";
            gridColumn7.FieldName = "DanToc";
            gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "TonGiao";
            gridColumn6.FieldName = "TonGiao";
            gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "TinhTrangHonNhan";
            gridColumn5.FieldName = "TinhTrangHonNhan";
            gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "NgoaiNgu";
            gridColumn4.FieldName = "NgoaiNgu";
            gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "TinHoc";
            gridColumn3.FieldName = "TinHoc";
            gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn26
            // 
            gridColumn26.Caption = "SoCanCuoc";
            gridColumn26.FieldName = "SoCanCuoc";
            gridColumn26.Name = "gridColumn26";
            // 
            // gridColumn25
            // 
            gridColumn25.Caption = "NgayCap";
            gridColumn25.FieldName = "NgayCap";
            gridColumn25.Name = "gridColumn25";
            // 
            // gridColumn24
            // 
            gridColumn24.Caption = "NoiCap";
            gridColumn24.FieldName = "NoiCap";
            gridColumn24.Name = "gridColumn24";
            // 
            // gridColumn23
            // 
            gridColumn23.Caption = "TinhTrangSucKhoe";
            gridColumn23.FieldName = "TinhTrangSucKhoe";
            gridColumn23.Name = "gridColumn23";
            // 
            // gridColumn22
            // 
            gridColumn22.Caption = "ChieuCao";
            gridColumn22.FieldName = "ChieuCao";
            gridColumn22.Name = "gridColumn22";
            // 
            // gridColumn21
            // 
            gridColumn21.Caption = "CanNang";
            gridColumn21.FieldName = "CanNang";
            gridColumn21.Name = "gridColumn21";
            // 
            // gridColumn20
            // 
            gridColumn20.Caption = "IdChucVu";
            gridColumn20.FieldName = "IdChucVu";
            gridColumn20.Name = "gridColumn20";
            // 
            // gridColumn19
            // 
            gridColumn19.Caption = "IdPhongBan";
            gridColumn19.FieldName = "IdPhongBan";
            gridColumn19.Name = "gridColumn19";
            // 
            // gridColumn18
            // 
            gridColumn18.Caption = "IdTrinhDoHocVan";
            gridColumn18.FieldName = "IdTrinhDoHocVan";
            gridColumn18.Name = "gridColumn18";
            // 
            // gridColumn32
            // 
            gridColumn32.Caption = "Username";
            gridColumn32.FieldName = "Username";
            gridColumn32.Name = "gridColumn32";
            // 
            // gridColumn31
            // 
            gridColumn31.Caption = "Password";
            gridColumn31.FieldName = "Password";
            gridColumn31.Name = "gridColumn31";
            // 
            // gridColumn30
            // 
            gridColumn30.Caption = "Avatar";
            gridColumn30.FieldName = "Avatar";
            gridColumn30.Name = "gridColumn30";
            // 
            // gridColumn29
            // 
            gridColumn29.Caption = "PhoneNumber";
            gridColumn29.FieldName = "PhoneNumber";
            gridColumn29.Name = "gridColumn29";
            // 
            // gridColumn28
            // 
            gridColumn28.Caption = "Email";
            gridColumn28.FieldName = "Email";
            gridColumn28.Name = "gridColumn28";
            // 
            // gridColumn27
            // 
            gridColumn27.Caption = "IsAdmin";
            gridColumn27.FieldName = "IsAdmin";
            gridColumn27.Name = "gridColumn27";
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
            layoutControlGroupEditControl.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2, emptySpaceItem1, layoutControlItem4, layoutControlItem6, layoutControlItem12, layoutControlItem7, layoutControlGroup1, layoutControlGroup2, layoutControlGroup3, layoutControlItem25, layoutControlItem26, layoutControlItem9, layoutControlItem5, layoutControlItem13, layoutControlGroup4, layoutControlItem11, layoutControlItem3, layoutControlItem24 });
            layoutControlGroupEditControl.Location = new Point(287, 0);
            layoutControlGroupEditControl.Name = "layoutControlGroupEditControl";
            layoutControlGroupEditControl.Size = new Size(1091, 704);
            layoutControlGroupEditControl.Text = "Thông tin nhân sự";
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = fMaSo;
            layoutControlItem2.Location = new Point(167, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(900, 24);
            layoutControlItem2.Text = "Mã số (*)";
            layoutControlItem2.TextSize = new Size(118, 13);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 522);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(1067, 137);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = fNgaySinh;
            layoutControlItem4.Location = new Point(167, 48);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(900, 24);
            layoutControlItem4.Text = "Ngày sinh (*)";
            layoutControlItem4.TextSize = new Size(118, 13);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = fNoiSinh;
            layoutControlItem6.Location = new Point(167, 96);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(900, 24);
            layoutControlItem6.Text = "Nơi sinh (*)";
            layoutControlItem6.TextSize = new Size(118, 13);
            // 
            // layoutControlItem12
            // 
            layoutControlItem12.Control = fDanToc;
            layoutControlItem12.Location = new Point(167, 168);
            layoutControlItem12.Name = "layoutControlItem12";
            layoutControlItem12.Size = new Size(900, 24);
            layoutControlItem12.Text = "Dân tộc (*)";
            layoutControlItem12.TextSize = new Size(118, 13);
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = fTinhTrangHonNhan;
            layoutControlItem7.Location = new Point(167, 216);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new Size(900, 24);
            layoutControlItem7.Text = "Trình trạng hôn nhân (*)";
            layoutControlItem7.TextSize = new Size(118, 13);
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem15, layoutControlItem16, layoutControlItem17, layoutControlItem8, layoutControlItem14 });
            layoutControlGroup1.Location = new Point(0, 240);
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new Size(545, 165);
            layoutControlGroup1.Text = "Thông tin công tác, học vấn";
            // 
            // layoutControlItem15
            // 
            layoutControlItem15.Control = fIdPhongBan;
            layoutControlItem15.Location = new Point(0, 0);
            layoutControlItem15.Name = "layoutControlItem15";
            layoutControlItem15.Size = new Size(521, 24);
            layoutControlItem15.Text = "Phòng ban (*)";
            layoutControlItem15.TextSize = new Size(118, 13);
            // 
            // layoutControlItem16
            // 
            layoutControlItem16.Control = fIdChucVu;
            layoutControlItem16.Location = new Point(0, 24);
            layoutControlItem16.Name = "layoutControlItem16";
            layoutControlItem16.Size = new Size(521, 24);
            layoutControlItem16.Text = "Chức vụ (*)";
            layoutControlItem16.TextSize = new Size(118, 13);
            // 
            // layoutControlItem17
            // 
            layoutControlItem17.Control = fIdTrinhDoHocVan;
            layoutControlItem17.Location = new Point(0, 48);
            layoutControlItem17.Name = "layoutControlItem17";
            layoutControlItem17.Size = new Size(521, 24);
            layoutControlItem17.Text = "Trình độ học vấn (*)";
            layoutControlItem17.TextSize = new Size(118, 13);
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.Control = fNgoaiNgu;
            layoutControlItem8.Location = new Point(0, 72);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.Size = new Size(521, 24);
            layoutControlItem8.Text = "Ngoại ngữ";
            layoutControlItem8.TextSize = new Size(118, 13);
            // 
            // layoutControlItem14
            // 
            layoutControlItem14.Control = fTinHoc;
            layoutControlItem14.Location = new Point(0, 96);
            layoutControlItem14.Name = "layoutControlItem14";
            layoutControlItem14.Size = new Size(521, 24);
            layoutControlItem14.Text = "Tin học";
            layoutControlItem14.TextSize = new Size(118, 13);
            // 
            // layoutControlGroup2
            // 
            layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem18, layoutControlItem19, layoutControlItem20 });
            layoutControlGroup2.Location = new Point(0, 405);
            layoutControlGroup2.Name = "layoutControlGroup2";
            layoutControlGroup2.Size = new Size(545, 117);
            layoutControlGroup2.Text = "Thông tin CCCD/CMND";
            // 
            // layoutControlItem18
            // 
            layoutControlItem18.Control = fSoCanCuoc;
            layoutControlItem18.Location = new Point(0, 0);
            layoutControlItem18.Name = "layoutControlItem18";
            layoutControlItem18.Size = new Size(521, 24);
            layoutControlItem18.Text = "Số CCCD/CMND";
            layoutControlItem18.TextSize = new Size(118, 13);
            // 
            // layoutControlItem19
            // 
            layoutControlItem19.Control = fNgayCap;
            layoutControlItem19.Location = new Point(0, 24);
            layoutControlItem19.Name = "layoutControlItem19";
            layoutControlItem19.Size = new Size(521, 24);
            layoutControlItem19.Text = "Ngày cấp";
            layoutControlItem19.TextSize = new Size(118, 13);
            // 
            // layoutControlItem20
            // 
            layoutControlItem20.Control = fNoiCap;
            layoutControlItem20.Location = new Point(0, 48);
            layoutControlItem20.Name = "layoutControlItem20";
            layoutControlItem20.Size = new Size(521, 24);
            layoutControlItem20.Text = "Nơi cấp";
            layoutControlItem20.TextSize = new Size(118, 13);
            // 
            // layoutControlGroup3
            // 
            layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem21, layoutControlItem22, layoutControlItem23 });
            layoutControlGroup3.Location = new Point(545, 405);
            layoutControlGroup3.Name = "layoutControlGroup3";
            layoutControlGroup3.Size = new Size(522, 117);
            layoutControlGroup3.Text = "Thông tin sức khoẻ";
            // 
            // layoutControlItem21
            // 
            layoutControlItem21.Control = fTinhTrangSucKhoe;
            layoutControlItem21.Location = new Point(0, 0);
            layoutControlItem21.Name = "layoutControlItem21";
            layoutControlItem21.Size = new Size(498, 24);
            layoutControlItem21.Text = "Trình trạng sức khoẻ";
            layoutControlItem21.TextSize = new Size(118, 13);
            // 
            // layoutControlItem22
            // 
            layoutControlItem22.Control = fChieuCao;
            layoutControlItem22.Location = new Point(0, 24);
            layoutControlItem22.Name = "layoutControlItem22";
            layoutControlItem22.Size = new Size(498, 24);
            layoutControlItem22.Text = "Chiều cao (cm)";
            layoutControlItem22.TextSize = new Size(118, 13);
            // 
            // layoutControlItem23
            // 
            layoutControlItem23.Control = fCanNang;
            layoutControlItem23.Location = new Point(0, 48);
            layoutControlItem23.Name = "layoutControlItem23";
            layoutControlItem23.Size = new Size(498, 24);
            layoutControlItem23.Text = "Cân nặng (kg)";
            layoutControlItem23.TextSize = new Size(118, 13);
            // 
            // layoutControlItem25
            // 
            layoutControlItem25.Control = btnUploadAvatar;
            layoutControlItem25.Location = new Point(0, 214);
            layoutControlItem25.Name = "layoutControlItem25";
            layoutControlItem25.Size = new Size(86, 26);
            layoutControlItem25.TextSize = new Size(0, 0);
            layoutControlItem25.TextVisible = false;
            // 
            // layoutControlItem26
            // 
            layoutControlItem26.Control = btnRemoveAvatar;
            layoutControlItem26.Location = new Point(86, 214);
            layoutControlItem26.Name = "layoutControlItem26";
            layoutControlItem26.Size = new Size(81, 26);
            layoutControlItem26.TextSize = new Size(0, 0);
            layoutControlItem26.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            layoutControlItem9.Control = fTen;
            layoutControlItem9.Location = new Point(167, 24);
            layoutControlItem9.Name = "layoutControlItem9";
            layoutControlItem9.Size = new Size(900, 24);
            layoutControlItem9.Text = "Họ và tên (*)";
            layoutControlItem9.TextSize = new Size(118, 13);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = fGioiTinh;
            layoutControlItem5.Location = new Point(167, 72);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(900, 24);
            layoutControlItem5.Text = "Giới tính (*)";
            layoutControlItem5.TextSize = new Size(118, 13);
            // 
            // layoutControlItem13
            // 
            layoutControlItem13.Control = fTonGiao;
            layoutControlItem13.Location = new Point(167, 192);
            layoutControlItem13.Name = "layoutControlItem13";
            layoutControlItem13.Size = new Size(900, 24);
            layoutControlItem13.Text = "Tôn giáo (*)";
            layoutControlItem13.TextSize = new Size(118, 13);
            // 
            // layoutControlGroup4
            // 
            layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem27, layoutControlItem28, layoutControlItem29, layoutControlItem31, layoutControlItem10 });
            layoutControlGroup4.Location = new Point(545, 240);
            layoutControlGroup4.Name = "layoutControlGroup4";
            layoutControlGroup4.Size = new Size(522, 165);
            layoutControlGroup4.Text = "Thông tin tài khoản";
            // 
            // layoutControlItem27
            // 
            layoutControlItem27.Control = fUsername;
            layoutControlItem27.Location = new Point(0, 0);
            layoutControlItem27.Name = "layoutControlItem27";
            layoutControlItem27.Size = new Size(498, 24);
            layoutControlItem27.Text = "Tên đăng nhập (*)";
            layoutControlItem27.TextSize = new Size(118, 13);
            // 
            // layoutControlItem28
            // 
            layoutControlItem28.Control = fPhoneNumber;
            layoutControlItem28.Location = new Point(0, 24);
            layoutControlItem28.Name = "layoutControlItem28";
            layoutControlItem28.Size = new Size(498, 24);
            layoutControlItem28.Text = "Số điện thoại (*)";
            layoutControlItem28.TextSize = new Size(118, 13);
            // 
            // layoutControlItem29
            // 
            layoutControlItem29.Control = fEmail;
            layoutControlItem29.Location = new Point(0, 48);
            layoutControlItem29.Name = "layoutControlItem29";
            layoutControlItem29.Size = new Size(498, 24);
            layoutControlItem29.Text = "Email cá nhân (*)";
            layoutControlItem29.TextSize = new Size(118, 13);
            // 
            // layoutControlItem31
            // 
            layoutControlItem31.Control = fCreateDate;
            layoutControlItem31.Location = new Point(0, 72);
            layoutControlItem31.Name = "layoutControlItem31";
            layoutControlItem31.Size = new Size(498, 24);
            layoutControlItem31.Text = "Ngày khởi tạo";
            layoutControlItem31.TextSize = new Size(118, 13);
            // 
            // layoutControlItem10
            // 
            layoutControlItem10.Control = fModifiedDate;
            layoutControlItem10.Location = new Point(0, 96);
            layoutControlItem10.Name = "layoutControlItem10";
            layoutControlItem10.Size = new Size(498, 24);
            layoutControlItem10.Text = "Ngày cập nhật";
            layoutControlItem10.TextSize = new Size(118, 13);
            // 
            // layoutControlItem11
            // 
            layoutControlItem11.Control = fQuocTich;
            layoutControlItem11.Location = new Point(167, 144);
            layoutControlItem11.Name = "layoutControlItem11";
            layoutControlItem11.Size = new Size(900, 24);
            layoutControlItem11.Text = "Quốc tịch (*)";
            layoutControlItem11.TextSize = new Size(118, 13);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = fDiaChi;
            layoutControlItem3.Location = new Point(167, 120);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(900, 24);
            layoutControlItem3.Text = "Địa chỉ (*)";
            layoutControlItem3.TextSize = new Size(118, 13);
            // 
            // splitterItem1
            // 
            splitterItem1.AllowHotTrack = true;
            splitterItem1.Location = new Point(277, 0);
            splitterItem1.Name = "splitterItem1";
            splitterItem1.Size = new Size(10, 704);
            // 
            // fAvatar
            // 
            fAvatar.Location = new Point(311, 45);
            fAvatar.MenuManager = barManager1;
            fAvatar.Name = "fAvatar";
            fAvatar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            fAvatar.Size = new Size(163, 210);
            fAvatar.StyleController = layoutControl1;
            fAvatar.TabIndex = 5;
            // 
            // layoutControlItem24
            // 
            layoutControlItem24.Control = fAvatar;
            layoutControlItem24.Location = new Point(0, 0);
            layoutControlItem24.Name = "layoutControlItem24";
            layoutControlItem24.Size = new Size(167, 214);
            layoutControlItem24.TextSize = new Size(0, 0);
            layoutControlItem24.TextVisible = false;
            // 
            // FrmNhanVien
            // 
            ClientSize = new Size(1398, 768);
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "FrmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách Nhân viên";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fModifiedDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fModifiedDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fCreateDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fCreateDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fPhoneNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fUsername.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fCanNang.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fChieuCao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fTinhTrangSucKhoe.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fNoiCap.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fNgayCap.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fNgayCap.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fSoCanCuoc.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fIdTrinhDoHocVan.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit3View).EndInit();
            ((System.ComponentModel.ISupportInitialize)fIdChucVu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit2View).EndInit();
            ((System.ComponentModel.ISupportInitialize)fIdPhongBan.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)fTinHoc.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fNgoaiNgu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fTinhTrangHonNhan.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fDiaChi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fTonGiao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fDanToc.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fQuocTich.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fNoiSinh.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fGioiTinh.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fNgaySinh.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fNgaySinh.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)fTen.Properties).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem12).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem15).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem16).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem17).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem14).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem18).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem19).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem20).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem21).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem22).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem23).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem25).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem26).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem13).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem27).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem28).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem29).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem31).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem10).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem11).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitterItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateTimeChartRangeControlClient1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fAvatar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem24).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repoNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn30;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraEditors.TextEdit fTen;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.DateEdit fNgaySinh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.ComboBoxEdit fGioiTinh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit fQuocTich;
        private DevExpress.XtraEditors.TextEdit fNoiSinh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraEditors.TextEdit fDanToc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraEditors.TextEdit fTonGiao;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraEditors.TextEdit fDiaChi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit fTinhTrangHonNhan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.TextEdit fNgoaiNgu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.TextEdit fTinHoc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraEditors.SearchLookUpEdit fIdPhongBan;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraEditors.SearchLookUpEdit fIdChucVu;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraEditors.SearchLookUpEdit fIdTrinhDoHocVan;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit3View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraEditors.TextEdit fSoCanCuoc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraEditors.DateEdit fNgayCap;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraEditors.TextEdit fNoiCap;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraEditors.TextEdit fTinhTrangSucKhoe;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraEditors.TextEdit fChieuCao;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraEditors.TextEdit fCanNang;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem23;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraEditors.SimpleButton btnUploadAvatar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem25;
        private DevExpress.XtraEditors.SimpleButton btnRemoveAvatar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem26;
        private DevExpress.XtraEditors.TextEdit fUsername;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem27;
        private DevExpress.XtraEditors.TextEdit fPhoneNumber;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem28;
        private DevExpress.XtraEditors.TextEdit fEmail;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem29;
        private DevExpress.XtraEditors.DateEdit fCreateDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem31;
        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
        private DevExpress.XtraEditors.DateEdit fModifiedDate;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.PictureEdit fAvatar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem24;
    }
}