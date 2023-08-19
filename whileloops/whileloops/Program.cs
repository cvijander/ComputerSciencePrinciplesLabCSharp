// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myValue = 0;
            while (myValue < 100 )
            {
                if(myValue % 9 == 0)
                {
                    Console.WriteLine(myValue);
                }
                myValue ++;
            }

            int myBadValue = 0;
            do
            {
                Console.WriteLine("This will run at least once.");
            } while (myBadValue != 0 );
        }
    }
}