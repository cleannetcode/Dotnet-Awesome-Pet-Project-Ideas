using System;

namespace Task_35
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

        static int GetDigitNumb(int numb)
        {
            int result = 0;
            while (numb > 0)
            {
                result++;
                numb /= 10;
            }
            return result;
        }

        static bool IsCircularPrime(int numb)
        {
            int mult = 1;
            int digitCount = GetDigitNumb(numb);
            int power = (int)Math.Pow(10, digitCount - 1);

            while (digitCount > 0)
            {
                if (!IsPrime(numb))
                {
                    return false;
                }

                numb = numb / 10 + (numb % 10 * power);
                digitCount--;
            }

            return true;
        }

        static int GetCircularPrimesNumb(int max)
        {
            int result = 0;
            for (int i = 1; i <= max; i++)
            {
                if (IsCircularPrime(i))
                {
                    result++;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetCircularPrimesNumb(1000000));
        }
    }
}
