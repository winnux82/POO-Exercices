using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1quater
{


class Etudiant : Personne
{
    string infoEtudes;
    public Etudiant(string nom, int age, string infoEtudes, Prof ProfesseurPrincipal = null) : base(nom, age, "Etudiant")
    {
        this.infoEtudes = infoEtudes;
            ProfesseurPrincipal.Afficher();


    }

    public override void Afficher()
    {
        AfficherNomEtAge();
        Console.WriteLine("  Etudiant en " + infoEtudes);
        Console.WriteLine("  Le professeur principal est : ");
            

    }

}
}