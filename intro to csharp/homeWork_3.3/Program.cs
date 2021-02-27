using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userStr, revStr = "";
            int i, l;

            

            Console.Write("Введите строку: ");
            userStr = Console.ReadLine();

            l = userStr.Length - 1;
            
            for (i = l; i >= 0; i--)
            {

                revStr = revStr + userStr[i];


            }

            Console.WriteLine($"Введённая строка наоборот: {revStr}");
            Console.ReadLine();




        }
    }
}
