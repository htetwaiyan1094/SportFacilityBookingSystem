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
    public partial class homepageusercontrol : UserControl
    {
        public homepageusercontrol()
        {
            InitializeComponent();
       
        }

        private void BtnHomepg1_Click(object sender, EventArgs e)
        {
            Panelhomepg1.Visible = true;
            Panelhomepg1.BringToFront();
            Panelhomepage2.Visible = false;
        }

        private void Btnhomepg2_Click(object sender, EventArgs e)
        {
            Panelhomepage2.Visible = true;
            Panelhomepg1.Visible = false;
            Panelhomepage2.BringToFront();
        }

        private void RockClimbInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The indoor 8M brick constructed wall with coloured grips." + "\n" + "Please wear knee-length pants and shoes");
        }

        private void GymInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The indoor air-conditioned gym located on the 2nd floor." + "\n" + "We have 6 treadmills, 2 bench-presses, weight machine and rowing machine" + 
                "\n" + "Please wear proper attire and bring own towels.");
        }

        private void footballInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The outdoor full sized football fields are available for individual or group bookings." + "\n" + "Balls are not provided" +
               "\n" + "Please wear proper attire.");
        }

        private void swinInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The outdoor and indoor Olympic sized swimming pools are available for booking." + "\n" + "Both pools are 1.6m at the ends and increase to 3m" +
               "\n" + "Kids under 10 should be under adult supervision at all times." + "\n" + "Only proper swimming attire would be allowed in the pools" );
        }

        private void TennisInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The 2 outdoor tennis courts are available for single or doubles" + "\n" + "Located on the first floor outdoors" +
              "\n" + "No equipment will be provided, please bring your own." + "\n" + "Please wear proper attire with shoes.");
        }

        private void SquashInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The 2 indoor squash courts are fully air-conditioned and available for single or doubles." + "\n" + "The courts are located on the 2nd floor" +
               "\n" + "Only proper attire with shoes allowed.");
        }

        private void homepageusercontrol_Load(object sender, EventArgs e)
        {
            BringToFront();
        }
    }



}
