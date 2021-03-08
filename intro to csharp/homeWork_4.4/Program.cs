using System;

namespace homeWork_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер эллемента.");
            var n = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine($"Под порядковым номер {n} скрывается число {Fibonacci(n)}");
        }

        static long Fibonacci(long n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
