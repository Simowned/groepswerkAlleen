using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroepsOpdracht
{
    public class Herbivoor: Dier
    {
        public override void DoeActie()
        {
            while (this.heeftActieGedaan == false)
            {
                if ((this.kolom) < 5)
                {
                    if (Terrarium.terrarium[this.rij, this.kolom + 1] is Plant)
                    {
                        Console.WriteLine("nu moet de plant opgegeten worden !!!");
                        this.Eat((Organisme)Terrarium.terrarium[this.rij, this.kolom + 1]);
                        this.heeftActieGedaan = true;
                        this.levenskracht++;
                    }
                    else
                    {
                        Console.WriteLine("nu moet hij bewegen in een willekeurige richting");
                        this.Move();
                    }
                }
                
            }            //if (Terrarium.terrarium[this.rij, this.kolom + 1] is Plant)
            //{
            //    Console.WriteLine("Eet de plant op");
            //    this.Eat((Organisme)Terrarium.terrarium[this.rij, this.kolom + 1]);
            //}
                // Eet de plant op hier
                
            //else 
            //    this.MoveTo(rij,kolom);
        }

        public override string ToString()
        {
            return "H";
        }
    }
}
