using System;
using System.Linq;

namespace Task_32
{
    class Program
    {
        static bool IsPandigital(string numb, int min, int max)
        {
            return String.Concat(Enumerable.Range(min, max - min + 1)) == String.Concat(numb.OrderBy(x => x));
        }

        static int GetSum(int min, int max)
        {
            int result = 0;
            int end = 100000;
            for (int i = 1; i <= end; i++)
            {
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        string res = "" + j + i / j + i;
                        if (IsPandigital(res, min, max))
                        {
                            result += i;
                            break;
                        }
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetSum(1, 9));
        }
    }
}
