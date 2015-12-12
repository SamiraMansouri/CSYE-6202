using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Registration.Casses
{
    public class Seat
    {
        public string  FlightNumber { get; private set; }
        public int CustomerID { get; private set; }
        public int SeatTypeID { get; private set; }
        public int SeatNumber { get; private set; }
        public float CustomerPaid { get; private set; }

        public Seat() { }

        public Seat(string _FlightNumber,int _CustomerID,int _SeatTypeID,int _SeatNumber,float _CustomerPaid)
        {
            FlightNumber = _FlightNumber;
            CustomerID = _CustomerID;
            SeatTypeID = _SeatTypeID;
            SeatNumber = _SeatNumber;
            CustomerPaid = _CustomerPaid;
        }

        public Seat(string _FlightNumber, int _SeatTypeID, int _SeatNumber, float _CustomerPaid)
        {
            FlightNumber = _FlightNumber;
            SeatTypeID = _SeatTypeID;
            SeatNumber = _SeatNumber;
            CustomerPaid = _CustomerPaid;
        }
    }
}
