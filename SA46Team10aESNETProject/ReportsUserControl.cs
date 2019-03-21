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
    public partial class ReportsUserControl : UserControl
    {
        public ReportsUserControl()
        {
            InitializeComponent();
        }

        private void BtnMemberList_Click(object sender, EventArgs e)
        {
            new MemberReportForm().Show();
        }

        private void BtnReport4_Click(object sender, EventArgs e)
        {
            new AgeRangeReportForm().Show();
        }

        private void BtnDailyReport_Click(object sender, EventArgs e)
        {
            new BookingReportForm().Show();
        }

        private void BtnReport3_Click(object sender, EventArgs e)
        {
            new OccupancyRptForm().Show();
        }
    }
}
