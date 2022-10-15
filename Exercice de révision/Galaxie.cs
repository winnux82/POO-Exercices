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
        public string? Nom { get; set; }


        #endregion

        #region Méthodes

        public Galaxie(string nom)
        {
            this.Nom = nom;
        }

        public void Description()
        {
            Console.WriteLine($"Je suis la galaxie {Nom} et je possède {Planete.NbPlanetes} planètes.");

        }
        #endregion

    }
}
