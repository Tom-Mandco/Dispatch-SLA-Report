namespace MandCo.Applications.DispatchSLAReport
{
    using System;
    using System.Windows.Forms;
    using Interfaces;
    using System.Collections.Generic;

    public partial class MainForm : Form
    {
        private readonly ILog logger;
        private readonly IApp app;

        public MainForm(ILog logger, IApp app)
        {
            this.logger = logger;
            this.app = app;
            InitializeComponent();
            logger.Info("Application Started");
        }

        private void btnLast24HrsViewReport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            app.SetDataSourceToLast24Hours(this);
            Cursor.Current = Cursors.Default;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                dtpReportFrom.Value = DateTime.Now.AddDays(-7);
                dtpReportTo.Value = DateTime.Now;
                app.SetDataSourceToLast24Hours(this);
                app.SetDataSourceToCustomTimeFrame(this);
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
                logger.Error(ex.StackTrace);
            }
        }

        private void btnReportCustomDateRange_Click(object sender, EventArgs e)
        {
            try 
            {
                Cursor.Current = Cursors.WaitCursor;
                app.SetDataSourceToCustomTimeFrame(this);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                logger.Error(ex.StackTrace);
            }
        }

        private void btnOpenConfigSettings_Click(object sender, EventArgs e)
        {
            ConfigurationSettingsForm configSettingsForm = new ConfigurationSettingsForm(logger, app);

            configSettingsForm.FormClosed += new FormClosedEventHandler(ConfigFormClosed);
            configSettingsForm.ShowDialog();
        }

        private void ConfigFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
        }

        private void btnCustViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                app.SetDataSourceToCustomTimeFrame(this);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                logger.Error(ex.StackTrace);
            }

        }

        private void ApplyDGVFilter(object sender, EventArgs e)
        {
            List<RadioButton> shipDestinationRadioButtons = new List<RadioButton>();
            shipDestinationRadioButtons.Add(rbExtendedDetailFilter_All);
            shipDestinationRadioButtons.Add(rbExtendedDetail_Standard);
            shipDestinationRadioButtons.Add(rbExtendedDetail_Store);
            shipDestinationRadioButtons.Add(rbExtendedDetail_International);

            List<RadioButton> shipDeliveryTypeRadioButtons = new List<RadioButton>();
            shipDeliveryTypeRadioButtons.Add(rbDGVFilter_ByShipMethod_All);
            shipDeliveryTypeRadioButtons.Add(rbDGVFilter_ByShipMethod_Express);
            shipDeliveryTypeRadioButtons.Add(rbDGVFilter_ByShipMethod_Standard);

            foreach(RadioButton destinationRadioBtn in shipDestinationRadioButtons)
            {
                if(destinationRadioBtn.Checked)
                {
                    foreach (RadioButton deliveryRadioBtn in shipDeliveryTypeRadioButtons)
                    {
                        if(deliveryRadioBtn.Checked)
                        {
                            app.FilterDGV_ByDelivery(dgvDetailBreakdown, destinationRadioBtn.Text, deliveryRadioBtn.Text);
                        }
                    }
                }
            }
        }

        private void btnCustPrintReport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            app.ExportCleanReport_CustomTimeFrame_ToExcel(this);
            Cursor.Current = Cursors.Default;
        }

        private void btnLast24HrsPrintReport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            app.ExportCleanReport_24Hrs_ToExcel();
            Cursor.Current = Cursors.Default;
        }

        private void btnExportCurrentScreenToExcel_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            app.ExportDGV_ToExcel(this);
            Cursor.Current = Cursors.Default;
        }

        private void cbUseCutoffTimes_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
