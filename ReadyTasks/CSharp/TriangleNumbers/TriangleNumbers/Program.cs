using System;
using System.Numerics;
using System.Collections.Generic;

namespace TriangleNumbers
{
    class Program
    {
        static BigInteger GetTriangleNumber(BigInteger numb)
        {
            return (numb * (numb + 1)) / 2;
        }

        static IEnumerable<BigInteger> GetTriangleSequence(BigInteger numb)
        {
            BigInteger start = 1;
            while (true)
            {
                yield return GetTriangleNumber(start);
                start += 1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
