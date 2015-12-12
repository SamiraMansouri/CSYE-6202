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
    public partial class frmAddFlight : Form
    {
        public frmAddFlight()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "";
            message+= CheckDataValidity();
            if (message=="")
            {
                TimeSpan time = new TimeSpan(cmbHour.SelectedIndex + 1, cmbMinute.SelectedIndex + 1, 0);
                Flight flight = new Flight(txtFlightNumber.Text,Convert.ToDateTime( dateTimePicker1.Text).Date, time,
                                            txtDestination.Text, txtArrival.Text, cmbCarrier.SelectedItem.ToString());

                

                if (chkBusiness.Checked)
                {
                    flight.AddSeatType("Business", Convert.ToInt32(txtPriceBusiness.Text), Convert.ToInt32(txtStartBusiness.Text),
                                            Convert.ToInt32(txtEndBusiness.Text));
                }
                if (chkEconomy.Checked)
                {
                    flight.AddSeatType("Economy", Convert.ToInt32(txtPriceEconomy.Text), Convert.ToInt32(txtStartEconomy.Text),
                                            Convert.ToInt32(txtEndEconomy.Text));
                }
                if (chkEconomyPlus.Checked)
                {
                    flight.AddSeatType("Economy Plus", Convert.ToInt32(txtEndEconomyPlus.Text), Convert.ToInt32(txtEndEconomyPlus.Text),
                                            Convert.ToInt32(txtEndEconomyPlus.Text));
                }

                BA_Flight BAFlight = new BA_Flight();
                int  result=BAFlight.AddFlight(flight);
                if (result==-1)
                {
                    message += "Please try again.";
                }

                else
                {

                    message += "Flight is added Successfully.";
                }
            }
            toolStripStatusLabel1.Text = message;
        }

        private string  CheckDataValidity()
        {
            string message = "";

            message += Is_All_Information_Filled(message);
            if (message=="")
            {
                message += Check_TextboxesInformation_Validity(message);
            }

            if (message=="")
            {
               
                if( ((chkBusiness.Checked)&&(Convert.ToInt32(txtStartBusiness.Text) > Convert.ToInt32(txtEndBusiness.Text))) ||
                    ( (chkEconomy.Checked) && (Convert.ToInt32(txtStartEconomy.Text) > Convert.ToInt32(txtEndEconomy.Text))) ||
                        ((chkEconomyPlus.Checked) && Convert.ToInt32(txtEndEconomyPlus.Text) > Convert.ToInt32(txtEndEconomyPlus.Text)))
                {
                    message += "End seat should be greater than the start seat";
                }

                if (((chkBusiness.Checked) && ((float.Parse(txtPriceBusiness.Text)) <=0))|| ((chkEconomy.Checked) && ((float.Parse(txtPriceEconomy.Text)<=0)))
                    || ((chkEconomyPlus.Checked) && ((float.Parse(txtPriceEconomyPlus.Text) <= 0))))
                {
                    message += "Price should be greater than ziro";
                }
            }

            if (message=="")
            {
                if (Check_Overlapping_of_TheSeats())
                {

                    message += "Each seat should be in just one Seat type.";
                }
            }

            if (message == "")
            {
                if (!(CheckPrices()))
                {

                    message += "Business class is more expensive than EconomyPlus and Economy Plus is more expensive than Economy.";
                }
            }

            if (message=="")
            {
                Flight flight;
                BA_Flight BAFlight = new BA_Flight();
                string Query = " FlightNumber='" + txtFlightNumber.Text + "'";
                flight = BAFlight.SearchFlight( Query);
                if (flight!=null)
                {
                    message += "this flight is added before ";
                }
            }
            
            return message;
        }

       private string  Is_All_Information_Filled(string message)
        {
            
            if (txtFlightNumber.Text == "" ||cmbHour.SelectedIndex==-1||cmbMinute.SelectedIndex==-1 || txtDestination.Text == "" ||txtArrival.Text==""||
                cmbCarrier.SelectedIndex==-1)
            {
                message += "All information should be filled.";
            }
            if ((!chkBusiness.Checked)&&(!chkEconomy.Checked)&&(!chkEconomyPlus.Checked))
            {
                message += "You should choose at least one of this seat classes.";
            }
            if (chkBusiness.Checked)
            {
                if (txtStartBusiness.Text==""||txtEndBusiness.Text==""||txtPriceBusiness.Text=="")
                {
                    message += "You should fill all the information of the BusinessClas.";
                }
            }
            if (chkEconomy.Checked)
            {
                if (txtStartEconomy.Text == "" || txtEndEconomy.Text == "" || txtPriceEconomy.Text == "")
                {
                    message += "You should fill all the information of the Economy Clas.";
                }
            }
            if (chkEconomyPlus.Checked)
            {
                if (txtStartEconomyPlus.Text == "" || txtEndEconomyPlus.Text == "" || txtPriceEconomyPlus.Text == "")
                {
                    message += "You should fill all the information of the Economy Plus Clas.";
                }
            }

            return message;
        }

        private string Check_TextboxesInformation_Validity(string message)
        {
            try
            {
                int x = Convert.ToInt32(txtArrival.Text);
                message += "Please fill the arrival with valid informations";
            }
            catch (Exception)
            {
                
            }

            try
            {
                int x = Convert.ToInt32(txtDestination.Text);
                message += "Please fill the Destination with valid informations";
            }
            catch (Exception)
            {

            }
            bool flag = true;
            if (chkBusiness.Checked)
            {
                
                try
                {
                    int x = Convert.ToInt32(txtStartBusiness.Text);
                    x= Convert.ToInt32(txtEndBusiness.Text);
                    float y = float.Parse(txtPriceBusiness.Text);
                    
                }
                catch (Exception)
                {
                    flag = false;
                }
            }

            if (chkEconomy.Checked &&flag)
            {
                
                try
                {
                    int x = Convert.ToInt32(txtStartEconomy.Text);
                    x = Convert.ToInt32(txtEndEconomy.Text);
                    float y = float.Parse(txtPriceEconomy.Text);

                }
                catch (Exception)
                {
                    flag = false;
                }
            }

            if (chkEconomyPlus.Checked && flag)
            {

                try
                {
                    int x = Convert.ToInt32(txtStartEconomyPlus.Text);
                    x = Convert.ToInt32(txtEndEconomyPlus.Text);
                    float y = float.Parse(txtPriceEconomyPlus.Text);

                }
                catch (Exception)
                {
                    flag = false;
                }
            }

            if (!flag)
            {
                message += "start seat and End seat should be integer and price should be float.";
            }

            return message;
        }

        private bool Check_Overlapping_of_TheSeats()
        {
            bool result = false;

            if (chkEconomy.Checked && chkEconomyPlus.Checked)
            {
                if(!((int.Parse(txtStartEconomy.Text) < int.Parse(txtStartEconomyPlus.Text) && int.Parse(txtEndEconomy.Text) < int.Parse(txtStartEconomyPlus.Text)) ||
                    int.Parse(txtStartEconomyPlus.Text) < int.Parse(txtStartEconomy.Text) && int.Parse(txtEndEconomyPlus.Text) < int.Parse(txtStartEconomy.Text)))
                    {
                       result = false;
                    }
            }

            if (chkEconomyPlus.Checked && chkBusiness.Checked)
            {
                if (!((int.Parse(txtStartEconomyPlus.Text) < int.Parse(txtStartBusiness.Text) && int.Parse(txtEndEconomyPlus.Text) < int.Parse(txtStartBusiness.Text)) ||
                    int.Parse(txtStartBusiness.Text) < int.Parse(txtStartEconomyPlus.Text) && int.Parse(txtEndBusiness.Text) < int.Parse(txtStartEconomyPlus.Text)))
                {
                    result = false;
                }
            }

            if (chkEconomy.Checked && chkBusiness.Checked)
            {
                if (!((int.Parse(txtStartEconomy.Text) < int.Parse(txtStartBusiness.Text) && int.Parse(txtEndEconomy.Text) < int.Parse(txtStartBusiness.Text)) ||
                    int.Parse(txtStartBusiness.Text) < int.Parse(txtStartEconomy.Text) && int.Parse(txtEndBusiness.Text) < int.Parse(txtStartEconomy.Text)))
                {
                    result = false;
                }
            }

            return result;
        }

        private bool CheckPrices()
        {
            bool result = true;

            if (chkEconomy.Checked && chkEconomyPlus.Checked)
            {
                if (!(float.Parse(txtPriceEconomy.Text) < int.Parse(txtPriceEconomyPlus.Text) ))
                {
                    result = false;
                }
            }

            if (chkEconomyPlus.Checked && chkBusiness.Checked)
            {
                if (!(float.Parse(txtPriceEconomyPlus.Text) < int.Parse(txtPriceBusiness.Text)))
                {
                    result = false;
                }
            }

            if (chkEconomy.Checked && chkEconomyPlus.Checked)
            {
                if (!(float.Parse(txtPriceEconomy.Text) < int.Parse(txtPriceEconomyPlus.Text)))
                {
                    result = false;
                }
            }

            return result;
        }

        private void frmAddFlight_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;

            BACarrier BACarrier = new BACarrier();
            List<Carrier> carriers = new List<Carrier>();
            carriers= BACarrier.GetAllCarriers();
            for (int i = 0; i < carriers.Count; i++)
            {
               cmbCarrier.Items.Add(carriers[i].Name);
            
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtArrival.Text = txtDestination.Text = txtEndBusiness.Text = txtEndEconomy.Text = txtEndEconomyPlus.Text = "";
            txtFlightNumber.Text = txtPriceBusiness.Text = txtPriceEconomy.Text = txtPriceEconomyPlus.Text = txtStartBusiness.Text = "";
            txtStartEconomy.Text = txtStartEconomyPlus.Text = "";
            
        }
    }
}
