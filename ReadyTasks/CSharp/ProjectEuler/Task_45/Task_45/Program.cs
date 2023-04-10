using System;

namespace Task_45
{
    class Program
    {
        static bool IsTriangle(long numb)
        {
            // 2 * x == n * n + n
            double D = Math.Sqrt(1 + 8 * numb);
            double x = (-1 + D) / 2;
            return x > 0 && x % 1 == 0;
        }

        static bool IsPentagonal(long numb)
        {
            // 2 * x == 3 * n * n - n
            double D = Math.Sqrt(1 + 24 * numb);
            double x = (1 + D) / 6;
            return x > 0 && x % 1 == 0;
        }

        static bool IsHexagonal(long numb)
        {
            // x == 2 * n * n - n
            double D = Math.Sqrt(1 + 8 * numb);
            double x = (1 + D) / 2;
            return x > 0 && x % 1 == 0;
        }

        static long GetVal(int ind)
        {
            for (long i = 1; ; i++)
            {
                long hexNumb = i * (2 * i - 1);
                if (IsPentagonal(hexNumb) && IsTriangle(hexNumb))
                {
                    if (ind == 0)
                    {
                        return hexNumb;
                    }
                    else
                    {
                        ind--;
                    }
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetVal(3));
        }
    }
}
