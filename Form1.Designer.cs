namespace WindowsFormsApp1
{
    partial class IblStatus
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.trkCredits = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(227, 275);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(235, 22);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status Shown here";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // trkCredits
            // 
            this.trkCredits.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trkCredits.Location = new System.Drawing.Point(182, 172);
            this.trkCredits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trkCredits.Name = "trkCredits";
            this.trkCredits.Size = new System.Drawing.Size(139, 45);
            this.trkCredits.TabIndex = 3;
            this.trkCredits.Scroll += new System.EventHandler(this.trkCredits_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of credits";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCredits.Location = new System.Drawing.Point(352, 172);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(16, 17);
            this.lblCredits.TabIndex = 5;
            this.lblCredits.Text = "0";
            // 
            // IblStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trkCredits);
            this.Controls.Add(this.lblStatus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IblStatus";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.IblStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TrackBar trkCredits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCredits;
    }
}

