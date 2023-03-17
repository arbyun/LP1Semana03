using System;
using System.Diagnostics;

namespace ChangeString
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Input a string!");
            string userString = Console.ReadLine();

            Console.WriteLine("Now input a character!");
            char userCharacter = Console.ReadKey().KeyChar;
        }
    }
}
