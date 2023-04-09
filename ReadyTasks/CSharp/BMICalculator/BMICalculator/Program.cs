using System;

namespace BMICalculator
{
    class Program
    {
        static double GetBMIValue(double weightInKg, double heightInM)
        {
            return weightInKg / Math.Pow(heightInM, 2);
        }
        static void Main(string[] args)
        {
            Console.Write("Your weight in kilogramms: ");
            double userWeight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Your height in metres: ");
            double userHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your BMI is: {0}", GetBMIValue(userWeight, userHeight));
            Console.ReadKey();
        }
    }
}
