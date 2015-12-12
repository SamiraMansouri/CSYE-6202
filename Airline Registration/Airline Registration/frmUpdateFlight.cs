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
    public partial class frmUpdateFlight : Form
    {

        List<Flight> flights;
        Flight flight;
        bool DateChanged = false;
        public frmUpdateFlight()
        {
            InitializeComponent();
        }

        private void frmUpdateFlight_Load(object sender, EventArgs e)
        {

            InitializeFlightssDataGridView();
        }

        private void InitializeFlightssDataGridView()
        {
            BA_Flight BAFlight = new BA_Flight();
            flights = BAFlight.getAllInforofAllFlight();

            dgvFlights.Columns.Add("FlightNumber", "Flight Number");
            dgvFlights.Columns.Add("Date", "Date");
            dgvFlights.Columns.Add("Time", "Time");
            dgvFlights.Columns.Add("Destination", "Destination");
            dgvFlights.Columns.Add("Arrival", "Arrival");
            dgvFlights.Columns.Add("carrierName", "Carrier Name");
            dgvFlights.Columns.Add("Economy", "Economy");
            dgvFlights.Columns.Add("Price", "Price");
            dgvFlights.Columns.Add("starEndSeat", "Start seat-End Seat");
            dgvFlights.Columns.Add("EconomyPlus", "EconomyPlus");
            dgvFlights.Columns.Add("Price2", "Price");
            dgvFlights.Columns.Add("starEndSeat2", "Start seat-End Seat");
            dgvFlights.Columns.Add("Business", "Business");
            dgvFlights.Columns.Add("Price3", "Price");
            dgvFlights.Columns.Add("starEndSeat3", "Start seat-End Seat");

            int j = 0;
            for (int i = 0; i < flights.Count; i++)
            {
                dgvFlights.Rows.Add();
                dgvFlights.Rows[i].Cells[0].Value = flights[i].FlightNumber;
                dgvFlights.Rows[i].Cells[1].Value = flights[i].Date.Date;
                dgvFlights.Rows[i].Cells[2].Value = flights[i].Time;
                dgvFlights.Rows[i].Cells[3].Value = flights[i].Destination;
                dgvFlights.Rows[i].Cells[4].Value = flights[i].Arrival;
                dgvFlights.Rows[i].Cells[5].Value = flights[i].CarrierName;
                j = 0;
                foreach (SeatType seatType in flights[i].GetSeatTypelList())
                {
                    dgvFlights.Rows[i].Cells[6 + j].Value = seatType.Type;
                    dgvFlights.Rows[i].Cells[7 + j].Value = seatType.Price;
                    dgvFlights.Rows[i].Cells[8 + j].Value = seatType.StartSeat + "-" + seatType.EndSeat;
                    j += 3;
                }
            }


        }

        private void dgvFlights_SelectionChanged(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dgvFlights.SelectedRows)
            {
                txtFlightNumber.Text = row.Cells[0].Value.ToString();
                txtCarrier.Text = row.Cells[5].Value.ToString();
                txtDestination.Text = row.Cells[3].Value.ToString();
                txtArrival.Text = row.Cells[4].Value.ToString();
                

                    dateTimePicker1.Value = Convert.ToDateTime(row.Cells[1].Value);
               

                string Hour ;
                Hour = row.Cells[1].Value.ToString()[0].ToString();
                Hour += row.Cells[1].Value.ToString()[1].ToString();
                cmbHour.SelectedItem = Hour;

                string Minute;
                Minute = row.Cells[1].Value.ToString()[3].ToString();
                Minute += row.Cells[1].Value.ToString()[4].ToString();
                cmbMinute.SelectedItem = Minute;
                string SeatType = "";
                try
                {
                    SeatType = row.Cells[6].Value.ToString();
                }
                catch (Exception)
                {
                    SeatType = "";
                }
                if (SeatType=="Economy")
                {
                    chkEconomy.Checked=true ;
                    int SeperatorIndex = sep(row.Cells[8].Value.ToString());
                    string Time = row.Cells[8].Value.ToString();
                    txtStartEconomy.Text = Time.Substring(0,SeperatorIndex);
                    txtEndEconomy.Text = Time.Substring(SeperatorIndex + 1);
                    txtPriceEconomy.Text = row.Cells[7].Value.ToString();
                }

                try
                {
                    SeatType = row.Cells[9].Value.ToString();
                }
                catch (Exception)
                {
                    SeatType = "";
                }
                if (SeatType =="Economy Plus")
                {
                    chkEconomyPlus.Checked = true;
                    int SeperatorIndex = sep(row.Cells[11].Value.ToString());
                    string Time = row.Cells[11].Value.ToString();
                    txtStartEconomyPlus.Text = Time.Substring(0, SeperatorIndex);
                    txtEndEconomyPlus.Text = Time.Substring(SeperatorIndex + 1);
                    txtPriceEconomyPlus.Text = row.Cells[10].Value.ToString();
                }

                try
                {
                    SeatType = row.Cells[12].Value.ToString();
                }
                catch (Exception)
                {
                    SeatType = "";
                }
                if ( SeatType== "Business")
                {
                    chkBusiness.Checked = true;
                    int SeperatorIndex = sep(row.Cells[14].Value.ToString());
                    string Time = row.Cells[14].Value.ToString();
                    txtStartBusiness.Text = Time.Substring(0, SeperatorIndex);
                    txtEndBusiness.Text = Time.Substring(SeperatorIndex + 1);
                    txtPriceBusiness.Text = row.Cells[13].Value.ToString();
                }
            }


        }

        public  int sep(string s)
        {
            int l = s.IndexOf("-");
            return l;

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BA_Flight BAFlight = new BA_Flight();
            bool flag = true;
            if (txtFlightNumber.Text==null||txtFlightNumber.Text==""||txtFlightNumber.Text.Trim()=="")
            {
                flag = false;
                MessageBox.Show("For deleting Flight Number should be filled.");
            }
            if ((cmbHour.SelectedIndex==-1 && cmbMinute.SelectedIndex!=-1)|| (cmbHour.SelectedIndex != -1 && cmbMinute.SelectedIndex == -1))
            {
                flag = false;
                MessageBox.Show("Please either fill both hour and minute or fill none of them.");

            }

            BA_Seat BASeat=new BA_Seat();
            string Query = "FlightNumber='" + txtFlightNumber.Text + "'";
            
            List<Seat> seats=BASeat.SearchSeat(Query);

            if (seats.Count>0)
            {
                flag = false;
                MessageBox.Show("You cannot delete this flight because thiket/s are bought from this flight.If you want to do you should unbooking tickets and then delete this.");
            }

            if (flag)
            {
                
                Flight flight= BAFlight.SearchFlight(Query);
                if (BAFlight==null )
                {
                    MessageBox.Show("Flight with this FlightNumber,CarrierName,Destination,Arrival,and date does not exist.");
                 }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this flight?", "Remove Flight", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (BAFlight.DeleteFlight(txtFlightNumber.Text)==0)
                        {
                            MessageBox.Show("The flight is deleted successfully.");
                            InitializeFlightssDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Exuse me,some problem occured during connection to database.please try again.");
                        }
                    }
                }
            }
               
        }

        private string  GenerateQuery()
        {
            string query = "";
            if (txtFlightNumber.Text!=""||txtFlightNumber.Text.Trim()!="")
            {
                query = "FlightNumber='" + txtFlightNumber.Text + "'";
            }

            if (txtCarrier.Text != "" || txtCarrier.Text.Trim() != "")
            {
                BACarrier BACarrier = new BACarrier();
                Carrier carrier;
                int CarrierID;
                carrier = BACarrier.SearchCarrier(" Name='" + flight.CarrierName + "'");
                CarrierID = carrier.ID;
                if (query=="")
                {
                    query = "CarrierID=" + CarrierID;
                }
                else
                {
                    query =query+ "and CarrierID=" + CarrierID;
                }
               
            }

            if (txtDestination.Text != "" || txtDestination.Text.Trim() != "")
            {
                
                if (query == "")
                {
                    query = "Destination='" + txtDestination.Text + "'";
                }
                else
                {
                    query = query + "and Destination='" + txtDestination.Text + "'";
                }
            }

            if (txtArrival.Text != "" || txtArrival.Text.Trim() != "")
            {

                if (query == "")
                {
                    query = "Arrival='" + txtArrival.Text + "'";
                }
                else
                {
                    query = query + "and Arrival='" + txtArrival.Text + "'";
                }
            }

            if (DateChanged)
            {

                if (query == "")
                {
                    query = "Date='" +dateTimePicker1.Value+ "'";
                }
                else
                {
                    query = query + "and Date='" + dateTimePicker1.Value + "'";
                }
            }

            if (cmbHour.SelectedIndex!=-1&&cmbMinute.SelectedIndex!=-1)
            {
                TimeSpan time = new TimeSpan(cmbHour.SelectedIndex + 1, cmbMinute.SelectedIndex + 1, 0);
                if (query == "")
                {
                    query = "Time='" + time + "'";
                }
                else
                {
                    query = query + "and Time='" + time+ "'";
                }
            }


            return query;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateChanged = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
         
            string message = "";
            message += CheckDataValidity();
            if (message == "")
            {
                message += UpdateSeatType();
            }

            if (message=="")
            {
                    
                    BA_Flight BAFlight = new BA_Flight();
                    int result = BAFlight.UpdateFlight(flight);
                    if (result == -1)
                    {
                        message += "Please try again.";
                    }

                    else
                    {

                        message += "Flight is Updated Successfully.";
                    }
                
             
            }
            MessageBox.Show(message);
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

                if (((chkBusiness.Checked) && (Convert.ToInt32(txtStartBusiness.Text) > Convert.ToInt32(txtEndBusiness.Text))) ||
                    ((chkEconomy.Checked) && (Convert.ToInt32(txtStartEconomy.Text) > Convert.ToInt32(txtEndEconomy.Text))) ||
                        ((chkEconomyPlus.Checked) && Convert.ToInt32(txtEndEconomyPlus.Text) > Convert.ToInt32(txtEndEconomyPlus.Text)))
                {
                    message += "End seat should be greater than the start seat";
                }

                if (((chkBusiness.Checked) && ((float.Parse(txtPriceBusiness.Text)) <= 0)) || ((chkEconomy.Checked) && ((float.Parse(txtPriceEconomy.Text) <= 0)))
                    || ((chkEconomyPlus.Checked) && ((float.Parse(txtPriceEconomyPlus.Text) <= 0))))
                {
                    message += "Price should be greater than ziro";
                }
            }

            if (message == "")
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

            if (message == "")
            {
                
                BA_Flight BAFlight = new BA_Flight();
                string Query = " FlightNumber='" + txtFlightNumber.Text + "'";
                flight = BAFlight.SearchFlight(Query);
                if (flight == null)
                {
                    message += "this flight does not exist ";
                }
                else
                {
                    flight = BAFlight.GetFlightInformation(flight);
                }
            }

            return message;
        }

        private string Is_All_Information_Filled(string message)
        {

            if (txtFlightNumber.Text == "" || cmbHour.SelectedIndex == -1 || cmbMinute.SelectedIndex == -1 || txtDestination.Text == "" || txtArrival.Text == "" ||
                txtCarrier.Text == "")
            {
                message += "All information should be filled.";
            }
            if ((!chkBusiness.Checked) && (!chkEconomy.Checked) && (!chkEconomyPlus.Checked))
            {
                message += "You should choose at least one of this seat classes.";
            }
            if (chkBusiness.Checked)
            {
                if (txtStartBusiness.Text == "" || txtEndBusiness.Text == "" || txtPriceBusiness.Text == "")
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
                    x = Convert.ToInt32(txtEndBusiness.Text);
                    float y = float.Parse(txtPriceBusiness.Text);

                }
                catch (Exception)
                {
                    flag = false;
                }
            }

            if (chkEconomy.Checked && flag)
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
            bool result = true;

            if (chkEconomy.Checked && chkEconomyPlus.Checked)
            {
                if (((int.Parse(txtStartEconomy.Text) < int.Parse(txtStartEconomyPlus.Text) && int.Parse(txtEndEconomy.Text) < int.Parse(txtStartEconomyPlus.Text)) ||
                  ( ( int.Parse(txtStartEconomyPlus.Text) < int.Parse(txtStartEconomy.Text) && int.Parse(txtEndEconomyPlus.Text) < int.Parse(txtStartEconomy.Text)))))
                {
                    result = false;
                }
            }

            if (chkEconomyPlus.Checked && chkBusiness.Checked)
            {
                if (((int.Parse(txtStartEconomyPlus.Text) < int.Parse(txtStartBusiness.Text) && int.Parse(txtEndEconomyPlus.Text) < int.Parse(txtStartBusiness.Text)) ||
                   (( int.Parse(txtStartBusiness.Text) < int.Parse(txtStartEconomyPlus.Text) && int.Parse(txtEndBusiness.Text) < int.Parse(txtStartEconomyPlus.Text)))))
                {
                    result = false;
                }
            }

            if (chkEconomy.Checked && chkBusiness.Checked)
            {
                
                if (((int.Parse(txtStartEconomy.Text) < int.Parse(txtStartBusiness.Text) && int.Parse(txtEndEconomy.Text) < int.Parse(txtStartBusiness.Text)) ||
                   (( int.Parse(txtStartBusiness.Text) < int.Parse(txtStartEconomy.Text) && int.Parse(txtEndBusiness.Text) < int.Parse(txtStartEconomy.Text)))))
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
                if (!(float.Parse(txtPriceEconomy.Text) < int.Parse(txtPriceEconomyPlus.Text)))
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

        private string  UpdateSeatType()
        {
            string message = "";
            List<SeatType> seatTypes = MakeNewList();

            #region Business

            if (chkBusiness.Checked)
            {
                bool flag = false;
                foreach (SeatType seatType in seatTypes)
                {
                    if (seatType.Type == "Business")
                    {
                        flag = true;
                        bool temp = flight.Is_there_any_seat_with_this_SeatType(seatType, Convert.ToInt32(txtStartBusiness.Text), Convert.ToInt32(txtEndBusiness.Text));
                        if (temp)
                        {
                            message += "With this range that you consider for Business class some tickets should be changed please try again.";
                            }

                        else
                        {
                            flight.UpdateItemInSeatTypeList(seatType, Convert.ToInt32(txtStartBusiness.Text), Convert.ToInt32(txtEndBusiness.Text), float.Parse(txtPriceBusiness.Text));
                        }
                    }
                }
                if (!flag)
                {
                    flight.AddSeatType("Business", Convert.ToInt32(txtPriceBusiness.Text), Convert.ToInt32(txtStartBusiness.Text),
                                       Convert.ToInt32(txtEndBusiness.Text));
                }

            }

            else
            {
                flight.RemoveSeatType("Business");
            }
            #endregion

            #region Economy
            if (chkEconomy.Checked)
            {
                bool flag = false;
                
                foreach (SeatType seatType in seatTypes )
                {
                    if (seatType.Type == "Economy")
                    {
                        flag = true;

                        bool temp;
                        temp= flight.Is_there_any_seat_with_this_SeatType(seatType, Convert.ToInt32(txtStartEconomy.Text), Convert.ToInt32(txtEndEconomy.Text));
                        if (temp)
                        {
                            message += "With this range that you consider for Economy class some tickets should be changed please try again.";
                            }

                        else
                        {
                            flight.UpdateItemInSeatTypeList(seatType, Convert.ToInt32(txtStartEconomy.Text), Convert.ToInt32(txtEndEconomy.Text), float.Parse(txtPriceEconomy.Text));
                        }
                    }
                }
                if (!flag)
                {
                    flight.AddSeatType("Economy", Convert.ToInt32(txtPriceEconomy.Text), Convert.ToInt32(txtStartEconomy.Text),
                                       Convert.ToInt32(txtEndEconomy.Text));
                }

            }

            else
            {
                flight.RemoveSeatType("Economy");
            }
            #endregion

            #region EconomyPlus
            if (chkEconomyPlus.Checked)
            {
                bool flag = false;
                foreach (SeatType seatType in seatTypes)
                {
                    if (seatType.Type == "Economy Plus")
                    {
                        flag = true;
                        bool temp = flight.Is_there_any_seat_with_this_SeatType(seatType, Convert.ToInt32(txtStartEconomyPlus.Text), Convert.ToInt32(txtEndEconomyPlus.Text));
                        if (temp)
                        {
                            message += "With this range that you consider for Business class some tickets should be changed please try again.";
                            }

                        else
                        {
                            flight.UpdateItemInSeatTypeList(seatType, Convert.ToInt32(txtStartEconomyPlus.Text), Convert.ToInt32(txtEndEconomyPlus.Text), float.Parse(txtPriceEconomyPlus.Text));
                        }
                    }
                }
                if (!flag)
                {
                    flight.AddSeatType("Economy Plus", Convert.ToInt32(txtPriceEconomyPlus.Text), Convert.ToInt32(txtStartEconomyPlus.Text),
                                       Convert.ToInt32(txtEndEconomyPlus.Text));
                }

            }

            else
            {
                flight.RemoveSeatType("Economy Plus");
            }
            #endregion

            foreach (SeatType seatType in seatTypes)
            {
                if (seatType.Type=="Business"&&!chkBusiness.Checked)
                {
                    flight.RemoveSeatType("Business");
                }

                if (seatType.Type == "Economy" && !chkEconomy.Checked)
                {
                    flight.RemoveSeatType("Economy");
                }

                if (seatType.Type == "Economy Plus" && !chkEconomyPlus.Checked)
                {
                    flight.RemoveSeatType("Economy Plus");
                }
            }

            return message;
        }

        private List<SeatType> MakeNewList()
        {
            List<SeatType> SeatTypes=new List<SeatType>();
            SeatType seatType;
            foreach (SeatType ST in flight.GetSeatTypelList())
            {
                seatType = new SeatType(ST.ID, ST.Type, ST.Price, ST.FlightNumber, ST.StartSeat, ST.EndSeat);

                SeatTypes.Add(seatType);
            }

            return SeatTypes;
        }
       
        private void txtFlightNumber_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
