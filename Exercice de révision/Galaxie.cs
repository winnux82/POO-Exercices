using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_de_révision
{
    public class Galaxie
    {
        #region getter/setter
        public string? NomGalaxie { get; set; }
        public List<Planete> ListePlanetes { get; set; }

        #endregion

        #region Méthodes

        public Galaxie(string nomgalaxie, List<Planete> listePlanetes)
        {
            NomGalaxie = nomgalaxie;
            ListePlanetes = listePlanetes;

            
        }

        public void Description()
        {
            Console.WriteLine($"Je suis la galaxie {NomGalaxie} et je possède {ListePlanetes.Count} planètes.");

            foreach (Planete p in ListePlanetes)
            {
                p.Description();
            }

        }
        #endregion

    }
}
