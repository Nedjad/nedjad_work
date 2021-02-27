using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phoneBook = new string[5, 2] { { "Никита ", "8 777 777 77 77" }, { "Игорь ", "8 898 786 21 43" }, { "Максим ", "8 924 000 00 00" }, { "Ольга ", "8 234 456 78 90" }, { "Елена ", "8 098 765 43 21" } };

            
            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                

                for (int j = 0; j < phoneBook.GetLength(1); j++)
                {
                    Console.Write($"{phoneBook[i,j]} ");
                }
                Console.ReadLine();
            }
            
             
        }
    }                                                                                 
}                                                                               // Никита 8 777 777 77 77
                                                                                // Игорь  8 898 786 21 43
                                                                                // Максим 8 924 000 00 00
                                                                                // Ольга  8 234 456 78 90
                                                                                // Елена  8 098 765 43 21