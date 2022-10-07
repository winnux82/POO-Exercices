using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_3
{
    public class Program
    {

        public static void Main(string[] args)
        {


            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Salarie> ListeSalaries = new List<Salarie>();

            ListeSalaries.Add(new Salarie());
            ListeSalaries.Add(new Salarie(4377));
            ListeSalaries.Add(new Salarie(4378,"FERME"));
            ListeSalaries.Add(new Salarie(4379, "VANDERMEULEN", "Christophe", 2800));
            ListeSalaries.Add(new Salarie(4380, "MENET", "Bertrand", 2500));
            ListeSalaries.Add(new Salarie(4387, "FERME", "Gérard", 2990));
            ListeSalaries.Add(new Salarie(4397, "DESMETTRE", "Anabelle", 3500));

            ListeSalaries.Add(new Salarie(5397, "DEZWAENE", "Annabel", 4500));

            foreach (Salarie salarie in ListeSalaries)
            {
                Console.WriteLine(salarie.Présentation() + " --> Calcul du salaire : " + salarie.CalculerSalaireNet() + "€");
                
            }




        }

    }
}