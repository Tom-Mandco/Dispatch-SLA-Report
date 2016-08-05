namespace MandCo.Applications.ws1160.Interfaces
{
    using MandCo.Data.ws1160.Models;
    using System.Collections.Generic;
    using System.Data;

    public interface IPopulateDataTables
    {
        DataTable ReturnAllSLAOrderInfo_ToDataTable(IEnumerable<Raw_SLA_Report_Details> slaReportDetails);
    }
}