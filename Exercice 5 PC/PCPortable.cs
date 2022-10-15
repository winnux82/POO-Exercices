using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5_PC
{
    public class PCPortable : PC
    {
        private float _tailleEcran;

        public float TailleEcran
        {
            get { return _tailleEcran; }
            set { _tailleEcran = value; }
        }




        public PCPortable(string name, int reference, float prix, string caracteristiques, float taillecran) : base(name, reference, prix, caracteristiques)
        {

                this.TailleEcran=taillecran;

        }

        public override void Décrire()
        {
            base.Décrire();
            Console.WriteLine($"Ce pc portable a une taille de {TailleEcran}");
        }
    }



}
