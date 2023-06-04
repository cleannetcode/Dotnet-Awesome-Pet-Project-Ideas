using System;
using System.Collections.Generic;

namespace Task_50
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

        static List<long> GetNumbers(int max)
        {
            List<long> result = new List<long>();
            for (int i = 2; i <= max; i++)
            {
                if (IsPrime(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        static long GetResult(int max)
        {
            var res = GetNumbers(max);
            var hashset = new HashSet<long>(res);
            int maxInd = 0;
            long result = 0;
            
            for (int i = 1; i < res.Count; i++)
            {
                res[i] += res[i - 1];
            }

            for (int i = 0; i < res.Count; i++)
            {
                for (int j = res.Count - 1; j > (i + maxInd); j--)
                {
                    long sum = res[j] - res[i];
                    if (sum < max && (j - i) > maxInd && hashset.Contains(sum))
                    {
                        maxInd = j - i;
                        result = sum;
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(1000000));
        }
    }
}
