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
    class BA_Crew
    {
        DA_Crew DACrew = new DA_Crew();

        public int AddCrew(Crew  crew)
        {
            int result = 0;


            result = DACrew.AddCrew(crew.FlightNumber, Convert.ToInt32(crew.ID), crew.FirstName, crew.LastName, crew.Type, crew.Title, crew.birthdate, crew.Phone, crew.Address);
            return result;
        }

        public List<Crew> GetAllCrews()
        {
            Crew crew = null;
            DataTable dt = DACrew.SearchCrew("");
            List<Crew> crews = new List<Crew>();
            
            if (dt.Rows.Count > 0)
            {

                foreach (DataRow row in dt.Rows)
                {

                    crew = new Crew(row["FirstName"].ToString(), row["LastName"].ToString(), row["EmployeeID"].ToString(), Convert.ToDateTime(row["Birthdate"].ToString()),
                                                    row["Phone"].ToString(), row["Address"].ToString(), row["Type"].ToString(), row["Title"].ToString(), row["FlightNumber"].ToString());

                    crews.Add(crew);
                }

            }

            return crews;
        }

        public Crew SearchCrew(string Query)
        {
            Crew  crew=null;
            DataTable dt = DACrew.SearchCrew(Query);
            if (dt.Rows.Count>0)
            {
                crew = new Crew();
                crew = new Crew(dt.Rows[0]["FirstName"].ToString(), dt.Rows[0]["LastName"].ToString(), dt.Rows[0]["EmployeeID"].ToString(), Convert.ToDateTime(dt.Rows[0]["Birthdate"].ToString()),
                                                   dt.Rows[0]["Phone"].ToString(), dt.Rows[0]["Address"].ToString(), dt.Rows[0]["Type"].ToString(), dt.Rows[0]["Title"].ToString(), dt.Rows[0]["FlightNumber"].ToString());

            }

            return crew;
        }

        public int DeleteCrew(string FlightNumber,int ID)
        {
            return DACrew.DeleteCrew(FlightNumber, ID);
        }

        public int UpdateCrew(Crew  crew)
        {
            return DACrew.UpdateCrew(crew.FlightNumber, int.Parse(crew.ID), crew.FirstName, crew.LastName, crew.Type, crew.Title, crew.birthdate, crew.Phone, crew.Address);
            
        }
        
    }
}
