using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozialNetwork_GA1_2019
{
    class Kommentar
    {
        Person absender;
        string kommentarText;

        public Kommentar()
        {

        }

        public Person getAbsender()
        {
            return absender;
        }

        public string getKommentarText()
        {
            return kommentarText;
        }
    }
}
