using System;

namespace Task_48
{
    class Program
    {
        static long GetResult(int max, long rem)
        {
            long result = 0;
            for (int i = 1; i <= max; i++)
            {
                long res = 1;
                for (int j = 0; j < i; j++)
                {
                    res *= i;
                    res %= rem;
                }
                result += res;
                result %= rem;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(1000, 10000000000L));
        }
    }
}
