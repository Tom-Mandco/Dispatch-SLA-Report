namespace MandCo.Service.DispatchSLAReport.Classes
{
    using Interfaces;
    using MandCo.Data.DispatchSLAReport.Interfaces;
    using MandCo.Data.DispatchSLAReport.Models;

    public class PerformInsert : IPerformInsert
    {
        private readonly IRepository oracleRepository;

        public PerformInsert(IRepository oracleRepository)
        {
            this.oracleRepository = oracleRepository;
        }

        public void UpdateConfigInformation(Config_Information configInfo)
        {

        }
    }
}
