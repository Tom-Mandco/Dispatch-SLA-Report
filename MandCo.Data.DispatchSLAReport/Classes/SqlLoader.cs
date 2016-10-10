namespace MandCo.Data.DispatchSLAReport.Classes
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    public static class SqlLoader
    {
        public static string GetSql(string fileName)
        {
            var sqlFolder = AppDomain.CurrentDomain.BaseDirectory + System.Configuration.ConfigurationManager.AppSettings["SqlDirectory"];
            var sqlFileLocation = string.Format("{0}{1}.sql", sqlFolder, fileName);
            var sql = File.ReadAllText(sqlFileLocation);
            return sql;
        }
    }
}
