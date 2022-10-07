using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace Exercice_1bis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Professeur prof = new Professeur();
            Classe maclasse = new Classe();
            List<Etudiant> Students = new List<Etudiant>();

            //prof.Nom = "DUPRES";
            //prof.Prenom = "Daniel";
            //prof.Genre = "Masculin";
            //prof.Age = 43;

            Etudiant etudiant1 = new Etudiant();
            Etudiant etudiant2 = new Etudiant();
            Etudiant etudiant3 = new Etudiant();
            Etudiant etudiant4 = new Etudiant();

            etudiant1.Nom = "DUPONT";
            etudiant1.Prenom = "Pierre";
            etudiant1.Genre = "Monsieur";
            etudiant1.Age = 35;

            etudiant2.Nom = "DURANT";
            etudiant2.Prenom = "Nicolas";
            etudiant2.Genre = "Monsieur";
            etudiant2.Age = 27;

            etudiant3.Nom = "DUMARCHER";
            etudiant3.Prenom = "Elise";
            etudiant3.Genre = "Madame";
            etudiant3.Age = 25;

            etudiant4.Nom = "LAPORTE";
            etudiant4.Prenom = "Céline";
            etudiant4.Genre = "Madame";
            etudiant4.Age = 28;

            Students.Add(etudiant1);
            Students.Add(etudiant2);
            Students.Add(etudiant3);
            Students.Add(etudiant4);

            maclasse.Matiere = "POO";
            maclasse.Prof = prof;
            maclasse.Etudiants = Students;

            prof.Maclasse = maclasse;

            maclasse.SePresenter();
        }
    }
}