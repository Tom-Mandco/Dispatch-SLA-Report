namespace MandCo.Applications.DispatchSLAReport.Classes
{
    using Interfaces;
    using MandCo.Data.DispatchSLAReport.Models;
    using System.Collections.Generic;

    public class CalculationHandler : IHandleCalculations
    {
        public DisplayData CalculateSLADeadlines_ToDisplayData(IEnumerable<Raw_SLA_Report_Details> SLAReportDetails, Config_Information configInfo)
        {
            #region Declarations
            DisplayData result = new DisplayData();

            int totalOrders = 0, totalOrdersFailed = 0;
            int expressOrders = 0, expressOrdersFailed = 0;
            int internationalOrders = 0, internationalOrdersFailed = 0;
            int standardOrders = 0, standardOrdersFailed = 0;
            int storeOrders = 0, storeOrdersFailed = 0;

            #endregion

            foreach (var detail in SLAReportDetails)
            {
                switch (detail.SHIP_METHOD)
                {
                    case "Express":
                        expressOrders++;
                        if (detail.SLA_MET == "N")
                            expressOrdersFailed++;
                        break;
                    case "International":
                        internationalOrders++;
                        if (detail.SLA_MET == "N")
                            internationalOrdersFailed++;
                        break;
                    case "Standard":
                        standardOrders++;
                        if (detail.SLA_MET == "N")
                            standardOrdersFailed++;
                        break;
                    case "Store":
                        storeOrders++;
                        if (detail.SLA_MET == "N")
                            storeOrdersFailed++;
                        break;
                    default:
                        break;
                }
            }

            totalOrders = CalculuateTotalOrders(expressOrders, internationalOrders, standardOrders, storeOrders);
            totalOrdersFailed = CalculuateTotalOrders(expressOrdersFailed, internationalOrdersFailed, standardOrdersFailed, storeOrdersFailed);

            

            return result;
        }

        #region Utilities
        private int CalculuateTotalOrders(int expressTotal, int internationalTotal, int standardTotal, int storeTotal)
        {
            return expressTotal + internationalTotal + standardTotal + storeTotal;
        }

        private float CalculateSuccessPct(int totalOrders, int totalOrdersFailed)
        {
            return ((totalOrdersFailed / totalOrders) * 100);
        }
        #endregion
    }
}
