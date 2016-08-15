namespace MandCo.Data.DispatchSLAReport.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Models;

    public interface IRepository
    {
        IEnumerable<Raw_SLA_Report_Data> GetAllOrderDetailsForSpecifiedTimes(string dateFrom, string dateTo);
        IEnumerable<Raw_Configuration_Data> GetRawConfigVariables();

        void UpdateConfigInformation(string[] updatedConfigInfo);
    }
}
