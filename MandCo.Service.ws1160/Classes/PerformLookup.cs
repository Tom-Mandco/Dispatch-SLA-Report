namespace MandCo.Service.ws1160.Classes
{
    using Interfaces;
    using System.Data;
    using MandCo.Data.ws1160.Models;
    using MandCo.Data.ws1160.Interfaces;
    using System;
    using System.Collections.Generic;

    public class PerformLookup : IPerformLookup
    {
        private readonly IRepository oracleRepository;
        IEnumerable<SLA_Report_Details> slaReportDetails;

        public PerformLookup(IRepository oracleRepository, IEnumerable<SLA_Report_Details> slaReportDetails)
        {
            this.oracleRepository = oracleRepository;
            this.slaReportDetails = slaReportDetails;
        }

        public IEnumerable<SLA_Report_Details> GetOrderDataFromSLATable(DateTime dateFrom, DateTime dateTo)
        {
            slaReportDetails = oracleRepository.GetAllOrderDetailsForSpecifiedTimes(dateFrom, dateTo);

            return slaReportDetails;
        }

    }
}
