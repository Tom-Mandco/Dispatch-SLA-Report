namespace MandCo.Applications.DispatchSLAReport.Classes
{
    using Interfaces;
    using System;
    using System.Data;

    class ExcelHandler : IExcelHandler
    {
        #region Initialization
        private readonly ILog logger;
        private readonly IExcelWriter excelWriter;

        public ExcelHandler(ILog logger, IExcelWriter excelWriter)
        {
            this.logger = logger;
            this.excelWriter = excelWriter;
        }
        #endregion


        #region Main Functions
        public void writeToExcel(DataTable dt, DateTime dateFrom, DateTime dateTo)
        {
            logger.Info("Excel Hander - Write to Excel: Started");
            try
            {
                excelWriter.WriteToExcel(dt, dateFrom, dateTo);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                logger.Error(ex.StackTrace);
            }
        }
        #endregion
    }
}
