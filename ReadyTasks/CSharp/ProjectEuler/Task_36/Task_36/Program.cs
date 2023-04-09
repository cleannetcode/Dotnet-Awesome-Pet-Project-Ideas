using System;

namespace Task_36
{
    class Program
    {
        static int GetReverse(int numb, int baseVal = 10)
        {
            int result = 0;
            while (numb > 0)
            {
                result *= baseVal;
                result += numb % baseVal;
                numb /= baseVal;
            }
            return result;
        }

        static int GetResult(int max)
        {
            int sum = 0;
            for (int i = 1; i < max; i++)
            {
                if (i == GetReverse(i, 10) && i == GetReverse(i, 2))
                {
                    sum += i;
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(1000000));
        }
    }
}
