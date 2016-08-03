﻿namespace MandCo.Applications.ws1160
{
    using Classes;
    using MandCo.Data.ws1160.Classes;
    using MandCo.Service.ws1160.Classes;
    using Interfaces;
    using MandCo.Data.ws1160.Interfaces;
    using MandCo.Service.ws1160.Interfaces;
    using MandCo.Data.ws1160.Models;
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

            Bind<Configuration_Data>().ToSelf();
            Bind<DisplayData>().ToSelf();
            Bind<SLA_Report_Details>().ToSelf();
        }
    }
}