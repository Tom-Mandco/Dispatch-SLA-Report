namespace MandCo.Applications.DispatchSLAReport
{
    using System;
    using System.Windows.Forms;
    using Interfaces;

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

        private void ApplyDGVFilter_ShipDestination(object sender, EventArgs e)
        {
            if (rbExtendedDetail_Standard.Checked)
                app.FilterDGV(dgvDetailBreakdown, "Standard");
            else if (rbExtendedDetail_International.Checked)
                app.FilterDGV(dgvDetailBreakdown, "International");
            else if (rbExtendedDetail_Store.Checked)
                app.FilterDGV(dgvDetailBreakdown, "Store");
            else
                app.FilterDGV(dgvDetailBreakdown, "All");
        }

        private void ApplyDGVFilter_DeliveryOption(object sender, EventArgs e)
        {
            if (rbDGVFilter_ByShipMethod_Express.Checked)
                app.FilterDGV_ByDeliveryOption(dgvDetailBreakdown, "Express");
            else if (rbDGVFilter_ByShipMethod_Standard.Checked)
                app.FilterDGV_ByDeliveryOption(dgvDetailBreakdown, "Standard");
            else
                app.FilterDGV_ByDeliveryOption(dgvDetailBreakdown, "All");
        }

        private void btnCustPrintReport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            app.ExportCleanReport_CustomTimeFrame_ToExcel(this);
            Cursor.Current = Cursors.Default;
        }

        private void cbUseCutoffTimes_CheckedChanged(object sender, EventArgs e)
        {
            
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
    }
}
