namespace MandCo.Applications.DispatchSLAReport.Classes
{
    using Interfaces;
    using MandCo.Data.DispatchSLAReport.Models;
    using MandCo.Service.DispatchSLAReport.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Data;

    class PopulateDataTable : IPopulateDataTables
    {
        private readonly IDataTableFactory dataTableFactory;

        public PopulateDataTable(IDataTableFactory dataTableFactory)
        {
            this.dataTableFactory = dataTableFactory;
        }

        public DataTable ReturnAllSLAOrderInfo_ToDataTable(IEnumerable<Raw_SLA_Report_Details> slaReportDetails)
        {
            DataTable allSlaOrderData = dataTableFactory.CreateNew_SLAReport_ToDataTable();

            foreach (var detail in slaReportDetails)
            {
                allSlaOrderData.Rows.Add(detail.WEB_ORDER_NUMBER,
                                         detail.SHIP_METHOD,
                                         detail.ORDER_DATE,
                                         detail.DATE_IMPORTED,
                                         detail.SHIP_DATE,
                                         detail.TIME_TO_IMPORT,
                                         detail.TIME_TO_RELEASE,
                                         detail.DATE_IMPORTED);
            }

            var result = allSlaOrderData;
            return result;
        }
    }
}
