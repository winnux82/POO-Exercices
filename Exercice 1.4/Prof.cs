using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1quater
{
    public class Prof:Personne
    {
        public Prof(string nom, int age, string emploi = "Professeur"):base(nom,age,emploi)
        {

        }
        public override void Afficher()
        {
            AfficherNomEtAge();
            Console.WriteLine("  EMPLOI : " + emploi);

        }


    }
}
