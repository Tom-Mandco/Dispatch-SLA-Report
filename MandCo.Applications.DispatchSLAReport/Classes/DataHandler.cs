namespace MandCo.Applications.DispatchSLAReport.Classes
{
    using Interfaces;
    using MandCo.Data.DispatchSLAReport.Models;
    using MandCo.Service.DispatchSLAReport.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;

    class DataHandler : IDataHandler
    {
        #region Initialization
        private readonly ILog logger;
        private readonly IPopulateDataTables dataTablePopulator;
        private readonly IPerformLookup performLookup;
        private readonly IHandleCalculations caclulationHandler;
        private readonly IDataFilter dataFilter;
        private readonly IFilterDataGridViews dataGridViewFilter;

        public DataHandler(ILog logger, IPerformLookup performLookup, IPopulateDataTables dataTablePopulator,
                            IHandleCalculations calculationHandler, IDataFilter dataFilter, IFilterDataGridViews dataGridViewFilter)
        {
            this.logger = logger;
            this.dataTablePopulator = dataTablePopulator;
            this.performLookup = performLookup;
            this.caclulationHandler = calculationHandler;
            this.dataFilter = dataFilter;
            this.dataGridViewFilter = dataGridViewFilter;
        }
        #endregion

        #region Filter SLA Report Details
        public IEnumerable<Cleansed_SLA_Report_Details> FilterDateRangeFromSLADetails(IEnumerable<Cleansed_SLA_Report_Details> fullSLADetails, DateTime dateFrom, DateTime dateTo)
        {
            return dataFilter.FilterDateRangeFromSLADetails(fullSLADetails, dateFrom, dateTo);
        }

        public IEnumerable<Cleansed_SLA_Report_Details> FilterCutOffTimes(IEnumerable<Cleansed_SLA_Report_Details> fullSLADetails, Config_Information configInfo, DateTime lastDate)
        {
            return dataFilter.FilterCutOffTimes(fullSLADetails, configInfo, lastDate);
        }
        #endregion

        #region Filter DataGridView
        public void FilterDataGrid_ByDestination(DataGridView dgv, string shipMethod)
        {
            dataGridViewFilter.FilterDataGrid_ByDestination(dgv, shipMethod);
        }

        public void FilterDataGrid_ByDeliveryOption(DataGridView dgv, string deliveryOption)
        {
            dataGridViewFilter.FilterDataGrid_ByDeliveryOption(dgv, deliveryOption);
        }
        #endregion

        #region Retrieve Data
        public IEnumerable<Cleansed_SLA_Report_Details> GetSLAReportDetails(DateTime fromDate, DateTime toDate)
        {
            return performLookup.GetOrderDataFromSLATable(fromDate, toDate);
        }

        public Config_Information GetConfigInformation()
        {
            Config_Information result = new Config_Information();

            result = performLookup.GetConfigurationInformation();

            return result;
        }
        #endregion

        #region Updated Data
        public void UpdateConfigInformation(Config_Information updatedConfigInfo)
        {

        }
        #endregion

        #region Bind SLA Data
        public DataTable BindSLAData_ToDataTable(IEnumerable<Cleansed_SLA_Report_Details> slaReportDetails)
        {
            DataTable result = dataTablePopulator.ReturnAllSLAOrderInfo_ToDataTable(slaReportDetails);

            return result;
        }

        public DisplayData BindSLAData_ToDisplayData(IEnumerable<Cleansed_SLA_Report_Details> slaReportDetails)
        {
            DisplayData result = caclulationHandler.CalculateSLADeadlines_ToDisplayData(slaReportDetails);

            return result;
        }
        #endregion
    }
}
