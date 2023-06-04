using System;
using System.Collections.Generic;

namespace TemperatureConversion
{
    enum TemperatureTypes
    {
        Kelvin,
        Celsius,
        Fahrenheit,
    }

    class Program
    {
        static Dictionary<TemperatureTypes, Func<double, double>> FromCelsius = new Dictionary<TemperatureTypes, Func<double, double>>()
        {
            {TemperatureTypes.Celsius, x => x },
            {TemperatureTypes.Fahrenheit, x => 1.8 * x + 32.0 },
            {TemperatureTypes.Kelvin, x => x + 273.13 }
        };

        static Dictionary<TemperatureTypes, Func<double, double>> ToCelsius = new Dictionary<TemperatureTypes, Func<double, double>>()
        {
            {TemperatureTypes.Celsius, x => x },
            {TemperatureTypes.Fahrenheit, x => 5.0 * (x - 32.0) / 9.0 },
            {TemperatureTypes.Kelvin, x => x - 273.13 }
        };

        static double ConvertToTemp(double temp, TemperatureTypes from, TemperatureTypes to)
        {
            double inCelsius = Program.ToCelsius[from](temp);
            return Program.FromCelsius[to](inCelsius);
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + ": " + ConvertToTemp(i, TemperatureTypes.Celsius, TemperatureTypes.Celsius));
                Console.WriteLine(i + ": " + ConvertToTemp(i, TemperatureTypes.Fahrenheit, TemperatureTypes.Fahrenheit));
                Console.WriteLine(i + ": " + ConvertToTemp(i, TemperatureTypes.Kelvin, TemperatureTypes.Kelvin));
            }
        }
    }
}
