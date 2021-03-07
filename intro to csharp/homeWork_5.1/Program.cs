using System;
using System.IO;

namespace homeWork_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string word = Console.ReadLine();

            
            File.AppendAllText(@"C:\Users\meshn\Desktop\work1.txt", word);
        }
    }
}
