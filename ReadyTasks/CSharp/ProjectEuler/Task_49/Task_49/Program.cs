using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_49
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

        static string GetSorted(int numb)
        {
            return String.Concat(numb.ToString().OrderBy(x => x));
        }
        static List<string> GetResult()
        {
            Dictionary<string, HashSet<int>> dict = new Dictionary<string, HashSet<int>>();
            List<string> result = new List<string>();

            for (int i = 1000; i < 10000; i++)
            {
                if (!IsPrime(i))
                {
                    continue;
                }

                var str = GetSorted(i);
                if (dict.ContainsKey(str))
                {
                    dict[str].Add(i);
                }
                else
                {
                    dict.Add(str, new HashSet<int>() { i });
                }
            }

            foreach (var val in dict.Values)
            {
                foreach (var a in val)
                {
                    foreach (var b in val)
                    {
                        int d = b - a;
                        if (d > 0 && val.Contains(a + d) && val.Contains(a + 2 * d))
                        {
                            result.Add("" + a + (a + d) + (a + 2 * d));
                        }
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(String.Join("\n", GetResult()));
        }
    }
}
