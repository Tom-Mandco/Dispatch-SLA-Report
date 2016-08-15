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
        public IEnumerable<Raw_SLA_Report_Data> GetAllOrderDetailsForSpecifiedTimes(string dateFrom, string dateTo)
        {
            using (new SharedConnection(dbConnection))
            {
                var result = dbConnection.Query<Raw_SLA_Report_Data>(SqlLoader.GetSql("GetAllOrders"), dateFrom, dateTo);
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

        public void UpdateConfigInformation(string[] updatedConfigInfo)
        {
            using (new SharedConnection(dbConnection))
            {
                dbConnection.Execute(SqlLoader.GetSql("UpdateConfigurationVariables"), updatedConfigInfo);
            }
        }
    }
}