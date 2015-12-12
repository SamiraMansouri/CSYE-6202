using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Registration.Casses
{
    public class customer:Person
    {
        public List<Seat> Seats { get; private set; }

        public customer() {}

        public customer(string Firstname, string LastName, string ID, string Phone, string Address, DateTime? Birthdate) : base(Firstname, LastName, ID, Birthdate, Phone, Address) { }

        public customer(string Firstname,string LastName,string ID,string Phone,string Address,DateTime? Birthdate, List<Seat> _seats):base(Firstname,LastName,ID,Birthdate,Phone,Address)
        {
            Seats = _seats;
        }
    }
}
