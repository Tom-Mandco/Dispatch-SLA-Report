namespace MandCo.Applications.DispatchSLAReport.Classes
{
    using Interfaces;
    using MandCo.Data.DispatchSLAReport.Models;
    using System.Collections.Generic;

    class CalculationHandler : IHandleCalculations
    {
        public DisplayData CalculateSLADeadlines_ToDisplayData(IEnumerable<Raw_SLA_Report_Details> SLAReportDetails, Config_Information configInfo)
        {
            DisplayData result = new DisplayData();



            return result;
        }
    }
}
