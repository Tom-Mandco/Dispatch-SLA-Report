namespace MandCo.Applications.DispatchSLAReport.Interfaces
{
    public interface IApp
    {
        void BindConfigDataToForm(MainForm mainForm);
        void BindCustomDisplayDataToForm(MainForm mainForm);
        void BindSLADataTableToDGVDataSource(MainForm mainForm, bool useCustomDateTimes);
    }
}
