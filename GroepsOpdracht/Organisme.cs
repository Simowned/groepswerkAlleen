using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroepsOpdracht
{
    public abstract class Organisme: IOrganisme
    {
        public int rij;
        public int kolom;
        public int levenskracht;

        public abstract void DoeActie();
    }
}
