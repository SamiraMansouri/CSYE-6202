using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Registration.Data_Access
{
    class DA_Seat
    {
        string ConnectionString = "Data Source=APPLEAD7E;Initial Catalog=Airline Reservation System;Integrated Security=True";


        public bool AddSeat(string FlightNumber, int SeatNumber, int CustomerID, int SeatTypeID, float CustomerPaid)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string queryString = string.Format("Insert Into tblSeat (FlightNumber,SeatNumber,CustomerID,SeatType,CustomerPaid) values" +
                "('{0}', '{1}', '{2}', '{3}', '{4}')", FlightNumber, SeatNumber, CustomerID, SeatTypeID, CustomerPaid);

            bool result = true;
            try
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {

                result = false;
            }

            return result;

        }
        
        public DataTable SearchSeat(string Query)
        {
            
            SqlConnection connection = new SqlConnection(ConnectionString);
            DataTable dt;
            try
            {
                string queryString ;
                if (Query =="")
                {
                    queryString = "select * from tblSeat ";
                }
                else
                {
                    queryString = "select * from tblSeat where "+Query;
                }
                
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

        public DataTable GetAllSeat()
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            DataTable dt;
            try
            {
                string queryString = "select * from tblSeat ";
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

        public bool DeleteSeat(int CustomerID,string FlightNumber)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string queryString = string.Format("Delete from tblSeat where CustomerID = {0} and FlightNumber='{1}'", CustomerID,FlightNumber);

            bool result = true;
            try
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {

                result = false;
            }

            return result;

        }
        
        public DataTable GetCustomerSeat(int CustomerID, string FlightNumber)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string queryString = "select * from tblSeat where CustomerID= " + CustomerID + " and FlightNumber='" + FlightNumber + "'";
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
