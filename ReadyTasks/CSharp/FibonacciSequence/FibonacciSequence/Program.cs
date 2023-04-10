using System;
using System.Collections;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;

namespace FibonacciSequence
{
    internal class Program
    {
        static BigInteger GetFibonacciAtInd(int ind)
        {
            BigInteger a = BigInteger.One;
            BigInteger b = BigInteger.One;

            for (int i = 0; i < ind; i++) {
                BigInteger tenp = b;
                b += a;
                a = tenp;
            }

            return a;
        }

        static IEnumerable<BigInteger> GetFibonacciSequence() {
            BigInteger a = BigInteger.One;
            BigInteger b = BigInteger.One;

            while (true)
            {
                yield return a;
                BigInteger tenp = b;
                b += a;
                a = tenp;
            }
        }
        static void Main(string[] args)
        {
            int ind = 0;
            Console.WriteLine("Fibonacci sequence: ");
            foreach (var elem in GetFibonacciSequence().Take(10))
            {
                Console.WriteLine("Fibonacci number at index {0}: {1}", ind, elem);
                ind++;
            }

            Console.WriteLine("\n\nFibonacci numbers at indexes");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Fibonacci number at index {0}: {1}", i, GetFibonacciAtInd(i));
                ind++;
            }
        }
    }
}
