using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozialNetwork_GA1_2019
{
    class Program
    {
        static void Main(string[] args)
        {

            SozialesNetzwerk snw = new SozialesNetzwerk();

            bool firstPerson = true; 

            for(int i=0; i<2; i++)
            {
                Person person = new Person("nachname" + i, "vorname" + i);
                Textnachricht textnachricht = new Textnachricht("nachricht" + i, person);
                if (firstPerson)
                {
                    textnachricht.hinzufuegenLike();
                    firstPerson = !firstPerson;
                }
                snw.hinzufuegenMitglied(person);
                snw.hinzufuegenNachricht(textnachricht);
            }
            Console.WriteLine(snw.getAlleNachrichten());

            string satz = "Ich generiere mir ein neues Password";
            Console.WriteLine(satz); 
            Console.WriteLine(snw.getPassword(satz));

            while (true)
                Console.ReadLine();
        }

    }
}
