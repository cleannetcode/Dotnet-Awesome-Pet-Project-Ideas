using System;
using System.Numerics;
using System.Collections.Generic;

namespace CollatzConjecture
{
    class Program
    {
        static List<BigInteger> CollatzConjecture(BigInteger numb)
        {
            List<BigInteger> result = new List<BigInteger>();
            while (numb > 1)
            {
                result.Add(numb);
                if (numb % 2 == 0)
                {
                    numb /= 2;
                }
                else
                {
                    numb = numb * 3 + 1;
                }
            }
            result.Add(1);
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Write number: ");
            int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Collatz sequence: {0}", String.Join(", ", CollatzConjecture(val)));
        }
    }
}
