using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airline_Registration.Business;
using Airline_Registration.Casses;

namespace Airline_Registration
{
    public partial class frmAddFlightCarrier : Form
    {
        public frmAddFlightCarrier()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text.Trim() == "" || txtName.Text.Trim() == "" || txtPhone.Text == "" || txtAddress.Text.Trim() == null || txtName.Text.Trim() == null || txtPhone.Text == null)
            {
                MessageBox.Show("You should fill Name,Address, and Phone at least");
            }
            else
            {
                int result;
                BACarrier BAcarrier = new BACarrier();
                Carrier carrier = new Carrier(txtName.Text, txtOrigion.Text, txtWebsite.Text, txtAddress.Text, txtPhone.Text);


                result = BAcarrier.AddCarrier(carrier);
                if (result == 0)
                {
                    toolStripStatusLabel1.Text = "You add carrier succefully";
                    ResetPage();
                }
                else if (result == -1)
                {
                    toolStripStatusLabel1.Text = "this carrier is added before.";
                }
                else if (result == -2)
                {
                    toolStripStatusLabel1.Text = "there is some problem with adding data please try again.";
                }

            }
        }

        public void ResetPage()
        {
            txtAddress.Text = "";
            txtName.Text = "";
            txtOrigion.Text = "";
            txtPhone.Text = "";
            txtWebsite.Text = "";
        }

        private void frmAddFlightCarrier_Load(object sender, EventArgs e)
        {

        }
    }
}
