using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Registration
{
    public partial class frmMainWindow : Form
    {
        string DataAccess = "Regular";

        public frmMainWindow()
        {
            InitializeComponent();
        }

        public frmMainWindow(string DA)
        {
            InitializeComponent();
            DataAccess = DA;
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            if (DataAccess=="Regular")
            {
                
                    AddFlight.Visible = false;
                    UpdateFlight.Visible = false;
                    flightCarrierToolStripMenuItem.Visible = false;
                    flightCrewToolStripMenuItem.Visible = false;
               
            }
           
        }

        private void flightCarrierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        

        private void showAllFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllFlightInformation frmAllflightsInfo = new frmAllFlightInformation();
            frmAllflightsInfo.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddFlight_Click(object sender, EventArgs e)
        {
            frmAddFlight frmAddflight = new frmAddFlight();
            frmAddflight.Show();
        }

        private void UpdateFlight_Click(object sender, EventArgs e)
        {
            frmUpdateFlight frmUPDflight = new frmUpdateFlight();
            frmUPDflight.Show();
        }

        private void addFlightCarrierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddFlightCarrier frmAddflightcarrier = new frmAddFlightCarrier();
            frmAddflightcarrier.Show();
        }

        private void editFlightCarrierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateFlightCarrier frmUPDflightcarrier = new frmUpdateFlightCarrier();
            frmUPDflightcarrier.Show();
        }

        private void addFlightCrewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddFlightCrew frmAddflightcrew = new frmAddFlightCrew();
            frmAddflightcrew.Show();
        }

        private void updateFlightCrewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateCrew frmUPDCrew = new frmUpdateCrew();
            frmUPDCrew.Show();
        }

        private void bookingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBookingFlight frmBooking = new frmBookingFlight();
            frmBooking.Show();
        }

        private void updateBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnbookingFlight frmUnbooking = new frmUnbookingFlight();
            frmUnbooking.Show();
        }
    }
}
