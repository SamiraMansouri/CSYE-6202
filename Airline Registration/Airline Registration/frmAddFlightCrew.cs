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
    public partial class frmAddFlightCrew : Form
    {
        public frmAddFlightCrew()
        {
            InitializeComponent();
        }

        private void frmAddFlightCrew_Load(object sender, EventArgs e)
        {
            List<Flight> Allflights;
            BA_Flight BAFlight = new BA_Flight();
            Allflights = BAFlight.GetAllFlightInfo();
            dataGridView1.DataSource = Allflights;
        }

        private void dgvFlights_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtFlightNumber.Text = row.Cells[0].Value.ToString();
             }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = "";
            message += CheckDataValidity();
            if (message=="")
            {
                message+=AddCrew();
                
            }

            toolStripStatusLabel1.Text = message;
        }

        private string AddCrew()
        {
            BA_Crew BACrew = new BA_Crew();
            string message = "";
            Crew crew = new Crew(txtFName.Text, txtLastName.Text, txtEmployeeID.Text, dateTimePicker1.Value.Date, txtPhone.Text, txtAddress.Text, txtType.Text, txtTitle.Text, txtFlightNumber.Text);
            int result = BACrew.AddCrew(crew);
            if (result==0)
            {
                message += "Done Successfully.";
            }
            else
            {
                message += "Something wrong is happened please try again.";
            }
            return message;
        }

        private string CheckDataValidity()
        {
            string message = "";

            message += Is_All_Information_Filled(message);

            if (message == "")
            {
                message += Check_TextboxesInformation_Validity(message);
            }

            if (message == "")
            {

                BA_Crew BACrew = new BA_Crew();
                string Query = " FlightNumber='"+txtFlightNumber.Text+ "' and EmployeeID=" + txtEmployeeID.Text;
                Crew crew= BACrew.SearchCrew(Query);
                if (crew !=null)
                {
                    message += "This Crew is added before to this flight.";
                }
            }

            if (message == "")
            {
                BA_Flight BAF = new BA_Flight();
               Flight flight= BAF.SearchFlight(" FlightNumber= '" + txtFlightNumber.Text + "'");
                if (flight==null)
                {
                    message += "This Flight does not exist";
                }
            }


            return message;
        }

        private string Is_All_Information_Filled(string message)
        {

            if (txtFlightNumber.Text == ""|| txtFlightNumber.Text.Trim() == "" || txtEmployeeID.Text ==""|| txtEmployeeID.Text.Trim() == "")
            {
                message += "FlightNumber and EmployeeID should be filled";
            }
            
            return message;
        }

        private string Check_TextboxesInformation_Validity(string message)
        {
            try
            {
                int x = Convert.ToInt32(txtAddress.Text);
                 x = Convert.ToInt32(txtFName.Text);
                x = Convert.ToInt32(txtLastName.Text);
                x = Convert.ToInt32(txtTitle.Text);
                x = Convert.ToInt32(txtType.Text);

                message += "please Fill textboxes with valid information";
            }
            catch (Exception)
            {

            }

            try
            {
                string x = Convert.ToString(txtEmployeeID.Text);

            }
            catch (Exception)
            {
                if (message=="")
                {

                    message += "Please fill the Destination with valid informations";
                }
            }
            return message;
            
        }
    }
}
