namespace MandCo.Applications.DispatchSLAReport.Interfaces
{
    using System.Data;

    public interface IExcelHandler
    {
        void writeToExcel(DataTable dt);
    }
}
