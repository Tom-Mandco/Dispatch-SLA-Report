namespace MandCo.Service.DispatchSLAReport.Interfaces
{
    using MandCo.Data.DispatchSLAReport.Models;
    using System.Collections.Generic;

    public interface IAdaptData
    {
        Config_Information InterpretRawConfigData(IEnumerable<Raw_Configuration_Data> _rawConfigData);
        IEnumerable<Cleansed_SLA_Report_Details> InterpretRawSLAData(IEnumerable<Raw_SLA_Report_Data> _rawSLAData, Config_Information configInfo);
    }
}
