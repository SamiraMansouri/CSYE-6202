using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Airline_Registration.Casses;

namespace AirLineRegistration_Test
{
    [TestFixture]

    public class MyFirstTestClass
    {
        #region Classes

        #region Carrier
        [Test]
        public void Test_CarrierConstructor_with_0Argument()
        {

            Carrier actual = new Carrier();
            Assert.That(actual, Is.Not.Null);
        }

        [Test]
        public void Test_CarrierConstructor_with_4Argument()
        {
            
            Carrier actual = new Carrier("TestCarrier", "Origion", "WebSite", "Address", "Phone");
            Assert.That(actual, Is.Not.Null);
        }

        [Test]
        public void Test_CarrierConstructor_with_5Argument()
        {

            Carrier actual = new Carrier(1,"TestCarrier", "Origion", "WebSite", "Address", "Phone");
            Assert.That(actual, Is.Not.Null);
        }

        [Test]
        public void Test_SetFlightFunction()
        {
            Carrier carrier = new Carrier();
            Flight flight = new Flight();
            List<Flight> flights = new List<Flight>();
            flights.Add(flight);
            var actual = flights;
            carrier.SetFlight(flight);
            Assert.That(actual.Count,Is.EqualTo( carrier.getFlight().Count));
        }

       

        #endregion

        #region Crew
        [Test]
        public void Test_CrewConstructor_with_0Argument()
        {

            Crew actual =new Crew();
            Assert.That(actual, Is.Not.Null);
        }

        [Test]
        public void Test_CrewConstructor_with_Argumentss()
        {
            DateTime? bd = DateTime.Parse("2015-12-11");
            Crew actual = new Crew("FN","LastName", "123", bd, "6176500744", "111 norway street", "Type", "Title", "FlightNumber");
            Assert.That(actual, Is.Not.Null);
        }
        #endregion

        #region Customer
        [Test]
        public void Test_CustomerConstructor_with_0Argument()
        {

            customer actual = new customer();
            Assert.That(actual, Is.Not.Null);
        }

        [Test]
        public void Test_CustomerConstructor_with_5Argument_Costructor_of_person()
        {
            DateTime? bd = DateTime.Parse("2015-12-11");
            customer actual = new customer("FirstName","LastName","ID","phone","Address", bd);
            Assert.That(actual, Is.Not.Null);
        }

        [Test]
        public void Test_CustomerConstructor_with_Arguments()
        {
            List<Seat> seats = new List<Seat>();
            DateTime? bd = DateTime.Parse("2015-12-11");
            customer actual = new customer("FirstName", "LastName", "ID", "phone", "Address", bd,seats);
            Assert.That(actual, Is.Not.Null);
        }
        #endregion

        #region Person
        [Test]
        public void Test_PersonConstructor_with_0Argument()
        {

            customer actual = new customer();
            Assert.That(actual, Is.Not.Null);
        }

        [Test]
        public void Test_PersonConstructor_with_Arguments()
        {
            DateTime? bd = DateTime.Parse("2015-12-11");
            Person actual = new Person("FirstName", "LastName", "ID", bd, "phone", "Address");
            Assert.That(actual, Is.Not.Null);
        }
        #endregion

        #region seat
        [Test]
        public void Test_SeatConstructor_with_0Argument()
        {

            Seat actual = new Seat();
            Assert.That(actual, Is.Not.Null);
        }

        [Test]
        public void Test_SeatConstructor_with_4Argument()
        {
           
            Seat actual = new Seat("FlightNumber", 1, 120,(float)150.0);
            Assert.That(actual, Is.Not.Null);
        }

        [Test]
        public void Test_SeatConstructor_with_5Argument()
        {
           Seat actual = new Seat("FlightNumber", 100,1, 120,(float)150.0);
            Assert.That(actual, Is.Not.Null);
        }
        #endregion

        #region SeatType
        [Test]
        public void Test_SeatTypeConstructor_with_0Argument()
        {

            SeatType actual = new SeatType();
            Assert.That(actual, Is.Not.Null);
        }

        [Test]
        public void Test_SeatTypeConstructor_with_5Argument()
        {

            SeatType actual = new SeatType("Business",130,"5467",10,56 );
            Assert.That(actual, Is.Not.Null);
        }

