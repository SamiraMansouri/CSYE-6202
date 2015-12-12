using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline_Registration.Data_Access;
using Airline_Registration.Casses;
using System.Data;

namespace Airline_Registration.Business
{
    class BA_Customer
    {
        DA_Customer DACustomer = new DA_Customer();

        public List <customer> GetAllCustomer()
        {
            
            DataTable dt = DACustomer.GetAllCustomers();
            List<customer> customers = new List<customer>();
            customer customer;
            foreach (DataRow row in dt.Rows)
            {
                DateTime? BirthDate;
                try
                {
                    BirthDate = Convert.ToDateTime(row["Birthdate"]).Date;
                }
                catch (Exception e)
                {

                    BirthDate = null;
                }

                customer = new customer( row["FirstName"].ToString(), row["LastName"].ToString(), row["ID"].ToString(), row["Phone"].ToString(), row["Address"].ToString(),BirthDate);
                customers.Add(customer);
            }

            return customers;
        }
        
        public List<customer> GetFlightCustomers(string FlightNumber)
        {

            List<customer> Passengers = new List<customer>();
            try
            {
                DataTable dt = DACustomer.GetFlightCustomers(FlightNumber);

                customer Customer;
                foreach (DataRow row in dt.Rows)
                {
                    DateTime? BirthDate;
                    try
                    {
                        BirthDate = Convert.ToDateTime(row["Birthdate"]).Date;
                    }
                    catch (Exception e)
                    {

                        BirthDate = null;
                    }

                    Customer = new customer(row["FirstName"].ToString(), row["LastName"].ToString(), row["ID"].ToString(),
                                            row["Phone"].ToString(), row["Address"].ToString(), BirthDate);
                    Passengers.Add(Customer);
                }
            }
            catch (Exception e)
            {

                throw;
            }


            return Passengers;
        }

    }
}
