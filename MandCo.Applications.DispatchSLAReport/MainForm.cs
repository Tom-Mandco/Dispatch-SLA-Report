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

        private void btnCustPrintReport_Click(object sender, EventArgs e)
        {
            app.ExportCleanReport_CustomTimeFrame_ToExcel(this);
        }

        private void cbUseCutoffTimes_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLast24HrsPrintReport_Click(object sender, EventArgs e)
        {
            app.ExportCleanReport_24Hrs_ToExcel();
        }

        private void btnExportCurrentScreenToExcel_Click(object sender, EventArgs e)
        {
            app.ExportDGV_ToExcel(this);
        }
    }
}
