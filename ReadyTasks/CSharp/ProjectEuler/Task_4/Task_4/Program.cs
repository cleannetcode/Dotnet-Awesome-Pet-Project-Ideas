using System;

namespace Task_4
{
    class Program
    {
        static int GetReverseNumber(int numb)
        {
            int result = 0;
            while(numb > 0)
            {
                result *= 10;
                result += numb % 10;
                numb /= 10;
            }
            return result;
        }

        static bool IsPallindrome(int numb)
        {
            return numb == GetReverseNumber(numb);
        }

        static int GetMaxProduct(int max1, int max2)
        {
            int result = 0;
            for (int i = 1; i <= max1; i++)
            {
                for (int j = 1; j <= max2; j++)
                {
                    int product = i * j;
                    if (IsPallindrome(product))
                    {
                        result = Math.Max(result, product);
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetMaxProduct(999, 999));
        }
    }
}
