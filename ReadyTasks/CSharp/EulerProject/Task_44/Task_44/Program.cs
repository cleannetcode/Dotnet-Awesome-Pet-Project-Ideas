using System;
using System.Collections.Generic;

namespace Task_44
{
    class Program
    {
        static long GetMinDifference()
        {
            HashSet<long> hashset = new HashSet<long>();
            long min = -1;
            long start = 1000;
            while (min == -1)
            {
                for (long i = 1; i <= start; i++)
                {
                    long sum = (i * (3 * i - 1)) / 2;
                    hashset.Add(sum);
                }
                foreach (var c in hashset)
                {
                    foreach (var b in hashset)
                    {
                        if ((hashset.Contains(c + b) && hashset.Contains(c - b)))
                        {
                            min = (min == -1) ? c - b : Math.Min(min, c - b);
                        }
                    }
                }
                start *= 10L;
            }
            return min;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetMinDifference());
        }
    }
}
