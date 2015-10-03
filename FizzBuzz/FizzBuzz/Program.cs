

namespace FizzBuzz
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please Enter Your Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            FizzBuzz cls = new FizzBuzz();
            string result = cls.RunFizzBuzz(num);

            Console.WriteLine("The Result Is:" + result);
            Console.ReadLine();
        }
    }
}
