using System;

namespace Task_27
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

        static int GetMaxPrimes(int a, int b)
        {
            int n = 0;
            while (IsPrime(n * n + a * n + b))
            {
                n++;
            }
            return n;
        }

        static int GetResult(int minA, int maxA, int minB, int maxB)
        {
            int res = 0;
            int a = 0;
            int b = 0;
            for (int i = minA; i <= maxA; i++)
            {
                for (int j = minB; j <= maxB; j++)
                {
                    int newRes = GetMaxPrimes(i, j);
                    if (newRes > res)
                    {
                        res = newRes;
                        a = i;
                        b = j;
                    }
                }
            }
            return a * b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(-1000,1000,-1000,1000));
        }
    }
}
