using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2_Animaux
{
    public class Animal
    {
        #region attributs
        private string _id;
        private string _name;
        private string _description;
        private string _type;
        private string _image;

        #endregion

        #region Getter/Setter
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nom
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
        #endregion

        #region Méthodes


        public Animal(string name)
        {
            _id = System.Guid.NewGuid().ToString();
            Nom = name;
        }

        public Animal(string name, string description, string type, string image)
        {
            Id = System.Guid.NewGuid().ToString();
            Nom = name;
            Description = description;
            Type = type;
            Image = image;

        }
        public string Présentation()
        {
            return $"Bonjour, je m'appelle {Nom}\n Mon id est {Id}\n Mon type est : {Type} ";
        }

        public bool estVivant()
        {
            return true;
        }

        #endregion

    }
}
