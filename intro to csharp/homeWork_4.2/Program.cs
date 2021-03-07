using System;

namespace homeWork_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа в строку!");

            var userStr = Console.ReadLine();

            var strArr = userStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var strLeng = userStr.Length;

            int sum = 0;

            for(int i = 0; i < strArr.Length; i++)
            {
                if(int.TryParse(strArr[i], out var res))
                {
                    sum += res;
                }
            }
            Console.WriteLine(sum);






        }
    }
}
