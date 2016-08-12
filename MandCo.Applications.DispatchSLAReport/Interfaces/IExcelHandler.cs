namespace MandCo.Applications.DispatchSLAReport.Interfaces
{
    using System;
using System.Data;

    public interface IExcelHandler
    {
        void writeToExcel(DataTable dt, DateTime dateFrom, DateTime dateTo);
    }
}
