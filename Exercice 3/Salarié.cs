using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_3
{

    public class Salarie
    {
        private int _matricule;
        private string _nom;
        private string _prenom;
        private float _salaire;
        private float _tauxcs;
        public static float TauxCS = 0.22f;

        public int Matricule
        {
            get { return _matricule; }
            set { _matricule = value; }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public float Salaire
        {
            get { return _salaire; }
            set { _salaire = value; }
        }
        public float Tauxcs
        {
            get { return _tauxcs; }
            set { _tauxcs = value; }
        }

        public Salarie()
        {
            
        }

        public Salarie(int matricule) : this()
        {
            Matricule = matricule;
        }

        public Salarie(int matricule,string nom) 
        {
            Matricule = matricule;
            Nom = nom;
        }

        public Salarie(int matricule, string nom, string prenom, float salaire)
        {

            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            Salaire = salaire;
            
        }

        public string Présentation()
        {
            
            return $"Matricule --> {Matricule} \n Nom --> {Nom} \n Prenom --> {Prenom} \n Salaire --> {Salaire}€ \n Taux -->{TauxCS}\n";
            
        }
        public float CalculerSalaireNet()
        {
            
            return Salaire = Salaire - (Salaire * TauxCS);

            
        }
    }
}
