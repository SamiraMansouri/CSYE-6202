using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airline_Registration.Casses;
using Airline_Registration.Business;

namespace Airline_Registration
{
    public partial class frmAllFlightInformation : Form
    {
        public frmAllFlightInformation()
        {
            InitializeComponent();
        }

        private void frmAllFlightInformation_Load(object sender, EventArgs e)
        {
            List<Flight> Allflights;
            BA_Flight BAFlight = new BA_Flight();
            Allflights= BAFlight.GetAllFlightInfo();
            dataGridView1.DataSource = Allflights;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count==1)
            {
                Flight flight = null;
                flight = (Flight)dataGridView1.CurrentRow.DataBoundItem;
                frmFlightInfoInDetail _frmFlightInfoInDetail = new frmFlightInfoInDetail(flight);
                this.Hide();
                _frmFlightInfoInDetail.Show();
            }
            else if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("please select one row");
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("please select Just one row");
            }


        }
    }
}
