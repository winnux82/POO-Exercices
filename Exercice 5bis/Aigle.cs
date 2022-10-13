using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5
{
    public class Aigle : Oiseau
    {

        public Aigle(string criAigle, int ageAigle) : base(criAigle, ageAigle)
        {
            criAigle = Cri;
            ageAigle = Age;
           

        }

        public override void Description()
        {
            Console.WriteLine($"L'aigle a {Age} ans");
            Console.WriteLine($"L'age maximum de l'aigle est de {AgeMaximum} ans");
            Console.WriteLine($"L'aigle {Cri}");

        }

    }
}
