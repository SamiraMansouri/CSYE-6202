using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Registration.Casses
{
    public class Carrier
    {
        public int ID { get; private set; }
        public String Name { get; private set; }
        public String Origion { get; private set; }
        public String WebSite { get; private set; }
        public String Phone { get; private set; }
        public String Address { get; private set; }
        private  List<Flight> CarrierFlights = new List<Flight>();

        public Carrier() { }

        public Carrier( string _Name, string _Origion, string _Website, string _Address, string _Phone)
        {
            Name = _Name;
            Origion = _Origion;
            WebSite = _Website;
            Phone = _Phone;
            Address = _Address;
        }

        public Carrier(int _ID,string _Name,string _Origion,string _Website,string _Address,string _Phone)
        {
            ID = _ID;
            Name = _Name;
            Origion = _Origion;
            WebSite = _Website;
            Phone = _Phone;
            Address = _Address;
        }

        public List<Flight> getFlight()
        {
            return CarrierFlights;
        }

        public void SetFlight(Flight flight)
        {
            CarrierFlights.Add(flight);
        }

    }
}
