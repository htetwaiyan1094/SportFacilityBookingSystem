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
    public partial class MemberReportForm : Form
    {
        public MemberReportForm()
        {
            InitializeComponent();
        }

        private void MemberReportForm_Load(object sender, EventArgs e)
        {
            MemberReport ds = new MemberReport();
            MemberReportTableAdapters.viewMemRptTableAdapter ta =
                new MemberReportTableAdapters.viewMemRptTableAdapter();
            ta.Fill(ds.viewMemRpt);

            MemberReportCR cr = new MemberReportCR();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
