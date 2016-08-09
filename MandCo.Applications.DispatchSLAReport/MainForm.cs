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
        }

        private void btnLast24HrsViewReport_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dtpReportFrom.Value = DateTime.Now.AddDays(-7);
            app.BindConfigDataToForm(this);
            app.Bind24HrDisplayDataToForm(this);
            app.BindCustomDisplayDataToForm(this);
            app.BindSLADataTableToDGVDataSource(this);
            
            this.Refresh();
        }

        private void btnReportCustomDateRange_Click(object sender, EventArgs e)
        {
            app.BindCustomDisplayDataToForm(this);
            app.Bind24HrDisplayDataToForm(this);
        }

        private void btnOpenConfigSettings_Click(object sender, EventArgs e)
        {
            ConfigurationSettingsForm configSettingsForm = new ConfigurationSettingsForm(logger, app);

            configSettingsForm.ShowDialog();
        }
    }
}
