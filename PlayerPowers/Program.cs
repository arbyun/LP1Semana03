using System;

namespace PlayerPowers
{
    [Flags]
    public enum Powers
    {
        None = 0,
        Fly = 1,
        XRayVision = 2,
        SuperStrength = 4
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the total number of players: ");
            int n = int.Parse(Console.ReadLine());
        }
    }
}
