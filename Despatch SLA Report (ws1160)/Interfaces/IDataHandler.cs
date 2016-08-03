namespace MandCo.Applications.ws1160.Interfaces
{
    using System;
    using System.Data;

    public interface IDataHandler
    {
        DataTable BindSLAData_ToDataTable(DateTime fromDate, DateTime toDate);
    }
}
