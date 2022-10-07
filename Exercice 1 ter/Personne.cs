using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1_ter
{
    public abstract class Personne
    {
        protected string nom;
        protected string prenom;
        protected int age;
        protected string genre;

        public Personne(string nom, string prenom, string genre, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.genre = genre;
                   }

        public void Créer(Personne unePersonne)
        {
            unePersonne.nom = nom;
            unePersonne.prenom = prenom;
            unePersonne.genre = genre;
            unePersonne.age = age;
        }
        public void SePrésenter()
        {
            Console.WriteLine($"Bonjour, je m'appelle {genre} {nom} {prenom} et j'ai {age} ans");
        }
    }

}
