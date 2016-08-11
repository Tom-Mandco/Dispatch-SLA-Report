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

        public DataTable ReturnAllSLAOrderInfo_ToDataTable(IEnumerable<Cleansed_SLA_Report_Details> slaReportDetails)
        {
            DataTable allSlaOrderData = dataTableFactory.CreateNew_SLAReport_ToDataTable();
            string _releaseDate, _dispatchDate, _timeToImport, _timeToDispatch;


            foreach (var detail in slaReportDetails)
            {
                if (!detail.SLA_Met)
                {
                    _releaseDate = (detail.Released_Date.Year == 1 ? "Not Released" : detail.Released_Date.ToString());
                    _dispatchDate = (detail.Ship_Date.Year == 1 ? "Not Dispatched" : detail.Ship_Date.ToString());
                    _timeToImport = (detail.Date_Imported.Year == 1 ? "Not Imported" : FormatTime_ToString(detail.Time_To_Import));
                    _timeToDispatch = (detail.Released_Date.Year == 1 ? "Not Released" : FormatTime_ToString(detail.Time_To_Release));

                    allSlaOrderData.Rows.Add(detail.Order_Number,
                                             detail.Delivery_Option,
                                             detail.Ship_Method,
                                             detail.Order_Date,
                                             detail.Date_Imported,
                                             _timeToImport,
                                             _releaseDate,
                                             _timeToDispatch,
                                             _dispatchDate
                                             );
                }
            }

            var result = allSlaOrderData;
            return result;
        }

        private string FormatTime_ToString(TimeSpan rawTime)
        {
            string result = "";

            result += rawTime.Days + " Days ";
            result += rawTime.Hours + " Hours ";
            result += rawTime.Minutes + " Minutes ";

            return result;
        }
    }
}
