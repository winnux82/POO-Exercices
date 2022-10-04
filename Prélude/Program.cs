namespace Exercice_1

{
    public class Program
    {
        class Rectangle
        {
            //par défaut si on ne mets pas public, les attributs sont privés
            //On mets _ dans la nomenclature pour déclarer des variables privées
            //si on veut respecter le principe d'encapsulation, on doit mettre en privé.
            #region Attributs

            private float _longueur;
            private float _largeur;
            private float _surface;

            #endregion

            //Création des méthodes.

            #region getters & setters
            public float getLongeur() { return _longueur; }
            public float getlargeur() { return _largeur; }
            public void setLongueur(float l) { _longueur = l; }
            public void setLargeur(float l) { _largeur = l; }

            //prop tab tab
            public int MyProperty { get; set; }





            #endregion

            void CalculerSurface()
            {

            }


            //ctor tab tab pour créer le constructeur
            //ce constructeur va aller dans celui ci si on entre pas de valeurs.
            public Rectangle()
            {
                _longueur = 5;
            }



            public Rectangle(float l, float L)
            {
                _longueur = L;
                _largeur = l;
                _surface = l * L;
            }

        }


        //F11 pour passer les points d'arrêts

        public static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 8);

            Console.WriteLine(rect.getLongeur());



        }

    }
}