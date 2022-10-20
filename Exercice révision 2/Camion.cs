using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_révision_2
{
    public class Camion : Véhicule
    {
        private float _poids;

        public float Poids
        {
            get { return _poids; }
            set { _poids = value; }
        }


        public Camion(string immatriculation, string fabricant, string modèle, DateTime datefabrication, float poids) : base(immatriculation,fabricant,modèle,datefabrication)
        {
            Poids = poids;
        }

        public override void Démarrer()
        {
            Console.WriteLine($"Le camion {Fabricant} {Modèle} démarre");
        }
        public override void Accélérer()
        {
            Console.WriteLine($"Le camion {Fabricant} {Modèle} accélère");
        }

        public override string Description()
        {
            return base.Description() + ($":: Poids: {Poids} Tonnes");
            
        }
    }
}
