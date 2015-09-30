using System;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.Write("Please Enter Your Number:");
            int Num = Convert.ToInt32(Console.ReadLine());

            FizzBuzz cls = new FizzBuzz();
            string Result = cls.RunFizzBuzz(Num);

            Console.WriteLine("The Result Is:" + Result);
            Console.ReadLine();
        }
	}
}
