using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle(2,3,4);
            Console.WriteLine(triangle1.CalculerSurface());


            Cercle cercle1 = new Cercle(2, 3);
            Console.WriteLine(cercle1.CalculerPerimetre());
            
        }

        

        
    }
}
