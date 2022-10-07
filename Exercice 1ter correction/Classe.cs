using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1ter
{
	public class Classe
	{
		public List<Etudiant> Etudiants { get; set; }
		public Professeur Prof { get; set; }
		public string Matiere { get; set; }

		private Classe()
		{

		}
		public Classe(List<Etudiant> etudiants, Professeur prof, string matiere)
		{
			Etudiants = etudiants;
			Prof = prof;
			Matiere = matiere;
		}

		public void SePresenter()
		{
			Console.Write($"la classe de {Matiere} est enseigné par {Prof.Genre} {Prof.Nom} {Prof.Prenom} et les étudiants participant au cours sont ");
			foreach (Etudiant student in Etudiants)
			{
				Console.Write($"{student.Nom} {student.Prenom} ");
			}

		}
	}

}