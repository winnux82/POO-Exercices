using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5_Vehicules
{
   public class Voitures
    {
        private string _marque;

        public string Marque
        {
            get { return _marque; }
            set { _marque = value; }
        }

        private string _modèle;

        public string Modèle
        {
            get { return _modèle; }
            set { _modèle = value; }
        }
        private float _kilometrage;

        public float Kilometrage
        {
            get { return _kilometrage; }
            set { _kilometrage = value; }
        }

        private string _immatriculation;

        public string Immatriculation
        {
            get { return _immatriculation; }
            set { _immatriculation = value; }
        }


        public Voitures(string marque,string modèle)
        {
            Marque = marque;
            Modèle = modèle;
        }

        public Voitures(string marque, string modèle, float kilometrage, string immatriculation)
        {
            Marque = marque;
            Modèle = modèle;
            Kilometrage = kilometrage;
            Immatriculation = immatriculation;
        }

        public void Présentation()
        {
            Console.WriteLine($"Marque : {Marque} -- Modèle : {Modèle} -- Km : {Kilometrage} -- Immatriculation : {Immatriculation}");
        }
    }
}
