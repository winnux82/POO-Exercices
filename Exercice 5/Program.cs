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

            Oiseau Moineau = new Oiseau("piaille ", 2);
            Moineau.Crie();
            Moineau.Veillit();
            Moineau.Mange();
            Moineau.SeDeplace();
            Moineau.Description();

            Aigle aigle1 = new Aigle("glati", 3);

            aigle1.Description();


            Chien Rantanplan = new Chien("Rantanplan", "aboit", 5);

            Rantanplan.Veillit();
            Rantanplan.Mange();
            Rantanplan.SeDeplace();
            Rantanplan.Description();

        }


}
}
