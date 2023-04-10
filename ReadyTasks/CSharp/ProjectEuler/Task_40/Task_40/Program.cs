using System;
using System.Text;

namespace Task_40
{
    class Program
    {
        static int GetIntegerAtPos(int ind)
        {
            ind--;
            int digits = 1;
            int start = 1;
            while (digits * start * 9 < ind)
            {
                ind -= digits * start * 9;
                start *= 10;
                digits++;
            }
            int numb = start + ind / digits;
            int pos = ind % digits;
            return numb.ToString()[pos] - '0';
        }

        static int GetIntegerAtPos2(int ind)
        {
            ind--;
            StringBuilder start = new StringBuilder(ind + 3);
            for (int i = 1; start.Length <= ind; i++)
            {
                start.Append(i.ToString());
            }
            return start[ind] - '0';
        }
        static int GetProduct(int[] arr)
        {
            int result = 1;
            foreach (var c in arr)
            {
                result *= GetIntegerAtPos(c);
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetProduct(new int[] { 1, 10, 100, 1000, 10000, 100000, 1000000 }));
        }
    }
}
