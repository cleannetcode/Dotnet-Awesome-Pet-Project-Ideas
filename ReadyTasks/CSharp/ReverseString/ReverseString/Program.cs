using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static string ReverseString(string str)
        {
            return String.Concat(str.Reverse());
        }
        static void Main(string[] args)
        {
            Console.Write("Write string: ");
            string text = Console.ReadLine();
            Console.WriteLine("Reversed string is {0}", ReverseString(text));
        }
    }
}
