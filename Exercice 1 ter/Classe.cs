using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1_ter
{
	public class Classe
	{

		#region attributs
		public List<Eleve> Eleves { get; set; }
		public Professeur elProfesseur { get; set; }
		public string? Matiere { get; set; }


		#endregion


		public void SePresenter()
		{


			Console.Write($"La classe de {Matiere} est enseigné par {elProfesseur.genre} {elProfesseur.nom} {elProfesseur.prenom} et les étudiants participant au cours sont :");
			foreach (Eleve student in Eleves)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write($"\n - {student.genre} {student.nom} {student.prenom} ");
				Console.ForegroundColor = ConsoleColor.White;
			}

		}
	}

}
