namespace MandCo.Applications.DispatchSLAReport
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbLast24Hrs = new System.Windows.Forms.GroupBox();
            this.lbl24HrsStoreSLADtlPct = new System.Windows.Forms.Label();
            this.lbl24HrsStandardSLADtlPct = new System.Windows.Forms.Label();
            this.lbl24HrsInternationalSLADtlPct = new System.Windows.Forms.Label();
            this.lbl24HrsExpressSLADtlPct = new System.Windows.Forms.Label();
            this.lbl24HrsTotalSLADtlPct = new System.Windows.Forms.Label();
            this.btnLast24HrsPrintReport = new System.Windows.Forms.Button();
            this.btnLast24HrsViewReport = new System.Windows.Forms.Button();
            this.lbl24HrsStoreSLAHdr = new System.Windows.Forms.Label();
            this.lbl24HrsStandardSLAHdr = new System.Windows.Forms.Label();
            this.lbl24HrsInternationalSLAHdr = new System.Windows.Forms.Label();
            this.lbl24HrsExpressSLAHdr = new System.Windows.Forms.Label();
            this.lbl24HrsTotalSLAHdr = new System.Windows.Forms.Label();
            this.gbCustomSLAStats = new System.Windows.Forms.GroupBox();
            this.lblCustTotalSLAHdr = new System.Windows.Forms.Label();
            this.lblCustStoreSLAHdr = new System.Windows.Forms.Label();
            this.lblCustExpressSLAHdr = new System.Windows.Forms.Label();
            this.lblCustStandardSLAHdr = new System.Windows.Forms.Label();
            this.lblCustInternationalSLAHdr = new System.Windows.Forms.Label();
            this.btnCustPrintReport = new System.Windows.Forms.Button();
            this.btnCustViewReport = new System.Windows.Forms.Button();
            this.lblCustStoreSLADtlPct = new System.Windows.Forms.Label();
            this.lblCustTotalSLADtlPct = new System.Windows.Forms.Label();
            this.lblCustStandardSLADtlPct = new System.Windows.Forms.Label();
            this.lblCustExpressSLADtlPct = new System.Windows.Forms.Label();
            this.lblCustInternationalSLADtlPct = new System.Windows.Forms.Label();
            this.pnAdminPanel = new System.Windows.Forms.Panel();
            this.btnOpenConfigSettings = new System.Windows.Forms.Button();
            this.lblConfigDetails = new System.Windows.Forms.Label();
            this.btnReportCustomDateRange = new System.Windows.Forms.Button();
            this.pnExtendedDetail = new System.Windows.Forms.Panel();
            this.pnOrderTotalsWithinSpecifiedTimeFrame = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStoreOrdersMetSLADtl = new System.Windows.Forms.Label();
            this.lblStoreOrdersDtl = new System.Windows.Forms.Label();
            this.lblStoreOrdersMetSLAHdr = new System.Windows.Forms.Label();
            this.lblStoreOrdersHdr = new System.Windows.Forms.Label();
            this.lblStandardOrdersMetSLADtl = new System.Windows.Forms.Label();
            this.lblStandardOrdersDtl = new System.Windows.Forms.Label();
            this.lblStandardOrdersMetSLAHdr = new System.Windows.Forms.Label();
            this.lblStandardOrdersHdr = new System.Windows.Forms.Label();
            this.lblInternationalOrdersMetSLADtl = new System.Windows.Forms.Label();
            this.lblInternationalOrdersDtl = new System.Windows.Forms.Label();
            this.lblInternationalOrdersMetSLAHdr = new System.Windows.Forms.Label();
            this.lblInternationalOrdersHdr = new System.Windows.Forms.Label();
            this.lblExpressMetSLADtl = new System.Windows.Forms.Label();
            this.lblExpressOrdersDtl = new System.Windows.Forms.Label();
            this.lblTotalOrdersMetSLADtl = new System.Windows.Forms.Label();
            this.lblTotalOrdersDtl = new System.Windows.Forms.Label();
            this.lblExpressMetSLAHdr = new System.Windows.Forms.Label();
            this.lblExpressOrdersHdr = new System.Windows.Forms.Label();
            this.lblTotalOrdersMetSLAHdr = new System.Windows.Forms.Label();
            this.lblTotalOrdersHdr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbExtendedDetailFilter_Store = new System.Windows.Forms.RadioButton();
            this.rbExtendedDetailFilter_All = new System.Windows.Forms.RadioButton();
            this.rbExtendedDetail_International = new System.Windows.Forms.RadioButton();
            this.rbExtendedDetail_Express = new System.Windows.Forms.RadioButton();
            this.rbExtendedDetail_Standard = new System.Windows.Forms.RadioButton();
            this.dgvDetailBreakdown = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.pnSLACriteriaMetKey = new System.Windows.Forms.Panel();
            this.lblCriteriaNotMetKey = new System.Windows.Forms.Label();
            this.lblMidCriteriaMetKey = new System.Windows.Forms.Label();
            this.lblTopCriteriaMetKey = new System.Windows.Forms.Label();
            this.pbCriteriaNotMetKey = new System.Windows.Forms.PictureBox();
            this.pbMidCriteriaMetKey = new System.Windows.Forms.PictureBox();
            this.pbTopCriteriaMetKey = new System.Windows.Forms.PictureBox();
            this.gbCustomDateRange = new System.Windows.Forms.GroupBox();
            this.cbCustomCutoff = new System.Windows.Forms.CheckBox();
            this.dtpReportTo = new System.Windows.Forms.DateTimePicker();
            this.lblReportTo = new System.Windows.Forms.Label();
            this.lblReportFrom = new System.Windows.Forms.Label();
            this.dtpReportFrom = new System.Windows.Forms.DateTimePicker();
            this.gbLast24Hrs.SuspendLayout();
            this.gbCustomSLAStats.SuspendLayout();
            this.pnAdminPanel.SuspendLayout();
            this.pnExtendedDetail.SuspendLayout();
            this.pnOrderTotalsWithinSpecifiedTimeFrame.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailBreakdown)).BeginInit();
            this.pnSLACriteriaMetKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCriteriaNotMetKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMidCriteriaMetKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopCriteriaMetKey)).BeginInit();
            this.gbCustomDateRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLast24Hrs
            // 
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsStoreSLADtlPct);
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsStandardSLADtlPct);
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsInternationalSLADtlPct);
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsExpressSLADtlPct);
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsTotalSLADtlPct);
            this.gbLast24Hrs.Controls.Add(this.btnLast24HrsPrintReport);
            this.gbLast24Hrs.Controls.Add(this.btnLast24HrsViewReport);
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsStoreSLAHdr);
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsStandardSLAHdr);
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsInternationalSLAHdr);
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsExpressSLAHdr);
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsTotalSLAHdr);
            this.gbLast24Hrs.Location = new System.Drawing.Point(9, 42);
            this.gbLast24Hrs.Name = "gbLast24Hrs";
            this.gbLast24Hrs.Size = new System.Drawing.Size(279, 193);
            this.gbLast24Hrs.TabIndex = 0;
            this.gbLast24Hrs.TabStop = false;
            this.gbLast24Hrs.Text = "Statistics from cut off point on : dd/mmm/yyyy";
            // 
            // lbl24HrsStoreSLADtlPct
            // 
            this.lbl24HrsStoreSLADtlPct.Location = new System.Drawing.Point(21, 123);
            this.lbl24HrsStoreSLADtlPct.Name = "lbl24HrsStoreSLADtlPct";
            this.lbl24HrsStoreSLADtlPct.Size = new System.Drawing.Size(40, 13);
            this.lbl24HrsStoreSLADtlPct.TabIndex = 9;
            this.lbl24HrsStoreSLADtlPct.Text = "  5.00";
            this.lbl24HrsStoreSLADtlPct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl24HrsStandardSLADtlPct
            // 
            this.lbl24HrsStandardSLADtlPct.Location = new System.Drawing.Point(21, 100);
            this.lbl24HrsStandardSLADtlPct.Name = "lbl24HrsStandardSLADtlPct";
            this.lbl24HrsStandardSLADtlPct.Size = new System.Drawing.Size(40, 13);
            this.lbl24HrsStandardSLADtlPct.TabIndex = 7;
            this.lbl24HrsStandardSLADtlPct.Text = "45.00";
            this.lbl24HrsStandardSLADtlPct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl24HrsInternationalSLADtlPct
            // 
            this.lbl24HrsInternationalSLADtlPct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl24HrsInternationalSLADtlPct.Location = new System.Drawing.Point(21, 77);
            this.lbl24HrsInternationalSLADtlPct.Name = "lbl24HrsInternationalSLADtlPct";
            this.lbl24HrsInternationalSLADtlPct.Size = new System.Drawing.Size(40, 13);
            this.lbl24HrsInternationalSLADtlPct.TabIndex = 5;
            this.lbl24HrsInternationalSLADtlPct.Text = "66.66";
            this.lbl24HrsInternationalSLADtlPct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl24HrsExpressSLADtlPct
            // 
            this.lbl24HrsExpressSLADtlPct.Location = new System.Drawing.Point(21, 54);
            this.lbl24HrsExpressSLADtlPct.Name = "lbl24HrsExpressSLADtlPct";
            this.lbl24HrsExpressSLADtlPct.Size = new System.Drawing.Size(40, 13);
            this.lbl24HrsExpressSLADtlPct.TabIndex = 3;
            this.lbl24HrsExpressSLADtlPct.Text = " 90.00";
            this.lbl24HrsExpressSLADtlPct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl24HrsTotalSLADtlPct
            // 
            this.lbl24HrsTotalSLADtlPct.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl24HrsTotalSLADtlPct.Location = new System.Drawing.Point(21, 31);
            this.lbl24HrsTotalSLADtlPct.Name = "lbl24HrsTotalSLADtlPct";
            this.lbl24HrsTotalSLADtlPct.Size = new System.Drawing.Size(40, 13);
            this.lbl24HrsTotalSLADtlPct.TabIndex = 1;
            this.lbl24HrsTotalSLADtlPct.Text = "100.00";
            this.lbl24HrsTotalSLADtlPct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLast24HrsPrintReport
            // 
            this.btnLast24HrsPrintReport.Location = new System.Drawing.Point(143, 160);
            this.btnLast24HrsPrintReport.Name = "btnLast24HrsPrintReport";
            this.btnLast24HrsPrintReport.Size = new System.Drawing.Size(131, 23);
            this.btnLast24HrsPrintReport.TabIndex = 11;
            this.btnLast24HrsPrintReport.Text = "Print Report";
            this.btnLast24HrsPrintReport.UseVisualStyleBackColor = true;
            // 
            // btnLast24HrsViewReport
            // 
            this.btnLast24HrsViewReport.Location = new System.Drawing.Point(6, 160);
            this.btnLast24HrsViewReport.Name = "btnLast24HrsViewReport";
            this.btnLast24HrsViewReport.Size = new System.Drawing.Size(131, 23);
            this.btnLast24HrsViewReport.TabIndex = 10;
            this.btnLast24HrsViewReport.Text = "View Report";
            this.btnLast24HrsViewReport.UseVisualStyleBackColor = true;
            this.btnLast24HrsViewReport.Click += new System.EventHandler(this.btnLast24HrsViewReport_Click);
            // 
            // lbl24HrsStoreSLAHdr
            // 
            this.lbl24HrsStoreSLAHdr.AutoSize = true;
            this.lbl24HrsStoreSLAHdr.Location = new System.Drawing.Point(59, 123);
            this.lbl24HrsStoreSLAHdr.Name = "lbl24HrsStoreSLAHdr";
            this.lbl24HrsStoreSLAHdr.Size = new System.Drawing.Size(169, 13);
            this.lbl24HrsStoreSLAHdr.TabIndex = 8;
            this.lbl24HrsStoreSLAHdr.Text = "% of the store orders met their SLA";
            // 
            // lbl24HrsStandardSLAHdr
            // 
            this.lbl24HrsStandardSLAHdr.AutoSize = true;
            this.lbl24HrsStandardSLAHdr.Location = new System.Drawing.Point(59, 100);
            this.lbl24HrsStandardSLAHdr.Name = "lbl24HrsStandardSLAHdr";
            this.lbl24HrsStandardSLAHdr.Size = new System.Drawing.Size(187, 13);
            this.lbl24HrsStandardSLAHdr.TabIndex = 6;
            this.lbl24HrsStandardSLAHdr.Text = "% of the standard orders met their SLA";
            // 
            // lbl24HrsInternationalSLAHdr
            // 
            this.lbl24HrsInternationalSLAHdr.AutoSize = true;
            this.lbl24HrsInternationalSLAHdr.Location = new System.Drawing.Point(59, 77);
            this.lbl24HrsInternationalSLAHdr.Name = "lbl24HrsInternationalSLAHdr";
            this.lbl24HrsInternationalSLAHdr.Size = new System.Drawing.Size(203, 13);
            this.lbl24HrsInternationalSLAHdr.TabIndex = 4;
            this.lbl24HrsInternationalSLAHdr.Text = "% of the international orders met their SLA";
            // 
            // lbl24HrsExpressSLAHdr
            // 
            this.lbl24HrsExpressSLAHdr.AutoSize = true;
            this.lbl24HrsExpressSLAHdr.Location = new System.Drawing.Point(59, 54);
            this.lbl24HrsExpressSLAHdr.Name = "lbl24HrsExpressSLAHdr";
            this.lbl24HrsExpressSLAHdr.Size = new System.Drawing.Size(182, 13);
            this.lbl24HrsExpressSLAHdr.TabIndex = 2;
            this.lbl24HrsExpressSLAHdr.Text = "% of the express orders met their SLA";
            // 
            // lbl24HrsTotalSLAHdr
            // 
            this.lbl24HrsTotalSLAHdr.AutoSize = true;
            this.lbl24HrsTotalSLAHdr.Location = new System.Drawing.Point(59, 31);
            this.lbl24HrsTotalSLAHdr.Name = "lbl24HrsTotalSLAHdr";
            this.lbl24HrsTotalSLAHdr.Size = new System.Drawing.Size(166, 13);
            this.lbl24HrsTotalSLAHdr.TabIndex = 0;
            this.lbl24HrsTotalSLAHdr.Text = "% of the total orders met their SLA";
            // 
            // gbCustomSLAStats
            // 
            this.gbCustomSLAStats.Controls.Add(this.lblCustTotalSLAHdr);
            this.gbCustomSLAStats.Controls.Add(this.lblCustStoreSLAHdr);
            this.gbCustomSLAStats.Controls.Add(this.lblCustExpressSLAHdr);
            this.gbCustomSLAStats.Controls.Add(this.lblCustStandardSLAHdr);
            this.gbCustomSLAStats.Controls.Add(this.lblCustInternationalSLAHdr);
            this.gbCustomSLAStats.Controls.Add(this.btnCustPrintReport);
            this.gbCustomSLAStats.Controls.Add(this.btnCustViewReport);
            this.gbCustomSLAStats.Controls.Add(this.lblCustStoreSLADtlPct);
            this.gbCustomSLAStats.Controls.Add(this.lblCustTotalSLADtlPct);
            this.gbCustomSLAStats.Controls.Add(this.lblCustStandardSLADtlPct);
            this.gbCustomSLAStats.Controls.Add(this.lblCustExpressSLADtlPct);
            this.gbCustomSLAStats.Controls.Add(this.lblCustInternationalSLADtlPct);
            this.gbCustomSLAStats.Location = new System.Drawing.Point(294, 42);
            this.gbCustomSLAStats.Name = "gbCustomSLAStats";
            this.gbCustomSLAStats.Size = new System.Drawing.Size(281, 193);
            this.gbCustomSLAStats.TabIndex = 1;
            this.gbCustomSLAStats.TabStop = false;
            this.gbCustomSLAStats.Text = "dd/mmm/yyyy hh:mm:ss - dd/mmm/yyyy hh:mm:ss";
            // 
            // lblCustTotalSLAHdr
            // 
            this.lblCustTotalSLAHdr.AutoSize = true;
            this.lblCustTotalSLAHdr.Location = new System.Drawing.Point(58, 31);
            this.lblCustTotalSLAHdr.Name = "lblCustTotalSLAHdr";
            this.lblCustTotalSLAHdr.Size = new System.Drawing.Size(166, 13);
            this.lblCustTotalSLAHdr.TabIndex = 12;
            this.lblCustTotalSLAHdr.Text = "% of the total orders met their SLA";
            // 
            // lblCustStoreSLAHdr
            // 
            this.lblCustStoreSLAHdr.AutoSize = true;
            this.lblCustStoreSLAHdr.Location = new System.Drawing.Point(58, 123);
            this.lblCustStoreSLAHdr.Name = "lblCustStoreSLAHdr";
            this.lblCustStoreSLAHdr.Size = new System.Drawing.Size(169, 13);
            this.lblCustStoreSLAHdr.TabIndex = 20;
            this.lblCustStoreSLAHdr.Text = "% of the store orders met their SLA";
            // 
            // lblCustExpressSLAHdr
            // 
            this.lblCustExpressSLAHdr.AutoSize = true;
            this.lblCustExpressSLAHdr.Location = new System.Drawing.Point(58, 54);
            this.lblCustExpressSLAHdr.Name = "lblCustExpressSLAHdr";
            this.lblCustExpressSLAHdr.Size = new System.Drawing.Size(182, 13);
            this.lblCustExpressSLAHdr.TabIndex = 14;
            this.lblCustExpressSLAHdr.Text = "% of the express orders met their SLA";
            // 
            // lblCustStandardSLAHdr
            // 
            this.lblCustStandardSLAHdr.AutoSize = true;
            this.lblCustStandardSLAHdr.Location = new System.Drawing.Point(58, 100);
            this.lblCustStandardSLAHdr.Name = "lblCustStandardSLAHdr";
            this.lblCustStandardSLAHdr.Size = new System.Drawing.Size(187, 13);
            this.lblCustStandardSLAHdr.TabIndex = 18;
            this.lblCustStandardSLAHdr.Text = "% of the standard orders met their SLA";
            // 
            // lblCustInternationalSLAHdr
            // 
            this.lblCustInternationalSLAHdr.AutoSize = true;
            this.lblCustInternationalSLAHdr.Location = new System.Drawing.Point(58, 77);
            this.lblCustInternationalSLAHdr.Name = "lblCustInternationalSLAHdr";
            this.lblCustInternationalSLAHdr.Size = new System.Drawing.Size(203, 13);
            this.lblCustInternationalSLAHdr.TabIndex = 16;
            this.lblCustInternationalSLAHdr.Text = "% of the international orders met their SLA";
            // 
            // btnCustPrintReport
            // 
            this.btnCustPrintReport.Location = new System.Drawing.Point(143, 160);
            this.btnCustPrintReport.Name = "btnCustPrintReport";
            this.btnCustPrintReport.Size = new System.Drawing.Size(131, 23);
            this.btnCustPrintReport.TabIndex = 23;
            this.btnCustPrintReport.Text = "Print Report";
            this.btnCustPrintReport.UseVisualStyleBackColor = true;
            // 
            // btnCustViewReport
            // 
            this.btnCustViewReport.Location = new System.Drawing.Point(6, 160);
            this.btnCustViewReport.Name = "btnCustViewReport";
            this.btnCustViewReport.Size = new System.Drawing.Size(131, 23);
            this.btnCustViewReport.TabIndex = 22;
            this.btnCustViewReport.Text = "View Report";
            this.btnCustViewReport.UseVisualStyleBackColor = true;
            // 
            // lblCustStoreSLADtlPct
            // 
            this.lblCustStoreSLADtlPct.Location = new System.Drawing.Point(10, 123);
            this.lblCustStoreSLADtlPct.Name = "lblCustStoreSLADtlPct";
            this.lblCustStoreSLADtlPct.Size = new System.Drawing.Size(50, 13);
            this.lblCustStoreSLADtlPct.TabIndex = 21;
            this.lblCustStoreSLADtlPct.Text = "5.00";
            this.lblCustStoreSLADtlPct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustTotalSLADtlPct
            // 
            this.lblCustTotalSLADtlPct.Location = new System.Drawing.Point(10, 31);
            this.lblCustTotalSLADtlPct.Name = "lblCustTotalSLADtlPct";
            this.lblCustTotalSLADtlPct.Size = new System.Drawing.Size(50, 13);
            this.lblCustTotalSLADtlPct.TabIndex = 13;
            this.lblCustTotalSLADtlPct.Text = "100.00";
            this.lblCustTotalSLADtlPct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustStandardSLADtlPct
            // 
            this.lblCustStandardSLADtlPct.Location = new System.Drawing.Point(10, 100);
            this.lblCustStandardSLADtlPct.Name = "lblCustStandardSLADtlPct";
            this.lblCustStandardSLADtlPct.Size = new System.Drawing.Size(50, 13);
            this.lblCustStandardSLADtlPct.TabIndex = 19;
            this.lblCustStandardSLADtlPct.Text = "45.00";
            this.lblCustStandardSLADtlPct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustExpressSLADtlPct
            // 
            this.lblCustExpressSLADtlPct.Location = new System.Drawing.Point(10, 54);
            this.lblCustExpressSLADtlPct.Name = "lblCustExpressSLADtlPct";
            this.lblCustExpressSLADtlPct.Size = new System.Drawing.Size(50, 13);
            this.lblCustExpressSLADtlPct.TabIndex = 15;
            this.lblCustExpressSLADtlPct.Text = "90.00";
            this.lblCustExpressSLADtlPct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustInternationalSLADtlPct
            // 
            this.lblCustInternationalSLADtlPct.Location = new System.Drawing.Point(10, 77);
            this.lblCustInternationalSLADtlPct.Name = "lblCustInternationalSLADtlPct";
            this.lblCustInternationalSLADtlPct.Size = new System.Drawing.Size(50, 13);
            this.lblCustInternationalSLADtlPct.TabIndex = 17;
            this.lblCustInternationalSLADtlPct.Text = "66.66";
            this.lblCustInternationalSLADtlPct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnAdminPanel
            // 
            this.pnAdminPanel.Controls.Add(this.btnOpenConfigSettings);
            this.pnAdminPanel.Controls.Add(this.lblConfigDetails);
            this.pnAdminPanel.Location = new System.Drawing.Point(804, 47);
            this.pnAdminPanel.Name = "pnAdminPanel";
            this.pnAdminPanel.Size = new System.Drawing.Size(378, 188);
            this.pnAdminPanel.TabIndex = 25;
            // 
            // btnOpenConfigSettings
            // 
            this.btnOpenConfigSettings.Location = new System.Drawing.Point(4, 155);
            this.btnOpenConfigSettings.Name = "btnOpenConfigSettings";
            this.btnOpenConfigSettings.Size = new System.Drawing.Size(370, 23);
            this.btnOpenConfigSettings.TabIndex = 1;
            this.btnOpenConfigSettings.Text = "Meddle with ye olde conflagration";
            this.btnOpenConfigSettings.UseVisualStyleBackColor = true;
            this.btnOpenConfigSettings.Click += new System.EventHandler(this.btnOpenConfigSettings_Click);
            // 
            // lblConfigDetails
            // 
            this.lblConfigDetails.AutoSize = true;
            this.lblConfigDetails.Location = new System.Drawing.Point(10, 10);
            this.lblConfigDetails.Name = "lblConfigDetails";
            this.lblConfigDetails.Size = new System.Drawing.Size(33, 39);
            this.lblConfigDetails.TabIndex = 0;
            this.lblConfigDetails.Text = "Multi\r\nLine\r\nLabel";
            // 
            // btnReportCustomDateRange
            // 
            this.btnReportCustomDateRange.Location = new System.Drawing.Point(6, 160);
            this.btnReportCustomDateRange.Name = "btnReportCustomDateRange";
            this.btnReportCustomDateRange.Size = new System.Drawing.Size(203, 23);
            this.btnReportCustomDateRange.TabIndex = 24;
            this.btnReportCustomDateRange.Text = "Report Custom Date Range";
            this.btnReportCustomDateRange.UseVisualStyleBackColor = true;
            this.btnReportCustomDateRange.Click += new System.EventHandler(this.btnReportCustomDateRange_Click);
            // 
            // pnExtendedDetail
            // 
            this.pnExtendedDetail.Controls.Add(this.pnOrderTotalsWithinSpecifiedTimeFrame);
            this.pnExtendedDetail.Controls.Add(this.panel1);
            this.pnExtendedDetail.Controls.Add(this.dgvDetailBreakdown);
            this.pnExtendedDetail.Controls.Add(this.label11);
            this.pnExtendedDetail.Controls.Add(this.pnSLACriteriaMetKey);
            this.pnExtendedDetail.Location = new System.Drawing.Point(9, 241);
            this.pnExtendedDetail.Name = "pnExtendedDetail";
            this.pnExtendedDetail.Size = new System.Drawing.Size(1173, 382);
            this.pnExtendedDetail.TabIndex = 2;
            // 
            // pnOrderTotalsWithinSpecifiedTimeFrame
            // 
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.label1);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblStoreOrdersMetSLADtl);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblStoreOrdersDtl);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblStoreOrdersMetSLAHdr);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblStoreOrdersHdr);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblStandardOrdersMetSLADtl);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblStandardOrdersDtl);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblStandardOrdersMetSLAHdr);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblStandardOrdersHdr);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblInternationalOrdersMetSLADtl);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblInternationalOrdersDtl);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblInternationalOrdersMetSLAHdr);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblInternationalOrdersHdr);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblExpressMetSLADtl);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblExpressOrdersDtl);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblTotalOrdersMetSLADtl);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblTotalOrdersDtl);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblExpressMetSLAHdr);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblExpressOrdersHdr);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblTotalOrdersMetSLAHdr);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Controls.Add(this.lblTotalOrdersHdr);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Location = new System.Drawing.Point(892, 102);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Name = "pnOrderTotalsWithinSpecifiedTimeFrame";
            this.pnOrderTotalsWithinSpecifiedTimeFrame.Size = new System.Drawing.Size(279, 277);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Order Totals within the previous x days";
            // 
            // lblStoreOrdersMetSLADtl
            // 
            this.lblStoreOrdersMetSLADtl.Location = new System.Drawing.Point(226, 246);
            this.lblStoreOrdersMetSLADtl.Name = "lblStoreOrdersMetSLADtl";
            this.lblStoreOrdersMetSLADtl.Size = new System.Drawing.Size(50, 13);
            this.lblStoreOrdersMetSLADtl.TabIndex = 19;
            this.lblStoreOrdersMetSLADtl.Text = "66477711";
            this.lblStoreOrdersMetSLADtl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStoreOrdersDtl
            // 
            this.lblStoreOrdersDtl.Location = new System.Drawing.Point(226, 230);
            this.lblStoreOrdersDtl.Name = "lblStoreOrdersDtl";
            this.lblStoreOrdersDtl.Size = new System.Drawing.Size(50, 13);
            this.lblStoreOrdersDtl.TabIndex = 18;
            this.lblStoreOrdersDtl.Text = "1";
            this.lblStoreOrdersDtl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStoreOrdersMetSLAHdr
            // 
            this.lblStoreOrdersMetSLAHdr.AutoSize = true;
            this.lblStoreOrdersMetSLAHdr.Location = new System.Drawing.Point(1, 248);
            this.lblStoreOrdersMetSLAHdr.Name = "lblStoreOrdersMetSLAHdr";
            this.lblStoreOrdersMetSLAHdr.Size = new System.Drawing.Size(106, 13);
            this.lblStoreOrdersMetSLAHdr.TabIndex = 17;
            this.lblStoreOrdersMetSLAHdr.Text = "Store which met SLA";
            // 
            // lblStoreOrdersHdr
            // 
            this.lblStoreOrdersHdr.AutoSize = true;
            this.lblStoreOrdersHdr.Location = new System.Drawing.Point(1, 230);
            this.lblStoreOrdersHdr.Name = "lblStoreOrdersHdr";
            this.lblStoreOrdersHdr.Size = new System.Drawing.Size(93, 13);
            this.lblStoreOrdersHdr.TabIndex = 16;
            this.lblStoreOrdersHdr.Text = "Total Store Orders";
            // 
            // lblStandardOrdersMetSLADtl
            // 
            this.lblStandardOrdersMetSLADtl.Location = new System.Drawing.Point(226, 198);
            this.lblStandardOrdersMetSLADtl.Name = "lblStandardOrdersMetSLADtl";
            this.lblStandardOrdersMetSLADtl.Size = new System.Drawing.Size(50, 13);
            this.lblStandardOrdersMetSLADtl.TabIndex = 15;
            this.lblStandardOrdersMetSLADtl.Text = "9997";
            this.lblStandardOrdersMetSLADtl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStandardOrdersDtl
            // 
            this.lblStandardOrdersDtl.Location = new System.Drawing.Point(226, 182);
            this.lblStandardOrdersDtl.Name = "lblStandardOrdersDtl";
            this.lblStandardOrdersDtl.Size = new System.Drawing.Size(50, 13);
            this.lblStandardOrdersDtl.TabIndex = 14;
            this.lblStandardOrdersDtl.Text = "64814";
            this.lblStandardOrdersDtl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStandardOrdersMetSLAHdr
            // 
            this.lblStandardOrdersMetSLAHdr.AutoSize = true;
            this.lblStandardOrdersMetSLAHdr.Location = new System.Drawing.Point(1, 200);
            this.lblStandardOrdersMetSLAHdr.Name = "lblStandardOrdersMetSLAHdr";
            this.lblStandardOrdersMetSLAHdr.Size = new System.Drawing.Size(124, 13);
            this.lblStandardOrdersMetSLAHdr.TabIndex = 13;
            this.lblStandardOrdersMetSLAHdr.Text = "Standard which met SLA";
            // 
            // lblStandardOrdersHdr
            // 
            this.lblStandardOrdersHdr.AutoSize = true;
            this.lblStandardOrdersHdr.Location = new System.Drawing.Point(1, 182);
            this.lblStandardOrdersHdr.Name = "lblStandardOrdersHdr";
            this.lblStandardOrdersHdr.Size = new System.Drawing.Size(111, 13);
            this.lblStandardOrdersHdr.TabIndex = 12;
            this.lblStandardOrdersHdr.Text = "Total Standard Orders";
            // 
            // lblInternationalOrdersMetSLADtl
            // 
            this.lblInternationalOrdersMetSLADtl.Location = new System.Drawing.Point(226, 152);
            this.lblInternationalOrdersMetSLADtl.Name = "lblInternationalOrdersMetSLADtl";
            this.lblInternationalOrdersMetSLADtl.Size = new System.Drawing.Size(50, 13);
            this.lblInternationalOrdersMetSLADtl.TabIndex = 11;
            this.lblInternationalOrdersMetSLADtl.Text = "258";
            this.lblInternationalOrdersMetSLADtl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInternationalOrdersDtl
            // 
            this.lblInternationalOrdersDtl.Location = new System.Drawing.Point(226, 136);
            this.lblInternationalOrdersDtl.Name = "lblInternationalOrdersDtl";
            this.lblInternationalOrdersDtl.Size = new System.Drawing.Size(50, 13);
            this.lblInternationalOrdersDtl.TabIndex = 10;
            this.lblInternationalOrdersDtl.Text = "468";
            this.lblInternationalOrdersDtl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInternationalOrdersMetSLAHdr
            // 
            this.lblInternationalOrdersMetSLAHdr.AutoSize = true;
            this.lblInternationalOrdersMetSLAHdr.Location = new System.Drawing.Point(1, 154);
            this.lblInternationalOrdersMetSLAHdr.Name = "lblInternationalOrdersMetSLAHdr";
            this.lblInternationalOrdersMetSLAHdr.Size = new System.Drawing.Size(139, 13);
            this.lblInternationalOrdersMetSLAHdr.TabIndex = 9;
            this.lblInternationalOrdersMetSLAHdr.Text = "International which met SLA";
            // 
            // lblInternationalOrdersHdr
            // 
            this.lblInternationalOrdersHdr.AutoSize = true;
            this.lblInternationalOrdersHdr.Location = new System.Drawing.Point(1, 136);
            this.lblInternationalOrdersHdr.Name = "lblInternationalOrdersHdr";
            this.lblInternationalOrdersHdr.Size = new System.Drawing.Size(126, 13);
            this.lblInternationalOrdersHdr.TabIndex = 8;
            this.lblInternationalOrdersHdr.Text = "Total International Orders";
            // 
            // lblExpressMetSLADtl
            // 
            this.lblExpressMetSLADtl.Location = new System.Drawing.Point(226, 100);
            this.lblExpressMetSLADtl.Name = "lblExpressMetSLADtl";
            this.lblExpressMetSLADtl.Size = new System.Drawing.Size(50, 13);
            this.lblExpressMetSLADtl.TabIndex = 7;
            this.lblExpressMetSLADtl.Text = "777";
            this.lblExpressMetSLADtl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExpressOrdersDtl
            // 
            this.lblExpressOrdersDtl.Location = new System.Drawing.Point(226, 84);
            this.lblExpressOrdersDtl.Name = "lblExpressOrdersDtl";
            this.lblExpressOrdersDtl.Size = new System.Drawing.Size(50, 13);
            this.lblExpressOrdersDtl.TabIndex = 6;
            this.lblExpressOrdersDtl.Text = "777";
            this.lblExpressOrdersDtl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalOrdersMetSLADtl
            // 
            this.lblTotalOrdersMetSLADtl.Location = new System.Drawing.Point(226, 48);
            this.lblTotalOrdersMetSLADtl.Name = "lblTotalOrdersMetSLADtl";
            this.lblTotalOrdersMetSLADtl.Size = new System.Drawing.Size(50, 13);
            this.lblTotalOrdersMetSLADtl.TabIndex = 5;
            this.lblTotalOrdersMetSLADtl.Text = "444";
            this.lblTotalOrdersMetSLADtl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalOrdersDtl
            // 
            this.lblTotalOrdersDtl.Location = new System.Drawing.Point(226, 32);
            this.lblTotalOrdersDtl.Name = "lblTotalOrdersDtl";
            this.lblTotalOrdersDtl.Size = new System.Drawing.Size(50, 13);
            this.lblTotalOrdersDtl.TabIndex = 4;
            this.lblTotalOrdersDtl.Text = "444";
            this.lblTotalOrdersDtl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExpressMetSLAHdr
            // 
            this.lblExpressMetSLAHdr.AutoSize = true;
            this.lblExpressMetSLAHdr.Location = new System.Drawing.Point(1, 102);
            this.lblExpressMetSLAHdr.Name = "lblExpressMetSLAHdr";
            this.lblExpressMetSLAHdr.Size = new System.Drawing.Size(118, 13);
            this.lblExpressMetSLAHdr.TabIndex = 3;
            this.lblExpressMetSLAHdr.Text = "Express which met SLA";
            // 
            // lblExpressOrdersHdr
            // 
            this.lblExpressOrdersHdr.AutoSize = true;
            this.lblExpressOrdersHdr.Location = new System.Drawing.Point(1, 84);
            this.lblExpressOrdersHdr.Name = "lblExpressOrdersHdr";
            this.lblExpressOrdersHdr.Size = new System.Drawing.Size(105, 13);
            this.lblExpressOrdersHdr.TabIndex = 2;
            this.lblExpressOrdersHdr.Text = "Total Express Orders";
            // 
            // lblTotalOrdersMetSLAHdr
            // 
            this.lblTotalOrdersMetSLAHdr.AutoSize = true;
            this.lblTotalOrdersMetSLAHdr.Location = new System.Drawing.Point(1, 50);
            this.lblTotalOrdersMetSLAHdr.Name = "lblTotalOrdersMetSLAHdr";
            this.lblTotalOrdersMetSLAHdr.Size = new System.Drawing.Size(105, 13);
            this.lblTotalOrdersMetSLAHdr.TabIndex = 1;
            this.lblTotalOrdersMetSLAHdr.Text = "Total which met SLA";
            // 
            // lblTotalOrdersHdr
            // 
            this.lblTotalOrdersHdr.AutoSize = true;
            this.lblTotalOrdersHdr.Location = new System.Drawing.Point(1, 32);
            this.lblTotalOrdersHdr.Name = "lblTotalOrdersHdr";
            this.lblTotalOrdersHdr.Size = new System.Drawing.Size(65, 13);
            this.lblTotalOrdersHdr.TabIndex = 0;
            this.lblTotalOrdersHdr.Text = "Total Orders";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbExtendedDetailFilter_Store);
            this.panel1.Controls.Add(this.rbExtendedDetailFilter_All);
            this.panel1.Controls.Add(this.rbExtendedDetail_International);
            this.panel1.Controls.Add(this.rbExtendedDetail_Express);
            this.panel1.Controls.Add(this.rbExtendedDetail_Standard);
            this.panel1.Location = new System.Drawing.Point(705, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 70);
            this.panel1.TabIndex = 8;
            // 
            // rbExtendedDetailFilter_Store
            // 
            this.rbExtendedDetailFilter_Store.AutoSize = true;
            this.rbExtendedDetailFilter_Store.Location = new System.Drawing.Point(5, 26);
            this.rbExtendedDetailFilter_Store.Name = "rbExtendedDetailFilter_Store";
            this.rbExtendedDetailFilter_Store.Size = new System.Drawing.Size(50, 17);
            this.rbExtendedDetailFilter_Store.TabIndex = 3;
            this.rbExtendedDetailFilter_Store.Text = "Store";
            this.rbExtendedDetailFilter_Store.UseVisualStyleBackColor = true;
            // 
            // rbExtendedDetailFilter_All
            // 
            this.rbExtendedDetailFilter_All.AutoSize = true;
            this.rbExtendedDetailFilter_All.Checked = true;
            this.rbExtendedDetailFilter_All.Location = new System.Drawing.Point(5, 4);
            this.rbExtendedDetailFilter_All.Name = "rbExtendedDetailFilter_All";
            this.rbExtendedDetailFilter_All.Size = new System.Drawing.Size(36, 17);
            this.rbExtendedDetailFilter_All.TabIndex = 2;
            this.rbExtendedDetailFilter_All.TabStop = true;
            this.rbExtendedDetailFilter_All.Text = "All";
            this.rbExtendedDetailFilter_All.UseVisualStyleBackColor = true;
            // 
            // rbExtendedDetail_International
            // 
            this.rbExtendedDetail_International.AutoSize = true;
            this.rbExtendedDetail_International.Location = new System.Drawing.Point(92, 48);
            this.rbExtendedDetail_International.Name = "rbExtendedDetail_International";
            this.rbExtendedDetail_International.Size = new System.Drawing.Size(83, 17);
            this.rbExtendedDetail_International.TabIndex = 6;
            this.rbExtendedDetail_International.Text = "International";
            this.rbExtendedDetail_International.UseVisualStyleBackColor = true;
            // 
            // rbExtendedDetail_Express
            // 
            this.rbExtendedDetail_Express.AutoSize = true;
            this.rbExtendedDetail_Express.Location = new System.Drawing.Point(5, 48);
            this.rbExtendedDetail_Express.Name = "rbExtendedDetail_Express";
            this.rbExtendedDetail_Express.Size = new System.Drawing.Size(62, 17);
            this.rbExtendedDetail_Express.TabIndex = 4;
            this.rbExtendedDetail_Express.Text = "Express";
            this.rbExtendedDetail_Express.UseVisualStyleBackColor = true;
            // 
            // rbExtendedDetail_Standard
            // 
            this.rbExtendedDetail_Standard.AutoSize = true;
            this.rbExtendedDetail_Standard.Location = new System.Drawing.Point(92, 26);
            this.rbExtendedDetail_Standard.Name = "rbExtendedDetail_Standard";
            this.rbExtendedDetail_Standard.Size = new System.Drawing.Size(68, 17);
            this.rbExtendedDetail_Standard.TabIndex = 5;
            this.rbExtendedDetail_Standard.Text = "Standard";
            this.rbExtendedDetail_Standard.UseVisualStyleBackColor = true;
            // 
            // dgvDetailBreakdown
            // 
            this.dgvDetailBreakdown.AllowUserToAddRows = false;
            this.dgvDetailBreakdown.AllowUserToDeleteRows = false;
            this.dgvDetailBreakdown.AllowUserToResizeColumns = false;
            this.dgvDetailBreakdown.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetailBreakdown.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetailBreakdown.ColumnHeadersHeight = 25;
            this.dgvDetailBreakdown.Location = new System.Drawing.Point(6, 102);
            this.dgvDetailBreakdown.Name = "dgvDetailBreakdown";
            this.dgvDetailBreakdown.RowHeadersVisible = false;
            this.dgvDetailBreakdown.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailBreakdown.Size = new System.Drawing.Size(880, 277);
            this.dgvDetailBreakdown.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(105, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(683, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Orders which failed SLA for time period:  08/08/1665 00:00:00 - 09/08/1948 05:46:" +
    "21";
            // 
            // pnSLACriteriaMetKey
            // 
            this.pnSLACriteriaMetKey.Controls.Add(this.lblCriteriaNotMetKey);
            this.pnSLACriteriaMetKey.Controls.Add(this.lblMidCriteriaMetKey);
            this.pnSLACriteriaMetKey.Controls.Add(this.lblTopCriteriaMetKey);
            this.pnSLACriteriaMetKey.Controls.Add(this.pbCriteriaNotMetKey);
            this.pnSLACriteriaMetKey.Controls.Add(this.pbMidCriteriaMetKey);
            this.pnSLACriteriaMetKey.Controls.Add(this.pbTopCriteriaMetKey);
            this.pnSLACriteriaMetKey.Location = new System.Drawing.Point(6, 6);
            this.pnSLACriteriaMetKey.Name = "pnSLACriteriaMetKey";
            this.pnSLACriteriaMetKey.Size = new System.Drawing.Size(334, 65);
            this.pnSLACriteriaMetKey.TabIndex = 0;
            // 
            // lblCriteriaNotMetKey
            // 
            this.lblCriteriaNotMetKey.AutoSize = true;
            this.lblCriteriaNotMetKey.Location = new System.Drawing.Point(41, 44);
            this.lblCriteriaNotMetKey.Name = "lblCriteriaNotMetKey";
            this.lblCriteriaNotMetKey.Size = new System.Drawing.Size(156, 13);
            this.lblCriteriaNotMetKey.TabIndex = 5;
            this.lblCriteriaNotMetKey.Text = "< y% met SLA (80% for Express)";
            // 
            // lblMidCriteriaMetKey
            // 
            this.lblMidCriteriaMetKey.AutoSize = true;
            this.lblMidCriteriaMetKey.Location = new System.Drawing.Point(41, 24);
            this.lblMidCriteriaMetKey.Name = "lblMidCriteriaMetKey";
            this.lblMidCriteriaMetKey.Size = new System.Drawing.Size(210, 13);
            this.lblMidCriteriaMetKey.TabIndex = 4;
            this.lblMidCriteriaMetKey.Text = "y% to z% met SLA (80% to 99% for Express)";
            // 
            // lblTopCriteriaMetKey
            // 
            this.lblTopCriteriaMetKey.AutoSize = true;
            this.lblTopCriteriaMetKey.Location = new System.Drawing.Point(41, 4);
            this.lblTopCriteriaMetKey.Name = "lblTopCriteriaMetKey";
            this.lblTopCriteriaMetKey.Size = new System.Drawing.Size(162, 13);
            this.lblTopCriteriaMetKey.TabIndex = 3;
            this.lblTopCriteriaMetKey.Text = "> x% met SLA (100% for Express)";
            // 
            // pbCriteriaNotMetKey
            // 
            this.pbCriteriaNotMetKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbCriteriaNotMetKey.Location = new System.Drawing.Point(5, 44);
            this.pbCriteriaNotMetKey.Name = "pbCriteriaNotMetKey";
            this.pbCriteriaNotMetKey.Size = new System.Drawing.Size(30, 13);
            this.pbCriteriaNotMetKey.TabIndex = 2;
            this.pbCriteriaNotMetKey.TabStop = false;
            // 
            // pbMidCriteriaMetKey
            // 
            this.pbMidCriteriaMetKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(128)))));
            this.pbMidCriteriaMetKey.Location = new System.Drawing.Point(5, 24);
            this.pbMidCriteriaMetKey.Name = "pbMidCriteriaMetKey";
            this.pbMidCriteriaMetKey.Size = new System.Drawing.Size(30, 13);
            this.pbMidCriteriaMetKey.TabIndex = 1;
            this.pbMidCriteriaMetKey.TabStop = false;
            // 
            // pbTopCriteriaMetKey
            // 
            this.pbTopCriteriaMetKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.pbTopCriteriaMetKey.Location = new System.Drawing.Point(5, 4);
            this.pbTopCriteriaMetKey.Name = "pbTopCriteriaMetKey";
            this.pbTopCriteriaMetKey.Size = new System.Drawing.Size(30, 13);
            this.pbTopCriteriaMetKey.TabIndex = 0;
            this.pbTopCriteriaMetKey.TabStop = false;
            // 
            // gbCustomDateRange
            // 
            this.gbCustomDateRange.Controls.Add(this.cbCustomCutoff);
            this.gbCustomDateRange.Controls.Add(this.dtpReportTo);
            this.gbCustomDateRange.Controls.Add(this.lblReportTo);
            this.gbCustomDateRange.Controls.Add(this.lblReportFrom);
            this.gbCustomDateRange.Controls.Add(this.dtpReportFrom);
            this.gbCustomDateRange.Controls.Add(this.btnReportCustomDateRange);
            this.gbCustomDateRange.Location = new System.Drawing.Point(581, 42);
            this.gbCustomDateRange.Name = "gbCustomDateRange";
            this.gbCustomDateRange.Size = new System.Drawing.Size(217, 193);
            this.gbCustomDateRange.TabIndex = 24;
            this.gbCustomDateRange.TabStop = false;
            this.gbCustomDateRange.Text = "Custom Date Range";
            // 
            // cbCustomCutoff
            // 
            this.cbCustomCutoff.AutoSize = true;
            this.cbCustomCutoff.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbCustomCutoff.Location = new System.Drawing.Point(118, 32);
            this.cbCustomCutoff.Name = "cbCustomCutoff";
            this.cbCustomCutoff.Size = new System.Drawing.Size(91, 17);
            this.cbCustomCutoff.TabIndex = 29;
            this.cbCustomCutoff.Text = "Custom cutoff";
            this.cbCustomCutoff.UseVisualStyleBackColor = true;
            // 
            // dtpReportTo
            // 
            this.dtpReportTo.CustomFormat = "dd MMM yyyy  HH:mm:ss";
            this.dtpReportTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReportTo.Location = new System.Drawing.Point(6, 119);
            this.dtpReportTo.Name = "dtpReportTo";
            this.dtpReportTo.Size = new System.Drawing.Size(203, 20);
            this.dtpReportTo.TabIndex = 28;
            // 
            // lblReportTo
            // 
            this.lblReportTo.AutoSize = true;
            this.lblReportTo.Location = new System.Drawing.Point(6, 96);
            this.lblReportTo.Name = "lblReportTo";
            this.lblReportTo.Size = new System.Drawing.Size(58, 13);
            this.lblReportTo.TabIndex = 27;
            this.lblReportTo.Text = "Report To:";
            // 
            // lblReportFrom
            // 
            this.lblReportFrom.AutoSize = true;
            this.lblReportFrom.Location = new System.Drawing.Point(4, 32);
            this.lblReportFrom.Name = "lblReportFrom";
            this.lblReportFrom.Size = new System.Drawing.Size(68, 13);
            this.lblReportFrom.TabIndex = 26;
            this.lblReportFrom.Text = "Report From:";
            // 
            // dtpReportFrom
            // 
            this.dtpReportFrom.CustomFormat = "dd MMM yyyy  HH:mm:ss";
            this.dtpReportFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReportFrom.Location = new System.Drawing.Point(6, 54);
            this.dtpReportFrom.Name = "dtpReportFrom";
            this.dtpReportFrom.Size = new System.Drawing.Size(203, 20);
            this.dtpReportFrom.TabIndex = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 627);
            this.Controls.Add(this.gbCustomDateRange);
            this.Controls.Add(this.pnExtendedDetail);
            this.Controls.Add(this.gbCustomSLAStats);
            this.Controls.Add(this.gbLast24Hrs);
            this.Controls.Add(this.pnAdminPanel);
            this.Name = "MainForm";
            this.Text = "Dispatch SLA Report (ws1160)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbLast24Hrs.ResumeLayout(false);
            this.gbLast24Hrs.PerformLayout();
            this.gbCustomSLAStats.ResumeLayout(false);
            this.gbCustomSLAStats.PerformLayout();
            this.pnAdminPanel.ResumeLayout(false);
            this.pnAdminPanel.PerformLayout();
            this.pnExtendedDetail.ResumeLayout(false);
            this.pnExtendedDetail.PerformLayout();
            this.pnOrderTotalsWithinSpecifiedTimeFrame.ResumeLayout(false);
            this.pnOrderTotalsWithinSpecifiedTimeFrame.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailBreakdown)).EndInit();
            this.pnSLACriteriaMetKey.ResumeLayout(false);
            this.pnSLACriteriaMetKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCriteriaNotMetKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMidCriteriaMetKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopCriteriaMetKey)).EndInit();
            this.gbCustomDateRange.ResumeLayout(false);
            this.gbCustomDateRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLast24HrsPrintReport;
        private System.Windows.Forms.Button btnLast24HrsViewReport;
        public System.Windows.Forms.Label lbl24HrsStoreSLADtlPct;
        private System.Windows.Forms.Label lbl24HrsStoreSLAHdr;
        public System.Windows.Forms.Label lbl24HrsStandardSLADtlPct;
        private System.Windows.Forms.Label lbl24HrsStandardSLAHdr;
        public System.Windows.Forms.Label lbl24HrsInternationalSLADtlPct;
        private System.Windows.Forms.Label lbl24HrsInternationalSLAHdr;
        public System.Windows.Forms.Label lbl24HrsExpressSLADtlPct;
        private System.Windows.Forms.Label lbl24HrsExpressSLAHdr;
        public System.Windows.Forms.Label lbl24HrsTotalSLADtlPct;
        private System.Windows.Forms.Label lbl24HrsTotalSLAHdr;
        private System.Windows.Forms.Button btnReportCustomDateRange;
        private System.Windows.Forms.Button btnCustPrintReport;
        private System.Windows.Forms.Button btnCustViewReport;
        private System.Windows.Forms.Label lblCustTotalSLAHdr;
        public System.Windows.Forms.Label lblCustStoreSLADtlPct;
        public System.Windows.Forms.Label lblCustTotalSLADtlPct;
        private System.Windows.Forms.Label lblCustStoreSLAHdr;
        private System.Windows.Forms.Label lblCustExpressSLAHdr;
        public System.Windows.Forms.Label lblCustStandardSLADtlPct;
        public System.Windows.Forms.Label lblCustExpressSLADtlPct;
        private System.Windows.Forms.Label lblCustStandardSLAHdr;
        private System.Windows.Forms.Label lblCustInternationalSLAHdr;
        public System.Windows.Forms.Label lblCustInternationalSLADtlPct;
        private System.Windows.Forms.Panel pnExtendedDetail;
        public System.Windows.Forms.DataGridView dgvDetailBreakdown;
        private System.Windows.Forms.RadioButton rbExtendedDetail_International;
        private System.Windows.Forms.RadioButton rbExtendedDetail_Standard;
        private System.Windows.Forms.RadioButton rbExtendedDetail_Express;
        private System.Windows.Forms.RadioButton rbExtendedDetailFilter_Store;
        private System.Windows.Forms.RadioButton rbExtendedDetailFilter_All;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnSLACriteriaMetKey;
        public System.Windows.Forms.DateTimePicker dtpReportFrom;
        public System.Windows.Forms.DateTimePicker dtpReportTo;
        private System.Windows.Forms.Label lblReportTo;
        private System.Windows.Forms.Label lblReportFrom;
        private System.Windows.Forms.PictureBox pbCriteriaNotMetKey;
        private System.Windows.Forms.PictureBox pbMidCriteriaMetKey;
        private System.Windows.Forms.PictureBox pbTopCriteriaMetKey;
        public System.Windows.Forms.Label lblCriteriaNotMetKey;
        public System.Windows.Forms.Label lblMidCriteriaMetKey;
        public System.Windows.Forms.Label lblTopCriteriaMetKey;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblConfigDetails;
        private System.Windows.Forms.Panel pnOrderTotalsWithinSpecifiedTimeFrame;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblStoreOrdersMetSLADtl;
        public System.Windows.Forms.Label lblStoreOrdersDtl;
        private System.Windows.Forms.Label lblStoreOrdersMetSLAHdr;
        private System.Windows.Forms.Label lblStoreOrdersHdr;
        public System.Windows.Forms.Label lblStandardOrdersMetSLADtl;
        public System.Windows.Forms.Label lblStandardOrdersDtl;
        private System.Windows.Forms.Label lblStandardOrdersMetSLAHdr;
        private System.Windows.Forms.Label lblStandardOrdersHdr;
        public System.Windows.Forms.Label lblInternationalOrdersMetSLADtl;
        public System.Windows.Forms.Label lblInternationalOrdersDtl;
        private System.Windows.Forms.Label lblInternationalOrdersMetSLAHdr;
        private System.Windows.Forms.Label lblInternationalOrdersHdr;
        public System.Windows.Forms.Label lblExpressMetSLADtl;
        public System.Windows.Forms.Label lblExpressOrdersDtl;
        public System.Windows.Forms.Label lblTotalOrdersMetSLADtl;
        public System.Windows.Forms.Label lblTotalOrdersDtl;
        private System.Windows.Forms.Label lblExpressMetSLAHdr;
        private System.Windows.Forms.Label lblExpressOrdersHdr;
        private System.Windows.Forms.Label lblTotalOrdersMetSLAHdr;
        private System.Windows.Forms.Label lblTotalOrdersHdr;
        public System.Windows.Forms.GroupBox gbCustomSLAStats;
        private System.Windows.Forms.GroupBox gbCustomDateRange;
        public System.Windows.Forms.GroupBox gbLast24Hrs;
        private System.Windows.Forms.CheckBox cbCustomCutoff;
        private System.Windows.Forms.Button btnOpenConfigSettings;
        public System.Windows.Forms.Panel pnAdminPanel;
    }
}

