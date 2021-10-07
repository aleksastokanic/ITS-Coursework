using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class Banka : IBanka, IIzvestaj
    {
        private string naziv; private int broj;
        // salteri banke, u kolekciji dictionary
        // salteri moraju biti jednisteni, a na svakom se usluzi lista klijenata 
        private Dictionary<int, List<Klijent>> salteri;

        public Banka(string n)
        {
            naziv = n; broj = 0;
            salteri = new Dictionary<int, List<Klijent>>();   // inicijalizacija 4 saltera 
            salteri.Add(1, new List<Klijent>());
            salteri.Add(2, new List<Klijent>());
            salteri.Add(3, new List<Klijent>());
            salteri.Add(4, new List<Klijent>());
        }

        // implementacija metoda interfejsa IBanka
        public int uzmiBroj()
        {
            return ++broj;
        }

        public void usluga(int salter, Klijent k)
        {
            salteri[salter].Add(k);
        }

        // implementacija metoda interfejsa IIzvestaj
        public void dnevniIzvestaj()
        {
            Console.WriteLine("************ DNEVNI IZVESTAJ **************");
            foreach (var klijent in salteri)
            {
                Console.WriteLine("\nSalter: " + klijent.Key);
                foreach (Klijent k in klijent.Value)
                    Console.WriteLine("\t" + k);
            }
            Console.WriteLine("************ KRAJ **************");
         }
    }

}

