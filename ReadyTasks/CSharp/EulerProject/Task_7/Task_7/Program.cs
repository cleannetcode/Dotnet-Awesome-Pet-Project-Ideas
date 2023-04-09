using System;

namespace Task_7
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

        static int GetPrime(int ind)
        {
            int numb = 1;
            while (ind > 0)
            {
                numb++;
                if (IsPrime(numb))
                {
                    ind--;
                }
            }
            return numb;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetPrime(10001));
        }
    }
}
