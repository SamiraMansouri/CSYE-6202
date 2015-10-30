using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    class BaseType
    {
        public static int Count { get; private set; }
        public string Name { get; set; }
        public  double ResultCarbonFootPrint { get;  set; }

        public virtual double  CalculatFootPrints(double FootPrint)
        {
            ResultCarbonFootPrint = 0;
            return ResultCarbonFootPrint;
        }

        public static void IncreamentCount()
        {
            Count++;
        }
    }
}
