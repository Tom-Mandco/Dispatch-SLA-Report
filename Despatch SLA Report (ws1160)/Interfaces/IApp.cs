namespace MandCo.Applications.ws1160.Interfaces
{
    public interface IApp
    {
        void BindConfigDataToForm(MainForm mainForm);
        void BindSLADataTableToDGVDataSource(MainForm mainForm, bool useCustomDateTimes);
    }
}
