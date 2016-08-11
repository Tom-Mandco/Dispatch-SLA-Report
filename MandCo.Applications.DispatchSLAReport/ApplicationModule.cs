namespace MandCo.Applications.DispatchSLAReport
{
    using Classes;
    using Interfaces;
    using MandCo.Data.DispatchSLAReport.Classes;
    using MandCo.Data.DispatchSLAReport.Interfaces;
    using MandCo.Data.DispatchSLAReport.Models;
    using MandCo.Service.DispatchSLAReport.Classes;
    using MandCo.Service.DispatchSLAReport.Interfaces;
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
            Bind(typeof(IAdaptData)).To(typeof(DataAdapter));
            Bind(typeof(IDataFilter)).To(typeof(DataFilter));
            Bind(typeof(IFilterDataGridViews)).To(typeof(DataGridViewFilter));
            Bind(typeof(IExcelHandler)).To(typeof(ExcelHandler));
            Bind(typeof(IExcelWriter)).To(typeof(ExcelWriter));

            Bind<Raw_Configuration_Data>().ToSelf();
            Bind<Cleansed_SLA_Report_Details>().ToSelf();
            Bind<Raw_SLA_Report_Data>().ToSelf();
            Bind<Config_Information>().ToSelf();
            Bind<DisplayData>().ToSelf();
        }
    }
}
