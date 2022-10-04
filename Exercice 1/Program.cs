using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            etudiant pierredupont = new etudiant();
            pierredupont.setNom("Dupont");
            pierredupont.Prenom = "Pierre";
            pierredupont.Genre = "Monsieur";
            pierredupont.Age = 35;
            pierredupont.SePresenter();

            //alt shift pour modifier plusieurs lignes.

            etudiant nicolasdurant = new etudiant();
            nicolasdurant.setNom("Durant");
            nicolasdurant.Prenom = ("nicolas");
            nicolasdurant.Genre = ("Monsieur");
            nicolasdurant.Age = (27);
            nicolasdurant.SePresenter();

            etudiant elisedumarcher = new etudiant();
            elisedumarcher.setNom("Dumarcher");
            elisedumarcher.Prenom = "Elise";
            elisedumarcher.Genre = "Madame";
            elisedumarcher.Age = 25;
            elisedumarcher.SePresenter();

            etudiant celinelaporte = new etudiant();
            celinelaporte.setNom("Laporte");
            celinelaporte.Prenom = "céline";
            celinelaporte.Genre = "Madame";
            celinelaporte.Age = 28;
            celinelaporte.SePresenter();


        }


    }


}

