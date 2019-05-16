using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("new app - Hello world!");
            string readLine = Console.ReadLine();
            Console.WriteLine("Вы ввели: " + readLine);
            Console.ReadLine();
        }
    }
}
