using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Registration.Casses
{
    public class User:Person
    {
        public String Username {  get; private set; }
        public String Password { get; private set; }
        public String AccessPoint { get; private set; }

        public User(){}
        public User(string FN,string LN,string UN,string Pass,string AP)
        {
            FirstName = FN;
            LastName = LN;
            Username = UN;
            Password = Pass;
            AccessPoint = AP;
        }


    }
}
