namespace MandCo.Data.DispatchSLAReport.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Models;

    public interface IRepository
    {
        IEnumerable<Raw_SLA_Report_Details> GetAllOrderDetailsForSpecifiedTimes(DateTime dateFrom, DateTime dateTo);
        IEnumerable<Raw_Configuration_Data> GetRawConfigVariables();
    }
}
