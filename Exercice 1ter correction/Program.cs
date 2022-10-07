using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_1ter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Professeur prof = new Professeur("DUPRES", "Daniel", "Masculin", 43);

            Etudiant etudiant1 = new Etudiant("DUPONT", "Pierre", "Monsieur", 35);
            Etudiant etudiant2 = new Etudiant("DURANT", "Nicolas", "Monsieur", 27);
            Etudiant etudiant3 = new Etudiant("DUMARCHER", "Elise", "Madame", 25);
            Etudiant etudiant4 = new Etudiant("LAPORTE", "Céline", "Madame", 28);
            List<Etudiant> Students = new List<Etudiant>() { etudiant1, etudiant2, etudiant3, etudiant4 };

            Classe maclasse = new Classe(Students, prof, "POO");

            prof.Maclasse = maclasse;

            maclasse.SePresenter();
        }
    }
}