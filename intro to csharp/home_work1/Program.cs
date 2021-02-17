using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите ваше имя! \n");

            string userName = Console.ReadLine();

            Console.WriteLine("\nПривет, {0}! \nаТекущая дата и время: {1}", userName, DateTime.Now.ToString("dd.MM.yyyy HH.mm.ss"));
            Console.ReadKey();
           
        }
    }
}
