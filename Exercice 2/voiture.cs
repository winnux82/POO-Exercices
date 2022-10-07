using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    public class Voiture
    {
        private string _marque;
        private string _couleur;
        private string _matricule;
        private int _nombre_de_chevaux;

        public string Marque
        {
            get { return _marque; }
            set { _marque = value; }
        }
        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }
        public string Matricule
        {
            get { return _matricule; }
            set { _matricule = value; }
        }
        public int Nombre_De_Chevaux
        {
            get { return _nombre_de_chevaux; }
            set { _nombre_de_chevaux = value; }
        }

        public Voiture()
        {

        }

        public Voiture(string marque, string couleur, string matricule, int nb_chevaux)
        {
            Marque = marque;
            Couleur = couleur;
            Matricule = matricule;
            Nombre_De_Chevaux = nb_chevaux;
        }

        public Voiture(string matricule)
        {
            Matricule = matricule;
        }

        public string Presentation()
        {
            return $"Marque --> {Marque} :: Couleur --> {Couleur} :: Matricule --> {Matricule} :: Puissance --> {Nombre_De_Chevaux}";
        }
    }
}