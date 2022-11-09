//using System;
//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;
//using System.Linq;

//namespace Exercice_révision_2
//    public class Program2
//    {
//        public static void Main(string[] args)
//        {


            


//            Camion camion1 =new Camion("1-BZC-003", "Iveco","EuroCargo", new DateTime(2017, 03, 21), 6);
//            Camion camion2 = new Camion("25-RWB-103", "Renault Truck", "Gamme D", new DateTime(2016, 12, 15), 6);

//            Voiture voiture1 =new Voiture("1-ABC-003", "Peugeot", "208", new DateTime(2018, 11, 01), "thermique");
//            Voiture voiture2 = new Voiture("5-GTF-103", "Peugeot", "3008", new DateTime(2020, 12, 15), "hybride");
//            Voiture voiture3 = new Voiture("4-BCZ-103", "Citroen", "C3", new DateTime(2019, 02, 25), "thermique");
//            Voiture voiture4 = new Voiture("2-HYD-546", "Renault", "ZOE", new DateTime(2020, 07, 12), "electrique");

//            List<Véhicule>  vehiculesList = new List<Véhicule>() { camion1,camion2,voiture1,voiture2,voiture3,voiture4};


//            // ajouter dans la list
//            // a modifier pour faciliter le choix de l'auto manuellement
//            // afficher les vehicules a partir de 2020 et ayant une plaque finissant par 3
//            Console.WriteLine("finissant par 3 et a partir de 2020");
//            foreach (Véhicule veh in vehiculesList)
//            {
//                string c = Convert.ToString(veh.Immatriculation[8]);
                         
//                if (veh.DateFabrication >= new DateTime(2020, 01, 01) && c == "3" )
//                { 
//                    Console.WriteLine( veh.Description());
//                }
//            }

//            Console.WriteLine("*************************");
//            Console.WriteLine("Contenant 103");
//            // afficher les vehicules contenant 103 
//            foreach (Véhicule veh in vehiculesList)
//            {
//                if (veh.Immatriculation.Contains("103")  == true)
//                {
//                    Console.WriteLine(veh.Description());
//                }
//            }
//            Console.WriteLine("*************************");
//            Console.WriteLine("Finissant par 103");
//            // afficher les vehicules finissant par  103 
//            foreach (Véhicule veh in vehiculesList)
//            {
//                string c = veh.Immatriculation;
//                if (veh.Immatriculation.Length == 9)
//                { 
//                    c = c.Substring(6,3);
//                }
//             else if (veh.Immatriculation.Length == 10)
//                {
//                    c = c.Substring(7,3);
//                }

//                if (c == "103"  )
//                {
//                    Console.WriteLine(veh.Description());
//                }
//            }
//            Console.WriteLine("*************************");

//        voiture3.Démarrer();
//        camion1.Accélérer();


//        }
//    }
//}
