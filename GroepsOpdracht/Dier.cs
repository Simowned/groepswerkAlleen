using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroepsOpdracht
{
    public abstract class Dier: Organisme
    {
        public bool heeftActieGedaan = false;
        public Dier()
        {
            this.levenskracht = 0;
        }

        public void Eat(Organisme org)
        {
            Terrarium.terrarium[org.rij, org.kolom] = new GeenOrganisme();
        }

        public void Move()
        {
            while (this.heeftActieGedaan == false)
            {
                Random rnd = new Random();
                int direction = rnd.Next(0, 4);
                switch (direction)
                {
                    case 0:
                        if (Terrarium.canMoveTo(this.rij, this.kolom - 1))
                        {
                            Terrarium.terrarium[this.rij, this.kolom] = new GeenOrganisme();
                            Terrarium.terrarium[this.rij, this.kolom + 1] = this;
                            this.kolom++;
                            this.heeftActieGedaan = true;
                        }
                        break;
                    case 1:
                        if (Terrarium.canMoveTo(this.rij, this.kolom - 1))
                        {
                            Terrarium.terrarium[this.rij, this.kolom] = new GeenOrganisme();
                            Terrarium.terrarium[this.rij, this.kolom - 1] = this;
                            this.kolom--;
                            this.heeftActieGedaan = true;
                        }
                        break;
                    case 2:
                        if (Terrarium.canMoveTo(this.rij + 1, this.kolom))
                        {
                            Terrarium.terrarium[this.rij, this.kolom] = new GeenOrganisme();
                            Terrarium.terrarium[this.rij + 1, this.kolom] = this;
                            this.rij++;
                            this.heeftActieGedaan = true;
                        }
                        break;
                    case 3:
                        if (Terrarium.canMoveTo(this.rij - 1, this.kolom))
                        {
                            Terrarium.terrarium[this.rij, this.kolom] = new GeenOrganisme();
                            Terrarium.terrarium[this.rij - 1, this.kolom] = this;
                            this.rij--;
                            this.heeftActieGedaan = true;
                        }
                        break;
                    default:
                        Console.WriteLine("er wordt een te hoog random nummer gecreërd");
                        break;
                }
                
            }
        }

        //public void MoveTo(int xPos, int yPos)
        //{
        //    if(Terrarium.canMoveTo(xPos,yPos))

        //}
    }
}
