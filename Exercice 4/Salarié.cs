using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_4
{

    public class Salarie
    {
        #region attributs
        private static int Nb=1;
        private string _id;
        private int _globalid=1;
        private int _matricule;
        private string _nom;
        private string _prenom;
        private float _salaire;
        private float _tauxcs;
        private static float TauxCS = 0.22f;

        #endregion

        #region getter/setter
        //sert à protéger et à faire des conditions.



        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }


        public int GlobalId
        {
            get { return _globalid; }

            set {
                _globalid = value;
            }
        }

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
        #endregion

        //différentes signatures
        public Salarie()
        {
            ID = System.Guid.NewGuid().ToString();
            GlobalId = AutoIncrémentation();
        }
        //surcharger la méthode.
        public Salarie(int matricule) : this()
        {
            Matricule = matricule;
        }

        public Salarie(int matricule, string nom):this()
        {
            Nom = nom;
        }

        public Salarie(int matricule, string nom, string prenom, float salaire):this()

        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            Salaire = salaire;
        }

        public string Présentation()
        {

            return $" Id --> {ID} \n GlobalID --> {GlobalId} \n IMatricule --> {Matricule} \n Nom --> {Nom} \n Prenom --> {Prenom} \n Salaire --> {Salaire}€ \n Taux -->{TauxCS}\n\n";

        }
        public float CalculerSalaireNet()
        {
            return Salaire = Salaire - (Salaire * TauxCS);
        }

        private int AutoIncrémentation()
        {
            return Nb++;
        }


    }


}
