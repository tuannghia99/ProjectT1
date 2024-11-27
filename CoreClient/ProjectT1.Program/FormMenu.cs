using app.Common;
using app.StdCommon;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using Microsoft.Extensions.Logging;
using ProjectT1.Client.Winform;
using VCSCASStdLib;

namespace ProjectT1.CoreClient {
    public partial class FormMenu : DevExpress.XtraEditors.XtraForm {
        private readonly ILogger _logger;
        private static FormMenu _instance;

        SessionAPI _sessionAPI;
        public int aFormMenu;
        public FormMenu Instance() {
            if (_instance != null)
                return null;
            _instance = new FormMenu(_sessionAPI, _logger);
            return _instance;
        }
        public FormMenu(SessionAPI sessionAPI, ILogger logger) {
            InitializeComponent();
            _sessionAPI = sessionAPI;
            _logger = logger;
        }
        private void FormMenu_Load(object sender, EventArgs e) {
            LoadDataToListTree();

            gridControl1.SetBasicEmbededNavigator();
            gridControl1.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            gridControl1.EmbeddedNavigator.TextStringFormat = "Form {0}/{1}";
        }

        private void repoForm_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
        }
        private void btnCheckAll_Click(object sender, EventArgs e) {
            treeList1.CheckAll();
        }
        private void treeList1_AfterCheckNode(object sender, NodeEventArgs e) {
            if (e.Node.Checked) {
                SetNodeCheckStateRecursive(e.Node, true);
                if (e.Node.ParentNode != null) {
                    e.Node.ParentNode.CheckState = CheckState.Checked;
                }
            }
            else {
                SetNodeCheckStateRecursive(e.Node, false);
            }
        }
        private void SetNodeCheckStateRecursive(TreeListNode parentNode, bool checkState) {
            foreach (TreeListNode childNode in parentNode.Nodes) {
                childNode.CheckState = checkState ? CheckState.Checked : CheckState.Unchecked;
                SetNodeCheckStateRecursive(childNode, checkState);
            }
        }
        private void btnUncheckAll_Click(object sender, EventArgs e) => treeList1.UncheckAll();
        private void btnApply_Click(object sender, EventArgs e) => LoadDataToGridAndRepos();
        private void LoadDataToListTree() {
        }
        private void LoadDataToGridAndRepos() {
        }
    }
}