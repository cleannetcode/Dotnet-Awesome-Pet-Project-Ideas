using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

// Unfinished: cross product
namespace CalculateDotAndCrossProductOfTwoVectors
{
    class Vector
    {
        public double[] Coordinates {
            get => this.coordinates;
        }

        private double[] coordinates;

        public Vector(double[] _coordinates)
        {
            this.coordinates = _coordinates;
        }

        public int Dimensions
        {
            get => this.Coordinates.Length;
        }

        public static Vector operator +(Vector a, Vector b)
        {
            if (a.Dimensions == b.Dimensions)
            {
                return new Vector(a.Coordinates.Select((x, i) => a.Coordinates[i] + b.Coordinates[i]).ToArray());
            }
            else
            {
                throw new ArgumentException("Vector must have equal dimensions.");
            }
        }

        public static Vector operator -(Vector a, Vector b)
        {
            if (a.Dimensions == b.Dimensions)
            {
                return new Vector(a.Coordinates.Select((x, i) => a.Coordinates[i] - b.Coordinates[i]).ToArray());
            }
            else
            {
                throw new ArgumentException("Vector must have equal dimensions.");
            }
        }

        public static double ScalarProduct(Vector a, Vector b)
        {
            if (a.Dimensions == b.Dimensions)
            {
                return a.Coordinates.Select((x, i) => a.Coordinates[i] * b.Coordinates[i]).Sum();
            }
            else
            {
                throw new ArgumentException("Vector must have equal dimensions.");
            }
        }

        public static Vector VectorProduct(Vector a, Vector b)
        {
            if (a.Dimensions == b.Dimensions)
            {
                return new Vector(a.Coordinates.Select((x, i) => a.Coordinates[i] - b.Coordinates[i]).ToArray());
            }
            else
            {
                throw new ArgumentException("Vector must have equal dimensions.");
            }
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
