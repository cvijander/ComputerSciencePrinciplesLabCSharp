// See https://aka.ms/new-using System;

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myVariable = 5;
            Console.WriteLine($"myVariable is equal to {myVariable} and is an int");

            string myString = myVariable.ToString();
            Console.WriteLine($"myString is equal to {myString } and is a string");

            myString = myString + 1;
            myString += 1;

            Console.WriteLine($"myString is equal to {myString} and is a string");

            myVariable = Int16.Parse( myString ) + 1;
            Console.WriteLine($"myVariable is equal to {myVariable} and is an int");
        }
       
    }
}



