using app.StdCommon;
using app.StdFramework.Reports;
using System.Runtime.Serialization;
using VCSCASStdLib;

namespace ProjectY.Report.Infrastructure {
    public class PM_01_2022_PL02B2_1_ReportPrintParameter : PrintParameterBase {
        public PM_01_2022_PL02B2_1_ReportPrintParameter() : base("") { }
        public PM_01_2022_PL02B2_1_ReportPrintParameter(string PrintObjectID, ISessionAPI _sessionAPI) : base(PrintObjectID) {
            PrintDateTime = DateTime.Now;
            PrintUserName = _sessionAPI.CurrentUser?.UserName;
            ServiceToken = _sessionAPI.ServiceToken;
        }
        public PM_01_2022_PL02B2_1_ReportPrintParameter(string PrintObjectID) : base(PrintObjectID) {
        }

        public PM_01_2022_PL02B2_1_ReportPrintParameter(SerializationInfo info, StreamingContext context) : base(info, context) { }

        // public IDictionary<string, object> ParameterList { get; set; }
        public PeriodOfTime2 PeriodOfTime2 { get; set; }
        public Guid IdDonVi { get; set; }
        public string ServiceToken { get; set; }
        public bool KieuIn { get; set; }
        public Guid? IdCTMT { get; set; }
        public Guid? IdDuAn { get; set; }
        public Guid? IdTieuDuAn { get; set; }
        public Decimal? SoTien { get; set; }
        public DateTime? NgayBaoCao { get; set; }

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