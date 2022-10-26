using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Révision_Etudiants
{
    public class Subject
    {

        public static int inc=1;
        public int ID { get; set; }
        public string Name { get; set; }

        public Subject(string name)
        {
            ID = inc++;
            Name = name;
        }

        public virtual void Présentation()
        {
            Console.WriteLine($"{ID} :: {Name}");
        }
    }
}
