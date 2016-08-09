namespace MandCo.Applications.DispatchSLAReport
{
    using System;
    using System.Windows.Forms;
    using Interfaces;

    public partial class MainForm : Form
    {
        public readonly ILog logger;
        public readonly IApp app;
        public DateTime customDateTimeFrom;
        public DateTime customDateTimeTo;

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
            app.BindCustomDisplayDataToForm(this);
            app.BindSLADataTableToDGVDataSource(this, true);
            this.Refresh();
        }
    }
}
