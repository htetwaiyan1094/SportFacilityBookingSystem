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
    public partial class FacilitiesUserControl : UserControl
    {
        SA46Team10aESNETProjectEntities ctx;
        List<Facility> flist;
        public FacilitiesUserControl()
        {
            InitializeComponent();
        }

        private void FacilitiesUserControl_Load(object sender, EventArgs e)
        {
            ctx = Program.ctx;
            flist = ctx?.Facilities?.ToList();
            gridFacility.DataSource = flist;
            gridFacility.ForeColor = Color.Black;
            var lastCol = gridFacility?.Columns?.GetLastColumn(
                DataGridViewElementStates.Visible,
                DataGridViewElementStates.None
            );
            if (lastCol != null) lastCol.Visible = false;
            gridFacility.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var q = from x in ctx.Facilities
                    where x.FacilityID.Contains(textBox1.Text)
                    select x;
            var q1 = from x in ctx.Facilities
                     where x.Activity.ToString().Contains(textBox1.Text)
                     select x;
            flist = q1.Concat(q).Distinct().ToList();
            gridFacility.DataSource = flist;
        }

        private void btnAddFac_Click(object sender, EventArgs e)
        {
            AddFacilityForm f = new AddFacilityForm();
            using (f)
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Successful Added!");
                    var q = from x in ctx.Facilities select x;
                    flist = q.ToList();
                    gridFacility.DataSource = flist;
                    gridFacility.Refresh();
                }
            }
        }

        private void BtnEditFac_Click(object sender, EventArgs e)
        {

            int row = gridFacility.CurrentRow.Index;
            EditFacilityForm f = new EditFacilityForm();
            Facility toupdate = flist[row];
            f.FacToEdit = toupdate;
            using (f)
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    toupdate = f.FacToEdit;
                    ctx.SaveChanges();
                    MessageBox.Show("Successful Updated!");
                }
            }
            gridFacility.Refresh();
        }

        private void btnDelFac_Click(object sender, EventArgs e)
        {
            int row = gridFacility.CurrentRow.Index;
            Facility todelete = flist[row];
            ctx.Facilities.Remove(todelete);
            List<Booking> todel = ctx.Bookings.Where(
                x => x.Facility.FacilityID == todelete.FacilityID).ToList();
            foreach(Booking b in todel)
            {
                ctx.Bookings.Remove(b);
            }
            ctx.SaveChanges();
            MessageBox.Show("Successfully Deleted!");
            textBox1.Text = "";
            var q = from x in ctx.Facilities
                    where x.FacilityID.Contains(textBox1.Text)
                    select x;
            flist = q.ToList();
            gridFacility.DataSource = flist;
            Refresh();
        }
    }
}
