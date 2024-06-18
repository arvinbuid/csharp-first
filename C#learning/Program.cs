using System;
using System.ComponentModel;

namespace LearningCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nested loops

            Console.WriteLine("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What symbol?: ");
            char symbol = Convert.ToChar(Console.ReadLine());


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
