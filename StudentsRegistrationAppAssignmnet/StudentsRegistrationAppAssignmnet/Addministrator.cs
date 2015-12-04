using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsRegistrationAppAssignmnet
{
    class Addministrator:Person
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public void AddAdmin(string fNAme, string LName, string username, string password)
        {
            FirstName = fNAme;
            LastName = LName;
            Username = username;
            Password = password;
        }

    }
}
