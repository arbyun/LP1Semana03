using System;

namespace ArraySums
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter the HORIZONTAL length of the array:");
            int horizontalArray = Console.Read();
            
            Console.WriteLine("Please enter the VERTICAL length of the array:");
            int verticalArray = Console.Read();

            float[,] myArray = new float[horizontalArray, verticalArray];
        }
    }
}
