namespace MandCo.Applications.DispatchSLAReport.Interfaces
{
    using System.Windows.Forms;

    public interface IFilterDataGridViews
    {
        void FilterDataGrid_ByDestination(DataGridView dgv, string shipMethod);
    }
}
