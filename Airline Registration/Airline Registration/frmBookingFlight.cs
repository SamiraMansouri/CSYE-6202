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
    public partial class frmBookingFlight : Form
    {

        List<Flight> flights;
        List<customer> customers;

        public frmBookingFlight()
        {
            InitializeComponent();
        }

        private void frmBookingFlight_Load(object sender, EventArgs e)
        {
            InitializeCustomersDataGridView();
            InitializeFlightssDataGridView();
        }

        private void InitializeCustomersDataGridView()
        {
            BA_Customer BACustomer = new BA_Customer();
            
            customers = BACustomer.GetAllCustomer();
            dgvPassengers.DataSource = customers;
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
            dgvFlights.Columns.Add("seatType1", "Seat Type");
            dgvFlights.Columns.Add("Price", "Price");
            dgvFlights.Columns.Add("starEndSeat", "Start seat-End Seat");
            dgvFlights.Columns.Add("SeatType2", "Seat Type");
            dgvFlights.Columns.Add("Price2", "Price");
            dgvFlights.Columns.Add("starEndSeat2", "Start seat-End Seat");
            dgvFlights.Columns.Add("SeatType3", "Seat Type");
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
                    dgvFlights.Rows[i].Cells[6+j].Value = seatType.Type;
                    dgvFlights.Rows[i].Cells[7+j].Value = seatType.Price;
                    dgvFlights.Rows[i].Cells[8+j].Value = seatType.StartSeat + "-" + seatType.EndSeat;
                    j+=3;
                }
            }
               
          
        }

        private void dgvFlights_SelectionChanged(object sender, EventArgs e)
        {
            this.cmbSeatNumber.Items.Clear();
            this.cmbSeatTypes.Items.Clear();

            foreach (DataGridViewRow row in dgvFlights.SelectedRows)
            {
                txtFlightID.Text = row.Cells[0].Value.ToString();

                
                foreach (Flight _flight in flights)
                {
                    if (_flight.FlightNumber == row.Cells[0].Value.ToString())
                    {
                        foreach (SeatType seatType in _flight.GetSeatTypelList())
                        {
                            cmbSeatTypes.Items.Add(seatType.Type);

                        }
                        break;
                    }
                }
            }

           
        }

        private void dgvPassengers_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPassengers.SelectedRows)
            {
                txtPassengerID.Text = row.Cells[2].Value.ToString();

            }
        }

        private void cmbSeatTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Flight _flight in flights)
            {
                if (_flight.FlightNumber == txtFlightID.Text)
                {
                    foreach (SeatType seatType in _flight.GetSeatTypelList())
                    {
                        if (seatType.Type==cmbSeatTypes.SelectedItem.ToString())
                        {
                            for (int i = seatType.StartSeat; i <=seatType.EndSeat; i++)
                            {
                                if (!_flight.Check_ThisSea_Is_Book_Before_OrNot(i))
                                {
                                    cmbSeatNumber.Items.Add(i.ToString());
                                }
                                
                            }


                            txtPrice.Text = seatType.Price.ToString();
                        }
                    }

                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string message = ChechValidityofBooking();
            if (message=="")
            {
                Flight flight=null;
                foreach (Flight _flight in flights)
                {
                    if(_flight.FlightNumber==txtFlightID.Text)
                    {
                        flight = _flight;
                        break;
                    }
                }

                Seat seat = new Seat(txtFlightID.Text,Convert.ToInt32( txtPassengerID.Text), flight.FindSeatTypeID(cmbSeatTypes.Text),
                                        Convert.ToInt32(cmbSeatNumber.Text), float.Parse(txtPrice.Text));

                flight.AddSeat(Convert.ToInt32(txtPassengerID.Text), flight.FindSeatTypeID(cmbSeatTypes.Text),
                                        Convert.ToInt32(cmbSeatNumber.Text), float.Parse(txtPrice.Text));
                BA_Seat BASeat = new BA_Seat();
                
                if (BASeat.AddSeat(seat)==0)
                {
                    message = "You booking is done successfully";
                }
                else
                {
                    message = "Something wrong is happened during booking,please try again";
                }
                
            }

            toolStripStatusLabel1.Text = message;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string ChechValidityofBooking()
        {
            string message = "";

            if (txtFlightID.Text.Trim() == "" || txtFlightID.Text == "" || txtFlightID.Text == null
               || txtPassengerID.Text.Trim() == "" || txtPassengerID.Text == "" || txtPassengerID.Text == null
               || cmbSeatNumber.SelectedIndex == -1 || cmbSeatTypes.SelectedIndex == -1 ||
               txtPrice.Text.Trim() == "" || txtPrice.Text == "" || txtPrice.Text == null
               )
            {
                message = "please fill all the information";
            }

            foreach (Flight flight in flights)
            {
                if (flight.FlightNumber==txtFlightID.Text)
                {
                    foreach (Seat seat in flight.GetSeatlList())
                    {
                        if (seat.CustomerID.ToString()==txtPassengerID.Text)
                        {
                            message = "This customer has booked a seat before and its seatNumber is "+seat.SeatNumber;
                        }
                    }
                }
            }
            return message;
        }
    }
}
