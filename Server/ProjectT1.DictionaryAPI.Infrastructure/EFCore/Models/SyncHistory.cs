using System;
using System.Collections.Generic;

#nullable disable

namespace GenerateModelSQLServerEFCore.Models
{
    public partial class SyncHistory
    {
        public Guid Oid { get; set; }
        public Guid? IdDonVi { get; set; }
        public string CategoryId { get; set; }
        public bool? IsSync { get; set; }
        public bool? IsSuccess { get; set; }
        public string HistoryCode { get; set; }
        public DateTime? HistoryDate { get; set; }
        public string HistoryBy { get; set; }
        public int? TotalCreate { get; set; }
        public int? TotalUpdate { get; set; }
        public int? TotalDelete { get; set; }
        public byte[] HistoryDetail { get; set; }

        public virtual Category Category { get; set; }
    }
}
