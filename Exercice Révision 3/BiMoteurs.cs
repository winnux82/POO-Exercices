using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Révision_3
{
    public class BiMoteurs : Avion
    {

        public int NbPlace { get; set; }
        public BiMoteurs(string immatriculation, string modèle, DateTime dateConstruction, int nbPlace) : base(immatriculation, modèle, dateConstruction)
        {
            NbPlace = nbPlace;
        }

        public override void Démarrer()
        {
            Console.WriteLine($"L’avion {Modèle} démarre et allume ses moteurs !");
        }
        public override void Atterir()
        {
            Console.WriteLine($"L’avion {Modèle} coupe ses moteurs et ouvre son train d’atterrissage");
        }

        public override string Description()
        {
            return base.Description() +  $":: {NbPlace} ";
 }
    }
}
