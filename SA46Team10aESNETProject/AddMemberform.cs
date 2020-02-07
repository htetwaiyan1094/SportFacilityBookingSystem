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
    public partial class AddMemberform : Form
    {
        SA46Team10aESNETProjectEntities ctx;
        Member m;
        List<Member> mlist;
        public List<Member> Mlist
        {
            get { return mlist; }
        }
        public AddMemberform()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddMemberform_Load(object sender, EventArgs e)
        {
            ctx = Program.ctx;
            m = new Member();
            int x, y;
            x = Screen.PrimaryScreen.WorkingArea.Width / 3;
            y = Screen.PrimaryScreen.WorkingArea.Height * 2 / 9;
            Location = new Point(x, y);
            tbPh1.MaxLength = 4;
            tbPh2.MaxLength = 4;
            rbtnM.Checked = true;
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
                if (rbtnF.Checked == true)
                {
                    m.Gender = "F";
                }
                else
                {
                    m.Gender = "M";
                }
                m.Address = tbAddr.Text;
                m.HandPhNo = tbPh1.Text + "-" + tbPh2.Text;
                ctx.Members.Add(m);
                ctx.SaveChanges();
                mlist = ctx.Members.ToList();
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
