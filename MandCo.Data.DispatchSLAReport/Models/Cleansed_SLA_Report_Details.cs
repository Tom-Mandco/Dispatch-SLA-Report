namespace MandCo.Data.DispatchSLAReport.Models
{
    using System;

    public class Cleansed_SLA_Report_Details
    {
        public string Order_Number { get; set; }
        public string Ship_Method { get; set; }
        public string Delivery_Option { get; set; }

        public bool SLA_Met { get; set; }

        public DateTime Order_Date { get; set; }
        public DateTime Released_Date { get; set; }
        public DateTime Ship_Date { get; set; }
        public DateTime Date_Imported { get; set; }

        public TimeSpan Time_To_Release { get; set; }
        public TimeSpan Time_To_Import { get; set; }
    }
}