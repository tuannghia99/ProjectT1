using System;
using System.Collections.Generic;

#nullable disable

namespace GenerateModelSQLServerEFCore.Models
{
    public partial class Category
    {
        public Category()
        {
            CategoryConfigs = new HashSet<CategoryConfig>();
            SyncHistories = new HashSet<SyncHistory>();
        }

        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Classify { get; set; }
        public bool? IsCommon { get; set; }
        public string MapCategoryX { get; set; }
        public string MapDtoY { get; set; }
        public DateTime? LastSync { get; set; }
        public string LastUser { get; set; }
        public string SchemaVersion { get; set; }
        public string DataVersion { get; set; }
        public int? NumOfSync { get; set; }

        public virtual ICollection<CategoryConfig> CategoryConfigs { get; set; }
        public virtual ICollection<SyncHistory> SyncHistories { get; set; }
    }
}
