using System;
using System.Numerics;

namespace Factorial
{
    internal class Program
    {
        static BigInteger Factorial(int num) {
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(num));
            }
            
            BigInteger result = BigInteger.One;
            for (int i = 2; i <= num; i++)
            {
                result = result * i;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Write number: ");
            int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial of numnber {0} is equal to {1}", val, Factorial(val));
        }
    }
}
