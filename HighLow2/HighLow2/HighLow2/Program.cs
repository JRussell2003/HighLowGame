using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcomes the user
            Console.WriteLine("Welcome to the HighLow game");

            //Generates random number between 1 and 100 and stores it in a variable
            Random rand = new Random();
            int rand1 = rand.Next(1, 11);

            //User has to keep guessing until they guess correctly


            bool playagain = true;
            while (playagain == true) 
            {
                rand1 = rand.Next(1, 11);
                bool correctguess = false;
                int tries = 0;
                while (correctguess == false)
                {
                    
                    //Stores the user's guess into a variable
                    Console.Write("Enter your guess: ");
                    int guess = Convert.ToInt32(Console.ReadLine());
                    
                    //Compares user guess to random number
                    if (guess < rand1)
                    {
                        Console.WriteLine("Your guess is too low");
                        tries += 1;
                    }
                    else if (guess > rand1)
                    {
                        Console.WriteLine("Your guess is too high");
                        tries += 1;
                    }
                    else
                    {
                        tries += 1;
                        Console.WriteLine("Your guess is correct, you guessed my number in " + tries + " attempts.");
                        correctguess = true;
                    }
                }
                Console.WriteLine("Do you want to play again?");
                if (Console.ReadLine() == "no")
                {
                    playagain = false;
                }
            }
            //Program starts after key press
            Console.ReadKey();
        }
    }
}
