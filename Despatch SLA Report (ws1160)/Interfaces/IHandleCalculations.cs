namespace MandCo.Applications.ws1160.Interfaces
{
    using MandCo.Data.ws1160.Models;
    using System.Collections.Generic;

    public interface IHandleCalculations
    {
        DisplayData CalculateSLADeadlines_ToDisplayData(IEnumerable<Raw_SLA_Report_Details> SLAReportDetails, Config_Information configInfo);
    }
}
