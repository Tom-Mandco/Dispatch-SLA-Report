namespace MandCo.Applications.ws1160.Classes
{
    using Interfaces;
    using MandCo.Data.ws1160.Models;
    using MandCo.Service.ws1160.Interfaces;
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

        public DataTable ReturnAllSLAOrderInfo_ToDataTable(IEnumerable<SLA_Report_Details> slaReportDetails)
        {
            DataTable allSlaOrderData = dataTableFactory.CreateNew_SLAReport_ToDataTable();

            foreach (var detail in slaReportDetails)
            {
                allSlaOrderData.Rows.Add(detail.WEB_ORDER_NUMBER,
                                         detail.SHIP_METHOD,
                                         detail.ORDER_DATE,
                                         detail.RELEASED_DATE,
                                         detail.SHIP_DATE,
                                         detail.SHIP_BY_DATE,
                                         detail.SLA_MET,
                                         detail.LAST_UPDATE);
            }

            var result = allSlaOrderData;
            return result;
        }
    }
}
