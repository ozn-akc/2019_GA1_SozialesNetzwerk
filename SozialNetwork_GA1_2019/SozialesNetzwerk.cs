using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozialNetwork_GA1_2019
{
    class SozialesNetzwerk
    {

        List<Person> mitgliederliste;
        List<Nachricht> nachrichtenliste;

        public SozialesNetzwerk()
        {
            mitgliederliste = new List<Person>();
            nachrichtenliste = new List<Nachricht>();
        }

        public void hinzufuegenMitglied(Person person)
        {
            mitgliederliste.Add(person);
        }

        public void hinzufuegenNachricht(Nachricht nachricht)
        {
            nachrichtenliste.Add(nachricht);
        }

        public string getAlleNachrichten()
        {
            string alleNachrichten = String.Empty;

            nachrichtenliste.ForEach(nachricht => alleNachrichten += nachricht.getNachricht() + "\r\n");

            return alleNachrichten;
        }

        public string getPassword(string satz)
        {
            string password = String.Empty;
            List<string> woerterInSatz = satz.Split(' ').ToList();
            bool upperCase = true;
            woerterInSatz.ForEach(
                wort =>
                {
                    if (upperCase)
                    {
                        password += wort.Substring(0, 1).ToUpper();
                    }
                    else
                    {
                        password += wort.Substring(0, 1).ToLower();
                    }
                    upperCase = !upperCase;
                }
                );
            return password;
        }
    }
}
