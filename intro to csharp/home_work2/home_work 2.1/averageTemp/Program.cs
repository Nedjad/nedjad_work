using System;
// Удалены неиспользуемые директивы using.

namespace averageTemp
{
    class Program
    {
        static void Main()
        {
            double minTemp;
            double maxTemp;

            // Программа заключенна в цикл do-while для возможности провести расчёт ещё раз.
            do
            {

                Console.WriteLine("Привет! Давай проверим среднюю температуру за сегодняшний день!");

                Console.WriteLine("Введи минимальную температуру: ");
                minTemp = double.Parse(Console.ReadLine());

                Console.WriteLine("А теперь введи максимальную температуру: ");
                maxTemp = double.Parse(Console.ReadLine());

                double result = (maxTemp + minTemp) / 2;

                DateTime dt = new DateTime();
                dt = DateTime.Now;

                // Условие неправильного ввода температуры
                if (minTemp > maxTemp)
                {
                    Console.WriteLine("Минимальная температура не может быть больше максимальной! ");
                    Console.ReadLine();
                    
                }
                else
                { 
                    Console.WriteLine($"Средняя температура за {dt} равна {result}");
                    Console.ReadLine();
                }
                // блок кода отвечающий за выполнение заново программы.
                {
                    Console.WriteLine("Повторим измерение ? д/н");

                    char endOrback = char.Parse(Console.ReadLine());

                    if (endOrback == 'д')
                    {
                        continue;
                    }
                    else if (endOrback == 'н')
                    {
                        Environment.Exit(0x101);
                    }
                }
            } while (minTemp < maxTemp);








        }
    }
}
