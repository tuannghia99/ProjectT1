namespace ProjectT1.Winform {
    partial class NotificationForm {
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
            label = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.Appearance.BackColor = Color.Transparent;
            label.Appearance.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label.Appearance.ForeColor = Color.FromArgb(64, 0, 0);
            label.Appearance.Options.UseBackColor = true;
            label.Appearance.Options.UseFont = true;
            label.Appearance.Options.UseForeColor = true;
            label.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            label.Location = new Point(41, 15);
            label.Name = "label";
            label.Size = new Size(85, 17);
            label.TabIndex = 0;
            label.Text = "labelControl1";
            label.Click += label_Click;
            // 
            // labelControl1
            // 
            labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            labelControl1.ImageOptions.ImageUri.Uri = "Apply";
            labelControl1.Location = new Point(3, 5);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(32, 32);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "\r\n";
            // 
            // progressBarControl1
            // 
            progressBarControl1.Dock = DockStyle.Bottom;
            progressBarControl1.Location = new Point(0, 53);
            progressBarControl1.Name = "progressBarControl1";
            progressBarControl1.Properties.Appearance.BackColor = Color.FromArgb(192, 0, 0);
            progressBarControl1.Properties.Appearance.BorderColor = Color.Transparent;
            progressBarControl1.Properties.Appearance.ForeColor = Color.Lime;
            progressBarControl1.Size = new Size(131, 5);
            progressBarControl1.TabIndex = 2;
            // 
            // NotificationForm
            // 
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(131, 58);
            Controls.Add(progressBarControl1);
            Controls.Add(labelControl1);
            Controls.Add(label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotificationForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "NotificationForm";
            TopMost = true;
            Load += NotificationForm_Load;
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl label;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
    }
}