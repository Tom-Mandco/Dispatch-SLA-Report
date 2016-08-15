namespace MandCo.Applications.DispatchSLAReport
{
    using System;
    using System.Windows.Forms;
    using Interfaces;
    using MandCo.Data.DispatchSLAReport.Models;

    public partial class ConfigurationSettingsForm : Form
    {
        private readonly ILog logger;
        private readonly IApp app;

        public ConfigurationSettingsForm(ILog logger, IApp app)
        {
            this.logger = logger;
            this.app = app;
            InitializeComponent();
        }

        private void ConfigurationSettingsForm_Load(object sender, EventArgs e)
        {
            populateConfigInfo();
        }

        private void populateConfigInfo()
        {
            Config_Information configInfo = app.GetConfigInformation();
            
            tbExpressPctHigh.Text = configInfo.Express_SLA_Percentage_High.ToString();
            tbExpressPctLow.Text = configInfo.Express_SLA_Percentage_Low.ToString();

            tbInternationalPctHigh.Text = configInfo.International_SLA_Percentage_High.ToString();
            tbInternationalPctLow.Text = configInfo.International_SLA_Percentage_Low.ToString();

            tbStandardPctHigh.Text = configInfo.Standard_SLA_Percentage_High.ToString();
            tbStandardPctLow.Text = configInfo.Standard_SLA_Percentage_Low.ToString();

            tbStorePctHigh.Text = configInfo.Store_SLA_Percentage_High.ToString();
            tbStorePctLow.Text = configInfo.Store_SLA_Percentage_Low.ToString();


            dtpExpressCutOff.Value = configInfo.Express_Cutoff_Time;
            dtpExpressSLA.Value = configInfo.Express_SLA_Time;

            dtpInternationalCutOff.Value = configInfo.International_Cutoff_Time;
            dtpInternationalSLA.Value = configInfo.International_SLA_Time;

            dtpStandardCutOff.Value = configInfo.Standard_Cutoff_Time;
            dtpStandardSLA.Value = configInfo.Standard_SLA_Time;

            dtpStoreCutOff.Value = configInfo.Store_Cutoff_Time;
            dtpStoreSLA.Value = configInfo.Store_SLA_Time;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to save changes?", "Save changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Config_Information updatedConfigInto = new Config_Information();
                int expressHigh = 100, expressLow = 90;
                int internationalHigh = 90, internationalLow = 80;
                int standardHigh = 90, standardLow = 80;
                int storeHigh = 90, storeLow = 80;

                int.TryParse(tbExpressPctHigh.Text, out expressHigh);
                int.TryParse(tbExpressPctLow.Text, out expressLow);
                int.TryParse(tbInternationalPctHigh.Text, out internationalHigh);
                int.TryParse(tbInternationalPctLow.Text, out internationalLow);
                int.TryParse(tbStandardPctHigh.Text, out standardHigh);
                int.TryParse(tbStandardPctLow.Text, out standardLow);
                int.TryParse(tbStorePctHigh.Text, out storeHigh);
                int.TryParse(tbStorePctLow.Text, out storeLow);

                updatedConfigInto.Express_Cutoff_Time = dtpExpressCutOff.Value;
                updatedConfigInto.Express_SLA_Time = dtpExpressSLA.Value;
                updatedConfigInto.Express_SLA_Percentage_High = expressHigh;
                updatedConfigInto.Express_SLA_Percentage_Low = expressLow;

                updatedConfigInto.International_Cutoff_Time = dtpInternationalCutOff.Value;
                updatedConfigInto.International_SLA_Time = dtpInternationalSLA.Value;
                updatedConfigInto.International_SLA_Percentage_High = internationalHigh;
                updatedConfigInto.International_SLA_Percentage_Low = internationalLow;

                updatedConfigInto.Standard_Cutoff_Time = dtpStandardCutOff.Value;
                updatedConfigInto.Standard_SLA_Time = dtpStandardSLA.Value;
                updatedConfigInto.Standard_SLA_Percentage_High = standardHigh;
                updatedConfigInto.Standard_SLA_Percentage_Low = standardLow;

                updatedConfigInto.Store_Cutoff_Time = dtpStoreCutOff.Value;
                updatedConfigInto.Store_SLA_Time = dtpStoreSLA.Value;
                updatedConfigInto.Store_SLA_Percentage_High = storeHigh;
                updatedConfigInto.Store_SLA_Percentage_Low = storeLow;

                try
                {
                    app.UpdateConfigInformation(updatedConfigInto);
                }
                catch(Exception ex)
                {
                    logger.Error(ex.Message);
                    logger.Error(ex.StackTrace);
                }
            }
        }

        private void btnDiscardChanges_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to revert all changes?", "Discard changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if(result == System.Windows.Forms.DialogResult.Yes)
                populateConfigInfo();
        }

    }
}