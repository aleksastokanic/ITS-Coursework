using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4._1
{
    public partial class frmUnosGosta : Form
    {
        public string Prezime { get { return this.tbPrezime.Text; } }
        
        public string Obroci { get { return this.vratiObrok(); } }

        public int Clanovi { get { return Convert.ToInt32(this.BrojClanovaComboBox.Text); } }
        public frmUnosGosta()
        {
            InitializeComponent();
        }

        public string vratiObrok()
        {
            string obroci = "";
            foreach(CheckBox cb in groupBox1.Controls)
            {
                if(cb.Checked)
                {
                    obroci += cb.Text + ";";
                }
            }
            return obroci;
        }

        private void btnUbaci_Click(object sender, EventArgs e)
        {
            if(tbPrezime.Text=="" || Convert.ToInt32(BrojClanovaComboBox.Text)<1 || Convert.ToInt32(BrojClanovaComboBox.Text)>5)
            {
                MessageBox.Show("Uneti podaci nisu ispravni", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
          

            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BrojClanovaComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(BrojClanovaComboBox.Text) < 1 || Convert.ToInt32(BrojClanovaComboBox.Text) > 5)
            {
                errorProvider1.SetError(BrojClanovaComboBox, "Broj clanova mora biti izmedju 1 i 5");
                BrojClanovaComboBox.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
