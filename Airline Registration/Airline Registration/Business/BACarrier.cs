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
    class BACarrier
    {
        DACarrier DAcarrier = new DACarrier();

        public int AddCarrier(Carrier carrier)
        {
            int result=0;

            List<Carrier> carriers = new List<Carrier>();
            foreach (Carrier _carrier in carriers)
            {
                if (_carrier.Name==carrier.Name)
                {
                    result = -1;
                    break;
                }
            }

            if (result!=-1)
            {
                bool flag;
               flag= DAcarrier.AddCarrier(carrier.Name, carrier.Origion, carrier.WebSite, carrier.Address, carrier.Phone);
                if (!flag)
                {
                    result = -2;
                }
            }
            
            return result;
        }

        public List <Carrier> GetAllCarriers()
        {
            DataTable dt = DAcarrier.GetAllCarriers();
            List<Carrier> carriers = InitializeCarrierList(dt);

            return carriers;
        }
     
        public Carrier SearchCarrier(string Query)
        {
            Carrier carrier;
            DataTable dt = DAcarrier.SearchCarrier(Query);
            carrier = new Carrier(int.Parse(dt.Rows[0]["ID"].ToString()), dt.Rows[0]["Name"].ToString(), dt.Rows[0]["Origion"].ToString(),
                                    dt.Rows[0]["Website"].ToString() , dt.Rows[0]["Address"].ToString(), dt.Rows[0]["Phone"].ToString());
           

            return carrier;
        }

        public bool DeleteCarrier(int ID)
        {
            return DAcarrier.DeleteCarrier(ID);
        }

        public bool UpdateCarrier(Carrier carrier)
        {
            bool result=true;

            result=DAcarrier.UpdateCarrier( carrier.ID, carrier.Origion, carrier.WebSite, carrier.Address, carrier.Phone);
            return result;
        }

        private List<Carrier> InitializeCarrierList(DataTable dt)
        {
            List<Carrier> carriers = new List<Carrier>();
            Carrier carrier;
            foreach (DataRow row in dt.Rows)
            {
                carrier = new Carrier(Convert.ToInt32(row["ID"].ToString()), row["Name"].ToString(), row["Origion"].ToString(),
                                    row["Website"].ToString(), row["Address"].ToString(), row["Phone"].ToString());

                carriers.Add(carrier);
            }
            return carriers;
        }
    }
}
