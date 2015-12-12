using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Registration.Data_Access
{
    class DA_SeatType
    {
        string ConnectionString = "Data Source=APPLEAD7E;Initial Catalog=Airline Reservation System;Integrated Security=True";


        public bool AddSeatType(string Type, float Price, string  FlightNumber, int StartSeat, int EndSeat)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string queryString = string.Format("Insert Into tblSeatType (Type,Price,FlightNumber,StartSeat,EndSeat) values" +
                "('{0}', '{1}', '{2}', '{3}', '{4}')", Type, Price, FlightNumber, StartSeat, EndSeat);

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

        public bool DeleteSeatType(int ID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string queryString = string.Format("Delete from tblSeatType where ID = {0}", ID);

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

        public bool UpdateSeatType(int ID,string Type, float Price, string FlightNumber, int StartSeat, int EndSeat)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            string queryString = string.Format("Update tblSeatType set Type='" + Type + "' ,Price=" + Price  +
                                                ",FlightNumber='" + FlightNumber + "',StartSeat=" + StartSeat + " ,EndSeat=" + EndSeat + " where ID=" + ID);

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

        public DataTable SearchseatType(string query)
        {
            DataTable dt;
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                string queryString = "";


                 if (query == "")
                {
                    queryString = "select * from tblSeatType";
                }
                else
                {
                        queryString= "select * from tblSeatType where " + query;
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
    }
}
