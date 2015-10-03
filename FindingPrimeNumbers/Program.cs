namespace FindingPrimeNumbers
{
    using System;
    class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Please Enter Your Number:");
            int num = Convert.ToInt32( Console.ReadLine());
            FindingPrimeNumbers prime = new FindingPrimeNumbers();
            long sum = prime.FindSumOfPrimeNumbers(num);
            Console.WriteLine("The Sum IS:" + sum.ToString());
            Console.ReadLine();
		}
	}
}