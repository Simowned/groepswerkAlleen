using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroepsOpdracht
{
    public class Carnivoor: Dier
    {
        public override void DoeActie()
        {
            //Console.WriteLine("De carnivoor doet iets");
        }
        public override string ToString()
        {
            return "C";
        }
    }
}
