using Airline_Registration.Casses;
using Airline_Registration.Data_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Registration.Business
{
    class BA_SeatType
    {
        DA_SeatType DASeatType = new DA_SeatType();

        public int AddSeatType(SeatType seatType)
        {
            int result = 0;
            try
            {

                DASeatType.AddSeatType(seatType.Type, seatType.Price, seatType.FlightNumber, seatType.StartSeat, seatType.EndSeat);
            }
            catch (Exception ex)
            {

                result = -1;
            }

            return result;
        }

        public int DeleteSeatType(SeatType seatType)
        {
            int result = 0;
            try
            {

                DASeatType.DeleteSeatType(seatType.ID);
            }
            catch (Exception ex)
            {

                result = -1;
            }
            return result;
        }

        public bool UpdateSeatType(SeatType seatType)
        {
            bool result = true;

            result = DASeatType.UpdateSeatType(seatType.ID, seatType.Type, seatType.Price,seatType.FlightNumber, seatType.StartSeat, seatType.EndSeat);
            return result;
        }

        public List<SeatType> SearchSeatType(string Query)
        {
            DataTable dt = DASeatType.SearchseatType(Query);
            List<SeatType> seatTypes = new List<SeatType>();
            SeatType seatType = null;
            if (dt.Rows.Count != 0)
            {
                
                foreach (DataRow row in dt.Rows)
                {
                    seatType = new SeatType(int.Parse(row["ID"].ToString()), row["Type"].ToString(), float.Parse(row["Price"].ToString()), row["FlightNumber"].ToString(), Convert.ToInt32(row["StartSeat"].ToString()), Convert.ToInt32(row["EndSeat"].ToString()));
                    seatTypes.Add(seatType);
                }
            }


            return seatTypes;
        }
    }
}
