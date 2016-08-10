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
            app.SetDataSourceToLast24Hours(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                dtpReportFrom.Value = DateTime.Now.AddDays(-7);
                app.BindConfigDataToForm(this);
                app.Bind24HrDisplayDataToForm(this);
                app.BindCustomDisplayDataToForm(this);
                app.SetDataSourceToCustomTimeFrame(this);

                this.Refresh();
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
            app.BindCustomDisplayDataToForm(this);
            app.Bind24HrDisplayDataToForm(this);
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

            configSettingsForm.ShowDialog();
        }

        private void btnCustViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                app.SetDataSourceToCustomTimeFrame(this);
                app.BindCustomDisplayDataToForm(this);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                logger.Error(ex.StackTrace);
            }

        }
    }
}
