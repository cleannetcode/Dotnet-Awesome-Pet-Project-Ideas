using System;

namespace Task_19
{
    class Program
    {
        static int GetResult(int startYear, int endYear)
        {
            int result = 0;
            DateTime start = new DateTime(startYear, 1, 1);
            while (start.Year <= endYear)
            {
                if (start.DayOfWeek == DayOfWeek.Sunday)
                {
                    result++;
                }
                start = start.AddMonths(1);
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetResult(1901, 2000));
        }
    }
}
