using System;

namespace homeWork_4._3
{
    class Program
    {
        enum seasons
        {
            Winter = 0,
            Spring = 1,
            Summer = 2,
            Autumn = 3
        }
            
        static void Main(string[] args)
        {
            int numbMonth = 0;

            mouth(numbMonth);

           
        }

        static void mouth(int numbMonth)
        {
            
            string numb;

            Console.WriteLine("Введите порядковый номер месяца.");
            numb = Console.ReadLine();

            bool number = int.TryParse(numb, out numbMonth);

            if(numbMonth == 12 || numbMonth == 1 || numbMonth == 2)
                Console.WriteLine(seasons.Winter);
            
            else if(numbMonth == 3 || numbMonth == 4 || numbMonth == 5)
                Console.WriteLine(seasons.Spring);

            else if(numbMonth == 6 || numbMonth == 7 || numbMonth == 8)
                Console.WriteLine(seasons.Summer);
            
            else if(numbMonth == 9 || numbMonth == 10 || numbMonth == 11)
                Console.WriteLine(seasons.Autumn);

            else
                Console.WriteLine("Введите номер месяца от 1 до 12!");

        }
    }
}
