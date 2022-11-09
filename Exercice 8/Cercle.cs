using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_8
{
    public class Cercle : FormeGeometrique
    {
        public int Rayon { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Cercle(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
        public override float CalculerPerimetre()
        {
           return (2 * (float)Math.PI * Rayon);
        }

        public override float CalculerSurface()
        {
            return (2 * (float)Math.PI * Rayon);
        }
        public override float CalculerVolume()
        {
            return 0;
        }

    }
}
