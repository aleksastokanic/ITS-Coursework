using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
    Kreirati klasu Laboratorija koja implementira interfejse IAnaliza i IIzvestaj,
i to prvi sa funkcionalnostima za dodelu rednog broja pacijentu int DodeliBroj() i vršenje trazene usluge 
void analizaUzorka(int labJedinica, Pacijent p), a drugi sa funkcionalnistima za rukovodioca u cilju evidencije 
aktivnosti pojedinačnih laboratorijskih jedinica void statistikaPoJedinicama().
    */

namespace Pacijenti
{
    class Laboratorija : IAnaliza, IIzvestaj
    {
        static int redniBroj=1;
        List<Pacijent> pacijenti = new List<Pacijent>();

        public void pregledajPacijenta(Pacijent p)
        {
            pacijenti.Add(p);
        }

        public void analizaUzorka(int labJedinica, Pacijent p)
        {
            p.LabJedinica = labJedinica;
            pacijenti.Add(p);
        }

        public int DodeliBroj()
        {
            return redniBroj++;
        }

        public void listaPacijenata()
        {
            // Statistički izveštaj primljenih pacijenata
            Console.WriteLine("\nLista pacijenata starijih od 50 god:\n");
            //var lista = from n in pacijenti where n.Starost > 50 select n;
            var lista = from n in pacijenti where n.Starost > 50 && (!n.KrvnaSlikaSaUrinom) orderby n.Ime select n;
            foreach (Pacijent p in lista)
                Console.WriteLine("Ime: " + p.Ime + ", godine: " + p.Starost);
        }
    }
}
