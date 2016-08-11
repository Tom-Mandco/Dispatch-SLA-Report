namespace MandCo.Applications.DispatchSLAReport.Interfaces
{
    using MandCo.Data.DispatchSLAReport.Models;
    using System;
    using System.Collections.Generic;

    public interface IDataFilter
    {
        IEnumerable<Cleansed_SLA_Report_Details> FilterDateRangeFromSLADetails(IEnumerable<Cleansed_SLA_Report_Details> fullSLADetails, DateTime dateFrom, DateTime dateTo);
        IEnumerable<Cleansed_SLA_Report_Details> FilterCutOffTimes(IEnumerable<Cleansed_SLA_Report_Details> fullSLADetails, Config_Information configInfo, DateTime lastDate);
    }
}
