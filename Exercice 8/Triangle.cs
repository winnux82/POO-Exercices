using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_8
{
    public class Triangle : FormeGeometrique
    {

        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Triangle(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override float CalculerPerimetre()
        {
            return(x + y + z);
        }

        public override float CalculerSurface()
        {
           return ((x*y)/2);
        }

        public override float CalculerVolume()
        {
            return((x*y*z)/2);
        }
    }
}
