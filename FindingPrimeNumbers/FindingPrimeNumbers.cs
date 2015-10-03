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
                if (this.IsPrime(num))
                {
                    sum += num;
                    count++;
                }

                num++;
            }
            
            return sum;
		}

        private bool IsPrime(int num)
        {
            bool result = true;
            if (num < 2)
            {
                result = false;
            }
            else if (num == 2)
            {
                result = true;
            }
            else if (num % 2 == 0)
            {
                result = false;
            }
            else if ((num % 2) != 0)
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
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
