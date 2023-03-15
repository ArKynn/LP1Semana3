using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the horizontal size of the array:");
            int horizontalSize = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Insert the vertical size of the array:");
            int verticalSize = Convert.ToInt16(Console.ReadLine());

            int[,] matrix = new int[horizontalSize, verticalSize];

            for (int i = 0; i < verticalSize; i++)
            {
                for (int j = 0; j < horizontalSize; j++)
                {
                    Console.WriteLine($"Current array element: {j},{i} \nInsert element value:");
                    matrix[j, i] = Convert.ToInt16(Console.ReadLine());
                }
            }
            
        }
    }
}