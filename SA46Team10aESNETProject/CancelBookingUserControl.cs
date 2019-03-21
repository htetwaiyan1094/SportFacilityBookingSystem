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
    public partial class CancelBookingUserControl : UserControl
    {
        SA46Team10aESNETProjectEntities ctx;
        List<Member> mlist;
        Member m;
        List<Booking> blist;
        Booking b = null;
        public CancelBookingUserControl()
        {
            InitializeComponent();
            dataGridView1.ForeColor = Color.Black;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void CancelBookingUserControl_Load(object sender, EventArgs e)
        {
            ctx = new SA46Team10aESNETProjectEntities();
            mlist = ctx.Bookings.Where(x => x.bookstatus == "active"
                ).Select(x => x.Member).Distinct().ToList();
            foreach (Member mem in mlist)
            {
                comboBox1.Items.Add(
                    String.Format("{0} ( ID - {1} )", mem.MemberName, mem.memberID)
                    );
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sel = comboBox1.SelectedIndex;
            m = mlist[sel];
            blist = m.Bookings.Where(x => x.bookstatus == "active").ToList();
            var gridlist = blist.Select(x =>
                new
                {
                    x.BookingNo,
                    x.Facility.Activity,
                    x.Facility.Venue,
                    x.FacilityDate,
                    x.Timing.TimingID
                }
            ).ToList();
            dataGridView1.DataSource = gridlist;
        }

        private void BtnCancelBooking_Click(object sender, EventArgs e)
        {
            if (b != null)
            {
                b.bookstatus = "cancelled";
                ctx.SaveChanges();
                MessageBox.Show("Successful!");
                blist = m.Bookings.Where(x => x.bookstatus == "active").ToList();
                dataGridView1.DataSource = blist;
                lblBookingInfo.Text = "";
            }
            else
            {
                MessageBox.Show("Select to cancel!");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selgrid = dataGridView1.SelectedRows[0].Index;
            b = blist[selgrid];
            string output = b.Facility.Activity + " " + b.Facility.Venue;
            output += Environment.NewLine + Environment.NewLine;
            output += String.Format("{0:dd/MM/yyyy}", b.FacilityDate);
            output += Environment.NewLine + Environment.NewLine;
            output += b.TimingID;
            lblBookingInfo.Text = output;
        }
    }
}
