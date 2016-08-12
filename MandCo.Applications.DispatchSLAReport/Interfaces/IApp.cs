namespace MandCo.Applications.DispatchSLAReport.Interfaces
{
    using MandCo.Data.DispatchSLAReport.Models;
    using System.Windows.Forms;

    public interface IApp
    {
        void SetDataSourceToCustomTimeFrame(MainForm mainForm);
        void SetDataSourceToLast24Hours(MainForm mainForm);

        Config_Information GetConfigInformation();
        void UpdateConfigInformation(Config_Information updatedConfigInfo);
        void FilterDGV(DataGridView dgv, string shipMethod);
        void FilterDGV_ByDeliveryOption(DataGridView dgv, string deliveryOption);

        void ExportDGV_ToExcel(MainForm mainForm);
        void ExportCleanReport_24Hrs_ToExcel();
        void ExportCleanReport_CustomTimeFrame_ToExcel(MainForm mainForm);
    }
}
