using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_Révision_Etudiants
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var etudiant1 = new Student("Vandermeulen", "christophe", new DateTime(1982, 4, 1), "Homme", "Rue de Roulers 69");
            var etudiant2 = new Student("                 qdfqsfqsf  ", "prou" );

            //etudiant1.Présentation();
            //etudiant2.Présentation();
            var ListeEtudiants = new List<Student>() { etudiant1,etudiant2};

            var prof1 = new Teacher("Sbai", "Ahmed", new DateTime(2022, 04, 01), "Homme", "je sais pas", "Prof principal");
            var prof2 = new Teacher("Bourrhim", "Ahmed", new DateTime(2022, 04, 01), "Homme", "je sais pas", "C#");

            //prof1.Présentation();
            var ListeProfs = new List<Teacher>() { prof1, prof2 };

            var matière1 = new Subject("POO");
            var matière2 = new Subject("Javascript");
            var matière3 = new Subject("PHP");
            var matière4 = new Subject("C#");

            List<Subject> ListeMatières = new List<Subject>() {matière1,matière2,matière3,matière4 };
            //foreach(Subject mati in ListeMatières)
            //{
            //    mati.Présentation();
            //}

            var AnnéeScolaire2022 = new SchoolYear(2022, ListeEtudiants, ListeProfs, ListeMatières);

            AnnéeScolaire2022.Présentation();

        }
    }
}
