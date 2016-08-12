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

        public void WriteToExcel(DataTable dt, DateTime dateFrom, DateTime dateTo)
        {
            string spreadsheetTimeFrame = (dateFrom == dateTo ? "Custom Data Filter" : string.Format("{0: dd.MM.yy HH-mm-ss} to {1: dd.MM.yy HH-mm-ss}", dateFrom, dateTo));
            string amalgamatedSpreadsheetName = string.Format("{0}{1} for {4} - {2}{3}",
                    ConfigurationManager.AppSettings["ExcelFilePath"],
                    ConfigurationManager.AppSettings["ExcelFileName"],
                    ConfigurationManager.AppSettings["RunLevel"],
                    ConfigurationManager.AppSettings["FileExtension"],
                    spreadsheetTimeFrame);

            logger.Info("Writing to Excel");
            XLWorkbook workbook = new XLWorkbook();

            workbook.Worksheets.Add(dt, "Dispatch SLA Report");

            workbook.SaveAs(amalgamatedSpreadsheetName);

            System.Diagnostics.Process.Start(amalgamatedSpreadsheetName);
        }
    }
}
