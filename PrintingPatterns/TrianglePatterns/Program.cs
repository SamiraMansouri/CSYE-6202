using System;

namespace TrianglePatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			DisplayPatternA();
			DisplayPatternB();
			DisplayPatternC();
			DisplayPatternD();

			Console.ReadLine();
		}

		static void DisplayPatternA()
		{
            Console.Write("Pattern A is: "+'\n');
            for (int i = 0; i < 10 ; i++)
            {
                for (int j = 0; j < (i+1); j++)
                {
                    Console.Write("*");
                }
                Console.Write('\n');
            }
            Console.Write('\n');
        }

		static void DisplayPatternB()
		{
            Console.Write("Pattern B is: " + '\n');
            for (int i = 11; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.Write('\n');
            }
            Console.Write('\n');
        }

		static void DisplayPatternC()
		{
            Console.Write("Pattern C is: " + '\n');
            for (int i = 11; i > 0; i--)
            {
                for (int k = (11 - i); k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = (i-1); j > 0; j--)
                {
                    Console.Write("*");
                }
               
                Console.Write('\n');
            }
            Console.Write('\n');
        }

		static void DisplayPatternD()
		{
            Console.Write("Pattern D is: " + '\n');
            for (int i = 11; i > 0; i--)
            {
                for (int j = (i - 1); j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = (11 - i); k > 0; k--)
                {
                    Console.Write("*");
                }
                Console.Write('\n');
            }
            Console.Write('\n');
        }
	}
}
