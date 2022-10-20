using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_révision_2
{
    public class Voiture : Véhicule
    {
        private string _nature;

        public string Nature
        {
            get { return _nature; }
            set { _nature = value; }
        }



        public Voiture(string immatriculation, string fabricant, string modèle, DateTime datefabrication, string nature) : base(immatriculation,fabricant,modèle,datefabrication)
        {
            Nature = nature;

        }

        public override void Démarrer()
        {
            Console.WriteLine($"La voiture {Fabricant} {Modèle} démarre");
        }
        public override void Accélérer()
        {
            Console.WriteLine($"La voiture {Fabricant} {Modèle} accélère");
        }

        public override string Description()
        {
            
            return base.Description() + ($":: De nature : {Nature}");
        }

    }
}
