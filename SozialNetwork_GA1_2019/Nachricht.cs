using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozialNetwork_GA1_2019
{
    abstract class Nachricht
    {

        protected int likes;
        Person absender;
        List<Kommentar> kommentarliste;

        public Person Absender { get => absender; set => absender = value; }
        protected int Likes { get => likes; set => likes = value; }
        public List<Kommentar> Kommentarliste { get => kommentarliste; }

        public Nachricht()
        {
            this.Likes = 0;
            kommentarliste = new List<Kommentar>();
        }

        public Nachricht(Person absender)
        {
            this.Likes = 0;
            this.Absender = absender;
            kommentarliste = new List<Kommentar>();
        }

        public void hinzufuegenLike()
        {
            Likes++;
        }

        public void hinzufuegenKommentar(Kommentar kommentar)
        {
            kommentarliste.Add(kommentar);
        }


        public abstract string getNachricht();
    }
}
