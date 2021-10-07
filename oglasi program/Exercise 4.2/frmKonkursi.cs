using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Exercise_4._2
{
    public partial class frmKonkursi : Form
    {
        private Oglas o;
        public ArrayList Oglasi;
        public frmKonkursi()
        {
            InitializeComponent();
            Oglasi = new ArrayList();
        }

        public void puniListu()
        {
            foreach(Oglas o in Oglasi)
            {
                Konkursi.Items.Add(o.ToString());
            }
        }

        private void btnNoviOglas_Click(object sender, EventArgs e)
        {
            frmUnosOglasa unos = new frmUnosOglasa();
            {
                if (DialogResult.OK == unos.ShowDialog())
                {
                    o = new Oglas(unos.Radno, unos.Staz, unos.Sprema);
                    Oglasi.Add(o);
                    Konkursi.Items.Clear();
                    puniListu();
                }
            }
        }

        private void btnIzbrisiOglas_Click(object sender, EventArgs e)
        {
            Oglasi.Remove(o);
            Konkursi.Items.Clear();
            MessageBox.Show("Poslednji oglas je obrisan");
            puniListu();
        }

        private void btnEksportuj_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Vazeci_oglasi.txt");
            foreach(Oglas o in Oglasi)
            {
                o.ToString();
            }

            MessageBox.Show("Podaci su snimljeni");
            sw.Close();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
