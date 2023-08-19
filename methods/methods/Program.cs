// See https://aka.ms/new-console-template for more information


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
   
    internal class Program
    {
        public static int myScore;
        static void Main(string[] args)
        {
            // Create a variable 
             myScore = 1000;
            
            ChangeScore();
        }
        // change the score of the game and output to the console 
        public static void ChangeScore()
        {
            myScore = myScore + 100;
            Console.WriteLine($"Player score: {myScore}");
        }

    }
}



 


//myScore = myScore + 100;
//Console.WriteLine($"Player score: {myScore}");





