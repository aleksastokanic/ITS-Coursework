
using System.Collections.Generic;

namespace Knjige
{
    // Deklaracija delegata za obradu knjige:
    public delegate void DelegatObradeKnjige(Knjiga book);

    class BazaKnjiga
    {
        int brojKnjiga = 0;
        decimal cenaKnjiga = 0.0m;
        // Lista svih k u bazi:
        List<Knjiga> list = new List<Knjiga>();

        // konstruktor - popunjavanje baze njiga
        public BazaKnjiga()
        {
            dodajKnjigu(new Knjiga("Programski jezik C", "Brian W. Kernighan i Dennis M. Ritchie", 19.95m, true));
            dodajKnjigu(new Knjiga("Prokleta avlija", "Ivo Andrić", 39.95m, true));
            dodajKnjigu(new Knjiga("Derviš i smrt", "Meša Selimović", 129.95m, false));
            dodajKnjigu(new Knjiga("Nauka – Velika ilustrovana enciklopedija ", "Grupa autora", 12.00m, true));
        }

        public void dodajKnjigu(Knjiga k)
        {
            list.Add(k);
        }

        internal void formiranjeUkupneCene(Knjiga k)
        {
            brojKnjiga += 1;
            cenaKnjiga += k.Cena;
        }

        internal decimal srednjaCena()
        {
            return cenaKnjiga / brojKnjiga;
        }

        // Poziv delegata za svaku knjigu sa tvrdim povezom da bi je obradio:
        public void knjigeSaTvrdimPovezom(DelegatObradeKnjige dok)
        {
            foreach (Knjiga b in list)
            {
                if (b.Tvrdpovez)
                    // Poziv delegata:
                    dok(b);
            }
        }

        public void sveKnjige(DelegatObradeKnjige dok)
        {
            foreach (Knjiga b in list)
            {
                // Poziv delegata:
                dok(b);
            }
        }
    }

}
