using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_6
{
    public class Directeur : Chef
    {
        private string _société;

        public string Société
        {
            get { return _société; }
            set { _société = value; }
        }

        public Directeur(string nom, string prenom, DateTime datenaissance, float salaire, string service, string société) : base(nom, prenom, datenaissance, salaire, service)
        {
            Société = société;

        }

        public override void Présentation()
        {
            base.Présentation();
            Console.WriteLine($"Sa société est : {Société}");
        }
    }
}
