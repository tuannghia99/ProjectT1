using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectT1.CoreClient {
    public partial class NotificationForm : DevExpress.XtraEditors.XtraForm {
        private System.Windows.Forms.Timer timer;
        private double Speed = 0.5;
        int? LabelImg;
        public NotificationForm(string noiDung, int? labelImg = 1) {
            InitializeComponent();
            // Đặt nội dung thông báo
            label.Text = noiDung;
            // Khởi tạo và cấu hình Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2; // Đơn vị mili giây
            timer.Tick += Timer_Tick;
            timer.Start();
            LabelImg = labelImg;
        }

        private void Timer_Tick(object sender, EventArgs e) {
            progressBarControl1.EditValue = Speed;
            if (Speed == 100) {
                this.Close();
            }
            else {
                Speed += 0.4;
            }
        }

        private void label_Click(object sender, EventArgs e) {

        }

        private void NotificationForm_Load(object sender, EventArgs e) {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;
            this.Width = labelControl1.Width + label.Width + 40;
            if (LabelImg == 1) {
                labelControl1.ImageOptions.ImageUri.Uri = "Apply";
            }
            else {
                labelControl1.ImageOptions.ImageUri.Uri = "Cancel";
            }
            // Đặt vị trí của Form ở góc phải bên trên của màn hình
            progressBarControl1.Width = this.Width;
            progressBarControl1.EditValue = 100;
            progressBarControl1.ForeColor = Color.Red;
            this.Location = new Point(screenWidth - this.Width + 20, 0);
            // Phát âm thanh
            //string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //var ListBaseDirec = baseDirectory.Split("ProjectY.Program");
            //string baseDirec = ListBaseDirec[0].Replace("\\\\", "\\");
            //string fileName = @"ProjectX.Client.Winform.CustomizeBusiness\Common\success-sound.wav";
            //string fullPath = Path.Combine(baseDirec, fileName);
            //SoundPlayer player = new SoundPlayer(fullPath);
        }
    }
}