using System;
using System.Collections.Generic;

namespace Task_26
{
    class Program
    {
        static int GetLongestCycle(int n, int d)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>() { { n, 0 } };
            int ind = 0;
            while (n > 0)
            {
                n %= d;
                n *= 10;
                ind++;
                if (dict.ContainsKey(n))
                {
                    return ind - dict[n];
                }
                else
                {
                    dict.Add(n, ind);
                }
            }
            return -1;
        }

        static int GetResult(int maxD)
        {
            int maxCycle = 0;
            int result = 0;
            for (int i = 2; i < maxD; i++)
            {
                int newCycle = GetLongestCycle(1, i);
                if (newCycle >= maxCycle)
                {
                    maxCycle = newCycle;
                    result = i;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(1000));
        }
    }
}
