using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5] { { 7, 5, 2, 5, 2 }, { 5, 7, 8, 3, 1 }, { 8, 1, 7, 5, 8 }, { 6, 7, 8, 7, 4}, { 4, 6, 2, 1, 7} };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{array[i, i]}" + " ");
            }
            Console.ReadLine();

        }
    }
}
