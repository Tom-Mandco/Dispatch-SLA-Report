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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDetailBreakdown = new System.Windows.Forms.DataGridView();
            this.colDetailBreakdown_OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailBreakdown_ShipMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailBreakdown_DateOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailBreakdown_DateReleased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailBreakdown_TimeToRelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetailBreakdown_DateDispatched = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpReportFrom = new System.Windows.Forms.DateTimePicker();
            this.lblReportFrom = new System.Windows.Forms.Label();
            this.lblReportTo = new System.Windows.Forms.Label();
            this.dtpReportTo = new System.Windows.Forms.DateTimePicker();
            this.gbLast24Hrs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailBreakdown)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.gbLast24Hrs.Text = "Statistics from cut off point on : dd/mm/yyyy";
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
            this.lbl24HrsInternationalSLADtl.Location = new System.Drawing.Point(21, 79);
            this.lbl24HrsInternationalSLADtl.Name = "lbl24HrsInternationalSLADtl";
            this.lbl24HrsInternationalSLADtl.Size = new System.Drawing.Size(34, 13);
            this.lbl24HrsInternationalSLADtl.TabIndex = 5;
            this.lbl24HrsInternationalSLADtl.Text = "66.66";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(294, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Within the last x days, y hours, z minutes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Print Report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "View Report";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "% of the total orders met their SLA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "5.00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "100.00";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "% of the store orders met their SLA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "% of the express orders met their SLA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "45.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "90.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "% of the standard orders met their SLA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "% of the international orders met their SLA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "66.66";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Enter Custom Date Range";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDetailBreakdown);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(9, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 382);
            this.panel1.TabIndex = 2;
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
            this.dgvDetailBreakdown.Location = new System.Drawing.Point(6, 129);
            this.dgvDetailBreakdown.Name = "dgvDetailBreakdown";
            this.dgvDetailBreakdown.RowHeadersVisible = false;
            this.dgvDetailBreakdown.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailBreakdown.Size = new System.Drawing.Size(775, 250);
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
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(353, 106);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(83, 17);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "International";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(266, 106);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(68, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Standard";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(177, 106);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Express";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(97, 106);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Store";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 106);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "All";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(281, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Orders which have not met their SLA within the last 7 days";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 54);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpReportTo);
            this.groupBox2.Controls.Add(this.lblReportTo);
            this.groupBox2.Controls.Add(this.lblReportFrom);
            this.groupBox2.Controls.Add(this.dtpReportFrom);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(581, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 193);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom Date Range";
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
            // lblReportFrom
            // 
            this.lblReportFrom.AutoSize = true;
            this.lblReportFrom.Location = new System.Drawing.Point(4, 33);
            this.lblReportFrom.Name = "lblReportFrom";
            this.lblReportFrom.Size = new System.Drawing.Size(68, 13);
            this.lblReportFrom.TabIndex = 26;
            this.lblReportFrom.Text = "Report From:";
            // 
            // lblReportTo
            // 
            this.lblReportTo.AutoSize = true;
            this.lblReportTo.Location = new System.Drawing.Point(6, 95);
            this.lblReportTo.Name = "lblReportTo";
            this.lblReportTo.Size = new System.Drawing.Size(58, 13);
            this.lblReportTo.TabIndex = 27;
            this.lblReportTo.Text = "Report To:";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbLast24Hrs);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.gbLast24Hrs.ResumeLayout(false);
            this.gbLast24Hrs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailBreakdown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgvDetailBreakdown;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailBreakdown_OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailBreakdown_ShipMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailBreakdown_DateOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailBreakdown_DateReleased;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailBreakdown_TimeToRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailBreakdown_DateDispatched;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpReportFrom;
        private System.Windows.Forms.DateTimePicker dtpReportTo;
        private System.Windows.Forms.Label lblReportTo;
        private System.Windows.Forms.Label lblReportFrom;
    }
}

