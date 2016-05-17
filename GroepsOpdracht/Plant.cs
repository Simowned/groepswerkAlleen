using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroepsOpdracht
{
    public class Plant: Organisme
    {
        public Plant()
        {
            this.levenskracht = 1;
        }

        public override void DoeActie()
        {
            //Console.WriteLine("De Plant doet niets");
        }
        public override string ToString()
        {
            return "P";
        }
    }
}
