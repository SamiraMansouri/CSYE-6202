using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Registration.Data_Access
{
    class DA_Crew
    {
        string ConnectionString = "Data Source=APPLEAD7E;Initial Catalog=Airline Reservation System;Integrated Security=True";

        public int AddCrew(string FlightNumber, int EmployeeID, string FirstName, string LastName, string Type,string Title,DateTime? Birthdate,string phone,string Address)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string queryString = string.Format("Insert Into tblCrew (FlightNumber,EmployeeID,FirstName,LastName,Type,Title,Birthdate,Phone,Address) values" +
                "('{0}', {1}, '{2}', '{3}', '{4}','{5}','{6}','{7}','{8}')", FlightNumber, EmployeeID, FirstName, LastName, Type,Title,Birthdate,phone,Address);

            int result = 0;
            try
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {

                result = -1;
            }

            return result;

        }

        public DataTable SearchCrew(string Query)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            string queryString = "";
            if (Query=="")
            {
                queryString = "select * from tblCrew ";
            }
            else
            {
                queryString = "select * from tblCrew where"+Query;
            }
            
            SqlCommand command = new SqlCommand(queryString, connection);


            SqlDataAdapter dap = new SqlDataAdapter(command);
            command.Connection.Open();
            DataTable dt = new DataTable();
            dap.Fill(dt);
            command.Connection.Close();
            return dt;

        }

        public int DeleteCrew(string FlightNumber,int ID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string queryString = string.Format("Delete from tblCrew where FlightNumber = '{0}' and EmployeeID= {1}", FlightNumber, ID);

            int result = 0;
            try
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {

                result = -1;
            }

            return result;

        }

        public int UpdateCrew(string FlightNumber, int EmployeeID, string FirstName, string LastName,
                                string Type, string Title, DateTime? Birthdate, string phone, string Address)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            
            
            string queryString = string.Format("Update tblCrew set FirstName='" + FirstName + "' ,LastName='" + LastName + "'" +
                                                ",Type='" + Type + "',Title='" + Title + "' ,Birthdate='"+Birthdate+ "',Phone='" + phone + "'" +
                                                ",Address='" + Address + "' where FlightNumber='" + FlightNumber+ "' and EmployeeID=" + EmployeeID);

            int result = 0;
            try
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {

                result = -1;
            }

            return result;

        }
    }
}
