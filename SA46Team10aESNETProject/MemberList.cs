using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA46Team10ASportsFacilityBookingSystem
{
    public partial class MemberList : UserControl
    {
        SA46Team10aESNETProjectEntities ctx;
        List<Member> mlist;
        public MemberList()
        {
            InitializeComponent();
            dataGridView1.ForeColor = Color.Black;

        }

        private void BtnAddMember_Click(object sender, EventArgs e)
        {
            AddMemberform f = new AddMemberform();
            using (f)
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Successful Added!");
                }
            }
            mlist = ctx.Members.ToList();
            dataGridView1.DataSource = mlist;
            dataGridView1.Refresh();
        }

        private void BtnEditMem_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;
            EditMember f = new EditMember();
            Member toupdate = mlist[row];
            f.MemToEdit = toupdate;
            using (f)
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    toupdate = f.MemToEdit;
                    ctx.SaveChanges();
                    MessageBox.Show("Successful Updated!");
                }
            }
            dataGridView1.Refresh();
        }

        private void MemberList_Load(object sender, EventArgs e)
        {
            ctx = new SA46Team10aESNETProjectEntities();
            var q = from x in ctx.Members select x;
            mlist = q.ToList();
            dataGridView1.DataSource = mlist;
            dataGridView1.Columns[dataGridView1.ColumnCount - 1].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var q = from x in ctx.Members
                    where x.MemberName.Contains(textBox1.Text)
                    select x;
            var q1 = from x in ctx.Members
                     where x.memberID.ToString().Contains(textBox1.Text)
                     select x;
            mlist = q1.Concat(q).Distinct().ToList();
            dataGridView1.DataSource = mlist;
        }

        private void BtnDeleteMem_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;
            Member todelete = mlist[row];
            ctx.Members.Remove(todelete);
            List<Booking> bdel = ctx.Bookings.Where(x => x.Member.memberID == todelete.memberID).ToList();
            foreach(Booking b in bdel)
            {
                ctx.Bookings.Remove(b);
            }
            ctx.SaveChanges();
            MessageBox.Show("Successfully Deleted!");
            textBox1.Text = "";
            var q = from x in ctx.Members
                    where x.MemberName.Contains(textBox1.Text)
                    select x;
            mlist = q.ToList();
            dataGridView1.DataSource = mlist;
            Refresh();
        }
    }
}
