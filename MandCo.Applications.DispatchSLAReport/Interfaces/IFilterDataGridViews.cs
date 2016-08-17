namespace MandCo.Applications.DispatchSLAReport.Interfaces
{
    using System.Windows.Forms;

    public interface IFilterDataGridViews
    {
        void FilterDataGrid_ByDelivery(DataGridView dgv, string shipMethod, string deliveryOption);
    }
}
