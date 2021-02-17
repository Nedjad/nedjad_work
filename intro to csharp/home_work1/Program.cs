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
            // Вывод текста на консоль
            Console.WriteLine("Введите ваше имя! \n");

            // Ожидание ввода данных с клавиатуры
            string userName = Console.ReadLine();

            // Вывод введённых данных из переменной userName и вывод даты и времени
            Console.WriteLine("\nПривет, {0}! \nаТекущая дата и время: {1}", userName, DateTime.Now.ToString("dd.MM.yyyy HH.mm.ss"));
            Console.ReadKey();
           
        }
    }
}
