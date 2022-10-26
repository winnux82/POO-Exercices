using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Révision_Etudiants
{
    public class Student : Person
    {

        private string _persoid;

        public string PersoId
        {
            get { return _persoid; }
            set { _persoid = value; }
        }

        private string _persopwd;

        public string PersoPwd
        {
            get { return _persopwd; }
            set { _persopwd = value; }
        }


        public Student(string nom, string prenom) : base(nom, prenom)
        {
            PersoId = Methods.CreateId(nom, prenom);
            PersoPwd = Methods.CreatePwd();

        }

        public Student(string nom, string prenom, DateTime datenaissance, string genre, string adresse):base(nom, prenom, datenaissance, genre, adresse)
        {
            PersoId = Methods.CreateId(nom, prenom);
            PersoPwd = Methods.CreatePwd();
        }

        public override void Présentation()
        {
            base.Présentation();
            Console.Write($"Identifiant : {PersoId} \nMot de passe: {PersoPwd}");
        }
    }
}
