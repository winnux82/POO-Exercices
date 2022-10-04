using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1_ter
{
    public class Professeur : Personne
    {

        #region Attributs

        private string? _genre;

        public string? nom { get; set; }
        public string? prenom { get; set; }
        public string? genre
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
        public int age { get; set; }

        #endregion

        public Professeur(string nom, string prenom, string genre, int age) : base(nom, prenom, genre, age)
        {
            this.nom = nom.ToUpper();
            this.prenom = prenom;
            this.genre = genre;
            this.age = age;
        }
    }
}
