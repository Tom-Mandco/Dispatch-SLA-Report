namespace MandCo.Service.DispatchSLAReport.Interfaces
{
    using MandCo.Data.DispatchSLAReport.Models;

    public interface IPerformUpdate
    {
        void UpdateConfigInformation(Config_Information configInfo);
    }
}
