using System;
using System.Text.Json.Serialization;

namespace PlayerPerks
{
    class Program
    {
        [Flags]
        enum Perks
        {
            None,
            WaterBreathing,
            Stealth,
            AutoHeal,
            DoubleJump
        };

        static void Main(string[] args)
        {
            try
            {
                string inputPerks = args[0];
                Perks playerWaterBreathing = Perks.None;
                Perks playerStealth = Perks.None;
                Perks playerAutoHeal = Perks.None;
                Perks playerDoubleJump = Perks.None;
                
                for (int c = 0; c < inputPerks.Length; c++)
                {
                    if (inputPerks[c] == Convert.ToChar("w"))
                    {
                        playerWaterBreathing ^= Perks.WaterBreathing;
                    }
                    else if (inputPerks[c] == Convert.ToChar("a"))
                    {
                        playerAutoHeal ^= Perks.AutoHeal;
                    }
                    else if (inputPerks[c] == Convert.ToChar("s"))
                    {
                        playerStealth ^= Perks.Stealth;
                    }
                    else if (inputPerks[c] == Convert.ToChar("d"))
                    {
                        playerDoubleJump ^= Perks.DoubleJump;
                    }
                    else
                    {
                        Console.WriteLine("Unknown perk!");
                        Environment.Exit(0);
                    }
                }

                Console.WriteLine($"{playerWaterBreathing}, {playerStealth}, {playerAutoHeal}, {playerDoubleJump}");
                
                if (playerStealth == Perks.Stealth && playerDoubleJump == Perks.DoubleJump)
                {
                    Console.WriteLine("Silent Jumper!");
                }

                if (playerAutoHeal != Perks.AutoHeal)
                {
                    Console.WriteLine("Not gonna make it!");
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("No Perks at all!");
                Environment.Exit(0);
            }
        }
    }
}    