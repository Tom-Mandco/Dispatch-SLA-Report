namespace MandCo.Applications.DispatchSLAReport.Classes
{
    using Interfaces;
    using MandCo.Data.DispatchSLAReport.Models;
    using System;
    using System.Collections.Generic;
    using System.Data;

    class DataFilter : IDataFilter
    {
        public IEnumerable<Cleansed_SLA_Report_Details> FilterDateRangeFromSLADetails(IEnumerable<Cleansed_SLA_Report_Details> fullSLADetails, DateTime dateFrom, DateTime dateTo)
        {
            List<Cleansed_SLA_Report_Details> list = new List<Cleansed_SLA_Report_Details>();
            Cleansed_SLA_Report_Details cleansedLine;

            foreach (var detail in fullSLADetails)
            {
                if (detail.Order_Date >= dateFrom && detail.Order_Date <= dateTo)
                {
                    cleansedLine = new Cleansed_SLA_Report_Details();
                    cleansedLine.Order_Number = detail.Order_Number;
                    cleansedLine.Ship_Method = detail.Ship_Method;
                    cleansedLine.Delivery_Option = detail.Delivery_Option;
                    cleansedLine.Date_Imported = detail.Date_Imported;
                    cleansedLine.Order_Date = detail.Order_Date;
                    cleansedLine.Released_Date = detail.Released_Date;
                    cleansedLine.Ship_Date = detail.Ship_Date;
                    cleansedLine.SLA_Met = detail.SLA_Met;
                    cleansedLine.Time_To_Import = detail.Time_To_Import;
                    cleansedLine.Time_To_Release = detail.Time_To_Release;

                    list.Add(cleansedLine);
                }
            }

            IEnumerable<Cleansed_SLA_Report_Details> result = list;

            return result;
        }

        public IEnumerable<Cleansed_SLA_Report_Details> FilterCutOffTimes(IEnumerable<Cleansed_SLA_Report_Details> fullSLADetails, Config_Information configInfo, DateTime lastDate)
        {
            List<Cleansed_SLA_Report_Details> list = new List<Cleansed_SLA_Report_Details>();
            Cleansed_SLA_Report_Details cleansedLine;

            DateTime CutOffTime = lastDate.Date;

            foreach (var detail in fullSLADetails)
            {
                if (detail.Delivery_Option == "Express")
                {
                    CutOffTime += configInfo.Express_Cutoff_Time.TimeOfDay;
                }
                else if (detail.Ship_Method == "Standard")
                {
                    CutOffTime += configInfo.Standard_Cutoff_Time.TimeOfDay;
                }
                else if (detail.Ship_Method == "Store")
                {
                    CutOffTime += configInfo.Store_Cutoff_Time.TimeOfDay;
                }
                else if (detail.Ship_Method == "International")
                {
                    CutOffTime += configInfo.International_Cutoff_Time.TimeOfDay;
                }
                

                if (detail.Order_Date >= CutOffTime)
                {
                    cleansedLine = new Cleansed_SLA_Report_Details();
                    cleansedLine.Order_Number = detail.Order_Number;
                    cleansedLine.Ship_Method = detail.Ship_Method;
                    cleansedLine.Delivery_Option = detail.Delivery_Option;
                    cleansedLine.Date_Imported = detail.Date_Imported;
                    cleansedLine.Order_Date = detail.Order_Date;
                    cleansedLine.Released_Date = detail.Released_Date;
                    cleansedLine.Ship_Date = detail.Ship_Date;
                    cleansedLine.SLA_Met = detail.SLA_Met;
                    cleansedLine.Time_To_Import = detail.Time_To_Import;
                    cleansedLine.Time_To_Release = detail.Time_To_Release;

                    list.Add(cleansedLine);
                }
            }

            IEnumerable<Cleansed_SLA_Report_Details> result = list;

            return result;
        }
    }
}
