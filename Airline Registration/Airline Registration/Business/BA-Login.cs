using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline_Registration.Casses;
using Airline_Registration.Data_Access;
using System.Data;

namespace Airline_Registration.Business
{
    class BA_Login
    {
        
        public User GetUser(String UserName,String Password)
        {
            DA_Login Loginobj = new DA_Login();
            DataTable dt = Loginobj.GetUser(UserName, Password);
            User user = null;
            if (dt.Rows.Count>=0)
            {
                string FirstName = dt.Rows[0]["FirstName"].ToString();
                string LastName = dt.Rows[0]["LastName"].ToString();
                string AccessPoint = dt.Rows[0]["AccessPoint"].ToString();
                user = new User(FirstName, LastName, UserName, Password, AccessPoint);
            }
           
             return user; 
        }
    }
}
