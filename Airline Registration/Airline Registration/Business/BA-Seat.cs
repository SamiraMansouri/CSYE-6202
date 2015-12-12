using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline_Registration.Casses;
using Airline_Registration.Data_Access;
using System.Data;

namespace Airline_Registration.Business
{
    class BA_Seat
    {
        DA_Seat DASeat = new DA_Seat();

        public int AddSeat(Seat seat)
        {
            int result = 0;
            try
            {

                DASeat.AddSeat(seat.FlightNumber, seat.SeatNumber, seat.CustomerID, seat.SeatTypeID, seat.CustomerPaid);
            }
            catch (Exception ex)
            {

                result = -1;
            }

            return result;
        }

        public List<Seat> GetAllseats()
        {
            List<Seat> seats = null;
            DataTable dt = DASeat.GetAllSeat();

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

                seat = new Seat(row["FlightNumber"].ToString(), Convert.ToInt32(row["SeatNumber"]), Convert.ToInt32(row["CustomerID"]), Convert.ToInt32(row["SeatType"]), CustomerPaid);
                seats.Add(seat);
            }

            return seats;
        }

        public bool DeleteSeat(Seat seat)
        {
            return DASeat.DeleteSeat(seat.CustomerID,seat.FlightNumber);
        }

        public List<Seat> SearchSeat(string Query)
        {
            DataTable dt = DASeat.SearchSeat(Query);
            List<Seat> seats = null;
            Seat seat;
            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    seat = new Seat(row["FlightNumber"].ToString(), Convert.ToInt32(row["CustomerID"]),
                                 Convert.ToInt32(row["SeatType"]), Convert.ToInt32(row["SeatNumber"]),
                                 float.Parse(row["CustomerPaid"].ToString()));

                    seats.Add(seat);

                }
               
            }
            catch (Exception ex)
            {

                throw;
            }


            return seats;
        }

    }
}
