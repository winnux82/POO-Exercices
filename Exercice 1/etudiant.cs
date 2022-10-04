using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Etudiant

- nom ->
- prenom ->
- age
- genre

--------

+ SePresenter()
+ getNom()
+ getPrenom()
+ getAge()
*/


// prop tab tab
// ctor tab tab


namespace Exercice_1
{
    public class etudiant
    {
        #region Attributs
        private string _nom;
        private string _prenom;
        private int _age;
        private string _genre;
        #endregion




        #region Accesseurs GETTER & SETTER
        // Accesseur ou getter "classique"
        //Version 1
        public string getNom()
        {
            return _nom;
        }

        //Mutateur ou setter "classique"
        public void setNom(string nom)
        {
            _nom = nom.ToUpper();
        }

        //Accesseurs ou getter et setter version c#

        public string Prenom
        {
            get
            {
                return _prenom;
            }
            set
            {
                _prenom = PrenomFirstUpper(value);
            }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        // Accesseurs (getter et setter) qui prend la forme d'une propriété en C#
        // Version 3 du langage C#
        public string Genre { get; set; }

        //version 6
        private string _title;
        public string Title { get => _title; set => _title = value; }

        #endregion

        #region méthodes publiques de la classe

        public void SePresenter()
        {
            Console.WriteLine($"Bonjour Monsieur le professeur, je m'appelle {_genre} {_nom} {_prenom} et j'ai {_age} ans");
        }
        public string PrenomFirstUpper(string pre)

        {
            pre = char.ToUpper(pre[0]) + pre.Substring(1);

            return pre;
        }

        #endregion



    }

}