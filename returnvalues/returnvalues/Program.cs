// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        public static double subtotal;

        //main function of the program 
        static void Main(string[] args)
        {
            subtotal = 15.00;

            Console.WriteLine($"Subtotal: {subtotal}");

            double total = subtotal + CalculateTax(0.08,subtotal);
            Console.WriteLine($"Total: {total}");
        }

        public static double CalculateTax(double taxRate,double amountToTax)
        {
            double tax = amountToTax * taxRate;
            Console.WriteLine($"Tax:  { tax} ");
            return tax;
        }
    }
}