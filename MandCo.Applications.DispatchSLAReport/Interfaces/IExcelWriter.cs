namespace MandCo.Applications.DispatchSLAReport.Interfaces
{
    using System.Data;

    public interface IExcelWriter
    {
        void WriteToExcel(DataTable dt);
    }
}
