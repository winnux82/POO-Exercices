using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//coucou
namespace Exercice_de_révision
{
    public class Galaxie
    {
        #region getter/setter  == Accesseurs / Mutateurs

        public string? NomGalaxie { get; set; }
        public List<Planete> ListePlanetes { get; set; }

        #endregion getter/setter  == Accesseurs / Mutateurs

        #region Méthodes

        public Galaxie(string nomgalaxie, List<Planete> listePlanetes = null)
        {
            NomGalaxie = nomgalaxie;
            ListePlanetes = listePlanetes;
        }

        public string Desc()
        {
            return ($"Je suis la galaxie {NomGalaxie} et je possède {ListePlanetes.Count} planètes.");
        }

        public string Description()
        {
            return($"Je suis la galaxie {NomGalaxie} et je possède {ListePlanetes.Count} planètes.");
            if (ListePlanetes.Count > 0)
            {
                //ListePlanetes = ListePlanetes.OrderBy(p => p.Nom).ToList();
                ListePlanetes = ListePlanetes.OrderBy(n => n.Nom).ToList();
                foreach (Planete p in ListePlanetes)
                {
                    Console.WriteLine(p.Description());
                }
            }
        }

        #endregion Méthodes
    }
}