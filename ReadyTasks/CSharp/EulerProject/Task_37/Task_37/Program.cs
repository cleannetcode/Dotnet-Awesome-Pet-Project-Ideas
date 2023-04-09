using System;

namespace Task_37
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

        static bool IsLeftDeletePrime(int numb)
        {
            while (numb > 0)
            {
                if (!IsPrime(numb))
                {
                    return false;
                }
                numb /= 10;
            }
            return true;
        }

        static int GetDigitCount(int numb)
        {
            int result = 0;
            while (numb > 0)
            {
                result++;
                numb /= 10;
            }
            return result;
        }

        static bool IsRightDeletePrime(int numb)
        {
            int digitCount = GetDigitCount(numb);
            int power = (int)Math.Pow(10, digitCount);

            while (power > 1)
            {
                numb %= power;
                if (!IsPrime(numb))
                {
                    return false;
                }
                power /= 10;
            }
            return true;
        }

        static bool HasProperty(int numb)
        {
            return IsRightDeletePrime(numb) && IsLeftDeletePrime(numb);
        }

        static int GetResult(int max)
        {
            int start = 11;
            int sum = 0;

            while (max > 0)
            {
                if (HasProperty(start))
                {
                    sum += start;
                    max--;
                }
                start += 2;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(11));
        }
    }
}
