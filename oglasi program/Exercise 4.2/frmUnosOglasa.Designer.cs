
namespace Exercise_4._2
{
    partial class frmUnosOglasa
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRadnoMesto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericGodineStaza = new System.Windows.Forms.NumericUpDown();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.rbNiza = new System.Windows.Forms.RadioButton();
            this.rbVisa = new System.Windows.Forms.RadioButton();
            this.rbVisoka = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGodineStaza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radno mesto";
            // 
            // tbRadnoMesto
            // 
            this.tbRadnoMesto.Location = new System.Drawing.Point(157, 58);
            this.tbRadnoMesto.Name = "tbRadnoMesto";
            this.tbRadnoMesto.Size = new System.Drawing.Size(132, 20);
            this.tbRadnoMesto.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVisoka);
            this.groupBox1.Controls.Add(this.rbVisa);
            this.groupBox1.Controls.Add(this.rbNiza);
            this.groupBox1.Location = new System.Drawing.Point(57, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Strucna sprema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Godine staza:";
            // 
            // numericGodineStaza
            // 
            this.numericGodineStaza.Location = new System.Drawing.Point(113, 253);
            this.numericGodineStaza.Name = "numericGodineStaza";
            this.numericGodineStaza.Size = new System.Drawing.Size(49, 20);
            this.numericGodineStaza.TabIndex = 4;
            this.numericGodineStaza.Validating += new System.ComponentModel.CancelEventHandler(this.numericGodineStaza_Validating);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(57, 321);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 5;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(188, 321);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 6;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // rbNiza
            // 
            this.rbNiza.AutoSize = true;
            this.rbNiza.Location = new System.Drawing.Point(7, 20);
            this.rbNiza.Name = "rbNiza";
            this.rbNiza.Size = new System.Drawing.Size(46, 17);
            this.rbNiza.TabIndex = 0;
            this.rbNiza.TabStop = true;
            this.rbNiza.Text = "Niza";
            this.rbNiza.UseVisualStyleBackColor = true;
            // 
            // rbVisa
            // 
            this.rbVisa.AutoSize = true;
            this.rbVisa.Location = new System.Drawing.Point(6, 59);
            this.rbVisa.Name = "rbVisa";
            this.rbVisa.Size = new System.Drawing.Size(45, 17);
            this.rbVisa.TabIndex = 1;
            this.rbVisa.TabStop = true;
            this.rbVisa.Text = "Visa";
            this.rbVisa.UseVisualStyleBackColor = true;
            // 
            // rbVisoka
            // 
            this.rbVisoka.AutoSize = true;
            this.rbVisoka.Location = new System.Drawing.Point(7, 97);
            this.rbVisoka.Name = "rbVisoka";
            this.rbVisoka.Size = new System.Drawing.Size(57, 17);
            this.rbVisoka.TabIndex = 2;
            this.rbVisoka.TabStop = true;
            this.rbVisoka.Text = "Visoka";
            this.rbVisoka.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUnosOglasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.numericGodineStaza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbRadnoMesto);
            this.Controls.Add(this.label1);
            this.Name = "frmUnosOglasa";
            this.Text = "Unos oglasa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGodineStaza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRadnoMesto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbVisoka;
        private System.Windows.Forms.RadioButton rbVisa;
        private System.Windows.Forms.RadioButton rbNiza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericGodineStaza;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}