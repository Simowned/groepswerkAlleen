using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroepsOpdracht
{
    public class Terrarium
    {
        private const int ROWS = 6;
        private const int COLS = 6;

        private bool TerrariumIsVol = false;
        public static IOrganisme[,] terrarium;

        public Terrarium()
        {
            terrarium = new IOrganisme[6, 6];
            Initialize();
            Afbeelden();
        }

        private void Initialize()
        {
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    terrarium[i, j] = new GeenOrganisme();
                }
            }
            // Hier kan je nog instellen hoeveel van elk organisme je min/max wil
            Random rnd = new Random();
            NieuwOrganisme(new Plant(), rnd.Next(1, 6));
            NieuwOrganisme(new Herbivoor(), rnd.Next(1, 4));
            NieuwOrganisme(new Carnivoor(), rnd.Next(1, 4));            
        }

        public void Afbeelden()
        {
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    Console.Write(terrarium[i,j].ToString() + "  ");
                }
                Console.WriteLine();
            }
        }

        public void NieuwOrganisme(Organisme org, int aantal)
        {
            Random rnd = new Random();
            for (int i = 0; i < aantal; i++)
            {
                int legePlaatsen = 0;
                foreach(var plek in terrarium) 
                {
                    if (plek is GeenOrganisme)
                        legePlaatsen++;
                }
                if (legePlaatsen == 0)
                    TerrariumIsVol = true;

                int rij;
                int kolom;
                do
                {
                    rij = rnd.Next(0, 6);
                    kolom = rnd.Next(0, 6);
                } while (TerrariumIsVol == false && terrarium[rij, kolom] is Organisme);
                org.rij = rij;
                org.kolom = kolom;
                terrarium[rij, kolom] = org;
            }
        }

        public void AskChoice()
        {
            Console.WriteLine("Druk v en <ENTER> om naar de volgende dag te gaan");
            Console.WriteLine("Druk s en <ENTER> om het programma te sluiten");
            var input = Console.ReadLine();
            while (input != "s")
            {
                if (input == "v")
                {
                    //hier komt methode om de dagelijkse acties uit te voeren
                    NextDay();
                    Afbeelden();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Druk v en <ENTER> om naar de volgende dag te gaan");
                    Console.WriteLine("Druk s en <ENTER> om het programma te sluiten");
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Druk v en <ENTER> om naar de volgende dag te gaan");
                    Console.WriteLine("Druk s en <ENTER> om het programma te sluiten");
                    input = Console.ReadLine();
                }
            }
        }
        public static bool canMoveTo(int x, int y)
        {
            if (x >= 0 && x <= 5 && y >= 0 && y <= 5)
            {
                if (terrarium[x, y] is GeenOrganisme)
                    return true;
                else
                    return false;
            }
            else return false;
            //if (terrarium[x,y] is GeenOrganisme)
            //    return true;
            //else
            //    return false;
        }

        private void NextDay()
        {
            Random rnd = new Random();
            foreach (var org in terrarium)
                org.DoeActie();
            // Er worden na elke dag 1 of 2 nieuwe planten toegevoegd
            //NieuwOrganisme(new Plant(), rnd.Next(1,3));
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    if (terrarium[i, j] is Dier)
                    {
                        Dier dier = (Dier)terrarium[i, j];
                        dier.heeftActieGedaan = false;
                    }
                }
            }
        }
    }
}