        [Test]
        public void Test_SeatTypeConstructor_with_6Argument()
        {
            SeatType actual = new SeatType(10,"Business", 130, "5467", 10, 56);
            Assert.That(actual, Is.Not.Null);
        }
        #endregion

        #region User

        [Test]
        public void Test_UserConstructor_with_0Argument()
        {

            User actual = new User();
            Assert.That(actual, Is.Not.Null);
        }

        [Test]
        public void Test_UserConstructor_with_4Argument()
        {

            User actual = new User("FirstName","LastName","Username","password","AccessPoint");
            Assert.That(actual, Is.Not.Null);
        }

        #endregion

        #region flight
        [Test]
        public void Test_FlightConstructor_with_0Argument()
        {
            Flight actual = new Flight();
            Assert.That(actual, Is.Not.Null);
        }

        [Test]
        public void Test_FlightConstructor_with_6Argument()
        {
            TimeSpan time = new TimeSpan(11, 45, 0);
            List<Crew> crews = new List<Crew>();
            Flight actual = new Flight("FlightNumber", DateTime.Parse("2015-12-11"),time,"destination","Arrival","CarrierName",crews);
            Assert.That(actual, Is.Not.Null);
        }

        [Test]
        public void Test_FlightConstructor_with_MoreArguments()
        {
            TimeSpan time = new TimeSpan(11, 45, 0);
            List<Crew> crews = new List<Crew>();
            Flight actual = new Flight("FlightNumber",DateTime.Parse("2015-12-11"), time,"Destination","arrival", "CarrierName", crews);
            Assert.That(actual, Is.Not.Null);
        }

        [Test]
        public void Test_ADDSeat()
        {
            string FlightNumber = "FN";
            int CustomerID = 1;
            int SeatTypeID = 1;
            int seatNumber = 1;
            float CustomerPaid = 100;
            Flight flight = new Flight(FlightNumber,DateTime.Parse(" 1991 - 12 - 31"),TimeSpan.Parse("13:24:00"),"","","");
            Seat seat = new Seat(FlightNumber,CustomerID,SeatTypeID,seatNumber,CustomerPaid);
            List<Seat> seats = new List<Seat>();
            seats.Add(seat);
            var actual = seats;
            flight.AddSeat( CustomerID, SeatTypeID, seatNumber, CustomerPaid);
            Assert.That(actual.Count, Is.EqualTo(flight.GetSeatlList().Count));
        }

        [Test]
        public void Test_ADDSeatType()
        {
            string FlightNumber = "FN";
            string  Type = "Business";
            int price = 1;
            int start = 1;
            int end = 10;
            
            Flight flight = new Flight(FlightNumber, DateTime.Parse(" 1991 - 12 - 31"), TimeSpan.Parse("13:24:00"), "", "", "");
            SeatType seattype = new SeatType(Type,price,FlightNumber,start,end);
            List<SeatType> seatsTypes = new List<SeatType>();
            seatsTypes.Add(seattype);
            var actual = seatsTypes;
            flight.AddSeatType(Type,price,start,end);
            Assert.That(actual.Count, Is.EqualTo(flight.GetSeatTypelList().Count));
        }

        [Test]
        public void Test_ADDSeatTypeToList()
        {
            string FlightNumber = "FN";
            string Type = "Business";
            int price = 1;
            int start = 1;
            int end = 10;

            Flight flight = new Flight(FlightNumber, DateTime.Parse(" 1991 - 12 - 31"), TimeSpan.Parse("13:24:00"), "", "", "");
            SeatType seattype = new SeatType(Type, price, FlightNumber, start, end);
            List<SeatType> seatsTypes = new List<SeatType>();
            seatsTypes.Add(seattype);
            var actual = seatsTypes;
            flight.AddSeatTypeToList(seattype);
            Assert.That(actual.Count, Is.EqualTo(flight.GetSeatTypelList().Count));
        }

        [Test]
        public void AddCrewToList()
        {
            string FlightNumber = "FN";
            

            Flight flight = new Flight(FlightNumber, DateTime.Parse(" 1991 - 12 - 31"), TimeSpan.Parse("13:24:00"), "", "", "");

            DateTime? bd = DateTime.Parse("2015-12-11");
            Crew crew = new Crew("FN", "LastName", "123", bd, "6176500744", "111 norway street", "Type", "Title", "FlightNumber");

            List<Crew> crews = new List<Crew>();
            crews.Add(crew);
            var actual = crews;

            flight.AddCrewToList(crew);
            Assert.That(actual.Count, Is.EqualTo(flight.GetCrewlList().Count));
        }

