using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5_Vehicules
{
    public class Vehicule
    {
        private string _id;

        public string ID
        {
            set { _id = value; }
        }

        public Vehicule()
        {
            ID = System.Guid.NewGuid().ToString();
        }



    }
}
