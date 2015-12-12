using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Airline_Registration.Data_Access
{
    class DA_Login
    {
        string ConnectionString = "Data Source=APPLEAD7E;Initial Catalog=Airline Reservation System;Integrated Security=True";

        public DataTable GetUser(String UserName,String Password)
        {
             SqlConnection connection = new SqlConnection(ConnectionString);
            string queryString = "select * from tblUser where Username='"+UserName+"' and Password= '"+ Password+"'";
            SqlCommand command = new SqlCommand(queryString, connection);
           

            SqlDataAdapter dap = new SqlDataAdapter(command);
            command.Connection.Open();
            DataTable dt = new DataTable();
            dap.Fill(dt);
            command.Connection.Close();
            return dt;

        }

    }
}
