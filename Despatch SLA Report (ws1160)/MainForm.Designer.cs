namespace MandCo.Applications.ws1160
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbLast24Hrs = new System.Windows.Forms.GroupBox();
            this.btnLast24HrsPrintReport = new System.Windows.Forms.Button();
            this.btnLast24HrsViewReport = new System.Windows.Forms.Button();
            this.lbl24HrsStoreSLADtl = new System.Windows.Forms.Label();
            this.lbl24HrsStoreSLAHdr = new System.Windows.Forms.Label();
            this.lbl24HrsStandardSLADtl = new System.Windows.Forms.Label();
            this.lbl24HrsStandardSLAHdr = new System.Windows.Forms.Label();
            this.lbl24HrsInternationalSLADtl = new System.Windows.Forms.Label();
            this.lbl24HrsInternationalSLAHdr = new System.Windows.Forms.Label();
            this.lbl24HrsExpressSLADtl = new System.Windows.Forms.Label();
            this.lbl24HrsExpressSLAHdr = new System.Windows.Forms.Label();
            this.lbl24HrsTotalSLADtl = new System.Windows.Forms.Label();
            this.lbl24HrsTotalSLAHdr = new System.Windows.Forms.Label();
            this.gbCustomSLAStats = new System.Windows.Forms.GroupBox();
            this.btnCustPrintReport = new System.Windows.Forms.Button();
            this.btnCustViewReport = new System.Windows.Forms.Button();
            this.lblCustTotalSLAHdr = new System.Windows.Forms.Label();
            this.lblCustStoreSLADtl = new System.Windows.Forms.Label();
            this.lblCustTotalSLADtl = new System.Windows.Forms.Label();
            this.lblCustStoreSLAHdr = new System.Windows.Forms.Label();
            this.lblCustExpressSLAHdr = new System.Windows.Forms.Label();
            this.lblStandardTotalSLADtl = new System.Windows.Forms.Label();
            this.lblCustExpressSLADtl = new System.Windows.Forms.Label();
            this.lblCustStandardSLAHdr = new System.Windows.Forms.Label();
            this.lblCustInternationalSLAHdr = new System.Windows.Forms.Label();
            this.lblCustInternationalSLADtl = new System.Windows.Forms.Label();
            this.btnReportCustomDateRange = new System.Windows.Forms.Button();
            this.pnExtendedDetail = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbExtendedDetailFilter_Store = new System.Windows.Forms.RadioButton();
            this.rbExtendedDetailFilter_All = new System.Windows.Forms.RadioButton();
            this.rbExtendedDetail_International = new System.Windows.Forms.RadioButton();
            this.rbExtendedDetail_Express = new System.Windows.Forms.RadioButton();
            this.rbExtendedDetail_Standard = new System.Windows.Forms.RadioButton();
            this.dgvDetailBreakdown = new System.Windows.Forms.DataGridView();
            this.colDetailBreakdown_OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailBreakdown_ShipMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailBreakdown_DateOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailBreakdown_DateReleased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailBreakdown_TimeToRelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailBreakdown_DateDispatched = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.pnSLACriteriaMetKey = new System.Windows.Forms.Panel();
            this.lblCriteriaNotMetKey = new System.Windows.Forms.Label();
            this.lblMidCriteriaMetKey = new System.Windows.Forms.Label();
            this.lblTopCriteriaMetKey = new System.Windows.Forms.Label();
            this.pbCriteriaNotMetKey = new System.Windows.Forms.PictureBox();
            this.pbMidCriteriaMetKey = new System.Windows.Forms.PictureBox();
            this.pbTopCriteriaMetKey = new System.Windows.Forms.PictureBox();
            this.gbCustomDateRange = new System.Windows.Forms.GroupBox();
            this.dtpReportTo = new System.Windows.Forms.DateTimePicker();
            this.lblReportTo = new System.Windows.Forms.Label();
            this.lblReportFrom = new System.Windows.Forms.Label();
            this.dtpReportFrom = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblConfigDetails = new System.Windows.Forms.Label();
            this.gbLast24Hrs.SuspendLayout();
            this.gbCustomSLAStats.SuspendLayout();
            this.pnExtendedDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailBreakdown)).BeginInit();
            this.pnSLACriteriaMetKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCriteriaNotMetKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMidCriteriaMetKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopCriteriaMetKey)).BeginInit();
            this.gbCustomDateRange.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLast24Hrs
            // 
            this.gbLast24Hrs.Controls.Add(this.btnLast24HrsPrintReport);
            this.gbLast24Hrs.Controls.Add(this.btnLast24HrsViewReport);
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsStoreSLADtl);
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsStoreSLAHdr);
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsStandardSLADtl);
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsStandardSLAHdr);
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsInternationalSLADtl);
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsInternationalSLAHdr);
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsExpressSLADtl);
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsExpressSLAHdr);
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsTotalSLADtl);
            this.gbLast24Hrs.Controls.Add(this.lbl24HrsTotalSLAHdr);
            this.gbLast24Hrs.Location = new System.Drawing.Point(9, 42);
            this.gbLast24Hrs.Name = "gbLast24Hrs";
            this.gbLast24Hrs.Size = new System.Drawing.Size(279, 193);
            this.gbLast24Hrs.TabIndex = 0;
            this.gbLast24Hrs.TabStop = false;
            this.gbLast24Hrs.Text = "Statistics from cut off point on : dd/mmm/yyyy";
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
            // lbl24HrsStoreSLADtl
            // 
            this.lbl24HrsStoreSLADtl.AutoSize = true;
            this.lbl24HrsStoreSLADtl.Location = new System.Drawing.Point(21, 128);
            this.lbl24HrsStoreSLADtl.Name = "lbl24HrsStoreSLADtl";
            this.lbl24HrsStoreSLADtl.Size = new System.Drawing.Size(34, 13);
            this.lbl24HrsStoreSLADtl.TabIndex = 9;
            this.lbl24HrsStoreSLADtl.Text = "  5.00";
            this.lbl24HrsStoreSLADtl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl24HrsStoreSLAHdr
            // 
            this.lbl24HrsStoreSLAHdr.AutoSize = true;
            this.lbl24HrsStoreSLAHdr.Location = new System.Drawing.Point(57, 128);
            this.lbl24HrsStoreSLAHdr.Name = "lbl24HrsStoreSLAHdr";
            this.lbl24HrsStoreSLAHdr.Size = new System.Drawing.Size(169, 13);
            this.lbl24HrsStoreSLAHdr.TabIndex = 8;
            this.lbl24HrsStoreSLAHdr.Text = "% of the store orders met their SLA";
            // 
            // lbl24HrsStandardSLADtl
            // 
            this.lbl24HrsStandardSLADtl.AutoSize = true;
            this.lbl24HrsStandardSLADtl.Location = new System.Drawing.Point(21, 103);
            this.lbl24HrsStandardSLADtl.Name = "lbl24HrsStandardSLADtl";
            this.lbl24HrsStandardSLADtl.Size = new System.Drawing.Size(34, 13);
            this.lbl24HrsStandardSLADtl.TabIndex = 7;
            this.lbl24HrsStandardSLADtl.Text = "45.00";
            // 
            // lbl24HrsStandardSLAHdr
            // 
            this.lbl24HrsStandardSLAHdr.AutoSize = true;
            this.lbl24HrsStandardSLAHdr.Location = new System.Drawing.Point(57, 103);
            this.lbl24HrsStandardSLAHdr.Name = "lbl24HrsStandardSLAHdr";
            this.lbl24HrsStandardSLAHdr.Size = new System.Drawing.Size(187, 13);
            this.lbl24HrsStandardSLAHdr.TabIndex = 6;
            this.lbl24HrsStandardSLAHdr.Text = "% of the standard orders met their SLA";
            // 
            // lbl24HrsInternationalSLADtl
            // 
            this.lbl24HrsInternationalSLADtl.AutoSize = true;
            this.lbl24HrsInternationalSLADtl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl24HrsInternationalSLADtl.Location = new System.Drawing.Point(21, 79);
            this.lbl24HrsInternationalSLADtl.Name = "lbl24HrsInternationalSLADtl";
            this.lbl24HrsInternationalSLADtl.Size = new System.Drawing.Size(34, 13);
            this.lbl24HrsInternationalSLADtl.TabIndex = 5;
            this.lbl24HrsInternationalSLADtl.Text = "66.66";
            this.lbl24HrsInternationalSLADtl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl24HrsInternationalSLAHdr
            // 
            this.lbl24HrsInternationalSLAHdr.AutoSize = true;
            this.lbl24HrsInternationalSLAHdr.Location = new System.Drawing.Point(57, 79);
            this.lbl24HrsInternationalSLAHdr.Name = "lbl24HrsInternationalSLAHdr";
            this.lbl24HrsInternationalSLAHdr.Size = new System.Drawing.Size(203, 13);
            this.lbl24HrsInternationalSLAHdr.TabIndex = 4;
            this.lbl24HrsInternationalSLAHdr.Text = "% of the international orders met their SLA";
            // 
            // lbl24HrsExpressSLADtl
            // 
            this.lbl24HrsExpressSLADtl.AutoSize = true;
            this.lbl24HrsExpressSLADtl.Location = new System.Drawing.Point(21, 54);
            this.lbl24HrsExpressSLADtl.Name = "lbl24HrsExpressSLADtl";
            this.lbl24HrsExpressSLADtl.Size = new System.Drawing.Size(37, 13);
            this.lbl24HrsExpressSLADtl.TabIndex = 3;
            this.lbl24HrsExpressSLADtl.Text = " 90.00";
            this.lbl24HrsExpressSLADtl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl24HrsExpressSLAHdr
            // 
            this.lbl24HrsExpressSLAHdr.AutoSize = true;
            this.lbl24HrsExpressSLAHdr.Location = new System.Drawing.Point(57, 54);
            this.lbl24HrsExpressSLAHdr.Name = "lbl24HrsExpressSLAHdr";
            this.lbl24HrsExpressSLAHdr.Size = new System.Drawing.Size(182, 13);
            this.lbl24HrsExpressSLAHdr.TabIndex = 2;
            this.lbl24HrsExpressSLAHdr.Text = "% of the express orders met their SLA";
            // 
            // lbl24HrsTotalSLADtl
            // 
            this.lbl24HrsTotalSLADtl.AutoSize = true;
            this.lbl24HrsTotalSLADtl.Location = new System.Drawing.Point(21, 31);
            this.lbl24HrsTotalSLADtl.Name = "lbl24HrsTotalSLADtl";
            this.lbl24HrsTotalSLADtl.Size = new System.Drawing.Size(40, 13);
            this.lbl24HrsTotalSLADtl.TabIndex = 1;
            this.lbl24HrsTotalSLADtl.Text = "100.00";
            this.lbl24HrsTotalSLADtl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl24HrsTotalSLAHdr
            // 
            this.lbl24HrsTotalSLAHdr.AutoSize = true;
            this.lbl24HrsTotalSLAHdr.Location = new System.Drawing.Point(57, 31);
            this.lbl24HrsTotalSLAHdr.Name = "lbl24HrsTotalSLAHdr";
            this.lbl24HrsTotalSLAHdr.Size = new System.Drawing.Size(166, 13);
            this.lbl24HrsTotalSLAHdr.TabIndex = 0;
            this.lbl24HrsTotalSLAHdr.Text = "% of the total orders met their SLA";
            // 
            // gbCustomSLAStats
            // 
            this.gbCustomSLAStats.Controls.Add(this.btnCustPrintReport);
            this.gbCustomSLAStats.Controls.Add(this.btnCustViewReport);
            this.gbCustomSLAStats.Controls.Add(this.lblCustTotalSLAHdr);
            this.gbCustomSLAStats.Controls.Add(this.lblCustStoreSLADtl);
            this.gbCustomSLAStats.Controls.Add(this.lblCustTotalSLADtl);
            this.gbCustomSLAStats.Controls.Add(this.lblCustStoreSLAHdr);
            this.gbCustomSLAStats.Controls.Add(this.lblCustExpressSLAHdr);
            this.gbCustomSLAStats.Controls.Add(this.lblStandardTotalSLADtl);
            this.gbCustomSLAStats.Controls.Add(this.lblCustExpressSLADtl);
            this.gbCustomSLAStats.Controls.Add(this.lblCustStandardSLAHdr);
            this.gbCustomSLAStats.Controls.Add(this.lblCustInternationalSLAHdr);
            this.gbCustomSLAStats.Controls.Add(this.lblCustInternationalSLADtl);
            this.gbCustomSLAStats.Location = new System.Drawing.Point(294, 42);
            this.gbCustomSLAStats.Name = "gbCustomSLAStats";
            this.gbCustomSLAStats.Size = new System.Drawing.Size(281, 193);
            this.gbCustomSLAStats.TabIndex = 1;
            this.gbCustomSLAStats.TabStop = false;
            this.gbCustomSLAStats.Text = "dd/mmm/yyyy hh:mm:ss - dd/mmm/yyyy hh:mm:ss";
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
            // lblCustTotalSLAHdr
            // 
            this.lblCustTotalSLAHdr.AutoSize = true;
            this.lblCustTotalSLAHdr.Location = new System.Drawing.Point(57, 31);
            this.lblCustTotalSLAHdr.Name = "lblCustTotalSLAHdr";
            this.lblCustTotalSLAHdr.Size = new System.Drawing.Size(166, 13);
            this.lblCustTotalSLAHdr.TabIndex = 12;
            this.lblCustTotalSLAHdr.Text = "% of the total orders met their SLA";
            // 
            // lblCustStoreSLADtl
            // 
            this.lblCustStoreSLADtl.AutoSize = true;
            this.lblCustStoreSLADtl.Location = new System.Drawing.Point(21, 128);
            this.lblCustStoreSLADtl.Name = "lblCustStoreSLADtl";
            this.lblCustStoreSLADtl.Size = new System.Drawing.Size(28, 13);
            this.lblCustStoreSLADtl.TabIndex = 21;
            this.lblCustStoreSLADtl.Text = "5.00";
            this.lblCustStoreSLADtl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustTotalSLADtl
            // 
            this.lblCustTotalSLADtl.AutoSize = true;
            this.lblCustTotalSLADtl.Location = new System.Drawing.Point(21, 31);
            this.lblCustTotalSLADtl.Name = "lblCustTotalSLADtl";
            this.lblCustTotalSLADtl.Size = new System.Drawing.Size(40, 13);
            this.lblCustTotalSLADtl.TabIndex = 13;
            this.lblCustTotalSLADtl.Text = "100.00";
            this.lblCustTotalSLADtl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCustStoreSLAHdr
            // 
            this.lblCustStoreSLAHdr.AutoSize = true;
            this.lblCustStoreSLAHdr.Location = new System.Drawing.Point(57, 128);
            this.lblCustStoreSLAHdr.Name = "lblCustStoreSLAHdr";
            this.lblCustStoreSLAHdr.Size = new System.Drawing.Size(169, 13);
            this.lblCustStoreSLAHdr.TabIndex = 20;
            this.lblCustStoreSLAHdr.Text = "% of the store orders met their SLA";
            // 
            // lblCustExpressSLAHdr
            // 
            this.lblCustExpressSLAHdr.AutoSize = true;
            this.lblCustExpressSLAHdr.Location = new System.Drawing.Point(57, 54);
            this.lblCustExpressSLAHdr.Name = "lblCustExpressSLAHdr";
            this.lblCustExpressSLAHdr.Size = new System.Drawing.Size(182, 13);
            this.lblCustExpressSLAHdr.TabIndex = 14;
            this.lblCustExpressSLAHdr.Text = "% of the express orders met their SLA";
            // 
            // lblStandardTotalSLADtl
            // 
            this.lblStandardTotalSLADtl.AutoSize = true;
            this.lblStandardTotalSLADtl.Location = new System.Drawing.Point(21, 103);
            this.lblStandardTotalSLADtl.Name = "lblStandardTotalSLADtl";
            this.lblStandardTotalSLADtl.Size = new System.Drawing.Size(34, 13);
            this.lblStandardTotalSLADtl.TabIndex = 19;
            this.lblStandardTotalSLADtl.Text = "45.00";
            // 
            // lblCustExpressSLADtl
            // 
            this.lblCustExpressSLADtl.AutoSize = true;
            this.lblCustExpressSLADtl.Location = new System.Drawing.Point(21, 54);
            this.lblCustExpressSLADtl.Name = "lblCustExpressSLADtl";
            this.lblCustExpressSLADtl.Size = new System.Drawing.Size(34, 13);
            this.lblCustExpressSLADtl.TabIndex = 15;
            this.lblCustExpressSLADtl.Text = "90.00";
            // 
            // lblCustStandardSLAHdr
            // 
            this.lblCustStandardSLAHdr.AutoSize = true;
            this.lblCustStandardSLAHdr.Location = new System.Drawing.Point(57, 103);
            this.lblCustStandardSLAHdr.Name = "lblCustStandardSLAHdr";
            this.lblCustStandardSLAHdr.Size = new System.Drawing.Size(187, 13);
            this.lblCustStandardSLAHdr.TabIndex = 18;
            this.lblCustStandardSLAHdr.Text = "% of the standard orders met their SLA";
            // 
            // lblCustInternationalSLAHdr
            // 
            this.lblCustInternationalSLAHdr.AutoSize = true;
            this.lblCustInternationalSLAHdr.Location = new System.Drawing.Point(57, 79);
            this.lblCustInternationalSLAHdr.Name = "lblCustInternationalSLAHdr";
            this.lblCustInternationalSLAHdr.Size = new System.Drawing.Size(203, 13);
            this.lblCustInternationalSLAHdr.TabIndex = 16;
            this.lblCustInternationalSLAHdr.Text = "% of the international orders met their SLA";
            // 
            // lblCustInternationalSLADtl
            // 
            this.lblCustInternationalSLADtl.AutoSize = true;
            this.lblCustInternationalSLADtl.Location = new System.Drawing.Point(21, 79);
            this.lblCustInternationalSLADtl.Name = "lblCustInternationalSLADtl";
            this.lblCustInternationalSLADtl.Size = new System.Drawing.Size(34, 13);
            this.lblCustInternationalSLADtl.TabIndex = 17;
            this.lblCustInternationalSLADtl.Text = "66.66";
            // 
            // btnReportCustomDateRange
            // 
            this.btnReportCustomDateRange.Location = new System.Drawing.Point(6, 160);
            this.btnReportCustomDateRange.Name = "btnReportCustomDateRange";
            this.btnReportCustomDateRange.Size = new System.Drawing.Size(203, 23);
            this.btnReportCustomDateRange.TabIndex = 24;
            this.btnReportCustomDateRange.Text = "Report Custom Date Range";
            this.btnReportCustomDateRange.UseVisualStyleBackColor = true;
            // 
            // pnExtendedDetail
            // 
            this.pnExtendedDetail.Controls.Add(this.panel1);
            this.pnExtendedDetail.Controls.Add(this.dgvDetailBreakdown);
            this.pnExtendedDetail.Controls.Add(this.label11);
            this.pnExtendedDetail.Controls.Add(this.pnSLACriteriaMetKey);
            this.pnExtendedDetail.Location = new System.Drawing.Point(9, 241);
            this.pnExtendedDetail.Name = "pnExtendedDetail";
            this.pnExtendedDetail.Size = new System.Drawing.Size(789, 382);
            this.pnExtendedDetail.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbExtendedDetailFilter_Store);
            this.panel1.Controls.Add(this.rbExtendedDetailFilter_All);
            this.panel1.Controls.Add(this.rbExtendedDetail_International);
            this.panel1.Controls.Add(this.rbExtendedDetail_Express);
            this.panel1.Controls.Add(this.rbExtendedDetail_Standard);
            this.panel1.Location = new System.Drawing.Point(600, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 70);
            this.panel1.TabIndex = 8;
            // 
            // rbExtendedDetailFilter_Store
            // 
            this.rbExtendedDetailFilter_Store.AutoSize = true;
            this.rbExtendedDetailFilter_Store.Location = new System.Drawing.Point(3, 24);
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
            this.rbExtendedDetailFilter_All.Location = new System.Drawing.Point(3, 4);
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
            this.rbExtendedDetail_International.Location = new System.Drawing.Point(90, 44);
            this.rbExtendedDetail_International.Name = "rbExtendedDetail_International";
            this.rbExtendedDetail_International.Size = new System.Drawing.Size(83, 17);
            this.rbExtendedDetail_International.TabIndex = 6;
            this.rbExtendedDetail_International.Text = "International";
            this.rbExtendedDetail_International.UseVisualStyleBackColor = true;
            // 
            // rbExtendedDetail_Express
            // 
            this.rbExtendedDetail_Express.AutoSize = true;
            this.rbExtendedDetail_Express.Location = new System.Drawing.Point(3, 44);
            this.rbExtendedDetail_Express.Name = "rbExtendedDetail_Express";
            this.rbExtendedDetail_Express.Size = new System.Drawing.Size(62, 17);
            this.rbExtendedDetail_Express.TabIndex = 4;
            this.rbExtendedDetail_Express.Text = "Express";
            this.rbExtendedDetail_Express.UseVisualStyleBackColor = true;
            // 
            // rbExtendedDetail_Standard
            // 
            this.rbExtendedDetail_Standard.AutoSize = true;
            this.rbExtendedDetail_Standard.Location = new System.Drawing.Point(90, 24);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetailBreakdown.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetailBreakdown.ColumnHeadersHeight = 25;
            this.dgvDetailBreakdown.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDetailBreakdown_OrderNumber,
            this.colDetailBreakdown_ShipMethod,
            this.colDetailBreakdown_DateOrdered,
            this.colDetailBreakdown_DateReleased,
            this.colDetailBreakdown_TimeToRelease,
            this.colDetailBreakdown_DateDispatched});
            this.dgvDetailBreakdown.Location = new System.Drawing.Point(6, 102);
            this.dgvDetailBreakdown.Name = "dgvDetailBreakdown";
            this.dgvDetailBreakdown.RowHeadersVisible = false;
            this.dgvDetailBreakdown.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailBreakdown.Size = new System.Drawing.Size(775, 277);
            this.dgvDetailBreakdown.TabIndex = 7;
            // 
            // colDetailBreakdown_OrderNumber
            // 
            this.colDetailBreakdown_OrderNumber.HeaderText = "Order Number";
            this.colDetailBreakdown_OrderNumber.Name = "colDetailBreakdown_OrderNumber";
            this.colDetailBreakdown_OrderNumber.ReadOnly = true;
            this.colDetailBreakdown_OrderNumber.Width = 145;
            // 
            // colDetailBreakdown_ShipMethod
            // 
            this.colDetailBreakdown_ShipMethod.HeaderText = "Ship Method";
            this.colDetailBreakdown_ShipMethod.Name = "colDetailBreakdown_ShipMethod";
            this.colDetailBreakdown_ShipMethod.ReadOnly = true;
            this.colDetailBreakdown_ShipMethod.Width = 105;
            // 
            // colDetailBreakdown_DateOrdered
            // 
            this.colDetailBreakdown_DateOrdered.HeaderText = "Date Ordered";
            this.colDetailBreakdown_DateOrdered.Name = "colDetailBreakdown_DateOrdered";
            this.colDetailBreakdown_DateOrdered.ReadOnly = true;
            this.colDetailBreakdown_DateOrdered.Width = 127;
            // 
            // colDetailBreakdown_DateReleased
            // 
            this.colDetailBreakdown_DateReleased.HeaderText = "Date Released";
            this.colDetailBreakdown_DateReleased.Name = "colDetailBreakdown_DateReleased";
            this.colDetailBreakdown_DateReleased.ReadOnly = true;
            this.colDetailBreakdown_DateReleased.Width = 131;
            // 
            // colDetailBreakdown_TimeToRelease
            // 
            this.colDetailBreakdown_TimeToRelease.HeaderText = "Time To Release";
            this.colDetailBreakdown_TimeToRelease.Name = "colDetailBreakdown_TimeToRelease";
            this.colDetailBreakdown_TimeToRelease.ReadOnly = true;
            this.colDetailBreakdown_TimeToRelease.Width = 119;
            // 
            // colDetailBreakdown_DateDispatched
            // 
            this.colDetailBreakdown_DateDispatched.HeaderText = "Date Dispatched";
            this.colDetailBreakdown_DateDispatched.Name = "colDetailBreakdown_DateDispatched";
            this.colDetailBreakdown_DateDispatched.ReadOnly = true;
            this.colDetailBreakdown_DateDispatched.Width = 143;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(169, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(475, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Orders which have not met their SLA within the last 7 days";
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
            this.lblCriteriaNotMetKey.Location = new System.Drawing.Point(41, 45);
            this.lblCriteriaNotMetKey.Name = "lblCriteriaNotMetKey";
            this.lblCriteriaNotMetKey.Size = new System.Drawing.Size(156, 13);
            this.lblCriteriaNotMetKey.TabIndex = 5;
            this.lblCriteriaNotMetKey.Text = "< y% met SLA (80% for Express)";
            // 
            // lblMidCriteriaMetKey
            // 
            this.lblMidCriteriaMetKey.AutoSize = true;
            this.lblMidCriteriaMetKey.Location = new System.Drawing.Point(41, 25);
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
            this.pbCriteriaNotMetKey.Location = new System.Drawing.Point(5, 45);
            this.pbCriteriaNotMetKey.Name = "pbCriteriaNotMetKey";
            this.pbCriteriaNotMetKey.Size = new System.Drawing.Size(30, 13);
            this.pbCriteriaNotMetKey.TabIndex = 2;
            this.pbCriteriaNotMetKey.TabStop = false;
            // 
            // pbMidCriteriaMetKey
            // 
            this.pbMidCriteriaMetKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(128)))));
            this.pbMidCriteriaMetKey.Location = new System.Drawing.Point(5, 25);
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
            this.lblReportFrom.Location = new System.Drawing.Point(4, 33);
            this.lblReportFrom.Name = "lblReportFrom";
            this.lblReportFrom.Size = new System.Drawing.Size(68, 13);
            this.lblReportFrom.TabIndex = 26;
            this.lblReportFrom.Text = "Report From:";
            // 
            // dtpReportFrom
            // 
            this.dtpReportFrom.CustomFormat = "dd MMM yyyy  HH:mm:ss";
            this.dtpReportFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReportFrom.Location = new System.Drawing.Point(6, 55);
            this.dtpReportFrom.Name = "dtpReportFrom";
            this.dtpReportFrom.Size = new System.Drawing.Size(203, 20);
            this.dtpReportFrom.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblConfigDetails);
            this.panel2.Location = new System.Drawing.Point(804, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 484);
            this.panel2.TabIndex = 25;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 634);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbCustomDateRange);
            this.Controls.Add(this.pnExtendedDetail);
            this.Controls.Add(this.gbCustomSLAStats);
            this.Controls.Add(this.gbLast24Hrs);
            this.Name = "MainForm";
            this.Text = "Dispatch SLA Report (ws1160)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbLast24Hrs.ResumeLayout(false);
            this.gbLast24Hrs.PerformLayout();
            this.gbCustomSLAStats.ResumeLayout(false);
            this.gbCustomSLAStats.PerformLayout();
            this.pnExtendedDetail.ResumeLayout(false);
            this.pnExtendedDetail.PerformLayout();
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLast24Hrs;
        private System.Windows.Forms.Button btnLast24HrsPrintReport;
        private System.Windows.Forms.Button btnLast24HrsViewReport;
        private System.Windows.Forms.Label lbl24HrsStoreSLADtl;
        private System.Windows.Forms.Label lbl24HrsStoreSLAHdr;
        private System.Windows.Forms.Label lbl24HrsStandardSLADtl;
        private System.Windows.Forms.Label lbl24HrsStandardSLAHdr;
        private System.Windows.Forms.Label lbl24HrsInternationalSLADtl;
        private System.Windows.Forms.Label lbl24HrsInternationalSLAHdr;
        private System.Windows.Forms.Label lbl24HrsExpressSLADtl;
        private System.Windows.Forms.Label lbl24HrsExpressSLAHdr;
        private System.Windows.Forms.Label lbl24HrsTotalSLADtl;
        private System.Windows.Forms.Label lbl24HrsTotalSLAHdr;
        private System.Windows.Forms.GroupBox gbCustomSLAStats;
        private System.Windows.Forms.Button btnReportCustomDateRange;
        private System.Windows.Forms.Button btnCustPrintReport;
        private System.Windows.Forms.Button btnCustViewReport;
        private System.Windows.Forms.Label lblCustTotalSLAHdr;
        private System.Windows.Forms.Label lblCustStoreSLADtl;
        private System.Windows.Forms.Label lblCustTotalSLADtl;
        private System.Windows.Forms.Label lblCustStoreSLAHdr;
        private System.Windows.Forms.Label lblCustExpressSLAHdr;
        private System.Windows.Forms.Label lblStandardTotalSLADtl;
        private System.Windows.Forms.Label lblCustExpressSLADtl;
        private System.Windows.Forms.Label lblCustStandardSLAHdr;
        private System.Windows.Forms.Label lblCustInternationalSLAHdr;
        private System.Windows.Forms.Label lblCustInternationalSLADtl;
        private System.Windows.Forms.Panel pnExtendedDetail;
        public System.Windows.Forms.DataGridView dgvDetailBreakdown;
        private System.Windows.Forms.RadioButton rbExtendedDetail_International;
        private System.Windows.Forms.RadioButton rbExtendedDetail_Standard;
        private System.Windows.Forms.RadioButton rbExtendedDetail_Express;
        private System.Windows.Forms.RadioButton rbExtendedDetailFilter_Store;
        private System.Windows.Forms.RadioButton rbExtendedDetailFilter_All;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnSLACriteriaMetKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailBreakdown_OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailBreakdown_ShipMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailBreakdown_DateOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailBreakdown_DateReleased;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailBreakdown_TimeToRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailBreakdown_DateDispatched;
        private System.Windows.Forms.GroupBox gbCustomDateRange;
        private System.Windows.Forms.DateTimePicker dtpReportFrom;
        private System.Windows.Forms.DateTimePicker dtpReportTo;
        private System.Windows.Forms.Label lblReportTo;
        private System.Windows.Forms.Label lblReportFrom;
        private System.Windows.Forms.PictureBox pbCriteriaNotMetKey;
        private System.Windows.Forms.PictureBox pbMidCriteriaMetKey;
        private System.Windows.Forms.PictureBox pbTopCriteriaMetKey;
        public System.Windows.Forms.Label lblCriteriaNotMetKey;
        public System.Windows.Forms.Label lblMidCriteriaMetKey;
        public System.Windows.Forms.Label lblTopCriteriaMetKey;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblConfigDetails;
    }
}

