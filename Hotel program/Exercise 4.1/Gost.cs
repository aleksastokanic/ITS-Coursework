using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4._1
{
    public class Gost
    {
        private string prezime;
        private int brClanova;
        private string obroci;

        public string Prezime { get => this.prezime; set => this.prezime = value; }
        public int BrClanova { get => this.brClanova; set => this.brClanova = value; }
        public string Obroci { get => this.obroci; set => this.obroci = value; }

        public Gost()
        {
            this.prezime = "";
            this.brClanova = 0;
            this.obroci = "";

        }

        public Gost(string surname, int num, string meal)
        {
            this.prezime = surname;
            this.brClanova = num;
            this.obroci = meal;
        }

        public override string ToString()
        {
            return "Porodica " + this.prezime + " je rezervisala za " + this.brClanova + " clan(ov)a. Obroci su: " + this.obroci;
        }
    }
}
