using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5
{
    public class Chien : Animal
    {
        public string Nom { get; set; }

        public override void SeDeplace()
        {
            Console.WriteLine("Le chien se déplace à quatre pattes");
        }

        public Chien(string nom, int ageChien)
        {
            Nom = nom;
            Cri = "Waf Waf";
            Age = ageChien ;
            AgeMaximum = 15;
        }

        public override void Description()
        {
            Console.WriteLine($"Le chien se prénomme {Nom}");
            Console.WriteLine($"Le chien a {Age} ans");
            this.SeDeplace();
            Console.WriteLine($"L'age maximum chien est de {AgeMaximum} ans");
            Console.WriteLine($"Le cri du chien est {Cri}");



        }
    }
}
