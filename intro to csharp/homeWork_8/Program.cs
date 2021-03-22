using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_8
{
    class Program
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.userName))
            {

                Console.WriteLine("Введите имя пользователя:");
                Properties.Settings.Default.userName = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            
            if(Properties.Settings.Default.age == 0)
            {
                Console.WriteLine("Введите возраст");
                Properties.Settings.Default.age = int.Parse(Console.ReadLine());
                Properties.Settings.Default.Save();
            }
            
            if(string.IsNullOrEmpty(Properties.Settings.Default.Profession))
            {
                Console.WriteLine("Введите вашу должность:");
                Properties.Settings.Default.Profession = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            
            string userName = Properties.Settings.Default.userName;
            int age = Properties.Settings.Default.age;
            string Prof = Properties.Settings.Default.Profession;
            string hello = Properties.Settings.Default.Hello;

            Console.WriteLine($"{hello}, {userName}! Age: {age} Profession: {Prof}!");
            Console.ReadLine();
        }
    }
}
