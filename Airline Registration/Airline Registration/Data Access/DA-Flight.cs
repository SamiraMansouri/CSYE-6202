using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Airline_Registration.Data_Access
{
    class DA_Flight
    {
        string ConnectionString = "Data Source=APPLEAD7E;Initial Catalog=Airline Reservation System;Integrated Security=True";

        public DataTable GetAllFlightsInformation()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            DataTable dt;
            try
            {
                string queryString = "select FlightNumber,[Date],[Time],Destination,Arrival,Name from tblFlight inner join tblCarrier on tblFlight.CarrierID=tblCarrier.ID";
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

        public DataTable GetFlightCarrier(string  FlightNumber)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            DataTable dt;
            try
            {
                string queryString = " select* from tblCarrier inner join tblFlight on tblCarrier.ID = tblFlight.CarrierID where FlightNumber = " + FlightNumber;
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

        public DataTable GetFlightSeatType(string FlightNumber)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            DataTable dt;
            try
            {
                string queryString = " select * from tblSeatType where FlightNumber = " + FlightNumber;
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

        public DataTable GetFlightCrews(string FlightNumber)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            DataTable dt;
            try
            {
                string queryString = " select * from tblCrew where FlightNumber = " + FlightNumber;
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
        
        public DataTable GetFlightSeat(string FlightNumber)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            DataTable dt;
            try
            {
                string queryString = "select * from tblSeat where FlightNumber=" + FlightNumber;
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

        public DataTable GetCustomerFlightsSeat(int CustomerID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            DataTable dt;
            try
            {
                string queryString = "select * from tblSeat where CustomerID="+CustomerID;
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

        public DataTable SearchFlight(string Query)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            DataTable dt;
            try
            {
                string queryString = "select * from tblFlight where " + Query;
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

        public bool AddFlight(string FlightNumber, DateTime date, TimeSpan time, string Destination, string  Arrival,int CarrierID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string queryString = string.Format("Insert Into tblFlight (FlightNumber,Date,Time,Destination,Arrival,CarrierID) values" +
                "('{0}', '{1}', '{2}', '{3}', '{4}',{5})", FlightNumber, date.ToShortDateString(), time, Destination, Arrival,CarrierID);

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

        public bool DeleteFlight(string FlightNumber)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string queryString = string.Format("Delete from tblFlight where flightNumber = '{0}'", FlightNumber);

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

        public bool UPDFlight( string FlightNumber,DateTime Date, TimeSpan Time,string Destination,string Arrival,int CarrierID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            string queryString = string.Format("Update tblFlight set [Date]='" + Date.ToShortDateString() + "'" + ",[Time]='" + Time + 
                "',Destination='" + Destination + "',Arrival='" + Arrival +" ,CarrierID="+CarrierID + "' where FlightNumber=" + FlightNumber);

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
    }
}
