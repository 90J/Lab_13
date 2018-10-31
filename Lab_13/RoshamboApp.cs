using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    //roshambo class
    class RoshamboApp
    {
        //set users computer and human

        //method to choose player(rocky or bill)
        public static Player ChoosePlayer()
        {
            //send out to the players
            Console.Write("Would you like to play against Rocky, or Bill? ");
            string opponent = Console.ReadLine();

            if (opponent == "Rocky")
            {
                Rocky rockyPlay = new Rocky();
                return rockyPlay;
            }
            else
            {
                Bill billPlay = new Bill();
                return billPlay;
            }
        }
        //get the choice from each player


        //method to check who wins


        //output


    }
}
