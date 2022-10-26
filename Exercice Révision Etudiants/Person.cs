using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Révision_Etudiants
{

    
    public abstract class Person
    {
        private static int Incrementation = 1;
        private int _globalid;

        public int Globalid
        {
            get { return _globalid; }
            set { _globalid = value; }
        }

        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set {

                _nom = value.Trim().ToUpper(); 
                
            }
        }
        private string _prenom;

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = Methods.PrenomUp(value); }
        }

        private DateTime _datenaissance;

        public DateTime DateNaissance
        {
            get { return _datenaissance; }
            set { _datenaissance = value; }
        }

        private string _genre;

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public string Adresse { get; set; }

        private string _persoId;

        public string PersoId
        {
            get { return _persoId; }
            set { _persoId = value; }
        }

        private string _persoPwd;

        public string PersoPwd
        {
            get { return _persoPwd; }
            set { _persoPwd = value; }
        }

        public Person(string nom, string prenom)


        {
            Globalid = Incrementation++;

            if (nom.Trim() == "")
            {
                Console.WriteLine("Erreur");
                

            }
            else
            {
                Nom = nom;
            }
        

            Prenom = prenom;

        }
        public Person(string nom, string prenom, DateTime datenaissance, string genre, string adresse) : this(nom, prenom)
        {

            DateNaissance = datenaissance;
            Genre = genre;
            Adresse = adresse;

        }

        public virtual void Présentation()
        {
            Console.WriteLine($"\n{Globalid} {Nom} {Prenom} {DateNaissance} {Genre} {Adresse}");
        }
    }
}
