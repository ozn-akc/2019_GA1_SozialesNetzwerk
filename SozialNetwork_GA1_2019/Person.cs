using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozialNetwork_GA1_2019
{
    public class Person
    {
        string vorname;
        string nachname;

        public Person()
        {
            vorname = String.Empty;
            nachname = String.Empty;
        }

        public Person(string nn, string vn)
        {
            vorname = vn;
            nachname = nn;
        }

        public string getNachname()
        {
            return nachname;
        }

        public string getVorname()
        {
            return vorname;
        }

    }
}
