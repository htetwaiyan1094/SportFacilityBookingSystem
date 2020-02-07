using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA46Team10ASportsFacilityBookingSystem
{
    public partial class BookingActivityusercontrol : UserControl
    {
        SA46Team10aESNETProjectEntities ctx;
        public BookingActivityusercontrol()
        {
            InitializeComponent();
        }

        private void Activity_search_button_Click(object sender, EventArgs e)
        {
            BookingForm f = new BookingForm();
            f.BookAct = Activity_comboBox1.SelectedItem.ToString();
            f.Bookven = VenueCB.SelectedItem.ToString();
            f.Bookdate = dateTimePicker1.Value.Date;
            f.ShowDialog();
        }

        private void BookingActivityusercontrol_Load(object sender, EventArgs e)
        {
            ctx = Program.ctx;
            var flist = ctx?.Facilities?.Select(x => x.Activity)?.Distinct()?.ToList();
            Activity_comboBox1.DataSource = flist;
            Activity_comboBox1.DisplayMember = "Activity";
            dateTimePicker1.MinDate = DateTime.Today.AddDays(1);
        }

        private void Activity_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = Activity_comboBox1.SelectedItem.ToString();
            var vlist = ctx.Facilities.Where(x => x.Activity == s).Select(x => x.Venue).ToList();
            VenueCB.DataSource = vlist;
            VenueCB.DisplayMember = "Venue";
        }
    }
}
