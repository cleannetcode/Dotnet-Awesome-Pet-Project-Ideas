using System;
using System.IO;
using System.Linq;

namespace Task_42
{
    class Program
    {
        static bool IsTriangle(int numb)
        {
            // n * n + n - 2 * x == 0
            double D = Math.Sqrt(1 + 8 * numb);
            double res = (-1 + D) / 2;
            return res > 0 && res % 1 == 0;
        }

        static int GetScore(string numb)
        {
            int result = 0;
            foreach (var c in numb)
            {
                result += c - 'A' + 1;
            }
            return result;
        }

        static int GetTriangleWords(string[] arr)
        {
            return arr.Count(x => IsTriangle(GetScore(x)));
        }

        static void Main(string[] args)
        {
            string[] arr = File.ReadAllText(@"C:\Users\Daniel\OneDrive\Рабочий стол\Elements.txt").Split(',').Select(x => x.Substring(1, x.Length - 2)).ToArray();
            Console.WriteLine(GetTriangleWords(arr));
        }
    }
}
