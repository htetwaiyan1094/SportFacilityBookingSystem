namespace SA46Team10ASportsFacilityBookingSystem
{
    partial class BookingActivityusercontrol
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
            this.Activity_search_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Activity_comboBox1 = new System.Windows.Forms.ComboBox();
            this.VenueCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Activity_search_button
            // 
            this.Activity_search_button.BackColor = System.Drawing.Color.Goldenrod;
            this.Activity_search_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity_search_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Activity_search_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Activity_search_button.Location = new System.Drawing.Point(39, 385);
            this.Activity_search_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Activity_search_button.Name = "Activity_search_button";
            this.Activity_search_button.Size = new System.Drawing.Size(171, 62);
            this.Activity_search_button.TabIndex = 11;
            this.Activity_search_button.Text = "Search";
            this.Activity_search_button.UseVisualStyleBackColor = false;
            this.Activity_search_button.Click += new System.EventHandler(this.Activity_search_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 55);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 304);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 55);
            this.label2.TabIndex = 7;
            this.label2.Text = "Activity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 56);
            this.label1.TabIndex = 6;
            this.label1.Text = "Booking of Facilities";
            // 
            // Activity_comboBox1
            // 
            this.Activity_comboBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity_comboBox1.FormattingEnabled = true;
            this.Activity_comboBox1.Items.AddRange(new object[] {
            "Swiming",
            "Tennis",
            "Squash",
            "Rock Climbing",
            "Gym",
            "Football",
            ""});
            this.Activity_comboBox1.Location = new System.Drawing.Point(39, 192);
            this.Activity_comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Activity_comboBox1.Name = "Activity_comboBox1";
            this.Activity_comboBox1.Size = new System.Drawing.Size(197, 31);
            this.Activity_comboBox1.TabIndex = 12;
            this.Activity_comboBox1.SelectedIndexChanged += new System.EventHandler(this.Activity_comboBox1_SelectedIndexChanged);
            // 
            // VenueCB
            // 
            this.VenueCB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenueCB.FormattingEnabled = true;
            this.VenueCB.Items.AddRange(new object[] {
            "Swiming",
            "Tennis",
            "Squash",
            "Rock Climbing",
            "Gym",
            "Football",
            ""});
            this.VenueCB.Location = new System.Drawing.Point(253, 192);
            this.VenueCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VenueCB.Name = "VenueCB";
            this.VenueCB.Size = new System.Drawing.Size(197, 31);
            this.VenueCB.TabIndex = 13;
            // 
            // BookingActivityusercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.VenueCB);
            this.Controls.Add(this.Activity_comboBox1);
            this.Controls.Add(this.Activity_search_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BookingActivityusercontrol";
            this.Size = new System.Drawing.Size(956, 738);
            this.Load += new System.EventHandler(this.BookingActivityusercontrol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Activity_search_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Activity_comboBox1;
        private System.Windows.Forms.ComboBox VenueCB;
    }
}
