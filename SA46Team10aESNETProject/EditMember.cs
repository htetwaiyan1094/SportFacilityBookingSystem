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
    public partial class EditMember : Form
    {
        SA46Team10aESNETProjectEntities ctx;
        Member m;
        public Member MemToEdit
        {
            get { return m; }
            set { m = value; }
        }
        public EditMember()
        {
            InitializeComponent();
            ctx = Program.ctx;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditMember_Load(object sender, EventArgs e)
        {
            int x, y;
            x = Screen.PrimaryScreen.WorkingArea.Width/3;
            y = Screen.PrimaryScreen.WorkingArea.Height * 2/9;
            Location = new Point(x, y);
            tbName.Text = m.MemberName;
            tbAddr.Text = m.Address;
            dateTimePicker1.Value = (DateTime)m.Birthdate;
            tbPh1.Text = m.HandPhNo.Substring(0, 4);
            tbPh2.Text = m.HandPhNo.Substring(5, 4);
        }

        private void BtnNewMemberConfirm_Click(object sender, EventArgs e)
        {
            if (!IsEmpty(tbName.Text) &&
            !IsEmpty(tbAddr.Text) &&
            !IsEmpty(tbPh1.Text) &&
            !IsEmpty(tbPh2.Text))
            {
                m.MemberName = tbName.Text;
                m.Birthdate = dateTimePicker1.Value;
                m.Address = tbAddr.Text;
                m.HandPhNo = tbPh1.Text + "-" + tbPh2.Text;
                ctx.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
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
