
namespace MandCo.Service.DispatchSLAReport.Interfaces
{
    using System.Data;

    public interface IDataTableFactory
    {
        DataTable CreateNew_SLAReport_ToDataTable();
    }
}
