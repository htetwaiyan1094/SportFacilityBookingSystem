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
    public partial class AgeRangeReportForm : Form
    {
        public AgeRangeReportForm()
        {
            InitializeComponent();
        }

        private void AgeRangeReportForm_Load(object sender, EventArgs e)
        {
            AgeDataSet ds = new AgeDataSet();
            AgeDataSetTableAdapters.viewAgeCountTableAdapter ta = 
                new AgeDataSetTableAdapters.viewAgeCountTableAdapter();
            ta.Fill(ds.viewAgeCount);

            AgeRangeCR cr = new AgeRangeCR();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
