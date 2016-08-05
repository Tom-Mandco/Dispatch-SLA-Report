namespace MandCo.Applications.DispatchSLAReport.Classes
{
    using Interfaces;
    using MandCo.Data.DispatchSLAReport.Models;
    using MandCo.Service.DispatchSLAReport.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Data;

    class DataHandler : IDataHandler
    {
        private readonly ILog logger;
        private readonly IPopulateDataTables dataTablePopulator;
        private readonly IPerformLookup performLookup;
        private readonly IHandleCalculations caclulationHandler;

        private IEnumerable<Raw_SLA_Report_Details> slaReportDetails;

        public DataHandler(ILog logger, IPerformLookup performLookup, IPopulateDataTables dataTablePopulator, IHandleCalculations calculationHandler, IEnumerable<Raw_SLA_Report_Details> slaReportDetails)
        {
            this.logger = logger;
            this.dataTablePopulator = dataTablePopulator;
            this.performLookup = performLookup;
            this.caclulationHandler = calculationHandler;
            this.slaReportDetails = slaReportDetails;
        }


        public DataTable BindSLAData_ToDataTable(DateTime fromDate, DateTime toDate)
        {
            slaReportDetails = RetrieveSLAReportDetails(fromDate, toDate);
            DataTable result = dataTablePopulator.ReturnAllSLAOrderInfo_ToDataTable(slaReportDetails);

            return result;
        }

        public Config_Information GetConfigInformation()
        {
            Config_Information result = new Config_Information();

            result = performLookup.GetConfigurationInformation();

            return result;
        }


        #region Utilities
        private IEnumerable<Raw_SLA_Report_Details> RetrieveSLAReportDetails(DateTime fromDate, DateTime toDate)
        {
            var result = performLookup.GetOrderDataFromSLATable(fromDate, toDate);
            return result;
        }
        #endregion

    }
}
