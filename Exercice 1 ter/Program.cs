using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace Exercice_1_ter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Professeur prof = new Professeur("Dupres", "Daniel", "Masculin", 43);
            Classe InfoClasse = new Classe();
            List<Eleve> ListeEtudiants = new List<Eleve>();


            Eleve etudiant1 = new Eleve("Dupont", "Pierre", "Monsieur", 35);
            Eleve etudiant2 = new Eleve("Durant", "Nicolas", "Monsieur", 27);
            Eleve etudiant3 = new Eleve("Dumarcher", "Elise", "Madame", 25);
            Eleve etudiant4 = new Eleve("Laporte", "Céline", "Madame", 28);


            etudiant1.SePrésenter();
            prof.SePrésenter();

            ListeEtudiants.Add(etudiant1);
            ListeEtudiants.Add(etudiant2);
            ListeEtudiants.Add(etudiant3);
            ListeEtudiants.Add(etudiant4);

            InfoClasse.Matiere = "POO";
            InfoClasse.elProfesseur = prof;
            InfoClasse.Eleves = ListeEtudiants;

            InfoClasse.SePresenter();

            
        }
    }
}
