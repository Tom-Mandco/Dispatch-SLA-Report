namespace MandCo.Applications.DispatchSLAReport.Classes
{
    using ClosedXML.Excel;
    using Interfaces;
    using System;
    using System.Configuration;
    using System.Data;

    class ExcelWriter : IExcelWriter
    {
        private readonly ILog logger;

        public ExcelWriter(ILog logger)
        {
            this.logger = logger;
        }

        public void WriteToExcel(DataTable dt)
        {
            logger.Info("Writing to Excel");
            XLWorkbook workbook = new XLWorkbook(string.Format("{0}{4}-{5}-{6} {1} - {2}{3}",
                    ConfigurationManager.AppSettings["ExcelFilePath"],
                    ConfigurationManager.AppSettings["ExcelFileName"],
                    ConfigurationManager.AppSettings["RunLevel"],
                    ConfigurationManager.AppSettings["FileExtension"],
                    System.DateTime.Now.Day,
                    System.DateTime.Now.Month,
                    System.DateTime.Now.Year));
            try
            {
                workbook.Worksheets.Add(dt, "Dispatch SLA Report");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                logger.Error(ex.StackTrace);
            }
            workbook.Save();
        }
    }
}
