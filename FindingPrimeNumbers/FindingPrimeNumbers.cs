namespace FindingPrimeNumbers
{
	public class FindingPrimeNumbers
	{
		public long FindSumOfPrimeNumbers(int n)
		{
			long sum = 0;
            
            int count = 0;
            int num = 0;

            while (count < n)
            {
                if (IsPrime(num))
                {
                    sum += num;
                    count++;
                }
                num++;
            }
            
            return sum;
		}

        private bool IsPrime(int Num)
        {
            bool result = true;
            if (Num < 2)
            {
                result = false;
            }
            else if (Num == 2)
            {
                result = true;
            }
            else if (Num % 2 == 0)
            {
                result = false;
            }
            else if ((Num % 2) != 0)
            {
                for (int i = 2; i < Num; i++)
                {
                    if (Num % i == 0)
                    {
                        result = false;
                        break;
                    }

                }
            }
            return result;
        }
    }
}
