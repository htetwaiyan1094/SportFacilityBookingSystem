namespace SA46Team10ASportsFacilityBookingSystem
{
    partial class ReportsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateReport = new System.Windows.Forms.Label();
            this.BtnMemberList = new System.Windows.Forms.Button();
            this.BtnDailyReport = new System.Windows.Forms.Button();
            this.BtnReport3 = new System.Windows.Forms.Button();
            this.BtnReport4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateReport
            // 
            this.GenerateReport.AutoSize = true;
            this.GenerateReport.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateReport.ForeColor = System.Drawing.Color.Firebrick;
            this.GenerateReport.Location = new System.Drawing.Point(29, 44);
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.Size = new System.Drawing.Size(386, 53);
            this.GenerateReport.TabIndex = 5;
            this.GenerateReport.Text = "Generate Report";
            // 
            // BtnMemberList
            // 
            this.BtnMemberList.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnMemberList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMemberList.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMemberList.ForeColor = System.Drawing.Color.White;
            this.BtnMemberList.Location = new System.Drawing.Point(102, 331);
            this.BtnMemberList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMemberList.Name = "BtnMemberList";
            this.BtnMemberList.Size = new System.Drawing.Size(142, 108);
            this.BtnMemberList.TabIndex = 18;
            this.BtnMemberList.Text = " MEMBER LIST REPORT";
            this.BtnMemberList.UseVisualStyleBackColor = false;
            this.BtnMemberList.Click += new System.EventHandler(this.BtnMemberList_Click);
            // 
            // BtnDailyReport
            // 
            this.BtnDailyReport.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnDailyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDailyReport.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDailyReport.ForeColor = System.Drawing.Color.White;
            this.BtnDailyReport.Location = new System.Drawing.Point(292, 331);
            this.BtnDailyReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDailyReport.Name = "BtnDailyReport";
            this.BtnDailyReport.Size = new System.Drawing.Size(145, 108);
            this.BtnDailyReport.TabIndex = 19;
            this.BtnDailyReport.Text = "RECEIPTS REPORT";
            this.BtnDailyReport.UseVisualStyleBackColor = false;
            this.BtnDailyReport.Click += new System.EventHandler(this.BtnDailyReport_Click);
            // 
            // BtnReport3
            // 
            this.BtnReport3.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnReport3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport3.ForeColor = System.Drawing.Color.White;
            this.BtnReport3.Location = new System.Drawing.Point(478, 331);
            this.BtnReport3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReport3.Name = "BtnReport3";
            this.BtnReport3.Size = new System.Drawing.Size(186, 108);
            this.BtnReport3.TabIndex = 20;
            this.BtnReport3.Text = "Occupancy Report";
            this.BtnReport3.UseVisualStyleBackColor = false;
            this.BtnReport3.Click += new System.EventHandler(this.BtnReport3_Click);
            // 
            // BtnReport4
            // 
            this.BtnReport4.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnReport4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport4.ForeColor = System.Drawing.Color.White;
            this.BtnReport4.Location = new System.Drawing.Point(707, 331);
            this.BtnReport4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReport4.Name = "BtnReport4";
            this.BtnReport4.Size = new System.Drawing.Size(146, 108);
            this.BtnReport4.TabIndex = 21;
            this.BtnReport4.Text = "AGE RANGE REPORT";
            this.BtnReport4.UseVisualStyleBackColor = false;
            this.BtnReport4.Click += new System.EventHandler(this.BtnReport4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(96, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 34);
            this.label1.TabIndex = 22;
            this.label1.Text = "Select Report Type:";
            // 
            // ReportsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnReport4);
            this.Controls.Add(this.BtnReport3);
            this.Controls.Add(this.BtnDailyReport);
            this.Controls.Add(this.BtnMemberList);
            this.Controls.Add(this.GenerateReport);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportsUserControl";
            this.Size = new System.Drawing.Size(956, 738);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GenerateReport;
        private System.Windows.Forms.Button BtnMemberList;
        private System.Windows.Forms.Button BtnDailyReport;
        private System.Windows.Forms.Button BtnReport3;
        private System.Windows.Forms.Button BtnReport4;
        private System.Windows.Forms.Label label1;
    }
}
