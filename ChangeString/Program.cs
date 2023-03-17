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
            
            string strWithoutChar = "";

            Debug.Assert(userString != null, nameof(userString) + " != null");
            foreach (var t in userString)
            {
                if (t != userCharacter)
                {
                    strWithoutChar += t;
                }
            }
            
            Console.WriteLine("\nResult:"+strWithoutChar);
        }
    }
}
