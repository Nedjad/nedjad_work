using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Что вы хотите сделать ? Выберите нужный пункт меню.");
            Console.WriteLine("1. Посмотреть все процессы.");
            Console.WriteLine("2. Завершить процесс.");

            char input = char.Parse(Console.ReadLine());

            if (input == '1')
                lookProc();
            else if (input == '2')
                stopProc();
            

             
        }

        static void lookProc()
        {
            foreach (Process process in Process.GetProcesses())
            {
                Console.WriteLine("-> PID: {0}\tName: {1}", process.Id, process.ProcessName);
            }

            Console.WriteLine("Напишите 2 для остановки процесса.");
            char kill = char.Parse(Console.ReadLine());

            if(kill == '2')
            {
                stopProc();
            }

        }

        static void stopProc()
        {
            Console.Write("Введите PID-идентификатор процесса, который нужно остановить: ");
            
            var pid = Console.ReadLine();
            
            Process myProc = null;
            
            
            try
            {
                int i = int.Parse(pid);
                myProc = Process.GetProcessById(i);
                myProc.Kill();                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