        [Test]
        public void AddSeatToList()
        {
            string FlightNumber = "FN";

            Flight flight = new Flight(FlightNumber, DateTime.Parse(" 1991 - 12 - 31"), TimeSpan.Parse("13:24:00"), "", "", "");

            Seat seat = new Seat("FlightNumber", 100, 1, 120, (float)150.0);

            List<Seat> seats = new List<Seat>();
            seats.Add(seat);
            var actual = seats;

            flight.AddSeatToList(seat);
            Assert.That(actual.Count, Is.EqualTo(flight.GetSeatlList().Count));
        }

        [Test]
        public void RemoveSeatFromList()
        {
            string FlightNumber = "FN";


            Flight flight = new Flight(FlightNumber, DateTime.Parse(" 1991 - 12 - 31"), TimeSpan.Parse("13:24:00"), "", "", "");

            Seat seat = new Seat("FlightNumber", 100, 1, 120, (float)150.0);

            List<Seat> seats = new List<Seat>();
            var actual = seats;

            flight.AddSeatToList(seat);
            flight.RemoveSeatFromList(seat);
            Assert.That(actual.Count, Is.EqualTo(flight.GetSeatlList().Count));
        }

        [Test]
        public void Test_Check_ThisSea_Is_Book_Before_OrNot()
        {
            string FlightNumber = "FN";

            Flight flight = new Flight(FlightNumber, DateTime.Parse(" 1991 - 12 - 31"), TimeSpan.Parse("13:24:00"), "", "", "");
            
            Seat seat = new Seat("FlightNumber", 100, 1, 120, (float)150.0);
            flight.AddSeatToList(seat);
            seat = new Seat("FlightNumber", 128, 1, 122, (float)150.0);
            flight.AddSeatToList(seat);
            seat = new Seat("FlightNumber", 366, 2, 200, (float)568.0);
            flight.AddSeatToList(seat);

            var actual = flight.Check_ThisSea_Is_Book_Before_OrNot(55);
            Assert.That(actual,Is.False );

             actual = flight.Check_ThisSea_Is_Book_Before_OrNot(200);
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Test_FindSeatTypeID()
        {
            string FlightNumber = "FN";
            string Type = "Business";
            int price = 1;
            int start = 1;
            int end = 10;

            Flight flight = new Flight(FlightNumber, DateTime.Parse(" 1991 - 12 - 31"), TimeSpan.Parse("13:24:00"), "", "", "");
           
            List<SeatType> seatsTypes = new List<SeatType>();
            SeatType seattype = new SeatType(1,Type, price, FlightNumber, start, end);
            flight.AddSeatTypeToList(seattype);
            var actual = flight.FindSeatTypeID("false"); 

            Assert.That(actual,Is.EqualTo(-1));

            actual = flight.FindSeatTypeID("Business");

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void Test_FindSeatTypeName()
        {
            string FlightNumber = "FN";
            string Type = "Business";
            int price = 1;
            int start = 1;
            int end = 10;

            Flight flight = new Flight(FlightNumber, DateTime.Parse(" 1991 - 12 - 31"), TimeSpan.Parse("13:24:00"), "", "", "");

            List<SeatType> seatsTypes = new List<SeatType>();
            SeatType seattype = new SeatType(1, Type, price, FlightNumber, start, end);
            flight.AddSeatTypeToList(seattype);
            var actual = flight.FindSeatTypeName(1);

            Assert.That(actual, Is.EqualTo("Business"));

            actual = flight.FindSeatTypeName(8);

            Assert.That(actual, Is.EqualTo(null));

            actual = flight.FindSeatTypeName(-1);

            Assert.That(actual, Is.EqualTo(null));
        }

        [Test]
        public void Test_Is_there_any_seat_with_this_SeatType()
        {
            string FlightNumber = "FN";

            Flight flight = new Flight(FlightNumber, DateTime.Parse(" 1991 - 12 - 31"), TimeSpan.Parse("13:24:00"), "", "", "");

            Seat seat = new Seat("FlightNumber", 101, 11, 10, (float)150.0);
            flight.AddSeatToList(seat);
            seat = new Seat("FlightNumber", 128, 1, 122, (float)150.0);
            flight.AddSeatToList(seat);
            seat = new Seat("FlightNumber", 366, 2, 200, (float)568.0);
            flight.AddSeatToList(seat);

            SeatType seattype = new SeatType(1, "Business", 150, "FlightNumber", 1, 140);
            flight.AddSeatTypeToList(seattype);

            var actual = flight.Is_there_any_seat_with_this_SeatType(seattype,150,300);
            Assert.That(actual,Is.EqualTo(true));

            actual = flight.Is_there_any_seat_with_this_SeatType(seattype, 120, 300);
            Assert.That(actual, Is.EqualTo(false));

        }

        [Test]
        public void Test_Find_SeatTypeIndex_In_List()
        {
            string FlightNumber = "FN";
            string Type = "Business";
            int price = 1;
            int start = 1;
            int end = 10;

            Flight flight = new Flight(FlightNumber, DateTime.Parse(" 1991 - 12 - 31"), TimeSpan.Parse("13:24:00"), "", "", "");

            List<SeatType> seatsTypes = new List<SeatType>();
            SeatType seattype = new SeatType(1, Type, price, FlightNumber, start, end);
            flight.AddSeatTypeToList(seattype);
            var actual = flight.Find_SeatTypeIndex_In_List(seattype);
            Assert.That(actual,Is.EqualTo(0));

            seattype = new SeatType(10, "economy", 120, "23435", 34, 67);
            actual = flight.Find_SeatTypeIndex_In_List(seattype);
            Assert.That(actual, Is.EqualTo(-1));
        }

        [Test]
        public void Test_UpdateItemInSeatTypeList()
        {
            string FlightNumber = "FN";
            string Type = "Business";
            int price = 1;
            int start = 1;
            int end = 10;

            Flight flight = new Flight(FlightNumber, DateTime.Parse(" 1991 - 12 - 31"), TimeSpan.Parse("13:24:00"), "", "", "");

            List<SeatType> seatsTypes = new List<SeatType>();
            SeatType seattype = new SeatType(1, Type, price, FlightNumber, start, end);
            flight.AddSeatTypeToList(seattype);

            flight.UpdateItemInSeatTypeList(seattype, 40, 60, 780);
            float actual = flight.GetSeatTypelList()[0].StartSeat ;
            Assert.That(actual, Is.EqualTo(40));

            actual = flight.GetSeatTypelList()[0].EndSeat;
            Assert.That(actual, Is.EqualTo(60));

            actual =float.Parse( (flight.GetSeatTypelList()[0].Price).ToString());
            Assert.That(actual, Is.EqualTo(780));

            seattype = new SeatType(12, Type, price, FlightNumber, start, end);
            flight.UpdateItemInSeatTypeList(seattype, 45, 67, 55);

            actual = flight.GetSeatTypelList()[0].StartSeat;
            Assert.That(actual, Is.EqualTo(40));

            actual = flight.GetSeatTypelList()[0].EndSeat;
            Assert.That(actual, Is.EqualTo(60));

            actual = flight.GetSeatTypelList()[0].Price;
            Assert.That(actual, Is.EqualTo(780));

        }

        [Test]

        public void Test_RemoveSeatType()
        {
            string FlightNumber = "FN";
            string Type = "Economy Plus";
            int price = 1;
            int start = 1;
            int end = 10;

            Flight flight = new Flight(FlightNumber, DateTime.Parse(" 1991 - 12 - 31"), TimeSpan.Parse("13:24:00"), "", "", "");

            List<SeatType> seatsTypes = new List<SeatType>();
            SeatType seattype = new SeatType(1, Type, price, FlightNumber, start, end);
            flight.AddSeatTypeToList(seattype);

            flight.RemoveSeatType("Business");
            var actual = flight.GetSeatTypelList();
            Assert.That(actual.Count,Is.EqualTo(1));

            flight.RemoveSeatType("Economy Plus");
             actual = flight.GetSeatTypelList();
            Assert.That(actual.Count, Is.EqualTo(0));

        }
        #endregion
        #endregion
    }
}
