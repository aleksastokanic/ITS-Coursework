using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1._2
{
    // delegata je najbolje da deklarišemo van klase, unutar namespace
    public delegate void delegatTurista(Turista t);

    class Autobus : IPutovanje
    {
        List<Turista> lista = new List<Turista>();
        private int kapacitet;
        private double cenaKarte;
        private int brSedista;

        /*
        public int Kapacitet { get => kapacitet;}
        public double CenaKarte { get => cenaKarte; set => cenaKarte = value; }
        public int BrSedista { get => brSedista; set => brSedista = value; }
        */

        public int slobodnoSediste
        {
            get
            { return kapacitet - BrSedista; }
        }

        public int BrSedista
        {
            get
            {
                return brSedista;
            }

            set
            {
                brSedista = value;
            }
        }

        public List<Turista> Lista
        {
            get
            {
                return lista;
            }
        }

        public Autobus(int kapacitet, double cenaKarte)
        {
            this.kapacitet = kapacitet;
            this.cenaKarte = cenaKarte;
            BrSedista = 0;
        }

        // Ove dve globalne promenljive uvodimo kako bi izračunavanje proseka preko delegata moglo da funkcioniše
        private double sumaCene=0;
        private int brPutnika = 0;

        // Ovo je metod koji delegiramo u glavnom programu i šaljemo ga metodu koji računa prosek
        // internal - vidljiv samo na nivou celog namespace, ali ne i van njega
        internal void sumaKarata(Turista t)   
        {
            sumaCene += t.CenaKarte;
            brPutnika++;
        }

        public double racunajProsek(delegatTurista ds)
        {
            foreach (Turista t in Lista)
                ds(t);
            return sumaCene / brPutnika;
        }

        public void usaoTurista(Turista t)
        {
            if (slobodnoSediste > 0)
            {
                Lista.Add(t);
                BrSedista++;
            }
            else
            throw new NemaMesta();
        }

        
        public List<Turista> GetTurista()
        {
            return Lista;
        }
        
        
        public IEnumerator GetEnumerator()
        {
            return Lista.GetEnumerator();
        }

        // Indekser na listu turista
        public Turista this[int i]
        {
            get
            {
                if (i < 0 || i > 5)
                    throw new IndexOutOfRangeException("Indeks van opsega");
                return Lista[i];
            }
            set
            {
                if (i < 0 || i > 5)
                    throw new IndexOutOfRangeException("Indeks van opsega");
                Lista[i] = value;
            }
        }

        public class sortPoKarti : IComparer<Turista>
        {
            public int Compare(Turista x, Turista y)
            {
                if (x.CenaKarte < y.CenaKarte) return -1;
                if (x.CenaKarte > y.CenaKarte) return 1;
                return 0;
            }
        }

        public class sortPoImenu : IComparer<Turista>
        {
            public int Compare(Turista x, Turista y)
            {
                return x.Ime.CompareTo(y.Ime);
            }
        }
    }
}
