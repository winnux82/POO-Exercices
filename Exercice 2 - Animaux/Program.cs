using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_2_Animaux
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            List<Animal> animal = new List<Animal>();
            animal.Add(new Animal("Azel"));
            animal.Add(new Animal("Bosco"));
            animal.Add(new Animal("CoCo"));

            foreach(Animal a in animal)
            {
                Console.WriteLine(a.Présentation());
            }

            Console.Write("\nVeuillez entrer un Nom : ");
            string RechercheNom = Console.ReadLine();

        }
    }
}
