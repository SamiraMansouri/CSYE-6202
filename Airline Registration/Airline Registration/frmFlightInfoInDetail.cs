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
    public partial class frmFlightInfoInDetail : Form
    {

        Flight flight;
        public frmFlightInfoInDetail()
        {
            InitializeComponent();
        }

        internal frmFlightInfoInDetail(Flight _flight)
        {
            InitializeComponent();
            flight = _flight;
        }

        private void frmFlightInfoInDetail_Load(object sender, EventArgs e)
        {
            BACarrier BAcarrier = new BACarrier();
            txtArrival.Text = flight.Arrival;
            txtDate.Text = (flight.Date.ToShortDateString());
            txtFlightNumber.Text = flight.FlightNumber;
            txtDestination.Text = flight.Destination;
            txtTime.Text = flight.Time.ToString();
            BA_Flight BAFlight = new BA_Flight();
            flight=BAFlight.GetFlightInformation(flight);

            Carrier carrier;
            carrier = BAcarrier.SearchCarrier(" Name='"+flight .CarrierName+"'");
            dgvCarrierInfo.Columns.Add("Name", "Name");
            dgvCarrierInfo.Columns.Add("Origion", "Origion");
            dgvCarrierInfo.Columns.Add("Website", "Website");
            dgvCarrierInfo.Columns.Add("CustomerPhone", "Phone");
            dgvCarrierInfo.Columns.Add("CustomerAddress", "Address");
            dgvCarrierInfo.Rows[0].Cells[0].Value = carrier.Name;
            dgvCarrierInfo.Rows[0].Cells[1].Value = carrier.Origion;
            dgvCarrierInfo.Rows[0].Cells[2].Value = carrier.WebSite;
            dgvCarrierInfo.Rows[0].Cells[3].Value = carrier.Phone;
            dgvCarrierInfo.Rows[0].Cells[4].Value = carrier.Address;


            dgvSeats.DataSource = flight.GetSeatTypelList();

            dgvCrews.DataSource = flight.GetCrewlList();

           
            List<customer> Customers;
            BA_Customer BACustomer = new BA_Customer();
            Customers = BACustomer.GetFlightCustomers(flight.FlightNumber);

            dgvPassengers.Columns.Add("PassengerID", "Passenger ID");
            dgvPassengers.Columns.Add("FirstName", "First Name");
            dgvPassengers.Columns.Add("LastName", "Last Name");
            dgvPassengers.Columns.Add("Phone", "Phone");
            dgvPassengers.Columns.Add("Address", "Address");
            dgvPassengers.Columns.Add("Birthdate", "Birthdate");
            dgvPassengers.Columns.Add("seatType1", "Seat Type");
            dgvPassengers.Columns.Add("SeatNumber", "Seat Number");
            dgvPassengers.Columns.Add("CustomerPaid", "Paid");

            int j = 0;
            for (int i = 0; i < Customers.Count; i++)
            {
                dgvPassengers.Rows.Add();
                dgvPassengers.Rows[i].Cells[0].Value = Customers[i].ID;
                dgvPassengers.Rows[i].Cells[1].Value = Customers[i].FirstName;
                dgvPassengers.Rows[i].Cells[2].Value = Customers[i].LastName;
                dgvPassengers.Rows[i].Cells[3].Value = Customers[i].Phone;
                dgvPassengers.Rows[i].Cells[4].Value = Customers[i].Address;
                dgvPassengers.Rows[i].Cells[5].Value = Customers[i].birthdate;

                BA_Seat BASeat = new BA_Seat();
                string Query = "  CustomerID="+Customers[i].ID+" and FlightNumber= '"+ txtFlightNumber.Text+"'";
                Seat seat = BASeat.SearchSeat(Query )[0];
                dgvPassengers.Rows[i].Cells[6 ].Value = flight.FindSeatTypeName(seat.SeatTypeID);
                dgvPassengers.Rows[i].Cells[7].Value = seat.SeatNumber;
                dgvPassengers.Rows[i].Cells[8].Value = seat.CustomerPaid;
            
                
            }

        }
    }
}
