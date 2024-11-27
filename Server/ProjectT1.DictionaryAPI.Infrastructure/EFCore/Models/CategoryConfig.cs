using System;
using System.Collections.Generic;

#nullable disable

namespace GenerateModelSQLServerEFCore.Models
{
    public partial class CategoryConfig
    {
        public Guid Oid { get; set; }
        public Guid? IdDonVi { get; set; }
        public string CategoryId { get; set; }
        public string SchemaVersionConfig { get; set; }
        public string DataVersionConfig { get; set; }
        public string JsonSyncRule { get; set; }
        public string JsonMapping { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UntilEffectiveDate { get; set; }
        public Guid? HistoryId { get; set; }
        public bool? IsUsing { get; set; }

        public virtual Category Category { get; set; }
    }
}
