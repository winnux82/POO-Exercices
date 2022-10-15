using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5_PC
{
    public class PC: Description
    {
        #region Attributs
        private string _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _ref;

        public int Reference
        {
            get { return _ref; }
            set { _ref = value; }
        }
        private float _prix;

        public float Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }
        private string _caract;

        public string Caractéristiques
        {
            get { return _caract; }
            set { _caract = value; }
        }

        #endregion

        //var statique
        static int nbPcs = 0;

        #region Méthodes

        public PC()
        {
            ID = System.Guid.NewGuid().ToString();
            nbPcs++;
        }
        public PC(string name, int reference, float prix, string caracteristiques):this()
        {
            

            this.Name = name;
            this.Reference = reference;
            this.Prix = prix;
            this.Caractéristiques = caracteristiques;

        }

        public virtual void Décrire()
        {
            
            DonnerCaractéristique();
            Console.WriteLine("Prix TTC : " + Prix);

            if(nbPcs > 5)
            {
                Console.WriteLine("Nous avons bcp de pc en stock!");
            }
            Console.WriteLine("***********************************");

        }

        protected void DonnerCaractéristique()
        {
            Console.WriteLine("****************Caractéristiques de l'ordinateur ****************");
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Nom: " + Name);
            Console.WriteLine("Ref: " + Reference);
            string[] caracts = Caractéristiques.Split(';');
            Console.WriteLine("CPU : " + caracts[0]);
            Console.WriteLine("GPU : " + caracts[1]);
            Console.WriteLine("RAM : " + caracts[2]);



            Console.WriteLine("**************** FIN ****************");

        }
        #endregion
    }

}