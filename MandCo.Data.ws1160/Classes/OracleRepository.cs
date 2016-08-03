namespace MandCo.Data.ws1160.Classes
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
        public IEnumerable<SLA_Report_Details> GetAllOrderDetailsForSpecifiedTimes(DateTime dateFrom, DateTime dateTo)
        {
            using (new SharedConnection(dbConnection))
            {
                var result = dbConnection.Query<SLA_Report_Details>(SqlLoader.GetSql("web despatch package peerformance"));
                return result.Any() ? result : null;
            }
        }
        #endregion
    }
}