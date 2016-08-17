namespace MandCo.Applications.DispatchSLAReport.Classes
{
    using Interfaces;
    using MandCo.Data.DispatchSLAReport.Models;
    using System;
    using System.Collections.Generic;

    public class CalculationHandler : IHandleCalculations
    {
        public DisplayData CalculateSLADeadlines_ToDisplayData(IEnumerable<Cleansed_SLA_Report_Details> SLAReportDetails)
        {
            #region Declarations
            DisplayData result = new DisplayData();
            Dictionary<string, int> orderTotals = AggregateTotals_ToDictionary(SLAReportDetails);
            Dictionary<string, decimal> totalPercentages = CalculatePercentages_ToDictionary(orderTotals);
            #endregion

            #region Assign results to data model

            result.ExpressOrders = orderTotals["Express"];
            result.ExpressOrdersSLA = (orderTotals["Express"] - orderTotals["Express Failed"]);
            result.ExpressOrdersSLAPct = totalPercentages["Express Pct"];

            result.InternationalOrders = orderTotals["International"];
            result.InternationalOrdersSLA = (orderTotals["International"] - orderTotals["International Failed"]);
            result.InternationalOrdersSLAPct = totalPercentages["International Pct"];

            result.StandardOrders = orderTotals["Standard"];
            result.StandardOrdersSLA = (orderTotals["Standard"] - orderTotals["Standard Failed"]);
            result.StandardOrdersSLAPct = totalPercentages["Standard Pct"];

            result.StoreOrders = orderTotals["Store"];
            result.StoreOrdersSLA = (orderTotals["Store"] - orderTotals["Store Failed"]);
            result.StoreOrdersSLAPct = totalPercentages["Store Pct"];

            result.TotalOrders = orderTotals["Total"];
            result.TotalOrdersSLA = (orderTotals["Total"] - orderTotals["Total Failed"]);
            result.TotalOrdersSLAPct = totalPercentages["Total Pct"];

            #endregion

            return result;
        }

        #region Utilities
        private decimal CalculateSuccessPct_ToDecimal(int orders, int ordersFailed)
        {
            decimal result = 0;
            result = (orders > 0 ? ((((decimal)orders - (decimal)ordersFailed) / (decimal)orders) * 100) : 0);
            result = Math.Round(result, 2);
            return result;
        }

        private Dictionary<string, decimal> CalculatePercentages_ToDictionary(Dictionary<string, int> orderTotals)
        {
            #region Declarations
            Dictionary<string, decimal> totalPercentages = new Dictionary<string, decimal>();
            decimal expressOrdersPct = 0, internationalOrdersPct = 0, standardOrdersPct = 0, storeOrdersPct = 0, totalOrdersPct = 0;
            #endregion

            #region Calculate total orders & percentages

            expressOrdersPct = CalculateSuccessPct_ToDecimal(orderTotals["Express"], orderTotals["Express Failed"]);
            internationalOrdersPct = CalculateSuccessPct_ToDecimal(orderTotals["International"], orderTotals["International Failed"]);
            standardOrdersPct = CalculateSuccessPct_ToDecimal(orderTotals["Standard"], orderTotals["Standard Failed"]);
            storeOrdersPct = CalculateSuccessPct_ToDecimal(orderTotals["Store"], orderTotals["Store Failed"]);
            totalOrdersPct = CalculateSuccessPct_ToDecimal(orderTotals["Total"], orderTotals["Total Failed"]);

            #endregion

            #region Add values to dictionary
            totalPercentages.Add("Express Pct", expressOrdersPct);
            totalPercentages.Add("International Pct", internationalOrdersPct);
            totalPercentages.Add("Standard Pct", standardOrdersPct);
            totalPercentages.Add("Store Pct", storeOrdersPct);
            totalPercentages.Add("Total Pct", totalOrdersPct);
            #endregion

            return totalPercentages;
        }

        private Dictionary<string, int> AggregateTotals_ToDictionary(IEnumerable<Cleansed_SLA_Report_Details> SLAReportDetails)
        {
            #region Declarations
            int totalOrders = 0, totalOrdersFailed = 0;
            int expressOrders = 0, expressOrdersFailed = 0;
            int internationalOrders = 0, internationalOrdersFailed = 0;
            int standardOrders = 0, standardOrdersFailed = 0;
            int storeOrders = 0, storeOrdersFailed = 0;
            Dictionary<string, int> OrderTotals = new Dictionary<string, int>();
            #endregion

            #region Aggregate totals
            foreach (var detail in SLAReportDetails)
            {
                if (detail.Delivery_Option == "Express")
                {
                    expressOrders++;
                    if (!detail.SLA_Met)
                        expressOrdersFailed++;
                }
                else
                {
                    switch (detail.Ship_Method)
                    {
                        case "International":
                            internationalOrders++;
                            if (!detail.SLA_Met)
                                internationalOrdersFailed++;
                            break;
                        case "Home":
                            standardOrders++;
                            if (!detail.SLA_Met)
                                standardOrdersFailed++;
                            break;
                        case "Store":
                            storeOrders++;
                            if (!detail.SLA_Met)
                                storeOrdersFailed++;
                            break;
                        default:
                            break;
                    }
                }
            }

            totalOrders = expressOrders + internationalOrders + standardOrders + storeOrders;
            totalOrdersFailed = expressOrdersFailed + internationalOrdersFailed + standardOrdersFailed + storeOrdersFailed;

            #endregion

            #region Add values to dictionary
            OrderTotals.Add("Total", totalOrders);
            OrderTotals.Add("Total Failed", totalOrdersFailed);
            OrderTotals.Add("Express", expressOrders);
            OrderTotals.Add("Express Failed", expressOrdersFailed);
            OrderTotals.Add("International", internationalOrders);
            OrderTotals.Add("International Failed", internationalOrdersFailed);
            OrderTotals.Add("Standard", standardOrders);
            OrderTotals.Add("Standard Failed", standardOrdersFailed);
            OrderTotals.Add("Store", storeOrders);
            OrderTotals.Add("Store Failed", storeOrdersFailed);
            #endregion

            return OrderTotals;
        }
        #endregion
    }
}
