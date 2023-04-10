using System;

namespace Task_12
{
    class Program
    {
        static int CountDivs(int num)
        {
            int result = 0;
            for (int i = 1; i * i <= num; i++)
            {
                if (i * i == num)
                {
                    result++;
                }
                else if (num % i == 0)
                {
                    result += 2;
                }
            }
            return result;
        }

        static int GetResult(int max)
        {
            for (int i = 1; ; i++)
            {
                int numb = (i * (i + 1)) / 2;
                if (CountDivs(numb) > max)
                {
                    return numb;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(500));
        }
    }
}
