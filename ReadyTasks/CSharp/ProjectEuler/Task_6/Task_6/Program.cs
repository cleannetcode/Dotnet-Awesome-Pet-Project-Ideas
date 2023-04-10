using System;
using System.Linq;

namespace Task_6
{
    class Program
    {
        static long GetResult(int max)
        {
            long sum = Enumerable.Range(1, max).Select(x => (long)x).Sum();
            long res = Enumerable.Range(1, max).Select(x => (long)(x * x)).Sum();
            return sum * sum - res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(100));
        }
    }
}
