using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1_ter
{
	public class Eleve : Personne
	{
		#region attributs
		public string? nom { get; set; }
		public string? prenom { get; set; }
		public string? genre { get; set; }
		public int? age { get; set; }
		#endregion


		public Eleve(string nom, string prenom, string genre, int age) : base(nom, prenom, genre, age)
		{
			this.nom = nom.ToUpper();
			this.prenom = prenom;
			this.genre = genre;
			this.age = age;
		}
	}
}
