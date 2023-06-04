using System;

namespace Task_2
{
    class Program
    {
        static int GetResult(int max)
        {
            int a = 1;
            int b = 2;
            int sum = 0;
            while (a < max)
            {
                if (a % 2 == 0)
                {
                    sum += a;
                }
                int temp = b;
                b += a;
                a = temp;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(4000000));
        }
    }
}
