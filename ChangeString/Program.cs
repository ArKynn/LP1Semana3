using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the string to modify:");
            string phrase = Console.ReadLine();
            Console.WriteLine("Insert the character to remove:"); 
            char character = Convert.ToChar(Console.ReadLine());

            string resultingString = "";

            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] != character)
                {
                    resultingString += phrase[i];
                }
                else
                {
                }
                
            }
            Console.WriteLine($"Resulting string: {resultingString}");
        }
    }
}