using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1ter
{
    public class Professeur
    {
        public Classe Maclasse { get; set; }
        public int Age { get; set; }
        public string Genre { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        private Professeur()
        {

        }
        public Professeur(string nom, string prenom, string genre, int age)
        {
            Nom = nom;
            Prenom = prenom;
            Genre = genre;
            Age = age;
        }
        public void SePresenter()
        {
            Console.WriteLine($"Bonjour, je m’appelle {Genre} {Nom} {Prenom} et je suis votre professeur de {Maclasse.Matiere}");

        }
    }
}