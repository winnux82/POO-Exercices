using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_6
{
    public class Personne
    {
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        private string _prenom;

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        private DateTime _datenaissance;

        public DateTime DateNaissance
        {
            get { return _datenaissance; }
            set { _datenaissance = value; }
        }


        public Personne(string nom, string prenom,DateTime datenaissance)
        {
            Nom = nom.ToUpper();
            Prenom = prenom;
            DateNaissance = datenaissance;
            
        }

        public virtual void Présentation()
        {
            Console.WriteLine($"Le nom : {Nom} {Prenom}, sa date de naissance est: {DateNaissance}");  
        }

    }
}
