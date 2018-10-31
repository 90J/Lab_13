using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Bill : Player
    {
        public Bill()
        {           
        }

        //random selection
        public override string Name { get; set; } = "Bill";
        //public override Roshambo { get; set; }
        public override Roshambo GenerateRoshambo()
        {
            //do randomness here
            Random rand = new Random();
            int x = rand.Next(1, 4);
            if(x == 1)
            {
                return Roshambo.rock;
            }
            else if (x == 2)
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