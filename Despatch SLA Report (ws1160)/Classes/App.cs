namespace MandCo.Applications.ws1160.Classes
{
    using Interfaces;
    using MandCo.Data.ws1160.Models;
    using System;
    using System.Data;

    class App : IApp
    {
        private readonly ILog logger;
        private readonly IDataHandler dataHandler;

        private DataTable detailBreakDownDT;

        public App(ILog logger, IDataHandler dataHandler, DataTable detailBreakDownDT)
        {
            this.logger = logger;
            this.dataHandler = dataHandler;
            this.detailBreakDownDT = detailBreakDownDT;
        }

        public void BindSLADataTableToDGVDataSource(MainForm mainForm, bool useCustomDateTimes)
        {
            try
            {
                detailBreakDownDT = dataHandler.BindSLAData_ToDataTable(mainForm.dtpReportFrom.Value, mainForm.dtpReportTo.Value);

                DataView detailBreakDownDV = new DataView(detailBreakDownDT);
                //detailBreakDownDV.RowFilter = string.Format("Date => #{0}# AND ",DateTime.);

                mainForm.dgvDetailBreakdown.DataSource = detailBreakDownDT;
                mainForm.dgvDetailBreakdown.AutoResizeColumns();
                mainForm.dgvDetailBreakdown.Refresh();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                logger.Error(ex.StackTrace);
            }
        }

        public void BindConfigDataToForm(MainForm mainForm)
        {
            Config_Information configInformation = dataHandler.GetConfigInformation();

            string lblText = "";
            lblText += string.Format("Admin Accounts: {1}{0}",
                                     Environment.NewLine,
                                     configInformation.Admin_Accounts);

            lblText += string.Format("Express SLA Time: {1}{0}Express Cutoff Time: {2}{0}Express SLA Percentage (High): {3}{0}Express SLA Percentage (Low): {4}{0}",
                                     Environment.NewLine,
                                     configInformation.Express_SLA_Time.ToShortTimeString(),
                                     configInformation.Express_Cutoff_Time.ToLongTimeString(),
                                     configInformation.Express_SLA_Percentage_High,
                                     configInformation.Express_SLA_Percentage_Low);

            lblText += string.Format("International SLA Time: {1}{0}International Cutoff Time: {2}{0}International SLA Percentage (High): {3}{0}International SLA Percentage (Low): {4}{0}",
                         Environment.NewLine,
                         configInformation.International_SLA_Time,
                         configInformation.International_Cutoff_Time,
                         configInformation.International_SLA_Percentage_High,
                         configInformation.International_SLA_Percentage_Low);

            lblText += string.Format("Standard SLA Time: {1}{0}Standard Cutoff Time: {2}{0}Standard SLA Percentage (High): {3}{0}Standard SLA Percentage (Low): {4}{0}",
                         Environment.NewLine,
                         configInformation.Standard_SLA_Time,
                         configInformation.Standard_Cutoff_Time,
                         configInformation.Standard_SLA_Percentage_High,
                         configInformation.Standard_SLA_Percentage_Low);

            lblText += string.Format("Store SLA Time: {1}{0}Store Cutoff Time: {2}{0}Store SLA Percentage (High): {3}{0}Store SLA Percentage (Low): {4}{0}",
                         Environment.NewLine,
                         configInformation.Store_SLA_Time,
                         configInformation.Store_Cutoff_Time,
                         configInformation.Store_SLA_Percentage_High,
                         configInformation.Store_SLA_Percentage_Low);

            mainForm.lblConfigDetails.Text = lblText;
        }
    }
}
