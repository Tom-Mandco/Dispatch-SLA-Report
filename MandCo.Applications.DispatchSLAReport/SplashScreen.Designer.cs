namespace MandCo.Applications.DispatchSLAReport
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.label2 = new System.Windows.Forms.Label();
            this.lblMsTaken = new System.Windows.Forms.Label();
            this.tmrTimeTaken = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 107);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dispatch SLA Report Loading\r\nRetreiving Report Data ...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMsTaken
            // 
            this.lblMsTaken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsTaken.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMsTaken.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblMsTaken.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMsTaken.Location = new System.Drawing.Point(362, 100);
            this.lblMsTaken.Name = "lblMsTaken";
            this.lblMsTaken.Size = new System.Drawing.Size(112, 16);
            this.lblMsTaken.TabIndex = 2;
            this.lblMsTaken.Text = "495444 ms";
            this.lblMsTaken.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tmrTimeTaken
            // 
            this.tmrTimeTaken.Interval = 1;
            this.tmrTimeTaken.Tick += new System.EventHandler(this.tmrTimeTaken_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(486, 125);
            this.Controls.Add(this.lblMsTaken);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMsTaken;
        private System.Windows.Forms.Timer tmrTimeTaken;
    }
}