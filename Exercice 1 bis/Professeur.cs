using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1_bis
{
    public class Professeur : Personne
    {

        #region Attributs



        public string nom { get; set; }
        public string prenom { get; set; }
        public string genre { get; set; }
        public int age { get; set; }
        private Classe maclasse { get; set; }
        /*#region Accesseurs
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
        */
        #endregion

        public Professeur(string nom, string prenom, string genre, int age) : base(nom, prenom,genre, age)
        {
            this.nom = nom.ToUpper();
            this.prenom = prenom;
            this.genre = genre;
            this.age = age;
        }
    }
}
