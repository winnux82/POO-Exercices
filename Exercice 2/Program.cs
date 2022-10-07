using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Voiture> voitures = new List<Voiture>();

            voitures.Add(new Voiture("Peugeot", "rouge", "AZE54RE", 4));
            voitures.Add(new Voiture("Porche", "vert", "AQZ76RE", 44));
            voitures.Add(new Voiture("Renault", "bleu", "ZER65DD", 5));
            voitures.Add(new Voiture("Citroen", "rouge", "IUY67FF", 4));
            voitures.Add(new Voiture("Peugeot", "noir", "UYT87FF", 6));

            foreach (Voiture auto in voitures)
            {
                Console.WriteLine(auto.Presentation());
            }

            foreach (Voiture auto in voitures)
            {
                auto.Nombre_De_Chevaux++;
            }

            foreach (Voiture auto in voitures)
            {
                Console.WriteLine(auto.Presentation());
            }

            Console.Write("\nVeuillez entrer un numéro de matricule : ");
            string matricule = Console.ReadLine();

            bool isExist = false;
            foreach (Voiture auto in voitures)
            {
                if (!isExist)
                    isExist = (auto.Matricule == matricule);
                if (isExist)
                {
                    Console.WriteLine(auto.Presentation());
                    break;
                }
            }

            if (isExist == false)
            {
                Console.WriteLine("matricule inexistant");
            }
            
            Voiture automobile = voitures.Find(auto => auto.Matricule == matricule);
            if (automobile != null)
                Console.WriteLine(automobile.Presentation());
            else
                Console.WriteLine("matricule inexistant");

            

        }
    }
}