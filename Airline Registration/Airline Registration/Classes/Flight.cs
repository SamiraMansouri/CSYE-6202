using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline_Registration.Business;

namespace Airline_Registration.Casses
{
    public class Flight
    {

        public String FlightNumber { get; protected set; }
        public DateTime Date { get; private set; }
        public TimeSpan Time { get; private set; }
        public String Destination { get; private set; }
        public String Arrival { get; private set; }
        public String CarrierName { get; private set; }
        private List<Crew> Crews = new List<Crew>();
        private  List<SeatType> SeatTypes = new List<SeatType>();
        private List<Seat> Seats = new List<Seat>();



        public Flight() { }

        public Flight(string _FlightNumber, DateTime _date, TimeSpan _Time, string _Destination, string _arrival,string  _CarrierName )
        {
            FlightNumber = _FlightNumber;
            Date = _date;
            Time = _Time;
            Destination = _Destination;
            Arrival = _arrival;
            CarrierName = _CarrierName;
        }

        public Flight(string _FlightNumber, DateTime _date, TimeSpan _Time,
                                            string _Destination, string _arrival, string  _CarrierName,List<Crew> _Crews)
        {
            FlightNumber = _FlightNumber;
            Date = _date;
            Time = _Time;
            Destination = _Destination;
            Arrival = _arrival;
            CarrierName = _CarrierName;
            Crews = _Crews;
        }
        

        public void AddSeat(int CustomerID,int _SeatTypeID, int _SeatNumber, float _CustomerPaid)
        {
            Seat seat = new Seat(FlightNumber, CustomerID, _SeatTypeID, _SeatNumber, _CustomerPaid);
            Seats.Add(seat);

        }

        public void AddSeatType(string _Type, float _Price ,int _StartSeat, int _EndSeat)
        {
            SeatType seatType = new SeatType(_Type, _Price, FlightNumber, _StartSeat, _EndSeat);
            SeatTypes.Add(seatType);

        }

        public void AddSeatTypeToList(SeatType seatType)
        {
            SeatTypes.Add(seatType);
        }

        public void AddCrewToList(Crew crew)
        {
            Crews.Add(crew);
        }

        public void AddSeatToList(Seat seat)
        {
            Seats.Add(seat);
        }

        public List<SeatType> GetSeatTypelList()
        {
            return SeatTypes;
        }

        public List<Seat> GetSeatlList()
        {
            return Seats;
        }

        public List<Crew> GetCrewlList()
        {
            return Crews;
        }

        public void RemoveSeatFromList(Seat  seat)
        {
            Seats.Remove(seat);
        }

        public bool Check_ThisSea_Is_Book_Before_OrNot(int SeatNumber)
        {
            bool result = false;
            foreach (Seat seat in Seats)
            {
                if (SeatNumber == seat.SeatNumber)
                {
                    result = true;
                }
            }
            return result;
        }

        public int FindSeatTypeID(string _SeatType)
        {
            int SeatNum = -1;
            foreach (SeatType seatType in SeatTypes)
            {
                if (seatType.Type == _SeatType)
                {
                    SeatNum = seatType.ID;
                    break;
                }
            }

            return SeatNum;
        }

        public string FindSeatTypeName(int _SeatTypeID)
        {
            string Type = null;
            foreach (SeatType seatType in SeatTypes)
            {
                if (seatType.ID == _SeatTypeID)
                {
                    Type = seatType.Type;
                    break;
                }
            }

            return Type;
        }

        public bool Is_there_any_seat_with_this_SeatType(SeatType seatType,int Newstart,int NewEnd)
        {
            bool result = false;
            foreach (Seat seat in Seats)
            {
                if (seat.SeatTypeID==seatType.ID )
                {
                    if (((seat.SeatNumber>seatType.StartSeat && seat.SeatNumber<seatType.EndSeat)&&!(seat.SeatNumber > Newstart && seat.SeatNumber < NewEnd)))
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }

        public void UpdateItemInSeatTypeList(SeatType seatType,int Start,int end,float price)
        {

            int index = Find_SeatTypeIndex_In_List(seatType);
            if (index!=-1)
            {
                SeatType SType = new SeatType(seatType.ID, seatType.Type, price, seatType.FlightNumber, Start, end);
                SeatTypes[index] = SType;
            }
           
        
        }

        public  int Find_SeatTypeIndex_In_List(SeatType seatType)
        {
            int index = -1;
            for (int i = 0; i < SeatTypes.Count; i++)
            {
                if (SeatTypes[i].ID == seatType.ID)
                {
                    index = i;
                }
            }
            return index;
        }

        public void RemoveSeatType(string Type)
        {
            foreach (SeatType ST in SeatTypes)
            {
                if (ST.Type == Type)
                {
                    int index = SeatTypes.IndexOf(ST);
                    SeatTypes.RemoveAt(index);
                }
                break;
            }
        }
    }
}
