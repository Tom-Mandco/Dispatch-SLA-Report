namespace MandCo.Data.DispatchSLAReport.Models
{
    using System;

    public class Raw_SLA_Report_Data
    {
        public string ORDER_NUMBER { get; set; }
        public string SHIP_METHOD { get; set; }

        public string TIME_TO_RELEASE { get; set; }
        public string TIME_TO_IMPORT { get; set; }

        public int DEL_OPTION { get; set; }

        public bool SLA_MET { get; set; }

        public DateTime ORDER_DATE { get; set; }
        public DateTime RELEASED_DATE { get; set; }
        public DateTime SHIP_DATE { get; set; }
        public DateTime DATE_IMPORTED { get; set; }
    }
}
