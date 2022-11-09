using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_de_révision_Planètes
{
    public class Planete
    {
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        private float _masse;

        public float Masse
        {
            get { return _masse; }
            set { _masse = value; }
        }

        private float _diametre;

        public float Diametre
        {
            get { return _diametre; }
            set { _diametre = value; }
        }

        public Planete()
        {

        }
        public Planete(string nom):this()
        {
            Nom = nom;
        }

        public Planete(string nom, float diametre ) : this(nom)
        {

            Diametre = diametre;
        }

        public Planete(string nom,float masse, float diametre) : this(nom,diametre)
        {
            Masse = masse;
        }

        public void Description()
        {
            Console.WriteLine($"Je suis la planète {Nom} de masse {Masse} relative par rapport à la terre");
        }

    }
}
