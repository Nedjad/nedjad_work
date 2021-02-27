using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenNumber_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 2;
            int number;
            char back;

            do
            {


                Console.WriteLine("Введите ваше число.");

                string numberStr = Console.ReadLine();

                bool result = int.TryParse(numberStr, out number);

                int percent = number % b;

                if (result)
                {
                    if (percent == 0)
                    {
                        Console.WriteLine("Число чётное!");
                        Console.ReadLine();






                    }
                    else
                    {
                        Console.WriteLine("Число нечётное!");
                        Console.ReadLine();
                    }

                }
                else
                {
                    Console.WriteLine("То, что вы ввели не является числом!");
                    Console.ReadLine();
                }
                Console.WriteLine("Ещё раз ? y/n");
                back = Convert.ToChar(Console.ReadLine());

                if(back == 'n')
                {
                    Environment.Exit(2);
                }

            } while (back == 'y');

        }
    }
}
