namespace MandCo.Applications.ws1160.Classes
{
    using Interfaces;
    using MandCo.Data.ws1160.Models;
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
