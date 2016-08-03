namespace MandCo.Service.ws1160.Classes
{
    using System.Data;
    using Interfaces;

    public class DataTableFactory : IDataTableFactory
    {
        public DataTable CreateNew_SLAReport_ToDataTable()
        {
            DataTable result = new DataTable();

            result.Columns.Add("Web Order Number");
            result.Columns.Add("Ship Method");
            result.Columns.Add("Order Date");
            result.Columns.Add("Released Date");
            result.Columns.Add("Ship Date");
            result.Columns.Add("Ship By Date");
            result.Columns.Add("Last Update");

            return result;
        }
    }
}
