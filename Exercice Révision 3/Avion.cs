using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Révision_3
{
    public abstract class Avion
    {
        private static int inc;
        private int _identifiant;

        public int Identifiant
        {
            get { return _identifiant; }
            set { _identifiant = value; }
        }


        private string _immatriculation;

        public string Immatriculation
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
        public string Modèle
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

        public string  Description()
        {
            return $"{Identifiant} :: {Immatriculation} :: {Modèle} :: {DateConstruction} ";
        }

        public virtual void Démarrer()
        {

        }

        public virtual void Atterir()
        {

        }
    }
}
