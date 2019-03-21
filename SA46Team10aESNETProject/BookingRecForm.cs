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
    public partial class BookingRecForm : Form
    {
        Booking b;
        public Booking Bdetail
        {
            get { return b; }
            set { b = value; }
        }
        public BookingRecForm()
        {
            InitializeComponent();
        }

        private void BookingRecForm_Load(object sender, EventArgs e)
        {
            label3.Text += b.BookingNo.ToString();
            lblMember.Text = "ID : " + b.Member.memberID.ToString();
            lblMember.Text += Environment.NewLine + Environment.NewLine;
            lblMember.Text += Environment.NewLine + b.Member.MemberName;
            labelBookDetails.Text = b.Facility.Activity;
            labelBookDetails.Text += Environment.NewLine +
                Environment.NewLine + b.Facility.Venue;
            labelBookDetails.Text += Environment.NewLine + Environment.NewLine;
            labelBookDetails.Text += String.Format("{0:dd/MM/yyyy}", b.FacilityDate);
            labelBookDetails.Text += Environment.NewLine + Environment.NewLine + 
                b.TimingID;
        }
    }
}
