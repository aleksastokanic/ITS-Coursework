
namespace Exercise_4._1
{
    partial class frmUnosGosta
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.BrojClanovaComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUbaci = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.cbDorucak = new System.Windows.Forms.CheckBox();
            this.cbRucak = new System.Windows.Forms.CheckBox();
            this.cbVecera = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj clanova";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(141, 49);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(100, 20);
            this.tbPrezime.TabIndex = 2;
            // 
            // BrojClanovaComboBox
            // 
            this.BrojClanovaComboBox.FormattingEnabled = true;
            this.BrojClanovaComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.BrojClanovaComboBox.Location = new System.Drawing.Point(141, 131);
            this.BrojClanovaComboBox.Name = "BrojClanovaComboBox";
            this.BrojClanovaComboBox.Size = new System.Drawing.Size(121, 21);
            this.BrojClanovaComboBox.TabIndex = 3;
            this.BrojClanovaComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.BrojClanovaComboBox_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbVecera);
            this.groupBox1.Controls.Add(this.cbRucak);
            this.groupBox1.Controls.Add(this.cbDorucak);
            this.groupBox1.Location = new System.Drawing.Point(41, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 184);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obroci";
            // 
            // btnUbaci
            // 
            this.btnUbaci.Location = new System.Drawing.Point(41, 412);
            this.btnUbaci.Name = "btnUbaci";
            this.btnUbaci.Size = new System.Drawing.Size(75, 23);
            this.btnUbaci.TabIndex = 5;
            this.btnUbaci.Text = "Ubaci";
            this.btnUbaci.UseVisualStyleBackColor = true;
            this.btnUbaci.Click += new System.EventHandler(this.btnUbaci_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(166, 412);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // cbDorucak
            // 
            this.cbDorucak.AutoSize = true;
            this.cbDorucak.Location = new System.Drawing.Point(16, 30);
            this.cbDorucak.Name = "cbDorucak";
            this.cbDorucak.Size = new System.Drawing.Size(67, 17);
            this.cbDorucak.TabIndex = 0;
            this.cbDorucak.Text = "Dorucak";
            this.cbDorucak.UseVisualStyleBackColor = true;
            // 
            // cbRucak
            // 
            this.cbRucak.AutoSize = true;
            this.cbRucak.Location = new System.Drawing.Point(16, 86);
            this.cbRucak.Name = "cbRucak";
            this.cbRucak.Size = new System.Drawing.Size(58, 17);
            this.cbRucak.TabIndex = 1;
            this.cbRucak.Text = "Rucak";
            this.cbRucak.UseVisualStyleBackColor = true;
            // 
            // cbVecera
            // 
            this.cbVecera.AutoSize = true;
            this.cbVecera.Location = new System.Drawing.Point(16, 145);
            this.cbVecera.Name = "cbVecera";
            this.cbVecera.Size = new System.Drawing.Size(60, 17);
            this.cbVecera.TabIndex = 2;
            this.cbVecera.Text = "Vecera";
            this.cbVecera.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUnosGosta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUbaci);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BrojClanovaComboBox);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUnosGosta";
            this.Text = "frmUnosGosta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.ComboBox BrojClanovaComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbVecera;
        private System.Windows.Forms.CheckBox cbRucak;
        private System.Windows.Forms.CheckBox cbDorucak;
        private System.Windows.Forms.Button btnUbaci;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}