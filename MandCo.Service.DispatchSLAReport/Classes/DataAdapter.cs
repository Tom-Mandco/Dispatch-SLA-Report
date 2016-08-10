namespace MandCo.Service.DispatchSLAReport.Classes
{
    using Interfaces;
    using MandCo.Data.DispatchSLAReport.Models;
    using System;
    using System.Collections.Generic; 

    public class DataAdapter : IAdaptData
    {
        public Config_Information InterpretRawConfigData(IEnumerable<Raw_Configuration_Data> _rawConfigData)
        {
            Config_Information result = new Config_Information();
            bool isnumeric;
            int numeric = 66;

            foreach (var detail in _rawConfigData)
            {
                switch (detail.RECORDSUBTYPE)
                {
                    #region Set Administration Configs
                    case "ADMINACCS":
                        result.Admin_Accounts = detail.DELIMITEDDATASTRING;
                        break;
                    #endregion

                    #region Set Express Configs
                    case "EXPCUT":
                        result.Express_Cutoff_Time = Convert.ToDateTime(detail.DELIMITEDDATASTRING);
                        break;
                    case "EXPSLA":
                        result.Express_SLA_Time = Convert.ToDateTime(detail.DELIMITEDDATASTRING);
                        break;
                    case "EXPSLAPC1":
                        isnumeric = int.TryParse(detail.DELIMITEDDATASTRING, out numeric);
                        result.Express_SLA_Percentage_High = numeric;
                        break;
                    case "EXPSLAPC2":
                        isnumeric = int.TryParse(detail.DELIMITEDDATASTRING, out numeric);
                        result.Express_SLA_Percentage_Low = numeric;
                        break;
                    #endregion

                    #region Set Express Configs
                    case "INTCUT":
                        result.International_Cutoff_Time = Convert.ToDateTime(detail.DELIMITEDDATASTRING);
                        break;
                    case "INTSLA":
                        result.International_SLA_Time = Convert.ToDateTime(detail.DELIMITEDDATASTRING);
                        break;
                    case "INTSLAPC1":
                        isnumeric = int.TryParse(detail.DELIMITEDDATASTRING, out numeric);
                        result.International_SLA_Percentage_High = numeric;
                        break;
                    case "INTSLAPC2":
                        isnumeric = int.TryParse(detail.DELIMITEDDATASTRING, out numeric);
                        result.International_SLA_Percentage_Low = numeric;
                        break;
                    #endregion

                    #region Set Standard Configs
                    case "STDCUT":
                        result.Standard_Cutoff_Time = Convert.ToDateTime(detail.DELIMITEDDATASTRING);
                        break;
                    case "STDSLA":
                        result.Standard_SLA_Time = Convert.ToDateTime(detail.DELIMITEDDATASTRING);
                        break;
                    case "STDSLAPC1":
                        isnumeric = int.TryParse(detail.DELIMITEDDATASTRING, out numeric);
                        result.Standard_SLA_Percentage_High = numeric;
                        break;
                    case "STDSLAPC2":
                        isnumeric = int.TryParse(detail.DELIMITEDDATASTRING, out numeric);
                        result.Standard_SLA_Percentage_Low = numeric;
                        break;
                    #endregion

                    #region Set Store Configs
                    case "STRCUT":
                        result.Store_Cutoff_Time = Convert.ToDateTime(detail.DELIMITEDDATASTRING);
                        break;
                    case "STRSLA":
                        result.Store_SLA_Time = Convert.ToDateTime(detail.DELIMITEDDATASTRING);
                        break;
                    case "STRSLAPC1":
                        isnumeric = int.TryParse(detail.DELIMITEDDATASTRING, out numeric);
                        result.Store_SLA_Percentage_High = numeric;
                        break;
                    case "STRSLAPC2":
                        isnumeric = int.TryParse(detail.DELIMITEDDATASTRING, out numeric);
                        result.Store_SLA_Percentage_Low = numeric;
                        break;
                    #endregion

                    default:
                        break;
                }
            }

            return result;
        }

        public IEnumerable<Cleansed_SLA_Report_Details> InterpretRawSLAData(IEnumerable<Raw_SLA_Report_Data> _rawSLAData, Config_Information configInfo)
        {
            List<Cleansed_SLA_Report_Details> list = new List<Cleansed_SLA_Report_Details>();
            Cleansed_SLA_Report_Details cleansedLine;
            DateTime dateImported, dateReleased;

            foreach(var detail in _rawSLAData)
            {
                cleansedLine = new Cleansed_SLA_Report_Details();
                cleansedLine.Order_Number = detail.ORDER_NUMBER;
                cleansedLine.Ship_Method = detail.SHIP_METHOD;
                cleansedLine.Delivery_Option = (detail.DEL_OPTION == 1 ? "Express" : "Standard");
                cleansedLine.Date_Imported = detail.DATE_IMPORTED;
                cleansedLine.Order_Date = detail.ORDER_DATE;
                cleansedLine.Released_Date = detail.RELEASED_DATE;
                cleansedLine.Ship_Date = detail.SHIP_DATE;
                cleansedLine.SLA_Met = CalculateSLAMet(configInfo, cleansedLine);

                dateImported = (detail.DATE_IMPORTED.Year == 1 ? DateTime.Now : detail.DATE_IMPORTED);
                dateReleased = (detail.RELEASED_DATE.Year == 1 ? DateTime.Now : detail.RELEASED_DATE);

                cleansedLine.Time_To_Import = GetTimeDifference_ToTimeSpan(detail.ORDER_DATE, dateImported);
                cleansedLine.Time_To_Release = GetTimeDifference_ToTimeSpan(detail.DATE_IMPORTED, dateReleased);

                list.Add(cleansedLine);
            }

            IEnumerable<Cleansed_SLA_Report_Details> result = list;
            return result;
        }

        private TimeSpan GetTimeDifference_ToTimeSpan(DateTime timeFrom, DateTime timeTo)
        {
            return timeTo - timeFrom;
        }

        private bool CalculateSLAMet(Config_Information configInfo, Cleansed_SLA_Report_Details cleansedLine)
        {
            bool result = false;
            DateTime cutOffDeadline = configInfo.Standard_Cutoff_Time;
            DateTime slaDeadline = configInfo.Standard_SLA_Time;

            if (cleansedLine.Delivery_Option == "Express")
            {
                cutOffDeadline = configInfo.Express_Cutoff_Time;
                slaDeadline = configInfo.Express_SLA_Time;
            }
            else
            {
                switch (cleansedLine.Ship_Method)
                {
                    case "Store":
                        cutOffDeadline = configInfo.Store_Cutoff_Time;
                        slaDeadline = configInfo.Store_SLA_Time;
                        break;
                    case "International":
                        cutOffDeadline = configInfo.International_Cutoff_Time;
                        slaDeadline = configInfo.International_SLA_Time;
                        break;
                }
            }

            DateTime shipDate = (cleansedLine.Ship_Date.Year == 1 ? DateTime.Now : cleansedLine.Ship_Date);

            TimeSpan alottedTime = CalculateAlottedTime(cleansedLine.Order_Date, cutOffDeadline, slaDeadline);
            TimeSpan timeTaken = GetTimeDifference_ToTimeSpan(cleansedLine.Order_Date, shipDate);

            result = (alottedTime > timeTaken ? true : false);

            return result;
        }

        private TimeSpan CalculateAlottedTime(DateTime dateOrdered, DateTime cutOffDeadline, DateTime slaDeadline)
        {
            TimeSpan result;
            TimeSpan additionalTime = TimeSpan.FromHours(24);

            result = slaDeadline.TimeOfDay - dateOrdered.TimeOfDay;

            if (dateOrdered.TimeOfDay > cutOffDeadline.TimeOfDay)
                result = new TimeSpan(1, result.Hours, result.Minutes, result.Seconds);

            return result;
        }
    }
}
