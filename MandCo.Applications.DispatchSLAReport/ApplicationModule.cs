namespace MandCo.Applications.DispatchSLAReport
{
    using Classes;
    using MandCo.Data.DispatchSLAReport.Classes;
    using MandCo.Service.DispatchSLAReport.Classes;
    using Interfaces;
    using MandCo.Data.DispatchSLAReport.Interfaces;
    using MandCo.Service.DispatchSLAReport.Interfaces;
    using MandCo.Data.DispatchSLAReport.Models;
    using Ninject.Modules;
    using NLog;
    using System;
    using System.Configuration;

    class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            string connectionString = "";
            try
            {
                connectionString = ConfigurationManager.AppSettings["OracleConnection"];
            }
            catch (Exception ex)
            {

            }

            Bind<ILog>().ToMethod(x =>
            {
                var scope = x.Request.ParentRequest.Service.FullName;
                var log = (ILog)LogManager.GetLogger(scope, typeof(Log));
                return log;
            });

            Bind(typeof(IApp)).To(typeof(App));
            Bind(typeof(IDataHandler)).To(typeof(DataHandler));
            Bind(typeof(IPopulateDataTables)).To(typeof(PopulateDataTable));
            Bind(typeof(IRepository)).To(typeof(OracleRepository)).InSingletonScope().WithConstructorArgument("connectionString", connectionString);
            Bind(typeof(IPerformLookup)).To(typeof(PerformLookup));
            Bind(typeof(IDataTableFactory)).To(typeof(DataTableFactory));
            Bind(typeof(IHandleCalculations)).To(typeof(CalculationHandler));


            Bind<Raw_Configuration_Data>().ToSelf();
            Bind<Raw_SLA_Report_Details>().ToSelf();
            Bind<Config_Information>().ToSelf();
            Bind<DisplayData>().ToSelf();
        }
    }
}
