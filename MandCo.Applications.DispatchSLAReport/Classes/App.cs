namespace MandCo.Applications.DispatchSLAReport.Classes
{
    using Interfaces;
using MandCo.Data.DispatchSLAReport.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

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

        public void SetDataSourceToCustomTimeFrame(MainForm mainForm)
        {
            try
            {
                detailBreakDownDT = dataHandler.BindSLAData_ToDataTable(mainForm.dtpReportFrom.Value, mainForm.dtpReportTo.Value);
                BindDataToDGV(mainForm, detailBreakDownDT);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                logger.Error(ex.StackTrace);
            }
        }

        private void BindDataToDGV(MainForm mainForm, DataTable dataTable)
        {
            mainForm.dgvDetailBreakdown.DataSource = dataTable;
            mainForm.dgvDetailBreakdown.AutoResizeColumns();
            mainForm.dgvDetailBreakdown.Refresh();
        }

        public void BindConfigDataToForm(MainForm mainForm)
        {
            Config_Information configInformation = dataHandler.GetConfigInformation();

            mainForm.lblConfigDetails.Text = Environment.UserName;
        }

        public void SetDataSourceToLast24Hours(MainForm mainForm)
        {
            mainForm.lblDGVHeader.Text = string.Format("Orders which failed SLA for time period: {0: dd MMM yy HH:mm:ss} - {1: dd MMM yy HH:mm:ss}",
                                            DateTime.Now.AddDays(-1),
                                            DateTime.Now);

            detailBreakDownDT = dataHandler.BindSLAData_ToDataTable(DateTime.Now.AddDays(-1), DateTime.Now);
            BindDataToDGV(mainForm, detailBreakDownDT);
        }

        public void BindCustomDisplayDataToForm(MainForm mainForm)
        {
            DisplayData displayData = dataHandler.GetSLAData_ToDisplayData(mainForm.dtpReportFrom.Value, mainForm.dtpReportTo.Value);
            Config_Information configInfo = dataHandler.GetConfigInformation();
            TimeSpan totalOrderTimePeriod = (mainForm.dtpReportTo.Value - mainForm.dtpReportFrom.Value);

            #region Set Top Labels 
            mainForm.lblCustTotalSLADtlPct.Text = displayData.TotalOrdersSLAPct.ToString();
            mainForm.lblCustExpressSLADtlPct.Text = displayData.ExpressOrdersSLAPct.ToString();
            mainForm.lblCustInternationalSLADtlPct.Text = displayData.InternationalOrdersSLAPct.ToString();
            mainForm.lblCustStandardSLADtlPct.Text = displayData.StandardOrdersSLAPct.ToString();
            mainForm.lblCustStoreSLADtlPct.Text = displayData.StoreOrdersSLAPct.ToString();

            mainForm.gbCustomSLAStats.Text = string.Format("{0} - {1}",
                                                            mainForm.dtpReportFrom.Value,
                                                            mainForm.dtpReportTo.Value);
            
            List<Label> labels = new List<Label>();
            labels.Add(mainForm.lblCustStandardSLADtlPct);
            labels.Add(mainForm.lblCustStoreSLADtlPct);
            labels.Add(mainForm.lblCustInternationalSLADtlPct);
            AssignColourCodedPct_ToLabels(labels, configInfo.Standard_SLA_Percentage_High, configInfo.Standard_SLA_Percentage_Low);

            labels.Clear();
            labels.Add(mainForm.lblCustExpressSLADtlPct);
            labels.Add(mainForm.lblCustTotalSLADtlPct);
            AssignColourCodedPct_ToLabels(labels, configInfo.Express_SLA_Percentage_High, configInfo.Express_SLA_Percentage_Low);

            mainForm.lblDGVHeader.Text = string.Format("Orders which failed SLA for time period: {0: dd MMM yy HH:mm:ss} - {1: dd MMM yy HH:mm:ss}",
                                                        mainForm.dtpReportFrom.Value,
                                                        mainForm.dtpReportTo.Value);
            #endregion

            #region Set Side Labels
            mainForm.lblOrderTotalsHeader.Text = string.Format("Order Totals within the previous {0} days", totalOrderTimePeriod.Days);

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

            #region Display Admin Panel
            if (configInfo.Admin_Accounts.Contains(Environment.UserName))
                mainForm.pnAdminPanel.Visible = true;
            else
                mainForm.pnAdminPanel.Visible = false;
            #endregion
        }

        public void Bind24HrDisplayDataToForm(MainForm mainForm)
        {
            DisplayData displayData = dataHandler.GetSLAData_ToDisplayData(DateTime.Now.AddDays(-1), DateTime.Now);
            Config_Information configInfo = dataHandler.GetConfigInformation();
            List<Label> labels = new List<Label>();

            #region Set top labels
            mainForm.lbl24HrsTotalSLADtlPct.Text = displayData.TotalOrdersSLAPct.ToString();
            mainForm.lbl24HrsExpressSLADtlPct.Text = displayData.ExpressOrdersSLAPct.ToString();
            mainForm.lbl24HrsInternationalSLADtlPct.Text = displayData.InternationalOrdersSLAPct.ToString();
            mainForm.lbl24HrsStandardSLADtlPct.Text = displayData.StandardOrdersSLAPct.ToString();
            mainForm.lbl24HrsStoreSLADtlPct.Text = displayData.StoreOrdersSLAPct.ToString();

            mainForm.gbLast24Hrs.Text = "Statistics from cut off point on : " + DateTime.Now.AddDays(-1).ToLongDateString();

            labels.Add(mainForm.lbl24HrsStandardSLADtlPct);
            labels.Add(mainForm.lbl24HrsStoreSLADtlPct);
            labels.Add(mainForm.lbl24HrsInternationalSLADtlPct);
            AssignColourCodedPct_ToLabels(labels, configInfo.Standard_SLA_Percentage_High, configInfo.Standard_SLA_Percentage_Low);

            labels.Clear();
            labels.Add(mainForm.lbl24HrsExpressSLADtlPct);
            labels.Add(mainForm.lbl24HrsTotalSLADtlPct);
            AssignColourCodedPct_ToLabels(labels, configInfo.Express_SLA_Percentage_High, configInfo.Express_SLA_Percentage_Low);
            #endregion
        }

        public Config_Information GetConfigInformation()
        {
            return dataHandler.GetConfigInformation();
        }

        public void UpdateConfigInformation(Config_Information updatedConfigInfo)
        {
            dataHandler.UpdateConfigInformation(updatedConfigInfo);
        }

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
    }
}
