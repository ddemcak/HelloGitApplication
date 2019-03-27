using System;

namespace HelloConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Current time is {0}.", DateTime.Now.ToLongTimeString());

            Console.ReadLine();
        }
    }
}
