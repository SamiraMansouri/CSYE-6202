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
    public partial class frmUpdateFlightCarrier : Form
    {
        public frmUpdateFlightCarrier()
        {
            InitializeComponent();
        }
        

        private void frmUpdateFlightCarrier_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            
        }

        private void InitializeDataGridView()
        {
            List<Carrier> carriers;
            BACarrier baCarrier = new BACarrier();
            carriers = baCarrier.GetAllCarriers();
            dataGridView1.DataSource = carriers;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtName.Text = row.Cells[1].Value.ToString();
                txtOrigion.Text = row.Cells[2].Value.ToString();
                txtWebsite.Text = row.Cells[3].Value.ToString();
                txtAddress.Text = row.Cells[5].Value.ToString();
                txtPhone.Text = row.Cells[4].Value.ToString();
               
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BACarrier bacarrier = new BACarrier();
            if (txtName.Text!=""||txtName.Text!=null)
            {
                Carrier carrier ;
                carrier=bacarrier.SearchCarrier(SearchCarierQuery());

                if (carrier==null)
                {
                    toolStripStatusLabel1.Text = "This carrier does not exist please refresh your information";
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this carrie?", "Remove Carrier", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (bacarrier.DeleteCarrier(carrier.ID))
                        {
                            toolStripStatusLabel1.Text = "The carier is deleted successfully.";
                            ResetPage();
                            InitializeDataGridView();
                        }
                        else
                        {
                            toolStripStatusLabel1.Text = "Exuse me,some problem occured during connection to database.please try again.";
                        }
                    }
                  
                }
            }
            else
            {
                MessageBox.Show("Please fill the name of carrier");
            }
        }

        private string SearchCarierQuery()
        {

            string Query;
            Query = "Name= '" + txtName.Text + "'";

            if (txtOrigion.Text != null && txtOrigion.Text.Trim() != "" && txtOrigion.Text != "")
            {
                Query += " and Origion= '" + txtOrigion.Text + "'";
            }

            if (txtWebsite.Text != null && txtWebsite.Text.Trim() != "" && txtWebsite.Text != "")
            {
                Query += " and Website= '" + txtWebsite.Text + "'";
            }

            if (txtPhone.Text != null && txtPhone.Text.Trim() != "" && txtPhone.Text != "")
            {
                Query += " and Phone= '" + txtPhone.Text + "'";
            }

            if (txtAddress.Text != null && txtAddress.Text.Trim() != "" && txtAddress.Text != "")
            {
                Query += " and Address= '" + txtAddress.Text + "'";
            }
            
            return Query;
            
        }

        public void ResetPage()
        {
            txtAddress.Text = "";
            txtName.Text = "";
            txtOrigion.Text = "";
            txtPhone.Text = "";
            txtWebsite.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int CarrierID;
            BACarrier bacarrier = new BACarrier();
            if (txtName.Text != "" || txtName.Text != null)
            {
                Carrier carrierr;
                carrierr = bacarrier.SearchCarrier(" Name='" + txtName.Text + "'");
                CarrierID = carrierr.ID;
                if (CarrierID==-1)
                {
                    toolStripStatusLabel1.Text = "This carrier does not exist please refresh your information";
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Edit this carrie?", "Edit Carrier", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Carrier carrier = new Carrier(CarrierID, txtName.Text, txtOrigion.Text, txtWebsite.Text, txtAddress.Text, txtPhone.Text);
                        if (bacarrier.UpdateCarrier(carrier))
                        {
                            toolStripStatusLabel1.Text = "The carier is Edited successfully.";
                            ResetPage();
                            InitializeDataGridView();
                        }
                        else
                        {
                            toolStripStatusLabel1.Text = "Exuse me,some problem occured during connection to database.please try again.";
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Please fill the name of carrier");
            }
        }
    }
}
