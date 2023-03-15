using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsum = 0;
            int colsum = 0;
            
            Console.WriteLine("Insert the horizontal size of the array:");
            int horizontalSize = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Insert the vertical size of the array:");
            int verticalSize = Convert.ToInt16(Console.ReadLine());

            int[,] matrix = new int[horizontalSize, verticalSize];

            for (int i = 0; i < verticalSize; i++)
            {
                for (int j = 0; j < horizontalSize; j++)
                {
                    Console.WriteLine($"Current array element: {i},{j} \nInsert element value:");
                    matrix[j, i] = Convert.ToInt16(Console.ReadLine());
                }
            }

            for (int i = 0; i < verticalSize; i++)
            {
                rowsum = 0;
                for (int j = 0; j < horizontalSize; j++)
                {
                    rowsum += matrix[i, j];

                }

                Console.WriteLine($"The sum of the elements in row {i} is {rowsum}");
            }

            for (int i = 0; i < horizontalSize; i++)
            {
                colsum = 0;
                for (int j = 0; j < verticalSize; j++)
                {
                    colsum += matrix[i, j];

                } 
                Console.WriteLine($"The sum of the elements in row {i} is {colsum}");
            }
        }
    }
}