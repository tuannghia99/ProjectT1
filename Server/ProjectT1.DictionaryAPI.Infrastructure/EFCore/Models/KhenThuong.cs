﻿using System;
using System.Collections.Generic;

#nullable disable

namespace GenerateModelSQLServerEFCore.Models
{
    public partial class KhenThuong
    {
        public Guid Oid { get; set; }
        public string MaSo { get; set; }
        public Guid? IdNhanVien { get; set; }
        public string CanCuKhenThuong { get; set; }
        public string LyDoKhenThuong { get; set; }
        public string HinhThucKhenThuong { get; set; }
        public decimal? MucKhenThuong { get; set; }
        public DateTime? NgayKhenThuong { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
