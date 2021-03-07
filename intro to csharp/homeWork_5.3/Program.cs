using System;
using System.IO;

namespace homeWork_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string numb = Console.ReadLine();

            if(int.TryParse(numb, out int result) && result <= 255 && result <= 0)
            {
                File.AppendAllText(@"C:\Users\meshn\Desktop\hello.bin", result.ToString());
            }
            else
                Console.WriteLine("Введите число!");
           

            
            
        }
    }
}
