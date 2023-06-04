using System;

namespace Task_5
{
    class Program
    {
        static long GCD(long a, long b)
        {
            return (b == 0) ? a : GCD(b, a % b);
        }

        static long MaxVal(int max)
        {
            long result = 1;
            for (int i = 2; i <= max; i++)
            {
                long gcd = GCD(result, i);
                result *= i;
                result /= gcd;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MaxVal(20));
        }
    }
}
