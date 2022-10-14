using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //pour afficher le signe €
            Personne personne1 = new Personne("Monroe", "Maryline", new DateTime(1926, 06, 01));
            personne1.Présentation();

            Employé employé1 = new Employé("Defunès", "Louis", new DateTime(1914, 07, 31), 2100.6f);
            employé1.Présentation();

        }
    }
}
