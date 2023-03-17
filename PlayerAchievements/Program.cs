using System;

namespace PlayerAchivements
{
    class Program
    {
        enum Achievements
        {
            DefeatOptionalBoss,
            FindHiddenLevel,
            FinishGame
        };
        
        static void Main(string[] args)
        {
            Console.WriteLine("Insert number of players:");
            int n = Convert.ToInt16(Console.ReadLine());

            int[,] playerAchievements = new int[n, 3];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Does player {i + 1} have the {(Achievements)j} Achievement? (Y = 1/N = 0)");
                    playerAchievements[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            
            for (int i = 0; i < n; i++)
            { 
                Console.WriteLine($"Player {i +1 }'s achievements:");

                int achievementsOwned = 0;
                
                for (int j = 0; j < 3; j++)
                {
                    if (playerAchievements[i, j] == 1)
                    {
                        Console.WriteLine($"{(Achievements) j}");
                        achievementsOwned++;
                    }

                    if (achievementsOwned == 3)
                    {
                        Console.WriteLine("Completionist!");
                    }
                }
                Console.WriteLine($"\n");
            }
        }
    }
}