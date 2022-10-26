using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Révision_Etudiants
{
    public class SchoolYear
    {
        private int _year;

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        private List<Teacher> _listeprof;

        public List<Teacher> ListeProf
        {
            get { return _listeprof; }
            set { _listeprof = value; }
        }
        private List<Student> _listeetudiants;

        public List<Student> ListeEtudiants
        {
            get { return _listeetudiants; }
            set { _listeetudiants = value; }
        }
        private List<Subject> _listematieres;

        public List<Subject> ListeMatières
        {
            get { return _listematieres; }
            set { _listematieres = value; }
        }


        public SchoolYear(int year, List<Student> listeetudiants, List<Teacher> listeprofs, List<Subject> listematieres)
        {
           Year = year;
            ListeEtudiants = listeetudiants;
            ListeProf = listeprofs;
            ListeMatières = listematieres;
        }

        public void Présentation()
        {
            Console.WriteLine($"Pour l'année scolaire {Year} - {Year+1} ");
            Console.WriteLine("\n\nListe des étudiants:");
            Console.WriteLine("-------------------");

            foreach(Student student in ListeEtudiants)
            {
               student.Présentation();
            }

            Console.WriteLine("\n\nListe des profs:");
            Console.WriteLine("-------------------");
            foreach (Teacher prof in ListeProf)
            {
                prof.Présentation();
            }

            Console.WriteLine("\n\nListe des matières:");
            Console.WriteLine("-------------------");
            foreach (Subject matière in ListeMatières)
            {
                matière.Présentation();
            }
        }
    }
}
