using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4._2
{
    class Oglas
    {
        private string radnoMesto;
        private int staz;
        private string strucnaSprema;

        public string RadnoMesto { get => this.radnoMesto; set => this.radnoMesto = value; }
        public int Staz { get => this.staz; set => this.staz = value; }
        public string StrucnaSprema { get => this.strucnaSprema; set => this.strucnaSprema = value; }

        public Oglas()
        {
            this.radnoMesto = "";
            this.staz = 0;
            this.strucnaSprema = "";
        }

        public Oglas(string workplace, int workyears, string qlty)
        {
            this.radnoMesto = workplace;
            this.staz = workyears;
            this.strucnaSprema = qlty;
        }

        public override string ToString()
        {
            return "Radno mesto: "+ this.radnoMesto +"- Minimalno iskustvo: " + this.staz + "- Strucna sprema: " + this.strucnaSprema;
        }
    }
}
