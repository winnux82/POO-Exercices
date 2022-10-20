using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_de_révision
{
    public class Planete
    {
        #region attributs
        private string _nom="";
        private float _masse;
        private float _diametre;
        #endregion

        #region Accesseurs

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public float Masse
        {
            //veillez empêcher la modification, en mettant setter private on peut encore l'utiliser mais pas en externe.  Cette partie là est réservée à ma classe.
            get { return _masse; }
            private set { _masse = value; }
        }

        public float Diametre
        {
            get { return _diametre; }
            set { _diametre = value; }
        }
        #endregion

        #region Méthodes
        protected Planete(string nom)
        {
            this.Nom = nom;
        }

        public Planete(string nom, float diametre) : this(nom)  
        {
            this.Diametre = diametre;
        }
        public Planete(string nom, float masse, float diametre) : this(nom,diametre)
        {
            this.Masse = masse;
        }

        //CTRL . pour créer les constructeurs.
        //propfull
        //ctor


        public void Description()
        {
            //Console.WriteLine($"Je suis la planète {1} de masse {2} relative par rapport à la terre.",Nom,Masse);
            Console.WriteLine($"Je suis la planète {Nom} de masse {Masse} relative par rapport à la terre.");
        }


        #endregion

    }
}
