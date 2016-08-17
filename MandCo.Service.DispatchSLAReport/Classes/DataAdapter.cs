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
                cleansedLine.Released_Date = detail.RELEASE_DATE;
                cleansedLine.Ship_Date = detail.SHIP_DATE;
                cleansedLine.SLA_Met = CalculateSLAMet(configInfo, cleansedLine);

                dateImported = (detail.DATE_IMPORTED.Year == 1 ? DateTime.Now : detail.DATE_IMPORTED);
                dateReleased = (detail.RELEASE_DATE.Year == 1 ? DateTime.Now : detail.RELEASE_DATE);

                cleansedLine.Time_To_Import = GetTimeDifference_ToTimeSpan(detail.ORDER_DATE, dateImported);
                cleansedLine.Time_To_Release = GetTimeDifference_ToTimeSpan(detail.DATE_IMPORTED, dateReleased);

                list.Add(cleansedLine);
            }

            IEnumerable<Cleansed_SLA_Report_Details> result = list;
            return result;
        }

        public string[] ReturnUpdatedConfigData_ToArray(Config_Information updatedConfigInfo)
        {
            List<string> result = new List<string>();

            result.Add(updatedConfigInfo.Express_SLA_Time.TimeOfDay.ToString());
            result.Add(updatedConfigInfo.Express_Cutoff_Time.TimeOfDay.ToString());
            result.Add(updatedConfigInfo.Express_SLA_Percentage_High.ToString());
            result.Add(updatedConfigInfo.Express_SLA_Percentage_Low.ToString());

            result.Add(updatedConfigInfo.International_SLA_Time.TimeOfDay.ToString());
            result.Add(updatedConfigInfo.International_Cutoff_Time.TimeOfDay.ToString());
            result.Add(updatedConfigInfo.International_SLA_Percentage_High.ToString());
            result.Add(updatedConfigInfo.International_SLA_Percentage_Low.ToString());

            result.Add(updatedConfigInfo.Standard_SLA_Time.TimeOfDay.ToString());
            result.Add(updatedConfigInfo.Standard_Cutoff_Time.TimeOfDay.ToString());
            result.Add(updatedConfigInfo.Standard_SLA_Percentage_High.ToString());
            result.Add(updatedConfigInfo.Standard_SLA_Percentage_Low.ToString());

            result.Add(updatedConfigInfo.Store_SLA_Time.TimeOfDay.ToString());
            result.Add(updatedConfigInfo.Store_Cutoff_Time.TimeOfDay.ToString());
            result.Add(updatedConfigInfo.Store_SLA_Percentage_High.ToString());
            result.Add(updatedConfigInfo.Store_SLA_Percentage_Low.ToString());

            return result.ToArray();
        }
        

        private TimeSpan GetTimeDifference_ToTimeSpan(DateTime timeFrom, DateTime timeTo)
        {
            return timeTo - timeFrom;
        }

        private bool CalculateSLAMet(Config_Information configInfo, Cleansed_SLA_Report_Details cleansedLine)
        {
            bool result = false;

            if(cleansedLine.Order_Number == "2994716")
            {
                result = false;
            }

            DateTime orderDate = (cleansedLine.Released_Date.Year == 1 ? cleansedLine.Date_Imported : cleansedLine.Released_Date);
            DateTime shipDate = (cleansedLine.Ship_Date.Year == 1 ? DateTime.Now.AddDays(1) : cleansedLine.Ship_Date);
            DateTime cutOffDeadline = CalculateCutOffTime(orderDate, configInfo, cleansedLine.Delivery_Option, cleansedLine.Ship_Method);
            DateTime slaDeadline = CalculateSLATime(orderDate, configInfo, cleansedLine.Delivery_Option, cleansedLine.Ship_Method);

            if (orderDate > cutOffDeadline)
            {
                if (shipDate < slaDeadline.AddDays(1))
                {
                    result = true;
                }
            }
            else
            {
                if (shipDate < slaDeadline)
                {
                    result = true;
                }
            }

            return result;
        }

        private bool CheckForWeekend(DateTime date, Config_Information configInfo)
        {
            bool result = false;

            if (date.DayOfWeek == DayOfWeek.Friday && date.TimeOfDay >= configInfo.Express_Cutoff_Time.TimeOfDay)
                result = true;
            else if (date.DayOfWeek == DayOfWeek.Saturday)
                result = true;
            else if (date.DayOfWeek == DayOfWeek.Sunday && date.TimeOfDay <= configInfo.Standard_Cutoff_Time.TimeOfDay)
                result = true;
            return result;
        }

        private DateTime CalculateCutOffTime(DateTime orderDate, Config_Information configInfo, string deliveryOption, string shipMethod)
        {
            DateTime result = orderDate.Date;
            bool isWeekend = CheckForWeekend(orderDate,configInfo);

            if (deliveryOption == "Express")
            {
                if(isWeekend)
                    result += configInfo.Standard_Cutoff_Time.TimeOfDay;
                else
                    result += configInfo.Express_Cutoff_Time.TimeOfDay;
            }
            else
            {
                switch (shipMethod)
                {
                    case "Home":
                        result += configInfo.Standard_Cutoff_Time.TimeOfDay;
                        break;
                    case "Store":
                        result += configInfo.Store_Cutoff_Time.TimeOfDay;
                        break;
                    case "International":
                        result += configInfo.International_Cutoff_Time.TimeOfDay;
                        break;
                }
            }

            return result;
        }

        private DateTime CalculateSLATime(DateTime orderDate, Config_Information configInfo, string deliveryOption, string shipMethod)
        {
            DateTime result = orderDate.Date;
            bool isWeekend = CheckForWeekend(orderDate, configInfo);

            if (deliveryOption == "Express")
            {
                if (isWeekend)
                {
                    if(orderDate.DayOfWeek == DayOfWeek.Sunday && orderDate.TimeOfDay <= configInfo.Express_SLA_Time.TimeOfDay)
                    {
                        result += configInfo.Express_SLA_Time.TimeOfDay;
                        result.AddDays(1);
                    }
                    else
                    {
                        result += configInfo.Standard_SLA_Time.TimeOfDay;
                    }
                }
                else
                {
                    result += configInfo.Express_SLA_Time.TimeOfDay;
                }
            }
            else
            {
                switch (shipMethod)
                {
                    case "Home":
                        result += configInfo.Standard_SLA_Time.TimeOfDay;
                        break;
                    case "Store":
                        result += configInfo.Store_SLA_Time.TimeOfDay;
                        break;
                    case "International":
                        result += configInfo.International_SLA_Time.TimeOfDay;
                        break;
                }
            }

            return result;
        }
    }

}
