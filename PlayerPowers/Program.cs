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

            Powers[] playerPowers = new Powers[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter powers for player {i + 1}:");
                Console.Write("Fly (y/n): ");
                bool hasFly = Console.ReadLine().ToLower() == "y";
                Console.Write("X-Ray Vision (y/n): ");
                bool hasXRayVision = Console.ReadLine().ToLower() == "y";
                Console.Write("Super Strength (y/n): ");
                bool hasSuperStrength = Console.ReadLine().ToLower() == "y";
                
                playerPowers[i] = Powers.None;

                if (hasFly)
                {
                    playerPowers[i] |= Powers.Fly;
                }

                if (hasXRayVision)
                {
                    playerPowers[i] |= Powers.XRayVision;
                }

                if (hasSuperStrength)
                {
                    playerPowers[i] |= Powers.SuperStrength;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Player {i + 1} powers: {playerPowers[i]}");

                if (playerPowers[i] == (Powers.Fly | Powers.SuperStrength))
                {
                    Console.WriteLine("Flying radiation!");
                }
            }

            Console.ReadKey();
        }
    }
}