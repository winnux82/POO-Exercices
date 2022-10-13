using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            Animal Chien = new Animal("aboie",2,12);

            Chien.Veillit();
            Chien.Veillit(2);
            Chien.Mange();
            Chien.Description();*/

            /*
            List<Animal> ListeAnimaux = new List<Animal>();

            ListeAnimaux.Add(new Animal("beugle", 22, 66));
            ListeAnimaux.Add(new Oiseau("piaille", 2));
            ListeAnimaux.Add(new Aigle("glati", 3));
            ListeAnimaux.Add(new Chien("Rantanplan", "aboit", 3));

            foreach (Animal a in ListeAnimaux)
            {
                
                a.ToString();
                a.Veillit();
                a.Crie();
                a.Veillit();
                a.Mange();
                a.SeDeplace();
                a.Description();

            }
            */
            
            
            Animal ee = new Animal("beugle", 22, 66);
            ee.ToString();
            Console.WriteLine(ee);
            ee.Description();

            Animal OiseauEssai = new Oiseau(2);
            OiseauEssai.Description();

            Animal Corbeau1 = new Corbeau(4);
            Corbeau1.Description();
            

            Oiseau Moineau = new Oiseau("piaille ", 2);
            
            Moineau.Crie();
            Moineau.Veillit();
            Moineau.Mange();
            Moineau.SeDeplace();
            Moineau.Description();

            Aigle aigle1 = new Aigle("glati", 3);

            aigle1.Description();


            Chien Rantanplan = new Chien("Rantanplan",  5);

            Rantanplan.Veillit();
            Rantanplan.Mange();
            Rantanplan.Description();
            

        }


    }
}
