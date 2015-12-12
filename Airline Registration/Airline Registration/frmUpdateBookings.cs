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
    public partial class frmUnbookingFlight : Form
    {

        List<Flight> flights;
        public frmUnbookingFlight()
        {
            InitializeComponent();
        }

        private void frmUnbookingFlight_Load(object sender, EventArgs e)
        {
            InitializeFlightDataGridView();
        }

        private void InitializeFlightDataGridView()
        {
            BA_Flight BAFlight = new BA_Flight();
            flights = BAFlight.getAllInforofAllFlight();

            dgvFlights.Columns.Add("FlightNumber", "Flight Number");
            dgvFlights.Columns.Add("CustomerID", "Cusromer ID");
            dgvFlights.Columns.Add("Date", "Date");
            dgvFlights.Columns.Add("Time", "Time");
            dgvFlights.Columns.Add("Destination", "Destination");
            dgvFlights.Columns.Add("Arrival", "Arrival");
            dgvFlights.Columns.Add("carrierName", "Carrier Name");
            dgvFlights.Columns.Add("seatType1", "Seat Type");
            dgvFlights.Columns.Add("SeatNumber", "Seat Number");
            dgvFlights.Columns.Add("Paid", "Paid");

            int j = 0;
            for (int i = 0; i < flights.Count; i++)
            {
                foreach (Seat seat in flights[i].GetSeatlList())
                {
                    dgvFlights.Rows.Add();
                    dgvFlights.Rows[j].Cells[0].Value = flights[i].FlightNumber;
                    dgvFlights.Rows[j].Cells[1].Value = seat.CustomerID;
                    dgvFlights.Rows[j].Cells[2].Value = flights[i].Date.ToShortDateString();
                    dgvFlights.Rows[j].Cells[3].Value = flights[i].Time;
                    dgvFlights.Rows[j].Cells[4].Value = flights[i].Destination;
                    dgvFlights.Rows[j].Cells[5].Value = flights[i].Arrival;
                    dgvFlights.Rows[j].Cells[6].Value = flights[i].CarrierName;
                    dgvFlights.Rows[j].Cells[7].Value = flights[i].FindSeatTypeName(seat.SeatTypeID);
                    dgvFlights.Rows[j].Cells[8].Value = seat.SeatNumber;
                    dgvFlights.Rows[j].Cells[9].Value = seat.CustomerPaid;
                    j++;
                }
            }
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this carrie?", "Remove Carrier", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dgvFlights.Refresh();

                DeleteBooking();

                foreach (DataGridViewRow item in this.dgvFlights.SelectedRows)
                {
                    if (txtFlightNumber.Text == dgvFlights.SelectedRows[0].Cells[0].ToString() && txtPassengerID.Text == dgvFlights.SelectedRows[0].Cells[1].ToString())
                    {
                        dgvFlights.Rows.RemoveAt(item.Index);
                    }
                }

                InitializeFlightDataGridView();
            }
        }


        private void DeleteBooking()
        {
            string message = "";
            BA_Seat BASeat = new BA_Seat();
            if (txtFlightNumber.Text.Trim() == "" || txtFlightNumber.Text == "" || txtFlightNumber.Text == null
               || txtPassengerID.Text.Trim() == "" || txtPassengerID.Text == "" || txtPassengerID.Text == null)
            {

                message = "Please Fill CustomerID and FlightNumber.";

            }

            else
            {
                Seat seat = DeleteFlightFromList();
                if (seat == null)
                {
                    message = "This Customer with this Flight Number does not exist.";
                }

                else
                {
                    if (BASeat.DeleteSeat(seat))
                    {
                        message = "this unbooking is done successfully";
                    }

                    else
                    {
                        message = "Something wrong is happened during unbooking,please try again";
                    }
                }

            }

            toolStripStatusLabel1.Text = message;
        }

        private Seat DeleteFlightFromList()
        {
            Seat _seat=null;
            Flight flight = null;
            foreach (Flight _flight in flights)
            {
                if (_flight.FlightNumber == txtFlightNumber.Text)
                {
                    flight = _flight;
                    break;
                }
            }

                foreach (Seat seat in flight.GetSeatlList())
                {
                    if (seat.CustomerID.ToString() == txtPassengerID.Text && seat.FlightNumber == txtFlightNumber.Text)
                    {
                        _seat = seat;
                        flight.RemoveSeatFromList(seat);
                        break;
                    }
                }
           

            return _seat;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFlights_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvFlights.SelectedRows)
            {
                txtFlightNumber.Text= row.Cells[0].Value.ToString();
                txtPassengerID.Text = row.Cells[1].Value.ToString();
                txtSeatNumber.Text = row.Cells[8].Value.ToString();
                try
                {

                    txtSeatType.Text = row.Cells[7].Value.ToString();
                }
                catch (Exception ex)
                {

                    txtSeatType.Text="";
                }
            }
        }
    }
}
