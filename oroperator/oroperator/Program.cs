// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(true || false)
            {
                Console.WriteLine(true);
            }

            if(true && false )
            {
                Console.WriteLine(true );
            }
            else
            {
                Console.WriteLine(false);
            }

            int myMaxLimit = 20;
            int myMinLimit = 5;

            int myValue = 10;

            if(myValue <myMaxLimit && myValue > myMinLimit)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            int myMaxxLimit = 5;
            int myMinXLimit = 1;
            int myMaxYlimit = 3;
            int myMinYlimit = 1;

            int myXValue = 6;
            int myYValue = 2;

            if ((myXValue < myMaxxLimit && myXValue > myMinXLimit) && (myYValue< myMaxYlimit && myYValue > myMinYlimit))
            {
                Console.WriteLine(true );
            }
            else
            {
                Console.WriteLine(false);
            }


            Boolean myBoolean = false;
            if (!myBoolean)
            {
                Console.WriteLine(true );
            }
         }
    }
}
