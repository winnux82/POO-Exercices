using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_de_révision
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Planete> ListePlanetes = new List<Planete>();
            ListePlanetes.Add(new Planete("Mercure",0.382f,0.06f));
            ListePlanetes.Add(new Planete("Vénus", 0.949f, 0.82f));
            ListePlanetes.Add(new Planete("Terre", 1.00f, 1.00f));
            ListePlanetes.Add(new Planete("Mars", 0.532f, 0.11f));
            ListePlanetes.Add(new Planete("Jupiter", 11.209f, 317.8f));

            Galaxie voie_lactée = new Galaxie("voie_lactée");

            voie_lactée.Description();
            foreach(Planete p in ListePlanetes)
            {
                p.Description();
            }

        }
    }
}
