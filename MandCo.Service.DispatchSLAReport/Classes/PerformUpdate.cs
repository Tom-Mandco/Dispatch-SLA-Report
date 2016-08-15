namespace MandCo.Service.DispatchSLAReport.Classes
{
    using Interfaces;
    using MandCo.Data.DispatchSLAReport.Interfaces;
    using MandCo.Data.DispatchSLAReport.Models;

    public class PerformUpdate : IPerformUpdate
    {
        private readonly IAdaptData dataAdapter;
        private readonly IRepository oracleRepository;

        public PerformUpdate(IRepository oracleRepository, IAdaptData dataAdapter)
        {
            this.oracleRepository = oracleRepository;
            this.dataAdapter = dataAdapter;
        }

        public void UpdateConfigInformation(Config_Information configInfo)
        {
            string[] updatedConfigInfo = dataAdapter.ReturnUpdatedConfigData_ToArray(configInfo);
            oracleRepository.UpdateConfigInformation(updatedConfigInfo);
        }
    }
}
