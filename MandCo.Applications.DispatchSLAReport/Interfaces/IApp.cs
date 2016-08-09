namespace MandCo.Applications.DispatchSLAReport.Interfaces
{
    using MandCo.Data.DispatchSLAReport.Models;

    public interface IApp
    {
        void BindConfigDataToForm(MainForm mainForm);
        void Bind24HrDisplayDataToForm(MainForm mainForm);
        void BindCustomDisplayDataToForm(MainForm mainForm);
        void BindSLADataTableToDGVDataSource(MainForm mainForm);

        Config_Information GetConfigInformation();
        void UpdateConfigInformation(Config_Information updatedConfigInfo);
    }
}
