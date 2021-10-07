using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Korpa : IKupovina, IEnumerable
    {
        private List<Hrana> hrana_kupljeno = new List<Hrana>();


        // private Hrana[] hrana_kupljeno = new Hrana[50];
        /*
        public Hrana this[int indeks]
        {
            get
            {
                return hrana_kupljeno[indeks];
            }

            set
            {
                hrana_kupljeno[indeks] = value;
            }
        }
        */

        public Hrana this[int indeks]
        {
            get { return hrana_kupljeno[indeks]; }
            set { hrana_kupljeno[indeks] = value;  }
        }



        public void dodajHranu(Hrana h)
        {
            if (h.BrojKalorija > 1000) throw new NezdravaHrana("Hrana nije zdrava");
            else hrana_kupljeno.Add(h);
        }

        public IEnumerator GetEnumerator()
        {
            return hrana_kupljeno.GetEnumerator();
        }

        public double racunajCenuKorpe()
        {
            double suma = 0;
            foreach (Hrana h in hrana_kupljeno)
                suma += h.prodajnaCena();
            return suma;
        }

        public void izlistaj()
        {
            foreach (Hrana h in hrana_kupljeno)
                Console.WriteLine(h.Naziv);
        }
    }

    class NezdravaHrana : Exception
    {
        public NezdravaHrana(string poruka)
        {
            Console.WriteLine(poruka);
        }
    }
}
