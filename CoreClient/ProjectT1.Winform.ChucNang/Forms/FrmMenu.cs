﻿using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.Winform {
    public partial class FrmMenu : DevExpress.XtraEditors.XtraForm {
        public FrmMenu() {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e) {

        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e) {
            var formDsNhanVien = new FrmDanhSachNhanVien();
            formDsNhanVien.ShowDialog();
        }
    }
}