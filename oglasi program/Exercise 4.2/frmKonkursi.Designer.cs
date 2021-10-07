
namespace Exercise_4._2
{
    partial class frmKonkursi
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
            this.Konkursi = new System.Windows.Forms.ListBox();
            this.btnNoviOglas = new System.Windows.Forms.Button();
            this.btnIzbrisiOglas = new System.Windows.Forms.Button();
            this.btnEksportuj = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Konkursi
            // 
            this.Konkursi.FormattingEnabled = true;
            this.Konkursi.Location = new System.Drawing.Point(83, 39);
            this.Konkursi.Name = "Konkursi";
            this.Konkursi.Size = new System.Drawing.Size(623, 290);
            this.Konkursi.TabIndex = 0;
            // 
            // btnNoviOglas
            // 
            this.btnNoviOglas.Location = new System.Drawing.Point(83, 371);
            this.btnNoviOglas.Name = "btnNoviOglas";
            this.btnNoviOglas.Size = new System.Drawing.Size(75, 23);
            this.btnNoviOglas.TabIndex = 1;
            this.btnNoviOglas.Text = "Novi oglas";
            this.btnNoviOglas.UseVisualStyleBackColor = true;
            this.btnNoviOglas.Click += new System.EventHandler(this.btnNoviOglas_Click);
            // 
            // btnIzbrisiOglas
            // 
            this.btnIzbrisiOglas.Location = new System.Drawing.Point(258, 371);
            this.btnIzbrisiOglas.Name = "btnIzbrisiOglas";
            this.btnIzbrisiOglas.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisiOglas.TabIndex = 2;
            this.btnIzbrisiOglas.Text = "Izbrisi oglas";
            this.btnIzbrisiOglas.UseVisualStyleBackColor = true;
            this.btnIzbrisiOglas.Click += new System.EventHandler(this.btnIzbrisiOglas_Click);
            // 
            // btnEksportuj
            // 
            this.btnEksportuj.Location = new System.Drawing.Point(448, 371);
            this.btnEksportuj.Name = "btnEksportuj";
            this.btnEksportuj.Size = new System.Drawing.Size(89, 23);
            this.btnEksportuj.TabIndex = 3;
            this.btnEksportuj.Text = "Eksportuj u txt";
            this.btnEksportuj.UseVisualStyleBackColor = true;
            this.btnEksportuj.Click += new System.EventHandler(this.btnEksportuj_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(631, 371);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 4;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // frmKonkursi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnEksportuj);
            this.Controls.Add(this.btnIzbrisiOglas);
            this.Controls.Add(this.btnNoviOglas);
            this.Controls.Add(this.Konkursi);
            this.Name = "frmKonkursi";
            this.Text = "Konkursi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Konkursi;
        private System.Windows.Forms.Button btnNoviOglas;
        private System.Windows.Forms.Button btnIzbrisiOglas;
        private System.Windows.Forms.Button btnEksportuj;
        private System.Windows.Forms.Button btnZatvori;
    }
}

