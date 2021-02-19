using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace averageTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Давай проверим среднюю температуру за сегодняшний день!");
            Console.WriteLine("Введи минимальную температуру!");

            double minTemp = double.Parse(Console.ReadLine());

            Console.WriteLine("А теперь введи максимальную температуру");

            double maxTemp = double.Parse(Console.ReadLine());

            double result = (maxTemp + minTemp) / 2;

            DateTime dt = new DateTime();
            dt = DateTime.Now;
            


            Console.WriteLine($"Средняя температура за {dt} равна {result}");
            Console.ReadLine();



        }
    }
}
