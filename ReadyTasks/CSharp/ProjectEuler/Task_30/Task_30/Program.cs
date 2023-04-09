using System;
using System.Numerics;

namespace Task_30
{
    class Program
    {
        static BigInteger GetSumWithPow(BigInteger numb, int pow = 1)
        {
            BigInteger result = 0;
            while (numb > 0)
            {
                result += BigInteger.Pow(numb % 10, pow);
                numb /= 10;
            }
            return result;
        }

        static BigInteger GetResult(int pow)
        {
            BigInteger result = 0;
            BigInteger max = BigInteger.Pow(10, pow + 1);
            for (BigInteger i = 10; i <= max; i++)
            {
                if (i == GetSumWithPow(i, pow))
                {
                    result += i;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(5));
        }
    }
}
