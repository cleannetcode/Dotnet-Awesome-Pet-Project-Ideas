using System;
using System.Collections.Generic;

namespace Task_14
{
    class Program
    {
        static long GetResult(int max)
        {
            long result = 0;
            int maxSteps = 0;
            Dictionary<long, int> cache = new Dictionary<long, int>() { { 1, 0 } };
            for (long i = 2; i <= max; i++)
            {
                int steps = GetLongestCollatzChainLength(i, cache);
                cache.Add(i, steps);
                if (steps > maxSteps)
                {
                    maxSteps = steps;
                    result = i;
                }
            }
            return result;
        }
        static int GetLongestCollatzChainLength(long val, Dictionary<long, int> hashset = null)
        {
            int steps = 0;
            while (val > 1)
            {
                if (hashset != null && hashset.ContainsKey(val))
                {
                    return steps + hashset[val];
                }
                if (val % 2 == 0)
                {
                    val = val / 2;
                }
                else
                {
                    val = 3 * val + 1;
                }
                steps++;
            }
            return steps;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(1000000));
        }
    }
}
