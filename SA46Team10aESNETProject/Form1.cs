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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Reservationbtn.Visible = false;
            Cancelbookingbtn.Visible = false;
            Sidepanel1.Height = HomeButton.Height;
            Sidepanel1.Top = HomeButton.Top;
            homepageusercontrol1.BringToFront();

        }


        private void button2_Click(object sender, EventArgs e) //Memberbtn
        {
            Reservationbtn.Visible = false;
            Cancelbookingbtn.Visible = false;
            Sidepanel1.Height = button2.Height;
            Sidepanel1.Top = button2.Top;
            memberList1.BringToFront();
     
        }

        private void BookingButton_Click(object sender, EventArgs e)
        {
            if (Reservationbtn.Visible == false && Cancelbookingbtn.Visible == false)
            {
                Cancelbookingbtn.Visible = true;
                Reservationbtn.Visible = true;
                Cancelbookingbtn.BringToFront();
                Reservationbtn.BringToFront();
            }
            else
            {
                Reservationbtn.Visible = false;
                Cancelbookingbtn.Visible = false;
            }
        }

        private void Reservationbtn_Click(object sender, EventArgs e)
        {
            Sidepanel1.Height = BookingButton.Height;
            Sidepanel1.Top = BookingButton.Top;
            bookingActivityusercontrol1.BringToFront();
            Reservationbtn.BringToFront();
            Cancelbookingbtn.Visible = false;
            Reservationbtn.Visible = false;
        }

        private void Facilitiesbtn_Click(object sender, EventArgs e)
        {
            Reservationbtn.Visible = false;
            Cancelbookingbtn.Visible = false;
            Sidepanel1.Height = Facilitiesbtn.Height;
            Sidepanel1.Top = Facilitiesbtn.Top;
            Sidepanel1.BringToFront();
            facilitiesUserControl1.BringToFront();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            Reservationbtn.Visible = false;
            Cancelbookingbtn.Visible = false;
            Sidepanel1.Height = ReportButton.Height;
            Sidepanel1.Top = ReportButton.Top;
            reportsUserControl1.BringToFront();
        }

        private void Cancelbookingbtn_Click(object sender, EventArgs e)
        {
            Sidepanel1.Height = BookingButton.Height;
            Sidepanel1.Top = BookingButton.Top;
            cancelBookingUserControl1.BringToFront();
            Cancelbookingbtn.BringToFront();
            Cancelbookingbtn.Visible = false;
            Reservationbtn.Visible = false;
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width * 15 / 100;
            int y = Screen.PrimaryScreen.WorkingArea.Height * 4 / 100;
            Location = new Point(x, y);
            Width = Screen.PrimaryScreen.WorkingArea.Width * 70 / 100;
            Height = Screen.PrimaryScreen.WorkingArea.Height * 92 / 100;
            Cancelbookingbtn.Visible = false;
            Reservationbtn.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
