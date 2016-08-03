namespace MandCo.Applications.ws1160.Classes
{
    using Interfaces;
    using MandCo.Data.ws1160.Models;
    using MandCo.Service.ws1160.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Data;

    class DataHandler : IDataHandler
    {
        private readonly ILog logger;
        private readonly IPopulateDataTables dataTablePopulator;
        private readonly IPerformLookup performLookup;

        private IEnumerable<SLA_Report_Details> slaReportDetails;

        public DataHandler(ILog logger, IPerformLookup performLookup, IPopulateDataTables dataTablePopulator, IEnumerable<SLA_Report_Details> slaReportDetails)
        {
            this.logger = logger;
            this.dataTablePopulator = dataTablePopulator;
            this.performLookup = performLookup;
            this.slaReportDetails = slaReportDetails;
        }

        private IEnumerable<SLA_Report_Details> RetrieveSLAReportDetails(DateTime fromDate, DateTime toDate)
        {
            var result = performLookup.GetOrderDataFromSLATable(fromDate, toDate);
            return result;
        }

        public DataTable BindSLAData_ToDataTable(DateTime fromDate, DateTime toDate)
        {
            slaReportDetails = RetrieveSLAReportDetails(fromDate, toDate);
            DataTable result = dataTablePopulator.ReturnAllSLAOrderInfo_ToDataTable(slaReportDetails);

            return result;
        }
    }
}
