using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Task_22
{
    class Program
    {
        static int GetScore(string name)
        {
            int result = 0;
            foreach (var letter in name)
            {
                result += letter - 'A' + 1;
            }
            return result;
        }

        static long GetResult(string[] names)
        {
            long result = 0;
            for (int i = 0; i < names.Length; i++)
            {
                result += (i + 1) * GetScore(names[i]);
            }
            return result;
        }
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Daniel\OneDrive\Рабочий стол\Elements.txt";
            string[] names = File.ReadAllText(filePath).Split(',').Select(x => x.Substring(1, x.Length - 2)).OrderBy(x => x).ToArray();
            Console.WriteLine(GetResult(names));
        }
    }
}
