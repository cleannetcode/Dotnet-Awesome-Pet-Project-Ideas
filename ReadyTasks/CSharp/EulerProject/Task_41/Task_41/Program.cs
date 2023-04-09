using System;

namespace Task_41
{
    class Program
    {
        static bool IsPrime(int numb)
        {
            for (int i = 2; i * i <= numb; i++)
            {
                if (numb % i == 0)
                {
                    return false;
                }
            }
            return numb > 1;
        }

        static bool IsPandigital(int numb)
        {
            int[] arr = new int[9];
            while (numb > 0)
            {
                if (numb % 10 == 0)
                {
                    return false;
                }
                arr[numb % 10 - 1]++;
                numb /= 10;
            }
            bool isOnes = true;
            foreach (var c in arr)
            {
                if (c > 1)
                {
                    return false;
                }
                else if (c == 1 && !isOnes)
                {
                    return false;
                }
                else if (c == 0)
                {
                    isOnes = false;
                }
            }
            return true;
        }

        static int GetResult()
        {
            int result = 0;
            for (int i = 0; i < 100000000; i++)
            {
                if (IsPandigital(i) && IsPrime(i))
                {
                    result = i;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetResult());
        }
    }
}
