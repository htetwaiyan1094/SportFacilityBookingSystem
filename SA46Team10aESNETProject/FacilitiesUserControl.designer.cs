namespace SA46Team10ASportsFacilityBookingSystem
{
    partial class FacilitiesUserControl
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
            this.BtnEditFac = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridFacility = new System.Windows.Forms.DataGridView();
            this.btnDelFac = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddFac = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacility)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEditFac
            // 
            this.BtnEditFac.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnEditFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditFac.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditFac.ForeColor = System.Drawing.Color.White;
            this.BtnEditFac.Location = new System.Drawing.Point(420, 588);
            this.BtnEditFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditFac.Name = "BtnEditFac";
            this.BtnEditFac.Size = new System.Drawing.Size(120, 42);
            this.BtnEditFac.TabIndex = 4;
            this.BtnEditFac.Text = "EDIT";
            this.BtnEditFac.UseVisualStyleBackColor = false;
            this.BtnEditFac.Click += new System.EventHandler(this.BtnEditFac_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gridFacility);
            this.panel1.Location = new System.Drawing.Point(37, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 614);
            this.panel1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 26);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(85, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Facility / ID";
            // 
            // gridFacility
            // 
            this.gridFacility.AllowUserToAddRows = false;
            this.gridFacility.AllowUserToDeleteRows = false;
            this.gridFacility.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridFacility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFacility.Location = new System.Drawing.Point(33, 128);
            this.gridFacility.MultiSelect = false;
            this.gridFacility.Name = "gridFacility";
            this.gridFacility.ReadOnly = true;
            this.gridFacility.RowTemplate.Height = 28;
            this.gridFacility.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFacility.Size = new System.Drawing.Size(822, 354);
            this.gridFacility.TabIndex = 0;
            // 
            // btnDelFac
            // 
            this.btnDelFac.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDelFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelFac.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelFac.ForeColor = System.Drawing.Color.White;
            this.btnDelFac.Location = new System.Drawing.Point(733, 588);
            this.btnDelFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelFac.Name = "btnDelFac";
            this.btnDelFac.Size = new System.Drawing.Size(120, 42);
            this.btnDelFac.TabIndex = 5;
            this.btnDelFac.Text = "DELETE";
            this.btnDelFac.UseVisualStyleBackColor = false;
            this.btnDelFac.Click += new System.EventHandler(this.btnDelFac_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Firebrick;
            this.label10.Location = new System.Drawing.Point(39, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(416, 39);
            this.label10.TabIndex = 16;
            this.label10.Text = "Maintenence of Facilities";
            // 
            // btnAddFac
            // 
            this.btnAddFac.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAddFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFac.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFac.ForeColor = System.Drawing.Color.White;
            this.btnAddFac.Location = new System.Drawing.Point(114, 588);
            this.btnAddFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFac.Name = "btnAddFac";
            this.btnAddFac.Size = new System.Drawing.Size(120, 42);
            this.btnAddFac.TabIndex = 6;
            this.btnAddFac.Text = "ADD";
            this.btnAddFac.UseVisualStyleBackColor = false;
            this.btnAddFac.Click += new System.EventHandler(this.btnAddFac_Click);
            // 
            // FacilitiesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddFac);
            this.Controls.Add(this.btnDelFac);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnEditFac);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FacilitiesUserControl";
            this.Size = new System.Drawing.Size(956, 738);
            this.Load += new System.EventHandler(this.FacilitiesUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacility)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnEditFac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelFac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddFac;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridFacility;
    }
}
