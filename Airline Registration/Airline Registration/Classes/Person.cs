using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Registration.Casses
{
    public class Person
    {
        public String FirstName { get; protected set; }
        public String LastName { get; protected set; }
        public String ID { get; protected set; }
        public DateTime? birthdate { get; protected set; }
        public String Phone { get; protected set; }
        public String Address { get; protected set; }

        public Person() { }

        public Person(string _FN,string LN,string _ID,DateTime? _Birthdate,string _Phone,string _Add)
        {
            FirstName = _FN;
            LastName = LN;
            ID = _ID;
            birthdate = _Birthdate;
            Phone = _Phone;
            Address = _Add;
        }
    }
}
