using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static string GetFizzBuzzSeq(int numb)
        {
            if (numb % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (numb % 5 == 0)
            {
                return "Buzz";
            }
            else if (numb % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return numb.ToString();
            }
        }

        static IEnumerable<string> GetFizzBuzzSequence()
        {
            int st = 1;
            while (true)
            {
                yield return GetFizzBuzzSeq(st);
                st++;
            }
        }

        static void Main(string[] args)
        {
            foreach (var seqElem in GetFizzBuzzSequence().Take(10))
            {
                Console.WriteLine(seqElem);
            }
            Console.ReadKey();
        }
    }
}
