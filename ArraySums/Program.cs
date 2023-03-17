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
            
            // Now we ask for the numbers
            for (int i = 0; i < horizontalArray; i++)
            {
                for (int j = 0; j < verticalArray; j++)
                {
                    Console.WriteLine($"Current position: [{i}, {j}]\n\n");
                    Console.WriteLine("Please input a float into your array:");
                    myArray[i, j] = Console.Read();
                    Console.WriteLine("\nDone!");
                }
            }
            
            // Sum row values
            Console.WriteLine("\nSum of values - Per Row:");
            for (int i = 0; i < horizontalArray; i++)
            {
                float totalSum = 0;

                for (int j = 0; j < verticalArray; j++)
                {
                    totalSum += myArray[i, j];
                }
                
                Console.WriteLine($"Row number {i}'s sum: {totalSum}");
            }
        }
    }
}
