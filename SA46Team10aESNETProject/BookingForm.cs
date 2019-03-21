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
    public partial class BookingForm : Form
    {
        SA46Team10aESNETProjectEntities ctx;
        List<Button> btngrp;
        List<Timing> timeslots;
        List<Member> mlist;
        string bookact, bookven;
        Member bookm;
        Facility bookf;
        DateTime bookdate;
        Timing bookt;
        public string BookAct
        {
            set { bookact = value; }
        }
        public string Bookven
        {
            set { bookven = value; }
        }
        public DateTime Bookdate
        {
            set { bookdate = value; }
        }
        public BookingForm()
        {
            InitializeComponent();
            btngrp = new List<Button>
            {
                button1,
                button2,
                button3,
                button4,
                button5,
                button6,
                button7,
                button8,
                button9
            };
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ctx = new SA46Team10aESNETProjectEntities();
            bookf = ctx.Facilities.Where(x => x.Activity == bookact
            && x.Venue == bookven).First();
            timeslots = (from x in ctx.Timings
                         orderby x.TimeSlot
                         select x).ToList();
            FormBuilding();
        }
        private void FormBuilding()
        {
            titleActivity.Text = bookf.Activity;
            titleVenue.Text = bookf.Activity + " " + bookf.Venue;
            lblDate.Text = String.Format("{0:dd/MM/yyyy}", bookdate);
            lblMemName.Text = "<name>";
            lblTimeslot.Text = "<time>";
            int i = 0;
            foreach (Timing t in timeslots)
            {
                int total;
                try
                {
                    var q = (from x in ctx.ViewBookingCounts
                             where x.FacilityID == bookf.FacilityID &&
                             x.FacilityDate == bookdate && x.TimingID == t.TimingID
                             select x).First();
                    total = (int)q.BookCount;
                }
                catch (Exception e1)
                {
                    total = 0;
                }
                if (total < bookf.MaxCount)
                {
                    btngrp[i].BackColor = Color.DarkOliveGreen;
                    btngrp[i].Enabled = true;
                }
                else
                {
                    btngrp[i].BackColor = Color.Firebrick;
                    btngrp[i].Enabled = false;
                }
                i++;
            }
            mlist = (from x in ctx.Members select x).ToList();
            var q1 = mlist.Select(x =>
                new
                {
                    x.memberID,
                    x.MemberName,
                    x.Gender,
                    x.HandPhNo
                }
            );
            DataGridViewMemberBook.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DataGridViewMemberBook.DataSource = q1.ToList();
            lblFacility.Text = bookf.Activity + " " + bookf.Venue;
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
            var q2 = mlist.Select(x =>
                    new
                    {
                        x.memberID,
                        x.MemberName,
                        x.Gender,
                        x.HandPhNo
                    }
                );
            DataGridViewMemberBook.DataSource = q2.ToList();
        }

        private void DataGridViewMemberBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = DataGridViewMemberBook.SelectedRows[0].Index;
            lblMemName.Text = String.Format("{0} ( ID : {1} )",
                mlist[i].MemberName, mlist[i].memberID);
            bookm = mlist[i];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookt = timeslots[0];
            lblTimeslot.Text = bookt.TimingID.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bookt = timeslots[1];
            lblTimeslot.Text = bookt.TimingID.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bookt = timeslots[2];
            lblTimeslot.Text = bookt.TimingID.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bookt = timeslots[3];
            lblTimeslot.Text = bookt.TimingID.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bookt = timeslots[4];
            lblTimeslot.Text = bookt.TimingID.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bookt = timeslots[5];
            lblTimeslot.Text = bookt.TimingID.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bookt = timeslots[6];
            lblTimeslot.Text = bookt.TimingID.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bookt = timeslots[7];
            lblTimeslot.Text = bookt.TimingID.ToString();
        }

        private void Confirm_button_Click(object sender, EventArgs e)
        {
            if(bookm != null && bookt != null)
            {
                Booking b = new Booking();
                b.Facility = bookf;
                b.Member = bookm;
                b.Timing = bookt;
                b.FacilityDate = bookdate;
                b.BookingDate = DateTime.Today.Date;
                b.bookstatus = "active";
                ctx.Bookings.Add(b);
                ctx.SaveChanges();
                MessageBox.Show("Successfully Booked!");
                BookingRecForm fshow = new BookingRecForm();
                fshow.Bdetail = b;
                fshow.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Please select details!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bookt = timeslots[8];
            lblTimeslot.Text = bookt.TimingID.ToString();
        }
    }
}
