namespace ProjectT1.CoreClient {
    partial class FormLogIn {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            btnLogin = new DevExpress.XtraEditors.SimpleButton();
            edUsername = new DevExpress.XtraEditors.TextEdit();
            edPassword = new DevExpress.XtraEditors.TextEdit();
            edAccName = new DevExpress.XtraEditors.LookUpEdit();
            edUrl = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            LookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edUsername.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edAccName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edUrl.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LookUpEdit1View).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnLogin);
            layoutControl1.Controls.Add(edUsername);
            layoutControl1.Controls.Add(edPassword);
            layoutControl1.Controls.Add(edAccName);
            layoutControl1.Controls.Add(edUrl);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(448, 168);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // btnLogin
            // 
            btnLogin.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnLogin.ImageOptions.SvgImage");
            btnLogin.ImageOptions.SvgImageSize = new Size(15, 15);
            btnLogin.Location = new Point(175, 118);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(101, 22);
            btnLogin.StyleController = layoutControl1;
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.Click += btnLogin_ClickAsync;
            // 
            // edUsername
            // 
            edUsername.Location = new Point(72, 60);
            edUsername.Name = "edUsername";
            edUsername.Size = new Size(364, 20);
            edUsername.StyleController = layoutControl1;
            edUsername.TabIndex = 3;
            // 
            // edPassword
            // 
            edPassword.Location = new Point(72, 84);
            edPassword.Name = "edPassword";
            edPassword.Properties.PasswordChar = '●';
            edPassword.Properties.UseSystemPasswordChar = true;
            edPassword.Size = new Size(364, 20);
            edPassword.StyleController = layoutControl1;
            edPassword.TabIndex = 4;
            // 
            // edAccName
            // 
            edAccName.Location = new Point(72, 12);
            edAccName.Name = "edAccName";
            edAccName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            edAccName.Size = new Size(364, 20);
            edAccName.StyleController = layoutControl1;
            edAccName.TabIndex = 0;
            edAccName.EditValueChanged += edAccName_EditValueChanged;
            // 
            // edUrl
            // 
            edUrl.Location = new Point(72, 36);
            edUrl.Name = "edUrl";
            edUrl.Size = new Size(364, 20);
            edUrl.StyleController = layoutControl1;
            edUrl.TabIndex = 2;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { emptySpaceItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem1, layoutControlItem5, emptySpaceItem2, emptySpaceItem3, emptySpaceItem4 });
            Root.Name = "Root";
            Root.Size = new Size(448, 168);
            Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 132);
            emptySpaceItem1.MaxSize = new Size(428, 16);
            emptySpaceItem1.MinSize = new Size(428, 16);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(428, 16);
            emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = edAccName;
            layoutControlItem2.Location = new Point(0, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(428, 24);
            layoutControlItem2.Text = "Đơn vị";
            layoutControlItem2.TextSize = new Size(48, 13);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = edPassword;
            layoutControlItem3.Location = new Point(0, 72);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(428, 24);
            layoutControlItem3.Text = "Password";
            layoutControlItem3.TextSize = new Size(48, 13);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = edUsername;
            layoutControlItem4.Location = new Point(0, 48);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(428, 24);
            layoutControlItem4.Text = "Username";
            layoutControlItem4.TextSize = new Size(48, 13);
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = edUrl;
            layoutControlItem1.Location = new Point(0, 24);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(428, 24);
            layoutControlItem1.Text = "URL";
            layoutControlItem1.TextSize = new Size(48, 13);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = btnLogin;
            layoutControlItem5.Location = new Point(163, 106);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(105, 26);
            layoutControlItem5.TextSize = new Size(0, 0);
            layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new Point(0, 96);
            emptySpaceItem2.MaxSize = new Size(426, 10);
            emptySpaceItem2.MinSize = new Size(426, 10);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new Size(428, 10);
            emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            emptySpaceItem2.TextSize = new Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.AllowHotTrack = false;
            emptySpaceItem3.Location = new Point(0, 106);
            emptySpaceItem3.MaxSize = new Size(163, 26);
            emptySpaceItem3.MinSize = new Size(163, 26);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new Size(163, 26);
            emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            emptySpaceItem3.TextSize = new Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            emptySpaceItem4.AllowHotTrack = false;
            emptySpaceItem4.Location = new Point(268, 106);
            emptySpaceItem4.MaxSize = new Size(160, 26);
            emptySpaceItem4.MinSize = new Size(160, 26);
            emptySpaceItem4.Name = "emptySpaceItem4";
            emptySpaceItem4.Size = new Size(160, 26);
            emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            emptySpaceItem4.TextSize = new Size(0, 0);
            // 
            // LookUpEdit1View
            // 
            LookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            LookUpEdit1View.Name = "LookUpEdit1View";
            LookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            LookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 168);
            Controls.Add(layoutControl1);
            MaximizeBox = false;
            Name = "FormLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += FormLogIn_FormClosing;
            Load += FormLogIn_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)edUsername.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)edPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)edAccName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)edUrl.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)LookUpEdit1View).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit edUsername;
        private DevExpress.XtraEditors.TextEdit edPassword;
        private DevExpress.XtraEditors.LookUpEdit edAccName;
        private DevExpress.XtraGrid.Views.Grid.GridView LookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit edUrl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
    }
}