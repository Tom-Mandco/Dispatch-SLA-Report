using System;
namespace MandCo.Data.ws1160.Models
{
    public class Config_Information
    {
        public string Admin_Accounts { get; set; }

        public DateTime Express_SLA_Time { get; set; }
        public DateTime Express_Cutoff_Time { get; set; }
        public int Express_SLA_Percentage_High { get; set; }
        public int Express_SLA_Percentage_Low { get; set; }

        public DateTime International_SLA_Time { get; set; }
        public DateTime International_Cutoff_Time { get; set; }
        public int International_SLA_Percentage_High { get; set; }
        public int International_SLA_Percentage_Low { get; set; }

        public DateTime Standard_SLA_Time { get; set; }
        public DateTime Standard_Cutoff_Time { get; set; }
        public int Standard_SLA_Percentage_High { get; set; }
        public int Standard_SLA_Percentage_Low { get; set; }

        public DateTime Store_SLA_Time { get; set; }
        public DateTime Store_Cutoff_Time { get; set; }
        public int Store_SLA_Percentage_High { get; set; }
        public int Store_SLA_Percentage_Low { get; set; }
    }
}
