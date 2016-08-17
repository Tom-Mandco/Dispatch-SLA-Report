namespace MandCo.Applications.DispatchSLAReport.Classes
{
    using Interfaces;
    using System.Data;
    using System.Windows.Forms;

    public class DataGridViewFilter : IFilterDataGridViews
    {
        public void FilterDataGrid_ByDelivery(DataGridView dgv, string shipMethod, string deliveryOption)
        {
            if (deliveryOption != "All")
                (dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Delivery Option] = '{0}'", deliveryOption);
            else
                (dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Delivery Option] <> '{0}'", deliveryOption);

            if(shipMethod != "All")
                (dgv.DataSource as DataTable).DefaultView.RowFilter += string.Format(" AND [Ship Method] = '{0}'", shipMethod);
            else
                (dgv.DataSource as DataTable).DefaultView.RowFilter += string.Format(" AND [Ship Method] <> '{0}'", shipMethod);
        }
    }
}
