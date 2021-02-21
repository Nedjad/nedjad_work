using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workDay_2._6
{
    class Program
    {
        [Flags]
        public enum dayOfWeek
        {
            Monday = 0b_000001,
            Tuesday = 0b_000010,
            Wednesday = 0b_000100,
            Thursday = 0b_001000,
            Friday = 0b_010000,
            Saturday = 0b_100000
        }

        static void Main(string[] args)
        {
            int numb;

            dayOfWeek officeOne = dayOfWeek.Friday | dayOfWeek.Saturday | dayOfWeek.Thursday;
            dayOfWeek officeTwo = dayOfWeek.Monday | dayOfWeek.Wednesday | dayOfWeek.Tuesday;

            Console.WriteLine("Введите номер вашего офиса.");

            string officeNumber = Console.ReadLine(); 

            bool number = int.TryParse(officeNumber, out numb);

            if(number == true && numb == 1)
            {
                Console.WriteLine($"Рабочие дни вашего офиса: {officeOne}");
                Console.ReadLine();
            }
            else if (number == true && numb == 2)
            {
                Console.WriteLine($"Рабочие дни вашего офиса: {officeTwo}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Такого офиса не существует.");
                Console.ReadLine();
            }

         

            
        }
    }
}
