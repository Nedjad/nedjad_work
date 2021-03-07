using System;
using System.IO;

namespace homeWork_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
              
            File.AppendAllText(@"C:\Users\meshn\Desktop\startup.txt", DateTime.Now.ToString());
        }
    }
}
