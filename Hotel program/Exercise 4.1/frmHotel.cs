using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Exercise_4._1
{
    public partial class frmHotel : Form
    {
        private Gost g;
        private Stack<Gost> gosti;
        public frmHotel()
        {
            InitializeComponent();
            gosti = new Stack<Gost>();
        }
        private void stampaj()
        {
            foreach(Gost g in gosti)
            {
                rbPrikaz.AppendText(g.ToString());
                rbPrikaz.AppendText("\n");
            }
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            frmUnosGosta frm = new frmUnosGosta();
            g = new Gost(frm.Prezime, frm.Clanovi, frm.Obroci);
            gosti.Push(g);
            rbPrikaz.Clear();
            stampaj();
           
        }

        private void btnIzbaci_Click(object sender, EventArgs e)
        {
            if(gosti.Count==0)
            {
                MessageBox.Show("Stek je prazan");
            }
            else
            {
                gosti.Pop();
                MessageBox.Show("Gost je otisao");
                rbPrikaz.Clear();
                stampaj();
            }
        }

        private void btnEksportuj_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("spisak_gostiju.txt");
            sw.WriteLine("Spisak gostiju");
            foreach(Gost g in gosti)
            {
                sw.WriteLine(g.ToString());
            }
            sw.Close();
            MessageBox.Show("Fajl spisak_gostiju.txt je uspesno snimljen");
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
