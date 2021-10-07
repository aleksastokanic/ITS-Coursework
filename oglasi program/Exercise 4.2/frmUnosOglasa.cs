using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4._2
{
    public partial class frmUnosOglasa : Form
    {
        public string Radno { get { return tbRadnoMesto.Text; } }
        public string Sprema { get { return vratiSpremu(); } }
        public int Staz { get { return Convert.ToInt32(numericGodineStaza.Value); } }
        public frmUnosOglasa()
        {
            InitializeComponent();
        }

        public string vratiSpremu()
        {
            string sprema = "";
            foreach(RadioButton rb in groupBox1.Controls)
            {
                if(rb.Checked)
                {
                    sprema = rb.Text;
                }
            }
            return sprema;
        }

        private void resetuj()
        {
            tbRadnoMesto.Clear();
            numericGodineStaza.Value = 0;
            foreach(RadioButton rb in groupBox1.Controls)
            {
                rb.Checked = false;
            }

            
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (tbRadnoMesto.Text != "" && numericGodineStaza.Value < 40)
            {
                DialogResult = DialogResult.OK;
                MessageBox.Show("Uspesno uneti podaci u listu");
                
            }
            else
                MessageBox.Show("Podaci nisu uneti pravilno", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            resetuj();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            resetuj();
        }

        private void numericGodineStaza_Validating(object sender, CancelEventArgs e)
        {
            if(numericGodineStaza.Value>40)
            {
                errorProvider1.SetError(numericGodineStaza, "Morate uneti vrednost koja je manja od broja 40");
                numericGodineStaza.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        
    }
}
