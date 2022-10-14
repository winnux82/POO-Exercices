using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_6
{
    public class Employé : Personne
    {
        private float _salaire;

        public float Salaire
        {
            get { return _salaire; }
            set { _salaire = value; }
        }

        public Employé(string nom, string prenom, DateTime datenaissance, float salaire):base(nom,prenom,datenaissance)
        {
            Salaire = salaire;

        }

        public override void Présentation()
        {
            base.Présentation();
            Console.WriteLine($"Son salaire est de : {Salaire}€");
        }
    }
}
