using System;
using System.Linq;

namespace Rot13
{
    class Program
    {
        static string Alphabet = "abcdefghijklmnopqrstuvwxyz";

        static char RotateCharacter(char letter, int rotation)
        {
            int ind = Alphabet.IndexOf(letter);
            ind += rotation;
            ind %= Alphabet.Length;
            return Alphabet[ind];
        }

        static string RotateString(string s, int rotation)
        {
            return String.Concat(s.Select(x => RotateCharacter(x, rotation)));
        }

        static string ROT13(string s)
        {
            return RotateString(s, 13);
        }

        static void Main(string[] args)
        {
            Console.Write("Write string: ");
            string text = Console.ReadLine();

            Console.Write("Rotated string: ");
            Console.WriteLine(ROT13(text));

            Console.Write("Rotated twice string: ");
            Console.WriteLine(ROT13(ROT13(text)));
        }
    }
}
