using System;
using System.Numerics;

namespace Task_15
{
    class Program
    {
        static BigInteger Composition(int n, int k)
        {
            BigInteger result = BigInteger.One;
            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }
            for (int i = 2; i <= (n - k); i++)
            {
                result /= i;
            }
            return result;
        }

        static BigInteger GetResult(int grid)
        {
            return Composition(grid * 2, grid);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(20));
        }
    }
}
