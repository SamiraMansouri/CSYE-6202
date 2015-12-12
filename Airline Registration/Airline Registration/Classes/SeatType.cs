using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Registration.Casses
{
    public class SeatType
    {
        public int ID { get; private set; }
        public String Type { get; private set; }
        public float Price { get; private set; }
        public string  FlightNumber { get; private set; }
        public int StartSeat { get; private set; }
        public int EndSeat { get; private set; }

        public SeatType() { }

        public SeatType(int _ID,string _Type,float _Price,string _FlightNumber,int _StartSeat,int _EndSeat)
        {
            ID = _ID;
            Type = _Type;
            Price = _Price;
            FlightNumber = _FlightNumber;
            StartSeat = _StartSeat;
            EndSeat = _EndSeat;
        }

        public SeatType( string _Type, float _Price, string _FlightNumber, int _StartSeat, int _EndSeat)
        {
            Type = _Type;
            Price = _Price;
            FlightNumber = _FlightNumber;
            StartSeat = _StartSeat;
            EndSeat = _EndSeat;
        }

    }
}
