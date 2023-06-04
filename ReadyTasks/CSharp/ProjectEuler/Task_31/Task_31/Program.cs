using System;

namespace Task_31
{
    class Program
    {
        static int GetResult(int max, int[] coins)
        {
            int[] result = new int[max + 1];
            result[0] = 1;
            foreach (var c in coins)
            {
                for (int i = c; i <= max; i++)
                {
                    result[i] += result[i - c];
                }
            }
            return result[max];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(200, new int[] {1,2,5,10,20,50,100,200}));
        }
    }
}
