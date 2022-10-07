using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1bis
{
	public class Etudiant
	{
		private string _nom;
		private string _prenom;
		private string _genre;
		private int _age;
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

		public void SePresenter()
		{
			Console.WriteLine($"Bonjour, je m'appelle {Genre} {_nom} {_prenom} et j'ai {_age} ans");
		}
	}
}