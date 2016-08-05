namespace MandCo.Applications.DispatchSLAReport.Interfaces
{
    using MandCo.Data.DispatchSLAReport.Models;
    using System.Collections.Generic;
    using System.Data;

    public interface IPopulateDataTables
    {
        DataTable ReturnAllSLAOrderInfo_ToDataTable(IEnumerable<Raw_SLA_Report_Details> slaReportDetails);
    }
}