using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_de_révision_Planètes
{
    public class Galaxie
    {
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        private List<Planete> _listeplanete;

        public List<Planete> ListePlanete
        {
            get { return _listeplanete; }
            set { _listeplanete = value; }
        }

        public Galaxie(string nom, List<Planete> listePlanete)
        {
            Nom = nom;
            ListePlanete = listePlanete;
        }

        public void Description()
        {
            Console.WriteLine($"Je suis la galaxie {Nom} et je possède {ListePlanete.Count} planètes.");

        
        }


    }
}
