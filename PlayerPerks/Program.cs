using System;

namespace PlayerPerks
{
    [Flags]
    internal enum PlayerPerks
    {
        WaterBreathing = 1 << 0,
        Stealth = 1 << 1,
        AutoHeal = 1 << 2,
        DoubleJump = 1 << 3
    }

    internal static class Program
    {
        private static void Main(string[] args)
        {
            PlayerPerks playerPerks = 0;
            
            Console.WriteLine("Please input your desired perks:");
            string userInput = Console.ReadLine();

            if (userInput != null && userInput.Length == 0 || userInput == null)
            {
                Console.WriteLine("No perks at all!");
                return;
            }
            
            foreach (char t in userInput)
            {
                if (t != 'w' && t != 'a' && t != 's' && t != 'd')
                {
                    Console.WriteLine("Unknown perk!");
                    return;
                }
            
                switch (t)
                {
                    case 'w':
                        playerPerks |= PlayerPerks.WaterBreathing;
                        break;
                    case 'a':
                        playerPerks |= PlayerPerks.Stealth;
                        break;
                    case 's':
                        playerPerks |= PlayerPerks.AutoHeal;
                        break;
                    case 'd':
                        playerPerks |= PlayerPerks.DoubleJump;
                        break;
                    default:
                        return;
                }
            }
            
            Console.WriteLine($"Player perks: {playerPerks}");
            
            if ((playerPerks & (PlayerPerks.Stealth | PlayerPerks.DoubleJump)) == (PlayerPerks.Stealth | PlayerPerks.DoubleJump))
            {
                Console.WriteLine("Silent jumper!");
            }

            if ((playerPerks & PlayerPerks.AutoHeal) == PlayerPerks.AutoHeal)
            {
                Console.WriteLine("Not gonna make it!");
            }
        }
    }
}
