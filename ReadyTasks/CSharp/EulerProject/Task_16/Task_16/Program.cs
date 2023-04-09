using System;
using System.Numerics;

namespace Task_16
{
    class Program
    {
        static int GetPowerSum(int numb, int power)
        {
            BigInteger res = BigInteger.Pow(numb, power);
            int result = 0;
            while (res > BigInteger.Zero)
            {
                result += (int)(res % 10);
                res /= 10;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetPowerSum(2, 1000));
        }
    }
}
