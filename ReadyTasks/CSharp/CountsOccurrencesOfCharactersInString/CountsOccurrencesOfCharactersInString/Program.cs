using System;
using System.Collections.Generic;
using System.Linq;

namespace CountsOccurrencesOfCharactersInString
{
    internal class Program
    {
        static Dictionary<char, int> GetCharacterOccurences(string text)
        {
            return text.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        }

        static void Main(string[] args)
        {
            Console.Write("Write a string: ");
            string text = Console.ReadLine();

            Console.WriteLine("\n\nCharacters count: ");
            var characterCount = GetCharacterOccurences(text);
            foreach (var character in characterCount.Keys)
            {
                Console.WriteLine($"{character}: {characterCount[character]}");
            }
        }
    }
}
