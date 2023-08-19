// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        // create the score variable for the game 
        public static int outsideValue = 5;

        // main function of the program 
        static void Main(string[] args)
        {
            // outside variable to the console 
            Console.WriteLine($"From outside: outsideValue = {outsideValue}");
            //Console.WriteLine($"From outside: functionValue ={functionValue}");

            MyFunction();
            MyOtherFunction();

        }
        public static void MyFunction()
        {
            // Create a variable inside of a function
            // 
            int functionValue = 10;

            // Output variables to the console 
            Console.WriteLine($"From outside : outsideValue ={outsideValue}");
            Console.WriteLine($"From outside : functionValue = {functionValue}");
        }

        public static void MyOtherFunction()
        {
            // output variuables to the console 
            Console.WriteLine($"From outside: outsideValue = {outsideValue}");
           // Console.WriteLine($"From outside : functionValue = { functionValue}");
        }
    }
}
