using DevExpress.XtraEditors;

namespace ProjectT1.Winform {
    public partial class RichTextEditorForm : DevExpress.XtraBars.Ribbon.RibbonForm {
        public string _richTextContent;

        public RichTextEditorForm(string content) {
            InitializeComponent();
            _richTextContent = content;
        }
        private void RichTextEditorForm_Load(object sender, EventArgs e) {
            richEditControl1.HtmlText = _richTextContent;
            richEditControl1.CreateBars();
            richEditControl1.CreateRibbon();
        }

        private void RichTextEditorForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (XtraMessageBox.Show("Lưu nội dung đã nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                _richTextContent = richEditControl1.HtmlText;
                XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
