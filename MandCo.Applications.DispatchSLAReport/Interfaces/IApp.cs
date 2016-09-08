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
        void FilterDGV_ByDelivery(DataGridView dgv, string shipMethod, string deliveryOption);
        bool Return_AdminStatus_ToBool();

        void ExportDGV_ToExcel(MainForm mainForm);
        void ExportCleanReport_24Hrs_ToExcel();
        void ExportCleanReport_CustomTimeFrame_ToExcel(MainForm mainForm);
    }
}
