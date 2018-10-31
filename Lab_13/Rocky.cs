using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Rocky : Player
    {
        public Rocky()
        {
        }

        //always selects Rock
        public override string Name { get; set; } = "Rocky";
        //public override Roshambo { get; set; }
        public override Roshambo GenerateRoshambo()
        {
            //return Rock and only rock
            // Roshambo = Convert.ToString(1);
            return Roshambo.rock;
        }

    }
}
