namespace MandCo.Service.ws1160.Interfaces
{
    using MandCo.Data.ws1160.Models;
    using System;
    using System.Collections.Generic;
    using System.Data;

    public interface IPerformLookup
    {
        IEnumerable<Raw_SLA_Report_Details> GetOrderDataFromSLATable(DateTime dateFrom, DateTime dateTo);
        Config_Information GetConfigurationInformation();
    }
}
