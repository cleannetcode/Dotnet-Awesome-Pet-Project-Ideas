using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_43
{
    class Program
    {
        static List<string> GeneratePermutations(string characters, bool[] isChosen = null, string curr = "", List<string> result = null)
        {
            isChosen ??= new bool[characters.Length];
            result ??= new List<string>();
            if (curr.Length == characters.Length)
            {
                result.Add(curr);
                return result;
            }
            else
            {
                for (int i = 0; i < characters.Length; i++)
                {
                    if (!isChosen[i])
                    {
                        isChosen[i] = true;
                        GeneratePermutations(characters, isChosen, curr + characters[i], result);
                        isChosen[i] = false;
                    }
                }
                return result;
            }
        }

        static bool CheckProperty(string numb, int start, int val, int[] arr)
        {
            int ind = 0;
            for (int i = start; i <= (numb.Length - val); i++)
            {
                int currNumb = Convert.ToInt32(numb.Substring(i, val));
                if (currNumb % arr[ind] != 0)
                {
                    return false;
                }
                ind++;
            }
            return true;
        }

        static long GetResult()
        {
            return GeneratePermutations("0123456789").Where(x => CheckProperty(x, 1, 3, new int[] { 2, 3, 5, 7, 11, 13, 17 })).
                   Select(x => Convert.ToInt64(x)).Sum();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetResult());
        }
    }
}
