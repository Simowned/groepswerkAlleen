using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroepsOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            // We maken het terrarium aan
            Terrarium park = new Terrarium();

            // Keuze aanbieden om naar de volgende dag te gaan
            park.AskChoice();

            //Console.ReadLine();
        }
    }
}
