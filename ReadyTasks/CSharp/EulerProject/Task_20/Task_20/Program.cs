using System;
using System.Numerics;
using System.Linq;

namespace Task_20
{
    class Program
    {
        static BigInteger Factorial(int num)
        {
            return Enumerable.Range(1, num).Aggregate(new BigInteger(1), (acc, x) => acc * x);
        }

        static int GetDigitSum(int ord)
        {
            BigInteger num = Factorial(ord);
            int result = 0;
            while (num > 0)
            {
                result += (int)(num % 10);
                num /= 10;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetDigitSum(100));
        }
    }
}