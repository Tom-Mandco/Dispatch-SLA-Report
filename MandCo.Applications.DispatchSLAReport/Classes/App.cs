namespace MandCo.Applications.DispatchSLAReport.Classes
{
    using Interfaces;
    using MandCo.Data.DispatchSLAReport.Models;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;
    using System.Linq;
    using System.Data.Linq;

    class App : IApp
    {
        #region Initialization
        private readonly ILog logger;
        private readonly IDataHandler dataHandler;
        private readonly IExcelHandler excelHandler;

        private DataTable detailBreakDownDT;

        public App(ILog logger, IDataHandler dataHandler, IExcelHandler excelHandler, DataTable detailBreakDownDT)
        {
            this.logger = logger;
            this.dataHandler = dataHandler;
            this.detailBreakDownDT = detailBreakDownDT;
            this.excelHandler = excelHandler;
        }
        #endregion

        #region Set Data Sources
        public void SetDataSourceToCustomTimeFrame(MainForm mainForm)
        {
            try
            {
                IEnumerable<Cleansed_SLA_Report_Details> slaReportDetails = dataHandler.GetSLAReportDetails(mainForm.dtpReportFrom.Value, mainForm.dtpReportTo.Value);
                BindCustomDisplayData_ToForm(mainForm, slaReportDetails);

                #region Apply DataTable to DataGridView
                detailBreakDownDT = dataHandler.BindSLAData_ToDataTable(slaReportDetails);
                BindDataToDGV(mainForm, detailBreakDownDT);
                #endregion
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                logger.Error(ex.StackTrace);
            }
        }

        public void SetDataSourceToLast24Hours(MainForm mainForm)
        {
            try
            {
                IEnumerable<Cleansed_SLA_Report_Details> slaReportDetails = dataHandler.GetSLAReportDetails(DateTime.Now.AddDays(-1), DateTime.Now);

                mainForm.lblDGVHeader.Text = string.Format("Real-time data correct as of {0: dd MMM yy HH:mm:ss}",
                                                DateTime.Now);

                Bind24HrDisplayData_ToForm(mainForm, slaReportDetails);

                detailBreakDownDT = dataHandler.BindSLAData_ToDataTable(slaReportDetails);
                BindDataToDGV(mainForm, detailBreakDownDT);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                logger.Error(ex.StackTrace);
            }
        }
        #endregion

        #region Bind Display Data To Form
        private void BindCustomDisplayData_ToForm(MainForm mainForm, IEnumerable<Cleansed_SLA_Report_Details> slaReportDetails)
        {
            DisplayData displayData = dataHandler.BindSLAData_ToDisplayData(slaReportDetails);
            Config_Information configInfo = dataHandler.GetConfigInformation();
            TimeSpan totalOrderTimePeriod = (mainForm.dtpReportTo.Value - mainForm.dtpReportFrom.Value);

            #region Set Top Labels
            mainForm.lblCustTotalSLADtlPct.Text = displayData.TotalOrdersSLAPct.ToString();
            mainForm.lblCustExpressSLADtlPct.Text = displayData.ExpressOrdersSLAPct.ToString();
            mainForm.lblCustInternationalSLADtlPct.Text = displayData.InternationalOrdersSLAPct.ToString();
            mainForm.lblCustStandardSLADtlPct.Text = displayData.StandardOrdersSLAPct.ToString();
            mainForm.lblCustStoreSLADtlPct.Text = displayData.StoreOrdersSLAPct.ToString();

            mainForm.gbCustomSLAStats.Text = string.Format("{0: dd MMM yyyy} - {1: dd MMM yyyy}",
                                                            mainForm.dtpReportFrom.Value,
                                                            mainForm.dtpReportTo.Value);

            List<Label> labels = new List<Label>();
            labels.Add(mainForm.lblCustStandardSLADtlPct);
            labels.Add(mainForm.lblCustStoreSLADtlPct);
            labels.Add(mainForm.lblCustInternationalSLADtlPct);
            labels.Add(mainForm.lblCustTotalSLADtlPct);
            AssignColourCodedPct_ToLabels(labels, configInfo.Standard_SLA_Percentage_High, configInfo.Standard_SLA_Percentage_Low);

            labels.Clear();
            labels.Add(mainForm.lblCustExpressSLADtlPct);
            AssignColourCodedPct_ToLabels(labels, configInfo.Express_SLA_Percentage_High, configInfo.Express_SLA_Percentage_Low);

            mainForm.lblDGVHeader.Text = string.Format("{0: dd MMM yy HH:mm:ss} - {1: dd MMM yy HH:mm:ss}",
                                                        mainForm.dtpReportFrom.Value,
                                                        mainForm.dtpReportTo.Value);
            #endregion

            #region Set Side Labels
            mainForm.lblTotalOrdersDtl.Text = displayData.TotalOrders.ToString();
            mainForm.lblTotalOrdersMetSLADtl.Text = displayData.TotalOrdersSLA.ToString();

            mainForm.lblExpressOrdersDtl.Text = displayData.ExpressOrders.ToString();
            mainForm.lblExpressMetSLADtl.Text = displayData.ExpressOrdersSLA.ToString();

            mainForm.lblInternationalOrdersDtl.Text = displayData.InternationalOrders.ToString();
            mainForm.lblInternationalOrdersMetSLADtl.Text = displayData.InternationalOrdersSLA.ToString();

            mainForm.lblStandardOrdersDtl.Text = displayData.StandardOrders.ToString();
            mainForm.lblStandardOrdersMetSLADtl.Text = displayData.StandardOrdersSLA.ToString();

            mainForm.lblStoreOrdersDtl.Text = displayData.StoreOrders.ToString();
            mainForm.lblStoreOrdersMetSLADtl.Text = displayData.StoreOrdersSLA.ToString();
            #endregion

            #region Set Config Labels
            mainForm.lblTopCriteriaMetKey.Text = string.Format("> {0}% met SLA ({1}% for Express)",
                                                    configInfo.Standard_SLA_Percentage_High,
                                                    configInfo.Express_SLA_Percentage_High);
            mainForm.lblMidCriteriaMetKey.Text = string.Format("  {0}% to {1}% met SLA ({2}% to {3}% for Express)",
                                                                configInfo.Standard_SLA_Percentage_Low,
                                                                configInfo.Standard_SLA_Percentage_High,
                                                                configInfo.Express_SLA_Percentage_Low,
                                                                configInfo.Express_SLA_Percentage_High);
            mainForm.lblCriteriaNotMetKey.Text = string.Format("< {0}% met SLA ({1}% for Express)",
                                                                configInfo.Standard_SLA_Percentage_Low,
                                                                configInfo.Express_SLA_Percentage_Low);

            #endregion
        }

        private void Bind24HrDisplayData_ToForm(MainForm mainForm, IEnumerable<Cleansed_SLA_Report_Details> slaReportDetails)
        {
            Config_Information configInfo = dataHandler.GetConfigInformation();

            DisplayData displayData = dataHandler.BindSLAData_ToDisplayData(slaReportDetails);
            List<Label> labels = new List<Label>();

            #region Set top labels
            mainForm.lbl24HrsTotalSLADtlPct.Text = displayData.TotalOrdersSLAPct.ToString();
            mainForm.lbl24HrsExpressSLADtlPct.Text = displayData.ExpressOrdersSLAPct.ToString();
            mainForm.lbl24HrsInternationalSLADtlPct.Text = displayData.InternationalOrdersSLAPct.ToString();
            mainForm.lbl24HrsStandardSLADtlPct.Text = displayData.StandardOrdersSLAPct.ToString();
            mainForm.lbl24HrsStoreSLADtlPct.Text = displayData.StoreOrdersSLAPct.ToString();

            mainForm.gbLast24Hrs.Text = "Statistics from cut off point on " + DateTime.Now.AddDays(-1).ToLongDateString();

            labels.Add(mainForm.lbl24HrsStandardSLADtlPct);
            labels.Add(mainForm.lbl24HrsStoreSLADtlPct);
            labels.Add(mainForm.lbl24HrsInternationalSLADtlPct);
            labels.Add(mainForm.lbl24HrsTotalSLADtlPct);
            AssignColourCodedPct_ToLabels(labels, configInfo.Standard_SLA_Percentage_High, configInfo.Standard_SLA_Percentage_Low);

            labels.Clear();
            labels.Add(mainForm.lbl24HrsExpressSLADtlPct);
            AssignColourCodedPct_ToLabels(labels, configInfo.Express_SLA_Percentage_High, configInfo.Express_SLA_Percentage_Low);
            #endregion
        }
        #endregion

        #region Retrieve Data
        public Config_Information GetConfigInformation()
        {
            return dataHandler.GetConfigInformation();
        }
        #endregion

        #region Update Data
        public void UpdateConfigInformation(Config_Information updatedConfigInfo)
        {
            dataHandler.UpdateConfigInformation(updatedConfigInfo);
        }
        #endregion

        #region Utilities
        private void AssignColourCodedPct_ToLabels(List<Label> labels, int pctHigh, int pctLow)
        {
            float labelValue = 0;

            foreach (var label in labels)
            {
                float.TryParse(label.Text, out labelValue);
                if (labelValue >= pctHigh)
                    label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
                else if (labelValue >= pctLow)
                    label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(128)))));
                else
                    label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }
        }
        #endregion

        #region Binding DataGridView Data
        private void BindDataToDGV(MainForm mainForm, DataTable dataTable)
        {
            mainForm.dgvDetailBreakdown.DataSource = dataTable;
            mainForm.dgvDetailBreakdown.AutoResizeColumns();
            mainForm.dgvDetailBreakdown.Refresh();
        }

        public void FilterDGV_ByDelivery(DataGridView dgv, string shipMethod, string deliveryOption)
        {
            dataHandler.FilterDataGrid_ByDelivery(dgv, shipMethod, deliveryOption);
        }
        #endregion

        #region Exporting to Excel
        public void ExportDGV_ToExcel(MainForm mainForm)
        {
            DataTable dt = (mainForm.dgvDetailBreakdown.DataSource as DataTable);
            excelHandler.writeToExcel(dt, new DateTime(1, 1, 1), new DateTime(1, 1, 1));
        }

        public void ExportCleanReport_24Hrs_ToExcel()
        {
            IEnumerable<Cleansed_SLA_Report_Details> slaReportDetails = dataHandler.GetSLAReportDetails(DateTime.Now.AddDays(-1), DateTime.Now);
            DataTable dt = dataHandler.BindSLAData_ToDataTable(slaReportDetails);
            excelHandler.writeToExcel(dt, DateTime.Now.AddDays(-1), DateTime.Now);
        }

        public void ExportCleanReport_CustomTimeFrame_ToExcel(MainForm mainForm)
        {
            IEnumerable<Cleansed_SLA_Report_Details> slaReportDetails = dataHandler.GetSLAReportDetails(mainForm.dtpReportFrom.Value, mainForm.dtpReportTo.Value);
            DataTable dt = dataHandler.BindSLAData_ToDataTable(slaReportDetails);
            excelHandler.writeToExcel(dt, mainForm.dtpReportFrom.Value, mainForm.dtpReportTo.Value);
        }
        #endregion
    }
}
