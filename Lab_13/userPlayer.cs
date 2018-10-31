using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class UserPlayer : Player
    {
        public UserPlayer()
        {
        }

        //public override string Roshambo { get; set; }
        public override Roshambo GenerateRoshambo()
        {
            //Users choice
            Console.WriteLine("Choose");
            Console.WriteLine("Rock (1)");
            Console.WriteLine("Paper (2)");
            Console.WriteLine("Scissors (3)");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1)
            {
                return Roshambo.rock;
            }
            else if (userInput == 2)
            {
                return Roshambo.paper;
            }
            else
            {
                return Roshambo.scissors;
            }

        }
        
    }
}
