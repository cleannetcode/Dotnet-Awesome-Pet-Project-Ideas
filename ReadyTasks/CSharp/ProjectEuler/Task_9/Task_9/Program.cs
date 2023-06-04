using System;

namespace Task_9
{
    class Program
    {
        static long GetTriplet(long sum)
        {
            for (long a = 1; a <= sum; a++)
            {
                for (long b = a; b <= sum; b++)
                {
                    double cDouble = Math.Sqrt(a * a + b * b);
                    if (cDouble % 1 > 0)
                    {
                        continue;
                    }
                    long c = (long)cDouble;
                    if (c + a + b == sum)
                    {
                        return a * b * c;
                    }
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetTriplet(1000));
        }
    }
}
