using System;
using System.Linq;

namespace Task_38
{
    class Program
    {
        static bool IsPandigital(string numb)
        {
            if (numb.Length != 9)
            {
                return false;
            }

            int[] val = new int[9];
            foreach (var c in numb)
            {
                int ind = c - '1';
                if (ind < 0 || ind > 9)
                {
                    return false;
                }
                val[ind]++;
                if (val[ind] > 1)
                {
                    return false;
                }
            }
            return true;
        }

        static string GetResult()
        {
            string result = "";
            for (int i = 1; i < 10000; i++)
            {
                int ind = 1;
                string numb = "";
                while (numb.Length < 9)
                {
                    numb += i * ind;
                    ind++;
                }
                if (IsPandigital(numb) && String.Compare(result, numb) < 0)
                {
                    result = numb;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetResult());
        }
    }
}
