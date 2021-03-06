using System;

namespace homeWork_4._1
{
    class Program
    {
        static void Main(string[] args)
        {

            (string firstName, string LastName, string patronymic) = GetFullName();
            Console.ReadLine();
            
            
        }
        public static (string firstName, string lastName, string patronymic) GetFullName()
        {
            string firstName = "";
            string lastName = "";
            string patronymic = "";
            

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите имя.");
                firstName = Console.ReadLine();

                Console.WriteLine("Введите фамилию.");
                lastName = Console.ReadLine();

                Console.WriteLine("Введите отчество.");
                patronymic = Console.ReadLine();
                
                Console.WriteLine($"{lastName} {firstName} {patronymic}");

            }
            
            
            return (firstName, lastName, patronymic);
            

            
            
            
            
            

            
            

            
        }
    }
}
