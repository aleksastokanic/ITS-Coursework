
namespace Exercise_4._1
{
    partial class frmHotel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnIzbaci = new System.Windows.Forms.Button();
            this.btnEksportuj = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.rbPrikaz = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(96, 367);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 1;
            this.btnUnesi.Text = "Unesi gosta";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnIzbaci
            // 
            this.btnIzbaci.Location = new System.Drawing.Point(269, 367);
            this.btnIzbaci.Name = "btnIzbaci";
            this.btnIzbaci.Size = new System.Drawing.Size(75, 23);
            this.btnIzbaci.TabIndex = 2;
            this.btnIzbaci.Text = "Izbaci gosta";
            this.btnIzbaci.UseVisualStyleBackColor = true;
            this.btnIzbaci.Click += new System.EventHandler(this.btnIzbaci_Click);
            // 
            // btnEksportuj
            // 
            this.btnEksportuj.Location = new System.Drawing.Point(426, 367);
            this.btnEksportuj.Name = "btnEksportuj";
            this.btnEksportuj.Size = new System.Drawing.Size(104, 23);
            this.btnEksportuj.TabIndex = 3;
            this.btnEksportuj.Text = "Exportuj u txt";
            this.btnEksportuj.UseVisualStyleBackColor = true;
            this.btnEksportuj.Click += new System.EventHandler(this.btnEksportuj_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(625, 367);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 4;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // rbPrikaz
            // 
            this.rbPrikaz.Location = new System.Drawing.Point(96, 63);
            this.rbPrikaz.Name = "rbPrikaz";
            this.rbPrikaz.Size = new System.Drawing.Size(604, 267);
            this.rbPrikaz.TabIndex = 5;
            this.rbPrikaz.Text = "";
            // 
            // frmHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbPrikaz);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnEksportuj);
            this.Controls.Add(this.btnIzbaci);
            this.Controls.Add(this.btnUnesi);
            this.Name = "frmHotel";
            this.Text = "Hotel";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnIzbaci;
        private System.Windows.Forms.Button btnEksportuj;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.RichTextBox rbPrikaz;
    }
}

