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
    public partial class OccupancyRptForm : Form
    {
        public OccupancyRptForm()
        {
            InitializeComponent();
        }

        private void OccupancyRptForm_Load(object sender, EventArgs e)
        {
            OccupancyDataSet ds = new OccupancyDataSet();
            OccupancyDataSetTableAdapters.viewOccuTableAdapter ta =
                new OccupancyDataSetTableAdapters.viewOccuTableAdapter();
            ta.Fill(ds.viewOccu);

            OccupancyReportCR cr = new OccupancyReportCR();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
