namespace MandCo.Applications.DispatchSLAReport.Interfaces
{
    using MandCo.Data.DispatchSLAReport.Models;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;

    public interface IDataHandler
    {
        IEnumerable<Cleansed_SLA_Report_Details> GetSLAReportDetails(DateTime fromDate, DateTime toDate);
        IEnumerable<Cleansed_SLA_Report_Details> FilterDateRangeFromSLADetails(IEnumerable<Cleansed_SLA_Report_Details> fullSLADetails, DateTime dateFrom, DateTime dateTo);
        IEnumerable<Cleansed_SLA_Report_Details> FilterCutOffTimes(IEnumerable<Cleansed_SLA_Report_Details> fullSLADetails, Config_Information configInfo, DateTime lastDate, DateTime toDate);

        DataTable BindSLAData_ToDataTable(IEnumerable<Cleansed_SLA_Report_Details> slaReportDetails);
        DisplayData BindSLAData_ToDisplayData(IEnumerable<Cleansed_SLA_Report_Details> slaReportDetails);
        Config_Information GetConfigInformation();

        void UpdateConfigInformation(Config_Information updatedConfigInfo);
        void FilterDataGrid_ByDelivery(DataGridView dgv, string shipMethod, string deliveryOption);
    }
}