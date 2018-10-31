using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    abstract class Player
    {

        virtual public string Name { get; set; }
        virtual public Roshambo Choice { get; set; }
        public abstract Roshambo GenerateRoshambo();
            
    }
}
