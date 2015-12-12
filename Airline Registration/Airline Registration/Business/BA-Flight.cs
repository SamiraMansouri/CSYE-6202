using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline_Registration.Data_Access;
using Airline_Registration.Casses;
using System.Data;

namespace Airline_Registration.Business
{
    class BA_Flight
    {
        DA_Flight DAFlight = new DA_Flight();

        public List<Flight> GetAllFlightInfo()
        {
            
            DataTable dt = DAFlight.GetAllFlightsInformation();
            List<Flight> Allflights=new List<Flight>();

            Flight flight;
            string FlightNumber;
            DateTime date;
            TimeSpan Time;
            string destination;
            string Arrival;
            string CarrierName;
            
            if (dt.Rows.Count >= 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    FlightNumber = dt.Rows[i]["FlightNumber"].ToString();
                    date =Convert.ToDateTime( dt.Rows[i]["Date"].ToString()).Date;
                    date = date.Date;
                    Time =Convert.ToDateTime( dt.Rows[i]["Time"].ToString()).TimeOfDay;
                    destination = dt.Rows[i]["Destination"].ToString();
                    Arrival= dt.Rows[i]["Arrival"].ToString();

                    CarrierName =Convert.ToString( dt.Rows[i]["Name"]);

                    flight = new Flight(FlightNumber, date, Time, destination, Arrival, CarrierName);
                    
                    Allflights.Add(flight);
                }
            }

            return Allflights;
        }

        public Flight GetFlightInformation(Flight flight)
        {
            try
            {
                DataTable dt;
                //seatType
                dt = DAFlight.GetFlightSeatType(flight.FlightNumber);
                SeatType seatType;
                foreach (DataRow row in dt.Rows)
                {
                    seatType = new SeatType(Convert .ToInt32( row["ID"]), row["Type"].ToString(), float.Parse(row["Price"].ToString()), flight.FlightNumber, Convert.ToInt32(row["StartSeat"]), Convert.ToInt32(row["EndSeat"]));
                    flight.AddSeatTypeToList(seatType);
                }

                //Crew
                dt = DAFlight.GetFlightCrews(flight.FlightNumber);
                Crew crew;
                foreach (DataRow row in dt.Rows)
                {
                    crew = new Crew(row["FirstName"].ToString(), row["LastName"].ToString(), row["EmployeeID"].ToString(), Convert.ToDateTime(row["Birthdate"]).Date,
                                                    row["Phone"].ToString(), row["Address"].ToString(), row["Type"].ToString(), row["Title"].ToString(), flight.FlightNumber);

                    flight.AddCrewToList(crew);
                }

                //seat
                dt = DAFlight.GetFlightSeat(flight.FlightNumber);
                Seat seat;
                float CustomerPaid;
                foreach (DataRow row in dt.Rows)
                {
                    
                    try
                    {
                        CustomerPaid = float.Parse(row["CustomerPaid"].ToString());
                    }
                    catch (Exception)
                    {

                        CustomerPaid = 0;
                    }
                    seat = new Seat(row["FlightNumber"].ToString(),  Convert.ToInt32(row["CustomerID"]),  Convert.ToInt32(row["SeatType"]), Convert.ToInt32(row["SeatNumber"]), CustomerPaid);
                    flight.AddSeatToList(seat);
                }
            }
            catch (Exception e)
            {

                throw;
            }
           
            return flight;
        }

        public List<Flight> getAllInforofAllFlight()
        {
            List<Flight> Flights;
            Flights = GetAllFlightInfo();

            for (int i = 0; i < Flights.Count; i++)
            {
                Flights[i] = GetFlightInformation(Flights[i]);
            }

            return Flights;
        }

        public Flight SearchFlight(string Query)
        {
            Flight flight = null;
            DataTable dt = DAFlight.SearchFlight(Query);
            if (dt.Rows.Count != 0)
            {
                DACarrier DAcarrier = new DACarrier();
                DataTable dtCarrier = DAcarrier.SearchCarrier(" ID= " + Convert.ToString(dt.Rows[0]["CarrierID"]) );
                string  CarrierName = dtCarrier.Rows[0]["Name"].ToString();

                flight = new Flight(dt.Rows[0]["flightNumber"].ToString(), Convert.ToDateTime(dt.Rows[0]["Date"].ToString()).Date,
                                       Convert.ToDateTime(dt.Rows[0]["Time"].ToString()).TimeOfDay, dt.Rows[0]["Destination"].ToString()
                                        , dt.Rows[0]["Arrival"].ToString(), CarrierName);

            }

            return flight;
        }

        public int AddFlight(Flight flight)
        {
            DACarrier DAcarrier = new DACarrier();
            DataTable dt = DAcarrier.SearchCarrier(" Name= '" + flight.CarrierName + "'");
            int CarrierID =Convert.ToInt32( dt.Rows[0]["ID"]);
            int result = 0;
            try
            {

                DAFlight.AddFlight(flight.FlightNumber, flight.Date, flight.Time, flight.Destination, flight.Arrival, CarrierID);

                BA_SeatType BASeatType = new BA_SeatType();
                foreach (SeatType seatType in flight.GetSeatTypelList())
                {
                    BASeatType.AddSeatType(seatType);
                }

            }
            catch (Exception ex)
            {

                result = -1;
            }

            return result;
        }

        public int DeleteFlight(string  flightNumber)
        {
            
            int result = 0;
            try
            {

                DAFlight.DeleteFlight(flightNumber);

            }
            catch (Exception ex)
            {

                result = -1;
            }

            return result;
        }

        public int UpdateFlight(Flight flight)
        {
           

            DACarrier DAcarrier = new DACarrier();
            DataTable dt = DAcarrier.SearchCarrier(" Name= '" + flight.CarrierName + "'");
            int CarrierID = Convert.ToInt32(dt.Rows[0]["ID"]);
            int result = 0;
            try
            {

                DAFlight.UPDFlight(flight.FlightNumber, flight.Date, flight.Time, flight.Destination, flight.Arrival, CarrierID);
                
                BA_SeatType BASeatType = new BA_SeatType();
                List<SeatType> DBFlightSeatType = BASeatType.SearchSeatType(" FlightNumber='"+ flight.FlightNumber+"'");
                bool flag = false;

                foreach (SeatType seatType in DBFlightSeatType)
                {
                    flag = false;
                    foreach (SeatType st in flight.GetSeatTypelList())
                    {
                        if (seatType.ID != st.ID)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                    {
                        BASeatType.DeleteSeatType(seatType);
                    }

                }

                foreach (SeatType seatType in flight.GetSeatTypelList())
                {
                    flag = false;
                    foreach (SeatType st in DBFlightSeatType)
                    {
                        if (seatType.ID==st.ID)
                        {
                            BASeatType.UpdateSeatType(seatType);
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        BASeatType.AddSeatType(seatType);
                    }
                    
                }

               
                
            }
            catch (Exception ex)
            {

                result = -1;
            }

            return result;
        }
    }
}
