using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luckyNum=2;
            int guess;
            bool Continue = true;
            int guessChance = 3;

            do
            {
                
                Console.WriteLine("Guess the Lucky number: ");
                guess = int.Parse(Console.ReadLine());
                

                if (guess == luckyNum)
                {
                    Console.WriteLine("You Won!");
                    Continue = false;
                    
                }
                else
                {
                    Console.WriteLine("You Lost!");
                    
                    guessChance--;
                    if(guessChance == 0)
                    {
                        Console.WriteLine("Out of Chance!!");
                        Continue = false;
                        
                    }
                }


                Console.ReadKey();

            } while (Continue);
                

            
        }
    }
}
