using System;

namespace Task_47
{
    class Program
    {
        static int CountDivs(int numb)
        {
            int ind = 2;
            int count = 0;
            while (numb > 1)
            {
                if (numb % ind == 0)
                {
                    count++;
                    while (numb % ind == 0)
                    {
                        numb /= ind;
                    }
                }
                ind++;
            }
            return count;
        }

        static bool CheckProperty(int numb, int k)
        {
            for (int i = 0; i < k; i++)
            {
                if (CountDivs(numb + i) != k)
                {
                    return false;
                }
            }
            return true;
        }

        static int GetResult(int numb)
        {
            for (int i = 1; ; i++)
            {
                if (CheckProperty(i, numb))
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(4));
        }
    }
}
