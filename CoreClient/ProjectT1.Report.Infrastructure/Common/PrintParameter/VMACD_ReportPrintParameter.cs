using app.StdCommon;
using app.StdFramework.Reports;
using System.Runtime.Serialization;
using VCSCASStdLib;

namespace ProjectY.Report.Infrastructure {
    public class VMACD_ReportPrintParameter : PrintParameterBase {
        public VMACD_ReportPrintParameter() : base("") { }
        public VMACD_ReportPrintParameter(string PrintObjectID, ISessionAPI _sessionAPI) : base(PrintObjectID) {
            PrintDateTime = DateTime.Now;
            PrintUserName = _sessionAPI.CurrentUser?.UserName;
            ServiceToken = _sessionAPI.ServiceToken;
        }
        public VMACD_ReportPrintParameter(string PrintObjectID) : base(PrintObjectID) {
        }

        public VMACD_ReportPrintParameter(SerializationInfo info, StreamingContext context) : base(info, context) { }

        // public IDictionary<string, object> ParameterList { get; set; }
        public PeriodOfTime2 PeriodOfTime2 { get; set; }
        public Guid IdDonVi { get; set; }
        public string ServiceToken { get; set; }
        public bool KieuIn { get; set; }
        public Guid? param1 { get; set; }
        public Guid? param2 { get; set; }

        public string jsonString { get; set; }

        public override void DeserializeData(SerializationInfo info, StreamingContext context) {
            base.DeserializeData(info, context);
            PeriodOfTime2 = PeriodOfTime2.ConvertPeriodStringToObject(info.GetString(nameof(PeriodOfTime2)));
            IdDonVi = Guid.Parse(info.GetString(nameof(IdDonVi)));
            ServiceToken = info.GetString(nameof(ServiceToken));
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context) {
            base.GetObjectData(info, context);
            info.AddValue(nameof(PeriodOfTime2), PeriodOfTime2.ConvertPeriodObjectToString());
            info.AddValue(nameof(IdDonVi), IdDonVi.ToString());
            info.AddValue(nameof(ServiceToken), ServiceToken);
        }
    }
}