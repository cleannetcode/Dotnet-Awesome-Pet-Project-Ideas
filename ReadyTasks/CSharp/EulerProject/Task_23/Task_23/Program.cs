using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_23
{
    class Program
    {
        static int GetDivSum(int numb)
        {
            int result = 1;
            for (int i = 2; i * i <= numb; i++)
            {
                if (i * i == numb)
                {
                    result += i;
                }
                else if (numb % i == 0)
                {
                    result += i + numb / i;
                }
            }
            return result;
        }

        static bool IsAbundant(int numb)
        {
            return GetDivSum(numb) > numb;
        }

        static long GetResult(int maxNumb)
        {
            long result = 0;
            HashSet<int> abundantNumb = new HashSet<int>();
            Func<int, bool> canBeWrittenAsAbundantSuum = x =>
            {
                foreach (var c in abundantNumb)
                {
                    if (abundantNumb.Contains(x - c))
                    {
                        return false;
                    }
                }
                return true;
            };
            for (int i = 1; i <= maxNumb; i++)
            {
                if (IsAbundant(i))
                {
                    abundantNumb.Add(i);
                }
                if (canBeWrittenAsAbundantSuum(i))
                {
                    result += i;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(30000));
        }
    }
}
