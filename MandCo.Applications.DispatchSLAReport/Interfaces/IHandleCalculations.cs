namespace MandCo.Applications.DispatchSLAReport.Interfaces
{
    using MandCo.Data.DispatchSLAReport.Models;
    using System.Collections.Generic;

    public interface IHandleCalculations
    {
        DisplayData CalculateSLADeadlines_ToDisplayData(IEnumerable<Raw_SLA_Report_Details> SLAReportDetails);
    }
}
