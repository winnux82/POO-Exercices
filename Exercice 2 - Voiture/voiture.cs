using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2_Voiture
{
    public class Voiture
{
        private string _marque;
        private string _couleur;
        private string _matricule;
        private int _nbrChevaux;

        #region attributs
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
        public int NbreChevaux
        {
            get { return _nbrChevaux; }
            set { _nbrChevaux = value; }
        }
        #endregion

        #region
        public Voiture()
        {

        }

        public Voiture(string marque, string couleur, string matricule, int nbrChevaux)
        {

            Marque = marque;
            Couleur = couleur;
            Matricule = matricule;
            NbreChevaux = nbrChevaux;
        }

        public Voiture(string matricule)
        {
            Matricule = matricule;
        }

        public string Présentation()
        {
            return $"Marque --> {Marque} :: Couleur --> {Couleur} :: Matricule --> {Matricule} :: Puissance --> {NbreChevaux}";
        }

        #endregion
    }
}
