using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Korpa : IKupovina
    {

        List<Racunar> racunarKupljeno = new List<Racunar>();

        public Racunar this[int indeks]
        { 
            get
            {
                return racunarKupljeno[indeks];
            }

            set
            {
                racunarKupljeno[indeks] = value;
            }
        }


        public void dodajRacunar(Racunar r)
        {
            if (r.Cena > 10000) throw new SkupArtikal();
            racunarKupljeno.Add(r);
        }

        public double nadjiNajskuplji()
        {
            double cena = 0;
            foreach(Racunar r in racunarKupljeno)
            {
                if (r.prodajnaCena() > cena) cena = r.prodajnaCena();
            }
            return cena;
        }

        public void stampajRacun()
        {
            double suma = 0;
            string st;
            foreach(Racunar r in racunarKupljeno)
            {
                if (r.NaAkciji) st = ", cena sa popustom: " + r.prodajnaCena(); else st = "";
                Console.WriteLine("Računar " + r.Naziv + ", cena: " + r.Cena + st );
                suma += r.prodajnaCena();
            }
            Console.WriteLine();
            Console.WriteLine("Ukupan iznos za naplatu: " + suma + " din");
        }

        public class SortPoCeni : IComparer<Racunar>
        {
            public int Compare(Racunar x, Racunar y)
            {
                if (x.Cena < y.Cena) return -1;
                if (x.Cena > y.Cena) return 1;
                return 0;

            }
        }

    }



}


