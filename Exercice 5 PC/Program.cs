using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_5_PC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PC monordi = new PC("Asus Rog", 5555, 1099.99f, "AMD Ryzen 9; Geforce RTX; 32 GB");
            PC tonordi = new PC("Asus Rog", 5555, 1099.99f, "AMD Ryzen 9; Geforce RTX; 32 GB");
            PCPortable portable1 = new PCPortable("Asus Rog", 554978, 3066.33f, "Amd Ryzen 9; Geforce RTX 3060; 32 GB",17.3f);

            monordi.Décrire();
            portable1.Décrire();
        }
    }
}
