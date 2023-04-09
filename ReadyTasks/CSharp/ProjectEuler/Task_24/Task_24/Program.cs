using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_24
{
    class Program
    {
        static int Factorial(int numb)
        {
            return Enumerable.Range(1, numb).Aggregate(1, (acc, x) => acc * x);
        }
        static string GetResult(List<int> nums, int order)
        {
            string result = "";
            for (int i = nums.Count; i >= 1; i--)
            {
                int fact = Factorial(i - 1);
                int ind = order / fact;
                result += nums[ind];
                nums.RemoveAt(ind);
                order %= fact;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(new List<int>() {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 999999));
        }
    }
}
