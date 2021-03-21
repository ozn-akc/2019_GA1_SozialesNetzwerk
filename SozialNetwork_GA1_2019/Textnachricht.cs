using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozialNetwork_GA1_2019
{
    class Textnachricht : Nachricht
    {
        string nachricht;

        public Textnachricht()
        {
            this.nachricht = String.Empty;
        }

        public Textnachricht(string nachricht, Person absender)
        {
            this.nachricht = nachricht;
            Absender = absender;
        }

        public override string getNachricht()
        {
            return "Name: " + Absender.getVorname() + " " + Absender.getNachname() + "; Likes: " + Likes ;
        }
    }
}
