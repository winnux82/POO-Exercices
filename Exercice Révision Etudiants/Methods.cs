using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Révision_Etudiants
{
    public static class Methods
    {
        public static string PrenomUp(string pre)

        {
            pre = char.ToUpper(pre[0]) + pre.Substring(1);

            return pre;
        }

        public static string CreateId(string nom, string prenom)
        {
            nom = nom.Trim().ToUpper();
            prenom = prenom.Trim().ToUpper();
            string resultat = nom.Substring(0,3) + prenom.Substring(0,4);

            return resultat;
        }

        public static string CreatePwd()
        {
            string pwd = null;
            string characters = "abcdefghijklmnopqrstuvwxyz0123456789";
            int nb;
            Random random = new Random();
            for(int i=0; i<8;i++)
            {
                nb = random.Next(characters.Length);
                pwd += characters[nb];
            }

            return pwd;

        }
    }
}
