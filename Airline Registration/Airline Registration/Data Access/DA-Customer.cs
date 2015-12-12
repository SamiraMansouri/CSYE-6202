using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Registration.Data_Access
{
    class DA_Customer
    {

        string ConnectionString = "Data Source=APPLEAD7E;Initial Catalog=Airline Reservation System;Integrated Security=True";

        public DataTable GetAllCustomers()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string queryString = "select * from tblCustomer";
            SqlCommand command = new SqlCommand(queryString, connection);


            SqlDataAdapter dap = new SqlDataAdapter(command);
            command.Connection.Open();
            DataTable dt = new DataTable();
            dap.Fill(dt);
            command.Connection.Close();
            return dt;

        }
        
        public DataTable GetFlightCustomers(string FlightNumber)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            DataTable dt;
            try
            {
                string queryString = " select * from tblCustomer inner join tblSeat on tblCustomer.ID=tblSeat.CustomerID where tblSeat.FlightNumber=" + FlightNumber;
                SqlCommand command = new SqlCommand(queryString, connection);


                SqlDataAdapter dap = new SqlDataAdapter(command);
                command.Connection.Open();
                dt = new DataTable();
                dap.Fill(dt);
                command.Connection.Close();
            }
            catch (Exception e)
            {

                throw;
            }

            return dt;
        }

    }
}
