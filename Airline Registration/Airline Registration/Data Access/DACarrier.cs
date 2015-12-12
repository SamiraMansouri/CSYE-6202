using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Airline_Registration.Data_Access
{
    class DACarrier
    {
        string ConnectionString = "Data Source=APPLEAD7E;Initial Catalog=Airline Reservation System;Integrated Security=True";

        public bool AddCarrier(string Name,string Origion,string Website,string Address,string Phone)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string queryString =string.Format( "Insert Into tblCarrier (Name,Origion,WebSite,[Address],phone) values" +
                "('{0}', '{1}', '{2}', '{3}', '{4}')", Name,Origion,Website,Address,Phone);

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

                result=false;
            }

            return result;

			}

        public DataTable GetAllCarriers()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string queryString = "select * from tblCarrier";
            SqlCommand command = new SqlCommand(queryString, connection);


            SqlDataAdapter dap = new SqlDataAdapter(command);
            command.Connection.Open();
            DataTable dt = new DataTable();
            dap.Fill(dt);
            command.Connection.Close();
            return dt;
        
        }

        public DataTable SearchCarrier(string Query)
        {
            DataTable dt;
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                string queryString = "select * from tblCarrier where " + Query;
                SqlCommand command = new SqlCommand(queryString, connection);


                SqlDataAdapter dap = new SqlDataAdapter(command);
                command.Connection.Open();
                 dt= new DataTable();
                dap.Fill(dt);
                command.Connection.Close();
            }
            catch (Exception e)
            {

                throw;
            }
          
            return dt;

        }

        public bool DeleteCarrier(int ID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string queryString = string.Format("Delete from tblCarrier where ID = '{0}'", ID);

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

        public bool UpdateCarrier(int ID, string Origion, string Website, string Address, string Phone)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            string queryString = string.Format("Update tblCarrier set Origion='"+Origion+"' ,WebSite='"+Website+"'"+
                                                ",[Address]='"+Address+"',phone='"+Phone+"' where ID="+ID);

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
