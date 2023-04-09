using System;
using System.Numerics;

namespace Task_17
{
    class Program
    {
        static BigInteger GetFactorial(int numb)
        {
            BigInteger start = BigInteger.One;
            for (int i = 2; i <= numb; i++)
            {
                start *= i;
            }
            return start;
        }
        static int GetFactorialSum(int numb)
        {
            int result = 0;
            BigInteger fact = GetFactorial(numb);
            while (fact > 0)
            {
                result += (int)(fact % 10);
                fact /= 10;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetFactorialSum(100));
        }
    }
}
