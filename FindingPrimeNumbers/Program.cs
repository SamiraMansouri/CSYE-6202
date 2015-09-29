using System;
using FindingPrimeNumbers;
namespace FindingPrimeNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Please Enter Your Number:");
            int Num =Convert.ToInt32( Console.ReadLine());
            FindingPrimeNumbers Prime = new FindingPrimeNumbers();
            long Sum=Prime.FindSumOfPrimeNumbers(Num);
            Console.WriteLine("The Sum IS:"+Sum.ToString());
            Console.ReadLine();
		}
	}
}
																																																		