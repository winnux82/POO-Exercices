using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Révision_3
{
    public abstract class Avion
    {
        //le membre static est commun à toutes les classes. Variable de classe et non d'instance.
        //base référence à la classe mère
        //Valeur ou référence
        //type déclaré A, type constaté B
        private static int inc =1;
        private int _identifiant;

        public int Identifiant
        {
            get { return _identifiant; }
            set { _identifiant = value; }
        }


        private string _immatriculation;

        protected string Immatriculation
        {
            get { return _immatriculation; }
            set { _immatriculation = value; }
        }


        //public string getImmatriculation()
        //{
        //    return _immatriculation;
        //}
        //public void setImmatriculation(string imm)
        //{
        //    _immatriculation = imm;
        //}


        private string _modèle;
        protected string Modèle
        {
            get { return _modèle; }
            set { _modèle = value; }
        }

        private DateTime _dateconstruction;

        public DateTime DateConstruction
        {
            get { return _dateconstruction; }
            set { _dateconstruction = value; }
        }

        public Avion(string immatriculation ,string modèle, DateTime dateConstruction)
        {
            Identifiant = inc++;
            Immatriculation = immatriculation;
            Modèle = modèle;
            DateConstruction = dateConstruction;
        }

        public virtual string Description()
        {
            //return $"{Identifiant} :: {Immatriculation} :: {Modèle} :: {DateConstruction} ";
            return $"{Identifiant} :: {Immatriculation} :: {Modèle} :: {DateConstruction.ToShortDateString()} ";

        }

        public virtual void Démarrer()
        {

        }

        public virtual void Atterir()
        {

        }
    }
}
