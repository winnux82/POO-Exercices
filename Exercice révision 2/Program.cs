using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//coucou
namespace Exercice_révision_2
{
    public class Program
    {
        public static void Main(string[] args)

        {
            Camion Camion1 = new Camion("1-BZC-003", "IVECO", "EUROCARGO", new DateTime(2017, 03, 21), 6f);
            Camion Camion2 = new Camion("25-RWB-493", "Renault Truc", "Gamme D", new DateTime(2016, 12, 15), 12f);

            Voiture Voiture1 = new Voiture("1-ABC-003", "Peuveot", "208", new DateTime(2018, 11, 01), "Thermique");
            Voiture Voiture2 = new Voiture("5-GTF-103", "Peugeot", "3008", new DateTime(2020, 12, 15), "Hybride");
            Voiture Voiture3 = new Voiture("4-BCZ-452", "Citroen", "C3", new DateTime(2019, 02, 25), "Thermique");
            Voiture Voiture4 = new Voiture("2-HYD-546", "Renault", "Zoe", new DateTime(2020, 07, 12), "Thermique");

            List<Véhicule> ListeVéhicules = new List<Véhicule>() { Camion1, Camion2, Voiture1, Voiture2, Voiture3, Voiture4 };

            foreach (var v in ListeVéhicules)
            {
                Console.WriteLine(v.Description());

            }



            Voiture3.Démarrer();
            Camion1.Accélérer();



            //Demande en cours
            Console.WriteLine();


            string recherche;


            do
            {
                Console.Write("\nEntrez la plaque que vous recherchez : ");
                recherche = Console.ReadLine();

                if (recherche == "exit")
                    break;

                foreach (var v in ListeVéhicules)
                {

                    if (v.Immatriculation.Contains(recherche.ToUpper()))
                    {
                        Console.WriteLine(v.Description());

                    }

                }
            } while (true);


        }
    }


}