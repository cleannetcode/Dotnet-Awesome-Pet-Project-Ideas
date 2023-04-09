using System;
using System.Numerics;
using System.Collections.Generic;

namespace Task_29
{
    class Program
    {
        static int GetDigitSum(BigInteger numb)
        {
            int result = 0;
            while (numb > 0)
            {
                result += (int)(numb % 10);
                numb /= 10;
            }
            return result;
        }

        static int GetResult(int minA, int maxA, int minB, int maxB)
        {
            HashSet<BigInteger> hashset = new HashSet<BigInteger>();
            for (int a = minA; a <= maxA; a++)
            {
                for (int b = minB; b <= maxB; b++)
                {
                    hashset.Add(BigInteger.Pow(a, b));
                }
            }
            return hashset.Count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(2, 100, 2, 100));
        }
    }
}
