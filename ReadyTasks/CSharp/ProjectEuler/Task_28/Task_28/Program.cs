using System;

namespace Task_28
{
    class Program
    {
        static long GetResult(int k)
        {
            k /= 2;
            long result = 0;
            for (int i = 0; i <= k; i++)
            {
                result += 4 * (2 * i + 1) * (2 * i + 1) - 12 * i;
            }
            return result - 3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(1001));
        }
    }
}
