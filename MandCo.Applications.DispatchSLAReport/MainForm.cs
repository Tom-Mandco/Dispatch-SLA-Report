namespace MandCo.Applications.DispatchSLAReport
{
    using System;
    using System.Windows.Forms;
    using Interfaces;
    using System.Collections.Generic;
    using System.Threading;
    using System.Configuration;

    public partial class MainForm : Form
    {
        private readonly ILog logger;
        private readonly IApp app;
        static Thread ms_oThread = null;

        public MainForm(ILog logger, IApp app)
        {
            this.logger = logger;
            this.app = app;
            InitializeComponent();
            logger.Info("Application Started");
        }

        #region Utilities
        private void RenderAdminVisibility()
        {
            this.btnOpenConfigSettings.Visible = true;
        }

        private void ConfigFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
        }
        static public void ShowSplashScreen()
        {
            ms_oThread = new Thread(new ThreadStart(SplashScreen.ShowForm));
            ms_oThread.IsBackground = true;
            ms_oThread.SetApartmentState(ApartmentState.STA);
            ms_oThread.Start();
        }

        static public void CloseSplashScreen()
        {
            ms_oThread.Abort();
        }
        #endregion

        #region Main
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

            foreach (RadioButton destinationRadioBtn in shipDestinationRadioButtons)
            {
                if (destinationRadioBtn.Checked)
                {
                    foreach (RadioButton deliveryRadioBtn in shipDeliveryTypeRadioButtons)
                    {
                        if (deliveryRadioBtn.Checked)
                        {
                            app.FilterDGV_ByDelivery(dgvDetailBreakdown, destinationRadioBtn.Text, deliveryRadioBtn.Text);
                        }
                    }
                }
            }
        }
        #endregion

        #region Events
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
                DateTime dtStart = DateTime.Now;
                ShowSplashScreen();

                dtpReportFrom.Value = DateTime.Now.AddDays(-7);
                dtpReportTo.Value = DateTime.Now;
                logger.Info("Setting start up data sources");
                app.SetDataSourceToLast24Hours(this);
                app.SetDataSourceToCustomTimeFrame(this);

                if (app.Return_AdminStatus_ToBool())
                    RenderAdminVisibility();

                CloseSplashScreen();
                TimeSpan totalTimeTakenToLoad = DateTime.Now - dtStart;
                logger.Info("Time taken to load initial screen: {0:ss'.'FFFF' ms'}", totalTimeTakenToLoad);

                this.TopMost = true;
                this.TopMost = false;
            }
            catch (Exception ex)
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
        #endregion

    }
}
