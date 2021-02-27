using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш текст.");

            string userText = Console.ReadLine();

            Console.WriteLine(userText.Reverse().ToArray());
            Console.ReadLine();



            
        }
    }
}
