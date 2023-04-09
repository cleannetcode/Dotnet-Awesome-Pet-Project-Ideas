using System;

namespace Task_10
{
    class Program
    {
        static bool IsPrime(int numb)
        {
            for (int i = 2; i * i <= numb; i++)
            {
                if (numb % i == 0)
                {
                    return false;
                }
            }
            return numb > 1;
        }

        static long GetSum(int max)
        {
            long sum = 0;
            for (int i = 1; i <= max; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetSum(2000000));
        }
    }
}
