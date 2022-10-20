using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //pour afficher le signe €

            var ListeTout = new List<Personne>();
            List<Chef> chefs = new List<Chef>();


            ListeTout.Add(new Employé("Monroe1", "Maryline", new DateTime(1926, 06, 01), 2100.6f));
            ListeTout.Add(new Employé("Monroe2", "Maryline", new DateTime(1926, 06, 01), 2100.6f));
            ListeTout.Add(new Employé("Monroe3", "Maryline", new DateTime(1926, 06, 01), 2100.6f));
            ListeTout.Add(new Employé("Monroe4", "Maryline", new DateTime(1926, 06, 01), 2100.6f));
            ListeTout.Add(new Employé("Monroe5", "Maryline", new DateTime(1926, 06, 01), 2100.6f));

            ListeTout.Add(new Chef("Chef1", "Beuh", new DateTime(1999, 01, 06), 2500.6f, "Service des chefs"));
            ListeTout.Add(new Chef("Chef2", "Beuh", new DateTime(1999, 01, 06), 2500.6f, "Service des chefs"));


            ListeTout.Add(new Directeur("Directeur Fernandel", "Joseph Désiré", new DateTime(1903, 05, 08), 5008.90f, "Service Direction", "Les plus Grands Acteurs Français"));



            Console.WriteLine("Liste par foreach");
            foreach(Personne person in ListeTout)
            {
                person.Présentation();
            }
            Console.WriteLine("Liste par For");
            for (int i = 0; i < ListeTout.Count; i++)
            {
                ListeTout[i].Présentation();
            }

            
            
        }
    }
}
