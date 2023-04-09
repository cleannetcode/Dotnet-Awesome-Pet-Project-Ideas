using System;
using System.Collections.Generic;

namespace Task_39
{
    class Program
    {
        static int GetResult(int max)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int a = 1; a < max / 2; a++)
            {
                for (int b = a + 1; b <= max / 2; b++)
                {
                    int sqrt = (int)Math.Sqrt(a * a + b * b);
                    if (sqrt * sqrt == (a * a + b * b))
                    {
                        int p = sqrt + a + b;
                        if (p < max)
                        {
                            if (dict.ContainsKey(p))
                            {
                                dict[p]++;
                            }
                            else
                            {
                                dict[p] = 1;
                            }
                        }
                    }
                }
            }
            int maxVal = 0;
            int result = 0;
            foreach (var key in dict.Keys)
            {
                if (maxVal < dict[key])
                {
                    maxVal = dict[key];
                    result = key;
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
