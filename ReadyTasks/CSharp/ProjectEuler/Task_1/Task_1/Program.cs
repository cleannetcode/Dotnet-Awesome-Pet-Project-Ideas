using System;

namespace Task_1
{
    class Program
    {
        static int GetResult(int max)
        {
            int three = (max - 1) / 3;
            int fives = (max - 1) / 5;
            int fifteens = (max - 1) / 15;
            return (3 * three * (three + 1) + 5 * fives * (fives + 1) - 15 * fifteens * (fifteens + 1)) / 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(1000));
        }
    }
}
