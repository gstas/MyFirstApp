using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("new app - Hello world!");
            Console.Write("Введите строку: ");
            string readLine = Console.ReadLine();
            Console.WriteLine("Вы ввели: " + readLine);
            Console.ReadLine();
        }
    }
}
