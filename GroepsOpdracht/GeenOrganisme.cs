using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroepsOpdracht
{
    public class GeenOrganisme: IOrganisme
    {
        //public GeenOrganisme()
        //{
        //}
        public override string ToString()
        {
            return ".";
        }
        public void DoeActie()
        {
            //Console.WriteLine("Het geenOrganisme doet niks");
        }
    }
}
