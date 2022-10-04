using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1_bis
{
    public class Eleve : Personne
    {
		#region attributs
		/*
		private string _nom;
		private string _prenom;
		private string _genre;
		private int _age;
		*/


		public string nom { get; set; }
		public string prenom { get; set; }

		public string genre { get; set; }

		public int age { get; set; }
        /*
		public int Age
		{
			get { return _age; }
			set { _age = value; }
		}
		public string Genre
		{
			get { return _genre; }
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
		*/
        #endregion


        public Eleve(string nom, string prenom, string genre, int age) : base(nom, prenom, genre, age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.genre = genre;
            this.age = age;
        }
    }
}
