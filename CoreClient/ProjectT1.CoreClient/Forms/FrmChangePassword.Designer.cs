namespace ProjectT1.CoreClient {
    partial class FrmChangePassword {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangePassword));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            fOldPassword = new DevExpress.XtraEditors.TextEdit();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            fNewPassword = new DevExpress.XtraEditors.TextEdit();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            fConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fOldPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fNewPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fConfirmPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(fConfirmPassword);
            layoutControl1.Controls.Add(fNewPassword);
            layoutControl1.Controls.Add(btnCancel);
            layoutControl1.Controls.Add(btnSubmit);
            layoutControl1.Controls.Add(fOldPassword);
            layoutControl1.Controls.Add(pictureBox1);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(449, 128);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // btnCancel
            // 
            btnCancel.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnCancel.ImageOptions.Image");
            btnCancel.Location = new System.Drawing.Point(341, 94);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(96, 22);
            btnCancel.StyleController = layoutControl1;
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Huỷ";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnLogin.ImageOptions.Image");
            btnSubmit.Location = new System.Drawing.Point(241, 94);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(96, 22);
            btnSubmit.StyleController = layoutControl1;
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Xác nhận";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // fOldPassword
            // 
            fOldPassword.Location = new System.Drawing.Point(219, 12);
            fOldPassword.Name = "fOldPassword";
            fOldPassword.Properties.UseSystemPasswordChar = true;
            fOldPassword.Size = new System.Drawing.Size(218, 20);
            fOldPassword.StyleController = layoutControl1;
            fOldPassword.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(100, 104);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem3, layoutControlItem4, layoutControlItem5, emptySpaceItem2, emptySpaceItem3, layoutControlItem2, layoutControlItem6 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(449, 128);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = pictureBox1;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(104, 108);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = fOldPassword;
            layoutControlItem3.Location = new System.Drawing.Point(104, 0);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(325, 24);
            layoutControlItem3.Text = "Mật khẩu cũ";
            layoutControlItem3.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = btnSubmit;
            layoutControlItem4.Location = new System.Drawing.Point(229, 82);
            layoutControlItem4.MaxSize = new System.Drawing.Size(100, 26);
            layoutControlItem4.MinSize = new System.Drawing.Size(100, 26);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(100, 26);
            layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = btnCancel;
            layoutControlItem5.Location = new System.Drawing.Point(329, 82);
            layoutControlItem5.MaxSize = new System.Drawing.Size(100, 26);
            layoutControlItem5.MinSize = new System.Drawing.Size(100, 26);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(100, 26);
            layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new System.Drawing.Point(104, 72);
            emptySpaceItem2.MaxSize = new System.Drawing.Size(325, 10);
            emptySpaceItem2.MinSize = new System.Drawing.Size(325, 10);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new System.Drawing.Size(325, 10);
            emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.AllowHotTrack = false;
            emptySpaceItem3.Location = new System.Drawing.Point(104, 82);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new System.Drawing.Size(125, 26);
            emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // fNewPassword
            // 
            fNewPassword.Location = new System.Drawing.Point(219, 36);
            fNewPassword.Name = "fNewPassword";
            fNewPassword.Properties.UseSystemPasswordChar = true;
            fNewPassword.Size = new System.Drawing.Size(218, 20);
            fNewPassword.StyleController = layoutControl1;
            fNewPassword.TabIndex = 5;
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = fNewPassword;
            layoutControlItem6.Location = new System.Drawing.Point(104, 24);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new System.Drawing.Size(325, 24);
            layoutControlItem6.Text = "Mật khẩu mới";
            layoutControlItem6.TextSize = new System.Drawing.Size(91, 13);
            // 
            // fConfirmPassword
            // 
            fConfirmPassword.Location = new System.Drawing.Point(219, 60);
            fConfirmPassword.Name = "fConfirmPassword";
            fConfirmPassword.Properties.UseSystemPasswordChar = true;
            fConfirmPassword.Size = new System.Drawing.Size(218, 20);
            fConfirmPassword.StyleController = layoutControl1;
            fConfirmPassword.TabIndex = 6;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = fConfirmPassword;
            layoutControlItem2.Location = new System.Drawing.Point(104, 48);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(325, 24);
            layoutControlItem2.Text = "Xác nhận mật khẩu";
            layoutControlItem2.TextSize = new System.Drawing.Size(91, 13);
            // 
            // FrmChangePassword
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(449, 128);
            Controls.Add(layoutControl1);
            MaximizeBox = false;
            Name = "FrmChangePassword";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fOldPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)fNewPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)fConfirmPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit fOldPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.TextEdit fConfirmPassword;
        private DevExpress.XtraEditors.TextEdit fNewPassword;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}