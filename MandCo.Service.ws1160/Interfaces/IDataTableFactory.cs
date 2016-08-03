
namespace MandCo.Service.ws1160.Interfaces
{
    using System.Data;

    public interface IDataTableFactory
    {
        DataTable CreateNew_SLAReport_ToDataTable();
    }
}
