using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5
{
    public class Corbeau : Oiseau
    {
        public Corbeau(int ageCorbeau) : base(ageCorbeau)
        {
            Cri = "croi croi croi";
            AgeMaximum = 10;
            Age=ageCorbeau;
        }

        public override void Description()
        {
            Console.WriteLine("Description du Corbeau");
            this.SeDeplace();
            Console.WriteLine($"Le corbeau a {Age} ans");
            Console.WriteLine($"L'age maximum du corbeau est de {AgeMaximum} ans");
            Console.WriteLine($"Le cri du corbeau est {Cri}");

        }
    }
}
