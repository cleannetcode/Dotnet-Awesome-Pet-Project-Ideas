using System;
using System.Collections.Generic;

namespace RadixBaseConverter
{
    internal class Program
    {
        static string Alphabet = "0123456789ABCDEF";

        static string ConvertToBase(int val, int radix)
        {
            Stack<char> result = new Stack<char>();
            int absVal = Math.Abs(val);
            while (absVal != 0)
            {
                result.Push(Program.Alphabet[absVal % radix]);
                absVal /= radix;
            }
            if (val < 0)
            {
                result.Push('-');
            }
            return String.Concat(result);
        }

        static void Main(string[] args)
        {
            Console.Write("Write number: ");
            int val = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write radix: ");
            int radix = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number {val} in radix {radix} is equal to {ConvertToBase(val, radix)}");
            Console.ReadKey();
        }
    }
}
