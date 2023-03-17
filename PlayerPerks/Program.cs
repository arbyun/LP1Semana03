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
            
        }
    }
}
