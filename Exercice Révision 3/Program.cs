using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_Révision_3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            BiMoteurs biMoteurs1 = new BiMoteurs("1BCZ003", "Beechcraft Baron", new DateTime(2017, 03, 21), 6);
            BiMoteurs biMoteurs2 = new BiMoteurs("25-RWB-493", "Piper Seneca", new DateTime(2016, 12, 15), 7);

            Planeur planeur1 = new Planeur("1-ABC-003", "AS-33", new DateTime(2020, 01, 23), 285);
            Planeur planeur2 = new Planeur("5-GTF-103", "Lange Antares 21E", new DateTime(2018, 12, 15), 485);
            Planeur planeur3 = new Planeur("4-BCZ-452", "Nord 2000", new DateTime(1947, 02, 25), 176);
            Planeur planeur4 = new Planeur("2-HYD-546", "L-Spatz 55", new DateTime(1952, 07, 12), 152);

            
            
            
            var ListeAvions = new List<Avion>();
            ListeAvions.Add(biMoteurs1);
            ListeAvions.Add(biMoteurs2);
            ListeAvions.Add(planeur1);
            ListeAvions.Add(planeur2);
            ListeAvions.Add(planeur3);
            ListeAvions.Add(planeur4);

            foreach(var avion in ListeAvions)
            {
                Console.WriteLine(avion.Description());
            }

            biMoteurs2.Démarrer();
            planeur2.Atterir();


            
        }


        
    }

}
