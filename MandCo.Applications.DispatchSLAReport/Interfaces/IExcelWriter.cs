namespace MandCo.Applications.DispatchSLAReport.Interfaces
{
    using System;
using System.Data;

    public interface IExcelWriter
    {
        void WriteToExcel(DataTable dt, DateTime dateFrom, DateTime dateTo);
    }
}
