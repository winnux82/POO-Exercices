using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5
{
    public class Animal
    {
        private string _cri;
        private int _age;

        public string Cri
        {
            get { return _cri; }
            set { _cri = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public static int AgeMaximum;


        public Animal()
        {
        }

        public Animal(int age) :this()
        {
            Age = age;
        }
        public Animal(string cri, int age):this()
        {
            Cri = cri;
        }

        public Animal(int age, int ageMaximum):this()
        {
            ageMaximum = age;
        }


        public Animal(string cri, int age, int ageMaximum):this()
        {
            AgeMaximum = ageMaximum;
        }

        public virtual void Crie()
        {
            Console.WriteLine(Cri);
        }

        public virtual void SeDeplace()
        {
            Console.WriteLine("L'animal se déplace en marchant");
        }
        public virtual void SeDeplace(int mètres)
        {
            Console.WriteLine($"L'animal se déplace de {mètres} mètres");
        }
        public void Veillit()
        {
            Console.WriteLine(++Age);
        }
        public void Veillit(int nb)
        {

            if ((Age + nb) > AgeMaximum)
                Console.WriteLine("Impossible, l'animal est mort");
            else
                Age += nb;
                Console.WriteLine($"L'animal a {Age} ans");
        }
        public void Mange()
        {
            Console.WriteLine("l'animal mange");
            Crie();
        }

        public virtual void Description()
        {
            Console.WriteLine();
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("Description");
            Console.WriteLine("-----------\n");
            Console.WriteLine($"L'animal a {Age} ans");
            Console.WriteLine($"L'age maximum de l'animal est de {AgeMaximum} ans");
            Console.WriteLine($"Le cri de l'animal est {Cri}\n");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
