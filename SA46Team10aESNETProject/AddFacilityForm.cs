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
    public partial class AddFacilityForm : Form
    {
        SA46Team10aESNETProjectEntities ctx;
        public AddFacilityForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddFacilityForm_Load(object sender, EventArgs e)
        {
            ctx = new SA46Team10aESNETProjectEntities();
        }

        private void BtnNewMemberConfirm_Click(object sender, EventArgs e)
        {
            if(!IsEmpty(textBox1.Text) &&
                !IsEmpty(textBox2.Text) &&
                !IsEmpty(textBox3.Text))
            {
                if (ctx.Facilities.Count(x => x.FacilityID == textBox1.Text) < 1)
                {
                    if((int)numericUpDown1.Value > 0)
                    {
                        Facility f = new Facility();
                        f.FacilityID = textBox1.Text;
                        f.Activity = textBox2.Text;
                        f.Venue = textBox3.Text;
                        f.MaxCount = (int)numericUpDown1.Value;
                        ctx.Facilities.Add(f);
                        ctx.SaveChanges();
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
                    MessageBox.Show("ID Exists! Try another one!");
                }
            }
            else
            {
                MessageBox.Show("You need to input all fields!");
            }
        }
        private bool IsEmpty(string s)
        {
            if(s.Trim() == "")
            {
                return true;
            }
            return false;
        }
    }
}
