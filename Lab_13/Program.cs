using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables
            int wins = 0;
            int losses = 0;
            int draws = 0;
            int timesPlayed = 1;


            //the game
            Console.WriteLine("Welcome to Rock, Paper, Scissors.");
            
            //player name
            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();
            Player userPlay = new UserPlayer();

            Player computer = RoshamboApp.ChoosePlayer();


            //continue playing?
            Console.Write("Would you like to go again? (y/n): ");
            string answer = Console.ReadLine();

            if (answer == "y" || answer == "Y")
            {
                timesPlayed++;

            }
            else
            {
                Console.WriteLine("Your scores for this session.");
                Console.WriteLine($"Wins: {wins}");
                Console.WriteLine($"Losses: {losses}");
                Console.WriteLine($"Ties: {draws}");
                Console.WriteLine($"Rounds played: {timesPlayed}");

                Console.WriteLine("Goodbye.");
                
            }

        }
    }
}
