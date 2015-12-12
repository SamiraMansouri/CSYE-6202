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
    public partial class frmUpdateCrew : Form
    {
        public frmUpdateCrew()
        {
            InitializeComponent();
        }

        private void frmUpdateCrew_Load(object sender, EventArgs e)
        {
            initializeGridView();
        }

        private void initializeGridView()
        {
            List<Crew> crews = new List<Crew>();
            BA_Crew bacrew = new BA_Crew();
            crews = bacrew.GetAllCrews();
            dataGridView1.DataSource = crews;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtType.Text = row.Cells[0].Value.ToString();
                txtTitle.Text = row.Cells[1].Value.ToString();
                txtFlightNumber.Text = row.Cells[2].Value.ToString();
                txtFName.Text = row.Cells[3].Value.ToString();
                txtLastName.Text = row.Cells[4].Value.ToString();
                txtEmployeeID.Text = row.Cells[5].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells[6].Value.ToString());
                txtPhone.Text = row.Cells[7].Value.ToString();
                txtAddress.Text = row.Cells[8].Value.ToString();

            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = "";
            message += CheckDataValidity();
            BA_Crew BACrew = new BA_Crew();
            Crew crew = null;
            if (message == "")
            {

                crew = new Crew(txtFName.Text, txtLastName.Text, txtEmployeeID.Text, dateTimePicker1.Value.Date, txtPhone.Text, txtAddress.Text, txtType.Text, txtTitle.Text, txtFlightNumber.Text);
                int result = BACrew.UpdateCrew(crew);
                if (result == 0)
                {
                    message += "Done Successfully.";
                    initializeGridView();
                }
                else
                {
                    message += "Something wrong is happened please try again.";
                }


            }

            toolStripStatusLabel1.Text = message;
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
                string Query = " FlightNumber='" + txtFlightNumber.Text + "' and EmployeeID=" + txtEmployeeID.Text;
                Crew crew = BACrew.SearchCrew(Query);
                if (crew == null)
                {
                    message += "this flight does not have this crew,please try again.";
                }
            }




            return message;
        }

        private string Is_All_Information_Filled(string message)
        {

            if (txtFlightNumber.Text == "" || txtFlightNumber.Text.Trim() == "" || txtEmployeeID.Text == "" || txtEmployeeID.Text.Trim() == "")
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
                if (message == "")
                {

                    message += "Please fill the Destination with valid informations";
                }
            }
            return message;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "";
            message += CheckDataValidity();
            BA_Crew BACrew = new BA_Crew();
            Crew crew = null;
            if (message == "")
            {

                int result = BACrew.DeleteCrew(txtFlightNumber.Text, Convert.ToInt32(txtEmployeeID.Text));
                if (result == 0)
                {
                    message += "Done Successfully.";
                    initializeGridView();
                }
                else
                {
                    message += "Something wrong is happened please try again.";
                }

            }
        }
    }

}
