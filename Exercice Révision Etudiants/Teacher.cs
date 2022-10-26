using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Révision_Etudiants
{
    public class Teacher : Student
    {

        private string _matiere;

        public string Matière
        {
            get
            {
                return _matiere;
            }
            set
            {
                _matiere = value;
            }
        }

        public Teacher(string nom, string prenom, DateTime datenaissance, string genre, string adresse, string matière) : base(nom, prenom, datenaissance, genre, adresse)
        {
            PersoId = Methods.CreateId(nom, prenom);
            PersoPwd = Methods.CreatePwd();
            
            Matière = matière;
        }
        public override void Présentation()
        {
            base.Présentation();
            Console.WriteLine($"\nMatière principale: {Matière}");
        }
    }
}
