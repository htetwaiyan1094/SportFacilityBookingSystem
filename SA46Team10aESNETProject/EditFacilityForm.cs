using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA46Team10ASportsFacilityBookingSystem
{
    public partial class EditFacilityForm : Form
    {
        SA46Team10aESNETProjectEntities ctx;
        Facility f;
        public Facility FacToEdit
        {
            get { return f; }
            set { f = value; }
        }
        public EditFacilityForm()
        {
            InitializeComponent();
        }

        private void EditFacilityForm_Load(object sender, EventArgs e)
        {
            ctx = Program.ctx;
            int x, y;
            x = Screen.PrimaryScreen.WorkingArea.Width / 3;
            y = Screen.PrimaryScreen.WorkingArea.Height * 2 / 9;
            Location = new Point(x, y);
            lblFacID.Text = f.FacilityID;
            textBox2.Text = f.Activity;
            textBox3.Text = f.Venue;
            numericUpDown1.Value = (decimal)f.MaxCount;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNewMemberConfirm_Click(object sender, EventArgs e)
        {

            if (!IsEmpty(textBox2.Text) &&
                !IsEmpty(textBox3.Text))
            {
                if ((int)numericUpDown1.Value > 0)
                {
                    f.Activity = textBox2.Text;
                    f.Venue = textBox3.Text;
                    f.MaxCount = (int)numericUpDown1.Value;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Please put positive number!");
                }
            }
            else
            {
                MessageBox.Show("You need to input all fields!");
            }
        }
        private bool IsEmpty(string s)
        {
            if (s.Trim() == "")
            {
                return true;
            }
            return false;
        }
    }
}
