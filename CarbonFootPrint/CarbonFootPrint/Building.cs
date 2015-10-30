using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    class Building :BaseType
    {
        public double SquareFootPrint { get; private set; }
        public override double CalculatFootPrints(double FootPrint)
        {
            SquareFootPrint = FootPrint;
            ResultCarbonFootPrint = 50 * FootPrint;
            return ResultCarbonFootPrint;
        }
    }
}
