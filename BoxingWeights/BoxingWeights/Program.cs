using System;
namespace BoxingWeights
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Please Enter Your Weight in Pounds:");
            int weightInPounds =Convert.ToInt32( Console.ReadLine());

            BoxingWeightClassifier clsFindCategoryofWeight = new BoxingWeightClassifier();
            string result = clsFindCategoryofWeight.ClassifyBoxingWeight(weightInPounds);

            Console.WriteLine("Category of the weight "+ weightInPounds.ToString()+ " in pound is: "+result+'\n');
            Console.Read();
            


        }
	}
}
