namespace SA46Team10ASportsFacilityBookingSystem
{
    partial class MemberList
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
            this.Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddMember = new System.Windows.Forms.Button();
            this.BtnEditMem = new System.Windows.Forms.Button();
            this.BtnDeleteMem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(56, 31);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(229, 43);
            this.Label.TabIndex = 4;
            this.Label.Text = "Member List";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(387, 124);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 30);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = " ";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Name/Member ID:";
            // 
            // BtnAddMember
            // 
            this.BtnAddMember.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddMember.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddMember.ForeColor = System.Drawing.Color.White;
            this.BtnAddMember.Location = new System.Drawing.Point(81, 543);
            this.BtnAddMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddMember.Name = "BtnAddMember";
            this.BtnAddMember.Size = new System.Drawing.Size(120, 42);
            this.BtnAddMember.TabIndex = 8;
            this.BtnAddMember.Text = "ADD";
            this.BtnAddMember.UseVisualStyleBackColor = false;
            this.BtnAddMember.Click += new System.EventHandler(this.BtnAddMember_Click);
            // 
            // BtnEditMem
            // 
            this.BtnEditMem.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnEditMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditMem.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditMem.ForeColor = System.Drawing.Color.White;
            this.BtnEditMem.Location = new System.Drawing.Point(410, 545);
            this.BtnEditMem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditMem.Name = "BtnEditMem";
            this.BtnEditMem.Size = new System.Drawing.Size(120, 42);
            this.BtnEditMem.TabIndex = 9;
            this.BtnEditMem.Text = "EDIT";
            this.BtnEditMem.UseVisualStyleBackColor = false;
            this.BtnEditMem.Click += new System.EventHandler(this.BtnEditMem_Click);
            // 
            // BtnDeleteMem
            // 
            this.BtnDeleteMem.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnDeleteMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteMem.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteMem.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteMem.Location = new System.Drawing.Point(744, 544);
            this.BtnDeleteMem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeleteMem.Name = "BtnDeleteMem";
            this.BtnDeleteMem.Size = new System.Drawing.Size(120, 42);
            this.BtnDeleteMem.TabIndex = 10;
            this.BtnDeleteMem.Text = "DELETE";
            this.BtnDeleteMem.UseVisualStyleBackColor = false;
            this.BtnDeleteMem.Click += new System.EventHandler(this.BtnDeleteMem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 205);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(824, 310);
            this.dataGridView1.TabIndex = 11;
            // 
            // MemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnDeleteMem);
            this.Controls.Add(this.BtnEditMem);
            this.Controls.Add(this.BtnAddMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Label);
            this.ForeColor = System.Drawing.Color.Firebrick;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MemberList";
            this.Size = new System.Drawing.Size(956, 603);
            this.Load += new System.EventHandler(this.MemberList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAddMember;
        private System.Windows.Forms.Button BtnEditMem;
        private System.Windows.Forms.Button BtnDeleteMem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
