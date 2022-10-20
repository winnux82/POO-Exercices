using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_6
{
    public class Chef : Employé
    {
        private string _service;

        public string Service
        {
            get { return _service; }
            set { _service = value; }
        }

        public Chef(string nom, string prenom, DateTime datenaissance, float salaire, string service) : base(nom, prenom, datenaissance,salaire)
        {
            Service = service;

        }


        public override void Présentation()
        {
            base.Présentation();
            Console.WriteLine($"Son service est de : {Service}");
        }
    }
}
