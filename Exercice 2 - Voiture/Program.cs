using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_2_Voiture
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Voiture> voitures = new List<Voiture>();

            voitures.Add(new Voiture("Peugeot", "rouge", "1ABC666", 4));
            voitures.Add(new Voiture("Porche", "vert", "1ABC667", 44));
            voitures.Add(new Voiture("Renault", "bleu", "1ABC686", 5));
            voitures.Add(new Voiture("Citroen", "rouge", "1ABC676", 4));
            voitures.Add(new Voiture("Peugeot", "noir", "1ABC646", 6));

            foreach (Voiture auto in voitures)
            {
                Console.WriteLine(auto.Présentation());
            }

            foreach(Voiture auto in voitures)
            {
                auto.NbreChevaux++;
            }
            Console.WriteLine("Avec 1 cheval supp.");

            foreach(Voiture auto in voitures)
            {
                Console.WriteLine(auto.Présentation());
            }

            Console.Write("\nVeuillez entrer un numéro de matricule : ");
            string matricule = Console.ReadLine();
            /*
            bool SiExiste = false;
            foreach (Voiture auto in voitures)
            {
                if (!SiExiste)
                    SiExiste = (auto.Matricule == matricule);
                if (SiExiste)
                {
                    Console.WriteLine(auto.Présentation());
                    break;
                }
            }
            if (SiExiste == false)
            {
                Console.WriteLine("matricule inexistant");
            }

            */
            Voiture RechercheMat = voitures.Find(auto => auto.Matricule == matricule);
            if (RechercheMat == null)
            {
                Console.WriteLine("Immatriculation inconnue");
            }
            else
            {
                Console.WriteLine(RechercheMat.Présentation());
            }
        }
    }
}
