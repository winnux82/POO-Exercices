using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1ter
{
	public class Etudiant
	{
		public int Age { get; set; }
		public string Genre { get; set; }
		public string Prenom { get; set; }
		public string Nom { get; set; }

		private Etudiant()
		{

		}
		public Etudiant(string nom, string prenom, string genre, int age)
		{
			Nom = nom;
			Prenom = prenom;
			Genre = genre;
			Age = age;
		}

		public void SePresenter()
		{
			Console.WriteLine($"Bonjour, je m'appelle {Genre} {Nom} {Prenom} et j'ai {Age} ans");
		}
	}
}