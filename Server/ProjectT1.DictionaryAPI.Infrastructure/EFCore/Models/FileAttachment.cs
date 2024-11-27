using System;
using System.Collections.Generic;

#nullable disable

namespace GenerateModelSQLServerEFCore.Models
{
    public partial class FileAttachment
    {
        public Guid Oid { get; set; }
        public Guid IdItem { get; set; }
        public string FunctionCode { get; set; }
        public string FieldCode { get; set; }
        public string FileName { get; set; }
        public byte[] FileContent { get; set; }
        public string FileId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public Guid? IdDonViSuDung { get; set; }
    }
}
