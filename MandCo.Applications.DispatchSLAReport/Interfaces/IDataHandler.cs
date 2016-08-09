namespace MandCo.Applications.DispatchSLAReport.Interfaces
{
    using MandCo.Data.DispatchSLAReport.Models;
    using System;
    using System.Data;

    public interface IDataHandler
    {
        DataTable BindSLAData_ToDataTable(DateTime fromDate, DateTime toDate);
        DisplayData GetSLAData_ToDisplayData(DateTime fromDate, DateTime toDate);

        Config_Information GetConfigInformation();
        void UpdateConfigInformation(Config_Information updatedConfigInfo);
    }
}
