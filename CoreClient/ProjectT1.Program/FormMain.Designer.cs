namespace ProjectX.CoreClient {
    partial class FormMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            txtBusVersion = new DevExpress.XtraBars.BarStaticItem();
            barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            btnMenuY1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            workspaceManager1 = new DevExpress.Utils.WorkspaceManager(components);
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            btnSwitchUser = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemComboBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemComboBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemComboBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, barButtonItem2, barButtonItem3, txtBusVersion, barStaticItem1, btnMenuY1, barButtonItem4, barButtonItem5 });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 33;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.QuickToolbarItemLinks.Add(txtBusVersion);
            ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemComboBox1, repositoryItemComboBox2, repositoryItemComboBox3, repositoryItemLookUpEdit1 });
            ribbon.Size = new Size(723, 158);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Chức năng";
            barButtonItem2.Id = 2;
            barButtonItem2.ImageOptions.Image = (Image)resources.GetObject("barButtonItem2.ImageOptions.Image");
            barButtonItem2.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem2.ImageOptions.LargeImage");
            barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "Báo cáo";
            barButtonItem3.Id = 3;
            barButtonItem3.ImageOptions.Image = (Image)resources.GetObject("barButtonItem3.ImageOptions.Image");
            barButtonItem3.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem3.ImageOptions.LargeImage");
            barButtonItem3.Name = "barButtonItem3";
            // 
            // txtBusVersion
            // 
            txtBusVersion.Caption = "barStaticItem1";
            txtBusVersion.Id = 16;
            txtBusVersion.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("txtBusVersion.ImageOptions.SvgImage");
            txtBusVersion.ItemAppearance.Normal.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBusVersion.ItemAppearance.Normal.ForeColor = Color.LawnGreen;
            txtBusVersion.ItemAppearance.Normal.Options.UseFont = true;
            txtBusVersion.ItemAppearance.Normal.Options.UseForeColor = true;
            txtBusVersion.Name = "txtBusVersion";
            txtBusVersion.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barStaticItem1
            // 
            barStaticItem1.Id = 22;
            barStaticItem1.Name = "barStaticItem1";
            // 
            // btnMenuY1
            // 
            btnMenuY1.Caption = "Z1.CoreClient";
            btnMenuY1.Id = 23;
            btnMenuY1.ImageOptions.Image = (Image)resources.GetObject("btnMenuY1.ImageOptions.Image");
            btnMenuY1.ImageOptions.LargeImage = (Image)resources.GetObject("btnMenuY1.ImageOptions.LargeImage");
            btnMenuY1.Name = "btnMenuY1";
            btnMenuY1.ItemClick += btnCTMTQG_ItemClick;
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "barButtonItem4";
            barButtonItem4.Id = 26;
            barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            barButtonItem5.Caption = "barButtonItem5";
            barButtonItem5.Id = 27;
            barButtonItem5.Name = "barButtonItem5";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Demo";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(btnMenuY1);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // repositoryItemComboBox1
            // 
            repositoryItemComboBox1.AutoHeight = false;
            repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemComboBox1.DropDownRows = 2;
            repositoryItemComboBox1.Items.AddRange(new object[] { "JsonBus", "ServerBus" });
            repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemComboBox2
            // 
            repositoryItemComboBox2.AutoHeight = false;
            repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // repositoryItemComboBox3
            // 
            repositoryItemComboBox3.AutoHeight = false;
            repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemComboBox3.DropDownRows = 2;
            repositoryItemComboBox3.Items.AddRange(new object[] { "JsonBusiness", "ServerBusiness" });
            repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // repositoryItemLookUpEdit1
            // 
            repositoryItemLookUpEdit1.AutoHeight = false;
            repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 763);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(723, 24);
            // 
            // workspaceManager1
            // 
            workspaceManager1.TargetControl = this;
            workspaceManager1.TransitionType = pushTransition1;
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader;
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // btnSwitchUser
            // 
            btnSwitchUser.ImageOptions.Image = (Image)resources.GetObject("btnSwitchUser.ImageOptions.Image");
            btnSwitchUser.Location = new Point(93, 84);
            btnSwitchUser.Name = "btnSwitchUser";
            btnSwitchUser.Size = new Size(91, 20);
            btnSwitchUser.TabIndex = 0;
            btnSwitchUser.Text = "Switch User";
            btnSwitchUser.Click += btnSwitchUser_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 787);
            Controls.Add(ribbonStatusBar);
            Controls.Add(btnSwitchUser);
            Controls.Add(ribbon);
            IsMdiContainer = true;
            Name = "FormMain";
            Ribbon = ribbon;
            StartPosition = FormStartPosition.CenterScreen;
            StatusBar = ribbonStatusBar;
            Text = "MainView - Y4c - CoreClient";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_LoadAsync;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemComboBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemComboBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemComboBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.SimpleButton simpleButton23;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private DevExpress.XtraBars.BarStaticItem txtBusVersion;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem btnMenuY1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraEditors.SimpleButton btnSwitchUser;
        //private DevExpress.XtraEditors.SimpleButton simpleButton23;
    }
}