using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5
{
    public class Oiseau : Animal
    {
        
        public override void SeDeplace()
        {
            Console.WriteLine("Je me déplace en volant");
        }
        public Oiseau(int ageOiseau) : base(ageOiseau)
        {
            
            ageOiseau = Age;
            Cri = "Cuicui";
            AgeMaximum = 20;

        }
        public Oiseau(string criOiseau, int ageOiseau) : base(criOiseau, ageOiseau)
        {
            criOiseau = Cri;
            ageOiseau = Age;
            AgeMaximum = 20;

        }
    }
}
