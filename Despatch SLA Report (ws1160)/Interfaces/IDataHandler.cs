namespace MandCo.Applications.ws1160.Interfaces
{
    using MandCo.Data.ws1160.Models;
    using System;
    using System.Data;

    public interface IDataHandler
    {
        DataTable BindSLAData_ToDataTable(DateTime fromDate, DateTime toDate);

        Config_Information GetConfigInformation();
    }
}
