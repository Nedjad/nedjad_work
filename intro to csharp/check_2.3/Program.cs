using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rand = new Random();

            int numbTick = rand.Next(10001, 20000);
            int oneTick = rand.Next(1, 21);
            int travel = rand.Next(1, 11);

            int sum = oneTick * travel;
            
            
            
            string strLenght = new string('*', 40);
            string strLen = new string('-', 40);

            Console.Title = "Квитанция";
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetWindowSize(40, 20);
            
            Console.WriteLine(strLenght);
            Console.WriteLine(strLen);
            Console.WriteLine("{0, 25}", "ИП Неджад \n");
            Console.WriteLine("{0, 23}", "Квитанция");
            Console.WriteLine("{0, 22}", $" № {numbTick}");
            Console.WriteLine(strLen);
            Console.WriteLine("{0, 29}", $"Стоимость: {sum} руб.");
            Console.WriteLine(strLen);
            Console.WriteLine(strLen);
            Console.WriteLine("{0, 33}","Перевозчик: Мешанович Н.М.");
            Console.WriteLine("{0, 27}","Автобус: GeekBus");
            Console.WriteLine(strLen);
            Console.Write("{0,24}", "Ваше место: ");
            Console.WriteLine("{0, 2}", rand.Next(1, 21));
            Console.WriteLine(strLen);
            
            Console.WriteLine("{0, 29}", DateTime.Now);
           
            Console.WriteLine("{0,31}", $"Цена одного билета: {oneTick}");
            Console.WriteLine("{0, 31}",$"Количество поездок: {travel}");
            Console.WriteLine(strLenght);
            Console.Write(strLen);
            
            
            
            
            Console.ReadLine();

        }
    }
}
