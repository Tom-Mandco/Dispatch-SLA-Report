namespace MandCo.Service.ws1160.Classes
{
    using System.Data;
    using Interfaces;

    public class DataTableFactory : IDataTableFactory
    {
        public DataTable CreateNew_SLAReport_ToDataTable()
        {
            DataTable result = new DataTable();

            result.Columns.Add("Order Number");
            result.Columns.Add("Ship Method");
            result.Columns.Add("Date Ordered");
            result.Columns.Add("Date Imported");
            result.Columns.Add("Date Released");
            result.Columns.Add("Time To Import");
            result.Columns.Add("Time To Release");
            result.Columns.Add("Date Dispatched");

            return result;
        }
    }
}
