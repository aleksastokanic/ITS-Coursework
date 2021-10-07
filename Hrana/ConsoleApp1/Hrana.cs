using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Hrana
    {
        double cena;
        int brojKalorija;
        string naziv;

        public double Cena { get => cena; set => cena = value; }
        public int BrojKalorija { get => brojKalorija; set => brojKalorija = value; }
        public string Naziv { get => naziv; set => naziv = value; }

        public Hrana(double c, int kalorije, string n)
        {
            Cena = c;
            BrojKalorija = kalorije;
            Naziv = n;
        }

        public double prodajnaCena()
        {
            double ncena = Cena;
            if (this.BrojKalorija>1000)
            {
                ncena *= 1.2;
            }
            return ncena;
        }

        public override string ToString()
        {
            return "Naziv: " + naziv;
        }
    }
}
