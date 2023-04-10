using System;
using System.Numerics;

namespace Task_25
{
    class Program
    {
        static int GetFirstFibonacciWithDigits(int max)
        {
            int ind = 1;
            BigInteger a = 1;
            BigInteger b = 1;
            while (a.ToString().Length < max)
            {
                var temp = b;
                b += a;
                a = temp;
                ind++;
            }
            return ind;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetFirstFibonacciWithDigits(1000));
        }
    }
}
