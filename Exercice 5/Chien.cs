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
            Console.WriteLine("Je me déplace à quatre pattes");
        }

        public Chien(string nom,string CriChien, int ageChien)
        {
            Nom = nom;
            Cri = CriChien ;
            Age = ageChien ;
            AgeMaximum = 15;
        }

        public override void Description()
        {
            Console.WriteLine($"Le chien se prénomme {Nom}");
            Console.WriteLine($"Le chien a {Age} ans");
            Console.WriteLine($"L'age maximum chien est de {AgeMaximum} ans");
            Console.WriteLine($"Le chien {Cri}");



        }
    }
}
