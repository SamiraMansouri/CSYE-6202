namespace GasPump
{
    using System;
    public class Program
	{
		public enum GasType
		{
			None,
			RegularGas,
			MidgradeGas,
			PremiumGas,
			DieselFuel				
		}

        static void Main(string[] args)
        {
            while (true)
            {
                loop:
                
                    Console.Write("Please enter purchased gas type, Q/qto quit:");
                    string gastTypeChar = Console.ReadLine().ToString();
                    if (UserEnteredSentinelValue(gastTypeChar))
                    {
                        Environment.Exit(9);
                    }

                    else if (UserEnteredValidGasType(gastTypeChar))
                    {
                        Console.Write("Please enter purchased gas amount, Q/q to quit:");
                        string gasAmount = Console.Read().ToString();
                        if (UserEnteredSentinelValue(gastTypeChar))
                        {
                            Environment.Exit(9);
                        }
                        else if (UserEnteredValidAmount(gasAmount))
                        {
                            GasType gasType = GasTypeMapper(Convert.ToChar(gastTypeChar));
                            double totalCost = 0;
                            CalculateTotalCost(gasType, Convert.ToInt32(gasAmount), ref totalCost);
                            Console.WriteLine("You bought" + gasAmount + "gallons of" + gasType + "at" + GasPriceMapper(gasType));
                            Console.WriteLine("Your total cost for this purchase is :" + totalCost.ToString());

                        }
                        else
                        {
                            Console.WriteLine("Please enter valid purchase gas amount.");
                            goto loop;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid purchase gas type.");
                        goto loop;
                    }
                }

		}

		// use this method to check and see if sentinel value is entered
		public static bool UserEnteredSentinelValue(string userInput)
		{
			var result = false;

            if (userInput.Contains("Q") || userInput.Contains("q"))
            {
                result = true;
            }

			return result;
		}

		// use this method to parse and check the characters entered
		// this does not conform 
		public static bool UserEnteredValidGasType(string userInput)
		{
			var result = false;
            string gasTypesCharacters = "PpMmRrDd";
            if (gasTypesCharacters.Contains(userInput) && userInput.Length==1)
            {
                result = true;
            }
            else
            {
                result = false;
            }
			return result;
		}

		// use this method to parse and check the double type entered
		// please use Double.TryParse() method 
		public static bool UserEnteredValidAmount(string userInput)
		{
			var result = false;

            if (Convert.ToInt32(userInput)<0)
            {
                result = true;
            }
            else 
            {
                result = false;
            }

			return result;
		}

		// use this method to map a valid char entry to its enum representation
		// e.g. User enters 'R' or 'r' --> this should be mapped to GasType.RegularGas
		// this mapping "must" be used within CalculateTotalCost() method later on
		public static GasType GasTypeMapper(char c)
		{
			GasType gasType = GasType.None;

            switch (c)
            {
                case 'r' :
                case 'R':
                    gasType=GasType.RegularGas;
                    break;

                case 'm':
                case 'M':
                    gasType = GasType.MidgradeGas;
                    break;

                case 'p':
                case 'P':
                    gasType = GasType.PremiumGas;
                    break;

                case 'd':
                case 'D':
                    gasType = GasType.DieselFuel;
                    break;

                default:
                    gasType = GasType.None;
                    break;

            }


            return gasType;
		}

		public static double GasPriceMapper(GasType gasType)
		{
			var result = 0.0;

            switch (gasType)
            {
                case GasType.DieselFuel:
                    result= 2.17;
                    break;

                case GasType.MidgradeGas:
                    result = 2;
                    break;

                case GasType.RegularGas:
                    result = 1.94;
                    break;

                case GasType.PremiumGas:
                    result = 2.24;
                    break;

            }

            return result;
	}

		public static void CalculateTotalCost(GasType gasType, int gasAmount, ref double totalCost)
		{
            double gasMap = GasPriceMapper(gasType);
            totalCost = gasAmount * gasMap;
		}
	}
}
