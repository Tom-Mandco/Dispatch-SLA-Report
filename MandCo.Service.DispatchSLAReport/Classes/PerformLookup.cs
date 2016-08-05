namespace MandCo.Service.DispatchSLAReport.Classes
{
    using Interfaces;
    using System.Data;
    using MandCo.Data.DispatchSLAReport.Models;
    using MandCo.Data.DispatchSLAReport.Interfaces;
    using System;
    using System.Collections.Generic;

    public class PerformLookup : IPerformLookup
    {
        private readonly IRepository oracleRepository;
        IEnumerable<Raw_SLA_Report_Details> slaReportDetails;
        IEnumerable<Raw_Configuration_Data> rawConfigData;

        Config_Information configInformation;

        public PerformLookup(IRepository oracleRepository, IEnumerable<Raw_SLA_Report_Details> slaReportDetails, Config_Information configInformation, IEnumerable<Raw_Configuration_Data> rawConfigData)
        {
            this.oracleRepository = oracleRepository;
            this.slaReportDetails = slaReportDetails;
            this.configInformation = configInformation;
            this.rawConfigData = rawConfigData;
        }

        public IEnumerable<Raw_SLA_Report_Details> GetOrderDataFromSLATable(DateTime dateFrom, DateTime dateTo)
        {
            slaReportDetails = oracleRepository.GetAllOrderDetailsForSpecifiedTimes(dateFrom, dateTo);

            return slaReportDetails;
        }

        public Config_Information GetConfigurationInformation()
        {
            rawConfigData = oracleRepository.GetRawConfigVariables();

            configInformation = InterpretRawConfigData(rawConfigData);

            return configInformation;
        }

        #region Utilities
        private Config_Information InterpretRawConfigData(IEnumerable<Raw_Configuration_Data> _rawConfigData)
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
        #endregion
    }
}
