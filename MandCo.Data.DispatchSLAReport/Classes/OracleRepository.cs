namespace MandCo.Data.DispatchSLAReport.Classes
{
    using Interfaces;
    using Models;
    using MandCo.Data;
    using System.Collections.Generic;
    using System.Linq;
    using System;

    public class OracleRepository : OracleBase, IRepository
    {
        #region Set Connection String
        public OracleRepository(string connectionString)
            : base(connectionString)
        {
        }
        #endregion

        #region Return Model Data
        public IEnumerable<Raw_SLA_Report_Details> GetAllOrderDetailsForSpecifiedTimes(DateTime dateFrom, DateTime dateTo)
        {
            using (new SharedConnection(dbConnection))
            {
                var result = dbConnection.Query<Raw_SLA_Report_Details>(SqlLoader.GetSql("GetAllSLAReportDetails"));
                return result.Any() ? result : null;
            }
        }

        public IEnumerable<Raw_Configuration_Data> GetRawConfigVariables()
        {
            using (new SharedConnection(dbConnection))
            {
                var result = dbConnection.Query<Raw_Configuration_Data>(SqlLoader.GetSql("GetConfigurationVariables"));
                return result.Any() ? result : null;
            }
        }
        #endregion
    }
}