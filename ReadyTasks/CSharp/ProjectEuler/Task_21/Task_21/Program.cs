using System;

namespace Task_21
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

        static bool IsAmicable(int numb)
        {
            int divSum = GetDivSum(numb);
            return numb != divSum && numb == GetDivSum(divSum);
        }
        static int GetResult(int max)
        {
            int result = 0;
            for (int i = 1; i <= max; i++)
            {
                if (IsAmicable(i))
                {
                    result += i;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(10000));
        }
    }
}
