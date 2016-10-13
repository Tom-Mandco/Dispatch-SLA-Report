namespace MandCo.Applications.DispatchSLAReport
{
    partial class ConfigurationSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeaderLabel = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDiscardChanges = new System.Windows.Forms.Button();
            this.gbDispatchCutOffTimes = new System.Windows.Forms.GroupBox();
            this.dtpStoreCutOff = new System.Windows.Forms.DateTimePicker();
            this.lblStoreCutOffHdr = new System.Windows.Forms.Label();
            this.dtpStandardCutOff = new System.Windows.Forms.DateTimePicker();
            this.lblStandardCutOffHdr = new System.Windows.Forms.Label();
            this.dtpInternationalCutOff = new System.Windows.Forms.DateTimePicker();
            this.lblInternationalCutOffHdr = new System.Windows.Forms.Label();
            this.dtpExpressCutOff = new System.Windows.Forms.DateTimePicker();
            this.lblExpressCutOffHdr = new System.Windows.Forms.Label();
            this.gbDispatchSLAPct = new System.Windows.Forms.GroupBox();
            this.tbStorePctLow = new System.Windows.Forms.TextBox();
            this.tbStandardPctLow = new System.Windows.Forms.TextBox();
            this.tbInternationalPctLow = new System.Windows.Forms.TextBox();
            this.tbExpressPctLow = new System.Windows.Forms.TextBox();
            this.tbStorePctHigh = new System.Windows.Forms.TextBox();
            this.tbStandardPctHigh = new System.Windows.Forms.TextBox();
            this.tbInternationalPctHigh = new System.Windows.Forms.TextBox();
            this.tbExpressPctHigh = new System.Windows.Forms.TextBox();
            this.lblStoreLowHdr = new System.Windows.Forms.Label();
            this.lblStandardLowHdr = new System.Windows.Forms.Label();
            this.lblInternationalLowHdr = new System.Windows.Forms.Label();
            this.lblExpressLowHdr = new System.Windows.Forms.Label();
            this.lblStorePctHdr = new System.Windows.Forms.Label();
            this.lblStandardPctHdr = new System.Windows.Forms.Label();
            this.lblInternationalPctHdr = new System.Windows.Forms.Label();
            this.lblExpressPctHdr = new System.Windows.Forms.Label();
            this.gbDispatchSLATimes = new System.Windows.Forms.GroupBox();
            this.dtpStoreSLA = new System.Windows.Forms.DateTimePicker();
            this.lblStoreSLAHdr = new System.Windows.Forms.Label();
            this.dtpStandardSLA = new System.Windows.Forms.DateTimePicker();
            this.lblStandardSLAHdr = new System.Windows.Forms.Label();
            this.dtpInternationalSLA = new System.Windows.Forms.DateTimePicker();
            this.lblInternationalSLAHdr = new System.Windows.Forms.Label();
            this.dtpExpressSLA = new System.Windows.Forms.DateTimePicker();
            this.lblExpressSLAHdr = new System.Windows.Forms.Label();
            this.lblRetrospectiveWarning = new System.Windows.Forms.Label();
            this.dtpWeekendCutOff = new System.Windows.Forms.DateTimePicker();
            this.lblWeekendCutOffHdr = new System.Windows.Forms.Label();
            this.dtpWeekendSLA = new System.Windows.Forms.DateTimePicker();
            this.lblWeekendSLAHdr = new System.Windows.Forms.Label();
            this.lblAdminAccs = new System.Windows.Forms.Label();
            this.gbDispatchCutOffTimes.SuspendLayout();
            this.gbDispatchSLAPct.SuspendLayout();
            this.gbDispatchSLATimes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeaderLabel
            // 
            this.lblHeaderLabel.AutoSize = true;
            this.lblHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.lblHeaderLabel.Name = "lblHeaderLabel";
            this.lblHeaderLabel.Size = new System.Drawing.Size(159, 16);
            this.lblHeaderLabel.TabIndex = 0;
            this.lblHeaderLabel.Text = "Configuration Settings";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(366, 208);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(298, 23);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDiscardChanges
            // 
            this.btnDiscardChanges.Location = new System.Drawing.Point(12, 208);
            this.btnDiscardChanges.Name = "btnDiscardChanges";
            this.btnDiscardChanges.Size = new System.Drawing.Size(348, 23);
            this.btnDiscardChanges.TabIndex = 2;
            this.btnDiscardChanges.Text = "Discard Changes";
            this.btnDiscardChanges.UseVisualStyleBackColor = true;
            this.btnDiscardChanges.Click += new System.EventHandler(this.btnDiscardChanges_Click);
            // 
            // gbDispatchCutOffTimes
            // 
            this.gbDispatchCutOffTimes.Controls.Add(this.dtpWeekendCutOff);
            this.gbDispatchCutOffTimes.Controls.Add(this.lblWeekendCutOffHdr);
            this.gbDispatchCutOffTimes.Controls.Add(this.dtpStoreCutOff);
            this.gbDispatchCutOffTimes.Controls.Add(this.lblStoreCutOffHdr);
            this.gbDispatchCutOffTimes.Controls.Add(this.dtpStandardCutOff);
            this.gbDispatchCutOffTimes.Controls.Add(this.lblStandardCutOffHdr);
            this.gbDispatchCutOffTimes.Controls.Add(this.dtpInternationalCutOff);
            this.gbDispatchCutOffTimes.Controls.Add(this.lblInternationalCutOffHdr);
            this.gbDispatchCutOffTimes.Controls.Add(this.dtpExpressCutOff);
            this.gbDispatchCutOffTimes.Controls.Add(this.lblExpressCutOffHdr);
            this.gbDispatchCutOffTimes.Location = new System.Drawing.Point(12, 42);
            this.gbDispatchCutOffTimes.Name = "gbDispatchCutOffTimes";
            this.gbDispatchCutOffTimes.Size = new System.Drawing.Size(171, 160);
            this.gbDispatchCutOffTimes.TabIndex = 3;
            this.gbDispatchCutOffTimes.TabStop = false;
            this.gbDispatchCutOffTimes.Text = "Dispatch Cut Off Times";
            // 
            // dtpStoreCutOff
            // 
            this.dtpStoreCutOff.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStoreCutOff.Location = new System.Drawing.Point(88, 99);
            this.dtpStoreCutOff.Name = "dtpStoreCutOff";
            this.dtpStoreCutOff.ShowUpDown = true;
            this.dtpStoreCutOff.Size = new System.Drawing.Size(72, 20);
            this.dtpStoreCutOff.TabIndex = 7;
            // 
            // lblStoreCutOffHdr
            // 
            this.lblStoreCutOffHdr.AutoSize = true;
            this.lblStoreCutOffHdr.Location = new System.Drawing.Point(7, 103);
            this.lblStoreCutOffHdr.Name = "lblStoreCutOffHdr";
            this.lblStoreCutOffHdr.Size = new System.Drawing.Size(35, 13);
            this.lblStoreCutOffHdr.TabIndex = 6;
            this.lblStoreCutOffHdr.Text = "Store:";
            // 
            // dtpStandardCutOff
            // 
            this.dtpStandardCutOff.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStandardCutOff.Location = new System.Drawing.Point(88, 73);
            this.dtpStandardCutOff.Name = "dtpStandardCutOff";
            this.dtpStandardCutOff.ShowUpDown = true;
            this.dtpStandardCutOff.Size = new System.Drawing.Size(72, 20);
            this.dtpStandardCutOff.TabIndex = 5;
            // 
            // lblStandardCutOffHdr
            // 
            this.lblStandardCutOffHdr.AutoSize = true;
            this.lblStandardCutOffHdr.Location = new System.Drawing.Point(7, 77);
            this.lblStandardCutOffHdr.Name = "lblStandardCutOffHdr";
            this.lblStandardCutOffHdr.Size = new System.Drawing.Size(53, 13);
            this.lblStandardCutOffHdr.TabIndex = 4;
            this.lblStandardCutOffHdr.Text = "Standard:";
            // 
            // dtpInternationalCutOff
            // 
            this.dtpInternationalCutOff.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpInternationalCutOff.Location = new System.Drawing.Point(88, 47);
            this.dtpInternationalCutOff.Name = "dtpInternationalCutOff";
            this.dtpInternationalCutOff.ShowUpDown = true;
            this.dtpInternationalCutOff.Size = new System.Drawing.Size(72, 20);
            this.dtpInternationalCutOff.TabIndex = 3;
            // 
            // lblInternationalCutOffHdr
            // 
            this.lblInternationalCutOffHdr.AutoSize = true;
            this.lblInternationalCutOffHdr.Location = new System.Drawing.Point(7, 51);
            this.lblInternationalCutOffHdr.Name = "lblInternationalCutOffHdr";
            this.lblInternationalCutOffHdr.Size = new System.Drawing.Size(68, 13);
            this.lblInternationalCutOffHdr.TabIndex = 2;
            this.lblInternationalCutOffHdr.Text = "International:";
            // 
            // dtpExpressCutOff
            // 
            this.dtpExpressCutOff.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpExpressCutOff.Location = new System.Drawing.Point(88, 21);
            this.dtpExpressCutOff.Name = "dtpExpressCutOff";
            this.dtpExpressCutOff.ShowUpDown = true;
            this.dtpExpressCutOff.Size = new System.Drawing.Size(72, 20);
            this.dtpExpressCutOff.TabIndex = 1;
            // 
            // lblExpressCutOffHdr
            // 
            this.lblExpressCutOffHdr.AutoSize = true;
            this.lblExpressCutOffHdr.Location = new System.Drawing.Point(7, 25);
            this.lblExpressCutOffHdr.Name = "lblExpressCutOffHdr";
            this.lblExpressCutOffHdr.Size = new System.Drawing.Size(47, 13);
            this.lblExpressCutOffHdr.TabIndex = 0;
            this.lblExpressCutOffHdr.Text = "Express:";
            // 
            // gbDispatchSLAPct
            // 
            this.gbDispatchSLAPct.Controls.Add(this.tbStorePctLow);
            this.gbDispatchSLAPct.Controls.Add(this.tbStandardPctLow);
            this.gbDispatchSLAPct.Controls.Add(this.tbInternationalPctLow);
            this.gbDispatchSLAPct.Controls.Add(this.tbExpressPctLow);
            this.gbDispatchSLAPct.Controls.Add(this.tbStorePctHigh);
            this.gbDispatchSLAPct.Controls.Add(this.tbStandardPctHigh);
            this.gbDispatchSLAPct.Controls.Add(this.tbInternationalPctHigh);
            this.gbDispatchSLAPct.Controls.Add(this.tbExpressPctHigh);
            this.gbDispatchSLAPct.Controls.Add(this.lblStoreLowHdr);
            this.gbDispatchSLAPct.Controls.Add(this.lblStandardLowHdr);
            this.gbDispatchSLAPct.Controls.Add(this.lblInternationalLowHdr);
            this.gbDispatchSLAPct.Controls.Add(this.lblExpressLowHdr);
            this.gbDispatchSLAPct.Controls.Add(this.lblStorePctHdr);
            this.gbDispatchSLAPct.Controls.Add(this.lblStandardPctHdr);
            this.gbDispatchSLAPct.Controls.Add(this.lblInternationalPctHdr);
            this.gbDispatchSLAPct.Controls.Add(this.lblExpressPctHdr);
            this.gbDispatchSLAPct.Location = new System.Drawing.Point(366, 42);
            this.gbDispatchSLAPct.Name = "gbDispatchSLAPct";
            this.gbDispatchSLAPct.Size = new System.Drawing.Size(298, 133);
            this.gbDispatchSLAPct.TabIndex = 4;
            this.gbDispatchSLAPct.TabStop = false;
            this.gbDispatchSLAPct.Text = "Dispatch SLA Percentiles";
            // 
            // tbStorePctLow
            // 
            this.tbStorePctLow.Location = new System.Drawing.Point(239, 100);
            this.tbStorePctLow.Name = "tbStorePctLow";
            this.tbStorePctLow.Size = new System.Drawing.Size(46, 20);
            this.tbStorePctLow.TabIndex = 15;
            // 
            // tbStandardPctLow
            // 
            this.tbStandardPctLow.Location = new System.Drawing.Point(239, 74);
            this.tbStandardPctLow.Name = "tbStandardPctLow";
            this.tbStandardPctLow.Size = new System.Drawing.Size(46, 20);
            this.tbStandardPctLow.TabIndex = 14;
            // 
            // tbInternationalPctLow
            // 
            this.tbInternationalPctLow.Location = new System.Drawing.Point(239, 48);
            this.tbInternationalPctLow.Name = "tbInternationalPctLow";
            this.tbInternationalPctLow.Size = new System.Drawing.Size(46, 20);
            this.tbInternationalPctLow.TabIndex = 13;
            // 
            // tbExpressPctLow
            // 
            this.tbExpressPctLow.Location = new System.Drawing.Point(239, 22);
            this.tbExpressPctLow.Name = "tbExpressPctLow";
            this.tbExpressPctLow.Size = new System.Drawing.Size(46, 20);
            this.tbExpressPctLow.TabIndex = 12;
            // 
            // tbStorePctHigh
            // 
            this.tbStorePctHigh.Location = new System.Drawing.Point(148, 100);
            this.tbStorePctHigh.Name = "tbStorePctHigh";
            this.tbStorePctHigh.Size = new System.Drawing.Size(46, 20);
            this.tbStorePctHigh.TabIndex = 11;
            // 
            // tbStandardPctHigh
            // 
            this.tbStandardPctHigh.Location = new System.Drawing.Point(148, 74);
            this.tbStandardPctHigh.Name = "tbStandardPctHigh";
            this.tbStandardPctHigh.Size = new System.Drawing.Size(46, 20);
            this.tbStandardPctHigh.TabIndex = 10;
            // 
            // tbInternationalPctHigh
            // 
            this.tbInternationalPctHigh.Location = new System.Drawing.Point(148, 48);
            this.tbInternationalPctHigh.Name = "tbInternationalPctHigh";
            this.tbInternationalPctHigh.Size = new System.Drawing.Size(46, 20);
            this.tbInternationalPctHigh.TabIndex = 9;
            // 
            // tbExpressPctHigh
            // 
            this.tbExpressPctHigh.Location = new System.Drawing.Point(148, 22);
            this.tbExpressPctHigh.Name = "tbExpressPctHigh";
            this.tbExpressPctHigh.Size = new System.Drawing.Size(46, 20);
            this.tbExpressPctHigh.TabIndex = 8;
            // 
            // lblStoreLowHdr
            // 
            this.lblStoreLowHdr.AutoSize = true;
            this.lblStoreLowHdr.Location = new System.Drawing.Point(200, 103);
            this.lblStoreLowHdr.Name = "lblStoreLowHdr";
            this.lblStoreLowHdr.Size = new System.Drawing.Size(33, 13);
            this.lblStoreLowHdr.TabIndex = 7;
            this.lblStoreLowHdr.Text = "(Low)";
            // 
            // lblStandardLowHdr
            // 
            this.lblStandardLowHdr.AutoSize = true;
            this.lblStandardLowHdr.Location = new System.Drawing.Point(200, 77);
            this.lblStandardLowHdr.Name = "lblStandardLowHdr";
            this.lblStandardLowHdr.Size = new System.Drawing.Size(33, 13);
            this.lblStandardLowHdr.TabIndex = 6;
            this.lblStandardLowHdr.Text = "(Low)";
            // 
            // lblInternationalLowHdr
            // 
            this.lblInternationalLowHdr.AutoSize = true;
            this.lblInternationalLowHdr.Location = new System.Drawing.Point(200, 51);
            this.lblInternationalLowHdr.Name = "lblInternationalLowHdr";
            this.lblInternationalLowHdr.Size = new System.Drawing.Size(33, 13);
            this.lblInternationalLowHdr.TabIndex = 5;
            this.lblInternationalLowHdr.Text = "(Low)";
            // 
            // lblExpressLowHdr
            // 
            this.lblExpressLowHdr.AutoSize = true;
            this.lblExpressLowHdr.Location = new System.Drawing.Point(200, 25);
            this.lblExpressLowHdr.Name = "lblExpressLowHdr";
            this.lblExpressLowHdr.Size = new System.Drawing.Size(33, 13);
            this.lblExpressLowHdr.TabIndex = 4;
            this.lblExpressLowHdr.Text = "(Low)";
            // 
            // lblStorePctHdr
            // 
            this.lblStorePctHdr.AutoSize = true;
            this.lblStorePctHdr.Location = new System.Drawing.Point(15, 103);
            this.lblStorePctHdr.Name = "lblStorePctHdr";
            this.lblStorePctHdr.Size = new System.Drawing.Size(84, 13);
            this.lblStorePctHdr.TabIndex = 3;
            this.lblStorePctHdr.Text = "Store SLA (high)";
            // 
            // lblStandardPctHdr
            // 
            this.lblStandardPctHdr.AutoSize = true;
            this.lblStandardPctHdr.Location = new System.Drawing.Point(15, 77);
            this.lblStandardPctHdr.Name = "lblStandardPctHdr";
            this.lblStandardPctHdr.Size = new System.Drawing.Size(102, 13);
            this.lblStandardPctHdr.TabIndex = 2;
            this.lblStandardPctHdr.Text = "Standard SLA (high)";
            // 
            // lblInternationalPctHdr
            // 
            this.lblInternationalPctHdr.AutoSize = true;
            this.lblInternationalPctHdr.Location = new System.Drawing.Point(15, 51);
            this.lblInternationalPctHdr.Name = "lblInternationalPctHdr";
            this.lblInternationalPctHdr.Size = new System.Drawing.Size(117, 13);
            this.lblInternationalPctHdr.TabIndex = 1;
            this.lblInternationalPctHdr.Text = "International SLA (high)";
            // 
            // lblExpressPctHdr
            // 
            this.lblExpressPctHdr.AutoSize = true;
            this.lblExpressPctHdr.Location = new System.Drawing.Point(15, 25);
            this.lblExpressPctHdr.Name = "lblExpressPctHdr";
            this.lblExpressPctHdr.Size = new System.Drawing.Size(96, 13);
            this.lblExpressPctHdr.TabIndex = 0;
            this.lblExpressPctHdr.Text = "Express SLA (high)";
            // 
            // gbDispatchSLATimes
            // 
            this.gbDispatchSLATimes.Controls.Add(this.dtpWeekendSLA);
            this.gbDispatchSLATimes.Controls.Add(this.lblWeekendSLAHdr);
            this.gbDispatchSLATimes.Controls.Add(this.dtpStoreSLA);
            this.gbDispatchSLATimes.Controls.Add(this.lblStoreSLAHdr);
            this.gbDispatchSLATimes.Controls.Add(this.dtpStandardSLA);
            this.gbDispatchSLATimes.Controls.Add(this.lblStandardSLAHdr);
            this.gbDispatchSLATimes.Controls.Add(this.dtpInternationalSLA);
            this.gbDispatchSLATimes.Controls.Add(this.lblInternationalSLAHdr);
            this.gbDispatchSLATimes.Controls.Add(this.dtpExpressSLA);
            this.gbDispatchSLATimes.Controls.Add(this.lblExpressSLAHdr);
            this.gbDispatchSLATimes.Location = new System.Drawing.Point(189, 42);
            this.gbDispatchSLATimes.Name = "gbDispatchSLATimes";
            this.gbDispatchSLATimes.Size = new System.Drawing.Size(171, 160);
            this.gbDispatchSLATimes.TabIndex = 8;
            this.gbDispatchSLATimes.TabStop = false;
            this.gbDispatchSLATimes.Text = "Dispatch SLA Times";
            // 
            // dtpStoreSLA
            // 
            this.dtpStoreSLA.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStoreSLA.Location = new System.Drawing.Point(88, 99);
            this.dtpStoreSLA.Name = "dtpStoreSLA";
            this.dtpStoreSLA.ShowUpDown = true;
            this.dtpStoreSLA.Size = new System.Drawing.Size(72, 20);
            this.dtpStoreSLA.TabIndex = 7;
            // 
            // lblStoreSLAHdr
            // 
            this.lblStoreSLAHdr.AutoSize = true;
            this.lblStoreSLAHdr.Location = new System.Drawing.Point(7, 103);
            this.lblStoreSLAHdr.Name = "lblStoreSLAHdr";
            this.lblStoreSLAHdr.Size = new System.Drawing.Size(35, 13);
            this.lblStoreSLAHdr.TabIndex = 6;
            this.lblStoreSLAHdr.Text = "Store:";
            // 
            // dtpStandardSLA
            // 
            this.dtpStandardSLA.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStandardSLA.Location = new System.Drawing.Point(88, 73);
            this.dtpStandardSLA.Name = "dtpStandardSLA";
            this.dtpStandardSLA.ShowUpDown = true;
            this.dtpStandardSLA.Size = new System.Drawing.Size(72, 20);
            this.dtpStandardSLA.TabIndex = 5;
            // 
            // lblStandardSLAHdr
            // 
            this.lblStandardSLAHdr.AutoSize = true;
            this.lblStandardSLAHdr.Location = new System.Drawing.Point(7, 77);
            this.lblStandardSLAHdr.Name = "lblStandardSLAHdr";
            this.lblStandardSLAHdr.Size = new System.Drawing.Size(53, 13);
            this.lblStandardSLAHdr.TabIndex = 4;
            this.lblStandardSLAHdr.Text = "Standard:";
            // 
            // dtpInternationalSLA
            // 
            this.dtpInternationalSLA.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpInternationalSLA.Location = new System.Drawing.Point(88, 47);
            this.dtpInternationalSLA.Name = "dtpInternationalSLA";
            this.dtpInternationalSLA.ShowUpDown = true;
            this.dtpInternationalSLA.Size = new System.Drawing.Size(72, 20);
            this.dtpInternationalSLA.TabIndex = 3;
            // 
            // lblInternationalSLAHdr
            // 
            this.lblInternationalSLAHdr.AutoSize = true;
            this.lblInternationalSLAHdr.Location = new System.Drawing.Point(7, 51);
            this.lblInternationalSLAHdr.Name = "lblInternationalSLAHdr";
            this.lblInternationalSLAHdr.Size = new System.Drawing.Size(68, 13);
            this.lblInternationalSLAHdr.TabIndex = 2;
            this.lblInternationalSLAHdr.Text = "International:";
            // 
            // dtpExpressSLA
            // 
            this.dtpExpressSLA.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpExpressSLA.Location = new System.Drawing.Point(88, 21);
            this.dtpExpressSLA.Name = "dtpExpressSLA";
            this.dtpExpressSLA.ShowUpDown = true;
            this.dtpExpressSLA.Size = new System.Drawing.Size(72, 20);
            this.dtpExpressSLA.TabIndex = 1;
            // 
            // lblExpressSLAHdr
            // 
            this.lblExpressSLAHdr.AutoSize = true;
            this.lblExpressSLAHdr.Location = new System.Drawing.Point(7, 25);
            this.lblExpressSLAHdr.Name = "lblExpressSLAHdr";
            this.lblExpressSLAHdr.Size = new System.Drawing.Size(47, 13);
            this.lblExpressSLAHdr.TabIndex = 0;
            this.lblExpressSLAHdr.Text = "Express:";
            // 
            // lblRetrospectiveWarning
            // 
            this.lblRetrospectiveWarning.AutoSize = true;
            this.lblRetrospectiveWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetrospectiveWarning.ForeColor = System.Drawing.Color.Red;
            this.lblRetrospectiveWarning.Location = new System.Drawing.Point(461, 11);
            this.lblRetrospectiveWarning.Name = "lblRetrospectiveWarning";
            this.lblRetrospectiveWarning.Size = new System.Drawing.Size(203, 13);
            this.lblRetrospectiveWarning.TabIndex = 9;
            this.lblRetrospectiveWarning.Text = "Changes will apply retrospectively.";
            // 
            // dtpWeekendCutOff
            // 
            this.dtpWeekendCutOff.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpWeekendCutOff.Location = new System.Drawing.Point(88, 125);
            this.dtpWeekendCutOff.Name = "dtpWeekendCutOff";
            this.dtpWeekendCutOff.ShowUpDown = true;
            this.dtpWeekendCutOff.Size = new System.Drawing.Size(72, 20);
            this.dtpWeekendCutOff.TabIndex = 9;
            // 
            // lblWeekendCutOffHdr
            // 
            this.lblWeekendCutOffHdr.AutoSize = true;
            this.lblWeekendCutOffHdr.Location = new System.Drawing.Point(7, 129);
            this.lblWeekendCutOffHdr.Name = "lblWeekendCutOffHdr";
            this.lblWeekendCutOffHdr.Size = new System.Drawing.Size(57, 13);
            this.lblWeekendCutOffHdr.TabIndex = 8;
            this.lblWeekendCutOffHdr.Text = "Weekend:";
            // 
            // dtpWeekendSLA
            // 
            this.dtpWeekendSLA.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpWeekendSLA.Location = new System.Drawing.Point(88, 125);
            this.dtpWeekendSLA.Name = "dtpWeekendSLA";
            this.dtpWeekendSLA.ShowUpDown = true;
            this.dtpWeekendSLA.Size = new System.Drawing.Size(72, 20);
            this.dtpWeekendSLA.TabIndex = 9;
            // 
            // lblWeekendSLAHdr
            // 
            this.lblWeekendSLAHdr.AutoSize = true;
            this.lblWeekendSLAHdr.Location = new System.Drawing.Point(7, 129);
            this.lblWeekendSLAHdr.Name = "lblWeekendSLAHdr";
            this.lblWeekendSLAHdr.Size = new System.Drawing.Size(57, 13);
            this.lblWeekendSLAHdr.TabIndex = 8;
            this.lblWeekendSLAHdr.Text = "Weekend:";
            // 
            // lblAdminAccs
            // 
            this.lblAdminAccs.AutoSize = true;
            this.lblAdminAccs.Location = new System.Drawing.Point(381, 178);
            this.lblAdminAccs.Name = "lblAdminAccs";
            this.lblAdminAccs.Size = new System.Drawing.Size(0, 13);
            this.lblAdminAccs.TabIndex = 10;
            this.lblAdminAccs.Visible = false;
            // 
            // ConfigurationSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 244);
            this.Controls.Add(this.lblAdminAccs);
            this.Controls.Add(this.lblRetrospectiveWarning);
            this.Controls.Add(this.gbDispatchSLATimes);
            this.Controls.Add(this.gbDispatchSLAPct);
            this.Controls.Add(this.gbDispatchCutOffTimes);
            this.Controls.Add(this.btnDiscardChanges);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.lblHeaderLabel);
            this.Name = "ConfigurationSettingsForm";
            this.Text = "ConfigurationSettingsForm";
            this.Load += new System.EventHandler(this.ConfigurationSettingsForm_Load);
            this.gbDispatchCutOffTimes.ResumeLayout(false);
            this.gbDispatchCutOffTimes.PerformLayout();
            this.gbDispatchSLAPct.ResumeLayout(false);
            this.gbDispatchSLAPct.PerformLayout();
            this.gbDispatchSLATimes.ResumeLayout(false);
            this.gbDispatchSLATimes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderLabel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDiscardChanges;
        private System.Windows.Forms.GroupBox gbDispatchCutOffTimes;
        private System.Windows.Forms.Label lblStoreCutOffHdr;
        private System.Windows.Forms.Label lblStandardCutOffHdr;
        private System.Windows.Forms.Label lblInternationalCutOffHdr;
        private System.Windows.Forms.Label lblExpressCutOffHdr;
        private System.Windows.Forms.GroupBox gbDispatchSLAPct;
        public System.Windows.Forms.TextBox tbStorePctLow;
        public System.Windows.Forms.TextBox tbStandardPctLow;
        public System.Windows.Forms.TextBox tbInternationalPctLow;
        public System.Windows.Forms.TextBox tbExpressPctLow;
        public System.Windows.Forms.TextBox tbStorePctHigh;
        public System.Windows.Forms.TextBox tbStandardPctHigh;
        public System.Windows.Forms.TextBox tbInternationalPctHigh;
        public System.Windows.Forms.TextBox tbExpressPctHigh;
        private System.Windows.Forms.Label lblStoreLowHdr;
        private System.Windows.Forms.Label lblStandardLowHdr;
        private System.Windows.Forms.Label lblInternationalLowHdr;
        private System.Windows.Forms.Label lblExpressLowHdr;
        private System.Windows.Forms.Label lblStorePctHdr;
        private System.Windows.Forms.Label lblStandardPctHdr;
        private System.Windows.Forms.Label lblInternationalPctHdr;
        private System.Windows.Forms.Label lblExpressPctHdr;
        public System.Windows.Forms.DateTimePicker dtpStoreCutOff;
        public System.Windows.Forms.DateTimePicker dtpStandardCutOff;
        public System.Windows.Forms.DateTimePicker dtpInternationalCutOff;
        public System.Windows.Forms.DateTimePicker dtpExpressCutOff;
        private System.Windows.Forms.GroupBox gbDispatchSLATimes;
        public System.Windows.Forms.DateTimePicker dtpStoreSLA;
        private System.Windows.Forms.Label lblStoreSLAHdr;
        public System.Windows.Forms.DateTimePicker dtpStandardSLA;
        private System.Windows.Forms.Label lblStandardSLAHdr;
        public System.Windows.Forms.DateTimePicker dtpInternationalSLA;
        private System.Windows.Forms.Label lblInternationalSLAHdr;
        public System.Windows.Forms.DateTimePicker dtpExpressSLA;
        private System.Windows.Forms.Label lblExpressSLAHdr;
        private System.Windows.Forms.Label lblRetrospectiveWarning;
        public System.Windows.Forms.DateTimePicker dtpWeekendCutOff;
        private System.Windows.Forms.Label lblWeekendCutOffHdr;
        public System.Windows.Forms.DateTimePicker dtpWeekendSLA;
        private System.Windows.Forms.Label lblWeekendSLAHdr;
        private System.Windows.Forms.Label lblAdminAccs;
    }
}