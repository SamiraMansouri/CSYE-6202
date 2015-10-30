using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    class Car : BaseType
    {
        public double GasGalons { get; private set; }
        public override double CalculatFootPrints(double FootPrint)
        {
            GasGalons = FootPrint;
            ResultCarbonFootPrint = 15 * FootPrint;
            return ResultCarbonFootPrint;
        }
    }
}
