using System;

namespace Task_3
{
    class Program
    {
        static long GetResult(long num)
        {
            for (int i = 2; i * i <= num; i++)
            {
                while (num % i == 0)
                {
                    num /= i;
                }
                if (num == 1)
                {
                    return i;
                }
            }
            return num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(600851475143));
        }
    }
}
