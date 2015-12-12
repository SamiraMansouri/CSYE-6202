using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Registration.Casses
{
    public class Crew:Person
    {
        public String Type { get; private set; }//fulltime,parttime,...
        public String Title { get; private set; }//capitan,...
        public string  FlightNumber { get; private set; }

        public Crew() { }

        public Crew (string FN,string LN,string ID,DateTime? _BirtDate,string phone,string Address, string _Type,string _Title,string  _flightNumber): base(FN, LN, ID, _BirtDate,phone,Address)
        {
            
            Type = _Type;
            Title = _Title;
            FlightNumber = _flightNumber;
        }
        
    }
}
