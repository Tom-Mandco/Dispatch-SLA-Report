namespace MandCo.Applications.DispatchSLAReport.Classes
{
    using Interfaces;
    using MandCo.Data.DispatchSLAReport.Models;
    using MandCo.Service.DispatchSLAReport.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Data;

    class DataFilter : IDataFilter
    {
        private IAdaptData dataAdapter;

        public DataFilter(IAdaptData dataAdapter)
        {
            this.dataAdapter = dataAdapter;
        }

        public IEnumerable<Cleansed_SLA_Report_Details> FilterDateRangeFromSLADetails(IEnumerable<Cleansed_SLA_Report_Details> fullSLADetails, DateTime dateFrom, DateTime dateTo)
        {
            List<Cleansed_SLA_Report_Details> list = new List<Cleansed_SLA_Report_Details>();
            Cleansed_SLA_Report_Details cleansedLine;
            DateTime orderDate;

            foreach (var detail in fullSLADetails)
            {
                orderDate = (detail.Released_Date.Year == 1 ? detail.Order_Date : detail.Released_Date);

                if ((orderDate >= dateFrom) && (orderDate <= dateTo))
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

        public IEnumerable<Cleansed_SLA_Report_Details> FilterCutOffTimes(IEnumerable<Cleansed_SLA_Report_Details> fullSLADetails, Config_Information configInfo, DateTime lastDate, DateTime toDate)
        {
            List<Cleansed_SLA_Report_Details> list = new List<Cleansed_SLA_Report_Details>();
            Cleansed_SLA_Report_Details cleansedLine;

            DateTime fromCutOffTime = lastDate.Date;
            DateTime toCutOffTime = toDate.Date;
            DateTime orderDate;

            foreach (var detail in fullSLADetails)
            {
                fromCutOffTime = lastDate.Date;
                toCutOffTime = toDate.Date;

                if (detail.Order_Number == "01004281015020000200")
                {
                    fromCutOffTime.AddDays(0);
                }

                if (dataAdapter.CheckForWeekend(detail.Order_Date, configInfo))
                {
                    fromCutOffTime += configInfo.Weekend_Cutoff_Time.TimeOfDay;
                    toCutOffTime += configInfo.Weekend_Cutoff_Time.TimeOfDay;
                }
                else if (detail.Delivery_Option == "Express")
                {
                    fromCutOffTime += configInfo.Express_Cutoff_Time.TimeOfDay;
                    toCutOffTime += configInfo.Express_Cutoff_Time.TimeOfDay;

                    if (triggerSundayExpressRule(detail.Order_Date, configInfo))
                    {
                        fromCutOffTime = fromCutOffTime.AddDays(1);
                        toCutOffTime = toCutOffTime.AddDays(1);
                    }
                }
                else if (detail.Ship_Method == "Home")
                {
                    fromCutOffTime += configInfo.Standard_Cutoff_Time.TimeOfDay;
                    toCutOffTime += configInfo.Standard_Cutoff_Time.TimeOfDay;
                }
                else if (detail.Ship_Method == "Store")
                {
                    fromCutOffTime += configInfo.Store_Cutoff_Time.TimeOfDay;
                    toCutOffTime += configInfo.Store_Cutoff_Time.TimeOfDay;
                }
                else if (detail.Ship_Method == "International")
                {
                    fromCutOffTime += configInfo.International_Cutoff_Time.TimeOfDay;
                    toCutOffTime += configInfo.International_Cutoff_Time.TimeOfDay;
                }

                orderDate = (detail.Released_Date.Year == 1 ? detail.Order_Date : detail.Released_Date);
                if ((detail.Released_Date.Year != 1) && (!detail.Order_Number.StartsWith("E") || !detail.Order_Number.StartsWith("R")))
                {
                    if ((orderDate >= fromCutOffTime) && (orderDate <= toCutOffTime))
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
            }



            IEnumerable<Cleansed_SLA_Report_Details> result = list;

            return result;
        }
        private bool triggerSundayExpressRule(DateTime orderDate, Config_Information configInfo)
        {
            bool result = false;

            if(orderDate.DayOfWeek == DayOfWeek.Sunday && orderDate.TimeOfDay <= configInfo.Express_SLA_Time.TimeOfDay)
            {
                result = true;
            }

            return result;
        }
    }
}
