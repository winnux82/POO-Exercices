using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1bis
{
    public class Professeur
    {
        #region attributs ou champs
        private string _nom;
        private string _prenom;
        private string _genre;
        private int _age;
        private Classe classe;
        #endregion

        #region Accesseurs
        public Classe Maclasse
        {
            get { return classe; }
            set { classe = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Genre
        {
            get
            {
                string str = string.Empty;
                if (_genre == "Masculin")
                {
                    str = "M.";

                }
                else
                {
                    str = "Mme";
                }

                return str;
            }
            set { _genre = value; }
        }
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        #endregion

        public void SePresenter()
        {
            Console.WriteLine($"Bonjour, je m’appelle {Genre} {Nom} {Prenom} et je suis votre professeur de {Maclasse.Matiere}");

        }
    }
}