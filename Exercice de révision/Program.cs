using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_de_révision
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Planete planete1 = new Planete("Mercure",0.382f,0.06f);
            Planete planete2 = new Planete("Vénus", 0.949f, 0.82f);
            Planete planete3 = new Planete("Terre", 1.00f, 1.00f);
            Planete planete4 = new Planete("Mars", 0.532f, 0.11f);
            Planete planete5 = new Planete("Jupiter", 11.209f, 317.8f);

            List<Planete> ListePlanetes = new List<Planete>() { planete1, planete2, planete3, planete4 };
            ListePlanetes.Add(planete5);

            Galaxie voie_lactée = new Galaxie("Voie Lactée", ListePlanetes);

            voie_lactée.Description();

        }
    }
}
