namespace MandCo.Service.DispatchSLAReport.Interfaces
{
    using MandCo.Data.DispatchSLAReport.Models;
    using System;
    using System.Collections.Generic;
    using System.Data;

    public interface IPerformLookup
    {
        IEnumerable<Cleansed_SLA_Report_Details> GetOrderDataFromSLATable(DateTime dateFrom, DateTime dateTo);
        Config_Information GetConfigurationInformation();
    }
}
