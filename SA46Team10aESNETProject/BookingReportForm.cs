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
    public partial class BookingReportForm : Form
    {
        public BookingReportForm()
        {
            InitializeComponent();
        }

        private void BookingReportForm_Load(object sender, EventArgs e)
        {
            BookingDataSet ds = new BookingDataSet();
            BookingDataSetTableAdapters.viewBookRecTableAdapter ta =
                new BookingDataSetTableAdapters.viewBookRecTableAdapter();
            ta.Fill(ds.viewBookRec);

            BookingReportCR cr = new BookingReportCR();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
