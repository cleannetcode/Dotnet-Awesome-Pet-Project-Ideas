using System;

namespace Task_34
{
    class Program
    {
        static int Factorial(int num)
        {
            int result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }

        static bool IsEqualToDigitsFactorial(int numb)
        {
            int copy = numb;
            int factorialDigitSum = 0;
            while (numb > 0)
            {
                factorialDigitSum += Factorial(numb % 10);
                numb /= 10;
            }
            return factorialDigitSum == copy;
        }

        static int GetSum()
        {
            int result = 0;
            int max = Factorial(9) * 10;
            for (int i = 10; i <= max; i++)
            {
                if (IsEqualToDigitsFactorial(i))
                {
                    result += i;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetSum());
        }
    }
}
