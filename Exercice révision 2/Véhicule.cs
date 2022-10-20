using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_révision_2
{
    public abstract class Véhicule
    {
        private static int Nb = 1;
        #region Getter/setter


        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _immatriculation ;

        public string Immatriculation
        {
            get { return _immatriculation ; }
            set { _immatriculation  = value; }
        }
        private string _fabricant;

        public string Fabricant
        {
            get { return _fabricant; }
            set { _fabricant = value; }
        }

        private string _modèle;

        public string Modèle
        {
            get { return _modèle; }
            set { _modèle = value; }
        }

        private DateTime _datefabrication;

        public DateTime DateFabrication
        {
            get { return _datefabrication; }
            set { _datefabrication = value; }
        }
        #endregion
        #region méthodes


        public Véhicule(string immatriculation, string fabricant, string modèle, DateTime datefabrication)
        {
            this.ID= AutoIncrémentation();
            this.Immatriculation = immatriculation;
            this.Fabricant = fabricant;
            this.Modèle = modèle;
            this.DateFabrication = datefabrication;
        }

        public virtual string Description()
        {
            return ($"{ID} :: {Immatriculation} :: {Fabricant} :: {Modèle} :: {DateFabrication} ");
        }

        public virtual void  Démarrer()
        {
            Console.WriteLine("Le véhicule démarre");
        }
        public virtual void Accélérer()
        {
            Console.WriteLine("Le véhicule accélère");
        }
        private int AutoIncrémentation()
        {
            return Nb++;
        }
        #endregion

    }
}
