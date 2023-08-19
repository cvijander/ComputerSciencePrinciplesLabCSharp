// See https://aka.ms/new-console-template for more information


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your  name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}");
        }
    }
}