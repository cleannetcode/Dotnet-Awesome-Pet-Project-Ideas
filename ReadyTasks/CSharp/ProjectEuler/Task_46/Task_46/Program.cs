using System;
using System.Collections.Generic;

namespace Task_46
{
    class Program
    {
        static bool IsPrime(int numb)
        {
            for (int i = 2; i * i <= numb; i++)
            {
                if (numb % i == 0)
                {
                    return false;
                }
            }
            return numb > 1;
        }

        static bool IsSqrt(int numb)
        {
            int val = (int)Math.Sqrt(numb);
            return val * val == numb;
        }

        static int GetResult()
        {
            List<int> primes = new List<int>() { 2 };
            for (int i = 3; ; i += 2)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
                else
                {
                    bool canBeWritten = false;
                    foreach (var c in primes)
                    {
                        if ((i - c) % 2 == 0 && IsSqrt((i - c) / 2))
                        {
                            canBeWritten = true;
                            break;
                        }
                    }
                    if (!canBeWritten)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetResult());
        }
    }
}
