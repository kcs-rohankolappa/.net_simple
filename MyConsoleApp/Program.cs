using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you, {name}!");
        }
    }
}
