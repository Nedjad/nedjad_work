using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthNumb
{
    class Program
    {
        //enum Month
        //{
        //    January = 1,
        //    February = 2,
        //    March = 3,
        //    April = 4,
        //    May = 5,
        //    June = 6,
        //    July = 7,
        //    August = 8,
        //    September = 9,
        //    October = 10,
        //    November = 11,
        //    December = 12
        //}

        static void Main(string[] args)
        {
            int number;


            

            Console.WriteLine("Введите порядковый номер текущего месяца.");
            number = int.Parse(Console.ReadLine());

            DateTime dt = new DateTime(1, number, 1);

            
            Console.WriteLine($"Текущий месяц:а {dt.ToString("MMMM")}");
            Console.ReadLine();

            
            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine(Month.January);
            //        break;
            //    case 2:
            //        Console.WriteLine(Month.February);
            //        break;
            //    case 3:
            //        Console.WriteLine(Month.March);
            //        break;
            //    case 4:
            //        Console.WriteLine(Month.April);
            //        break;
            //    case 5:
            //        Console.WriteLine(Month.May);
            //        break;
            //    case 6:
            //        Console.WriteLine(Month.June);
            //        break;
            //    case 7:
            //        Console.WriteLine(Month.July);
            //        break;
            //    case 8:
            //        Console.WriteLine(Month.August);
            //        break;
            //    case 9:
            //        Console.WriteLine(Month.September);
            //        break;
            //    case 10:
            //        Console.WriteLine(Month.October);
            //        break;
            //    case 11:
            //        Console.WriteLine(Month.November);
            //        break;
            //    case 12:
            //        Console.WriteLine(Month.December);
            //        break;
            //    default:
            //        Console.WriteLine("Такого месяца нет!");
            //        break;

                    
            
            

        }
    }
}
