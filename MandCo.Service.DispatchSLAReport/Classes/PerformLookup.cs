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
        private readonly IAdaptData dataAdapter;
        IEnumerable<Cleansed_SLA_Report_Details> slaReportDetails;
        IEnumerable<Raw_Configuration_Data> rawConfigData;

        Config_Information configInformation;

        public PerformLookup(IRepository oracleRepository, IAdaptData dataAdapter, IEnumerable<Cleansed_SLA_Report_Details> slaReportDetails, Config_Information configInformation, IEnumerable<Raw_Configuration_Data> rawConfigData)
        {
            this.oracleRepository = oracleRepository;
            this.slaReportDetails = slaReportDetails;
            this.configInformation = configInformation;
            this.dataAdapter = dataAdapter;
            this.rawConfigData = rawConfigData;
        }

        public IEnumerable<Cleansed_SLA_Report_Details> GetOrderDataFromSLATable(DateTime dateFrom, DateTime dateTo)
        {
            string formattedDateFrom = string.Format("{0:yyyy-MM-dd HH-mm-ss}", dateFrom);
            string formattedDateTo = string.Format("{0:yyyy-MM-dd HH-mm-ss}", dateTo);
            
            IEnumerable<Raw_SLA_Report_Data> rawSLAReportDetails = oracleRepository.GetAllOrderDetailsForSpecifiedTimes(formattedDateFrom, formattedDateTo);

            IEnumerable<Cleansed_SLA_Report_Details> slaReportDetails = dataAdapter.InterpretRawSLAData(rawSLAReportDetails, GetConfigurationInformation());

            return slaReportDetails;
        }

        public Config_Information GetConfigurationInformation()
        {
            rawConfigData = oracleRepository.GetRawConfigVariables();

            configInformation = dataAdapter.InterpretRawConfigData(rawConfigData);

            return configInformation;
        }
    }
}
