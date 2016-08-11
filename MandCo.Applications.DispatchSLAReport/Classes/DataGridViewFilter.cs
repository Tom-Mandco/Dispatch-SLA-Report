namespace MandCo.Applications.DispatchSLAReport.Classes
{
    using Interfaces;
    using System.Data;
    using System.Windows.Forms;

    public class DataGridViewFilter : IFilterDataGridViews
    {
        public void FilterDataGrid_ByDestination(DataGridView dgv, string shipMethod)
        {
            if(shipMethod != "All")
                (dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Ship Method] = '{0}'", shipMethod);
            else
                (dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Ship Method] <> '{0}'", shipMethod);

        }

        public void RemoveDataGridFilter(DataGridView dgv)
        {
        }
    }
}
