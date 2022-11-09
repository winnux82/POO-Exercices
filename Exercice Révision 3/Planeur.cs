using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Révision_3
{
    public class Planeur : Avion
    {
        public int Poids { get; set; }
        public Planeur(string immatriculation, string modèle, DateTime dateConstruction, int poids) : base(immatriculation, modèle, dateConstruction)
        {
            Poids = poids;
        }

        public override void Démarrer()
        {
            Console.WriteLine($"Le Planeur {Modèle} est tracté et prend de la vitesse");
        }
        public override void Atterir()
        {
            Console.WriteLine($"Le Planeur {Modèle} perd de l'altitude");
        }

        public override string Description()
        {
            return base.Description() + $":: {Poids} ";
        }
    }
}
