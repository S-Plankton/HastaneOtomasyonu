namespace HastaneOtomasyonu
{
    partial class HastaSilGuncelleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaSilGuncelleForm));
            this.cmb_tcvatandaslik = new System.Windows.Forms.ComboBox();
            this.txb_yakinad = new System.Windows.Forms.TextBox();
            this.mtb_yakintelefon = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rtb_adres = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_sigorta = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_hastaid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.mtb_hastatc = new System.Windows.Forms.MaskedTextBox();
            this.mtb_hastatelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.mtb_dogum = new System.Windows.Forms.MaskedTextBox();
            this.cmb_kangrubu = new System.Windows.Forms.ComboBox();
            this.txb_hastasoyadi = new System.Windows.Forms.TextBox();
            this.txb_Hastaadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_tcvatandaslik
            // 
            this.cmb_tcvatandaslik.FormattingEnabled = true;
            this.cmb_tcvatandaslik.Location = new System.Drawing.Point(149, 167);
            this.cmb_tcvatandaslik.Name = "cmb_tcvatandaslik";
            this.cmb_tcvatandaslik.Size = new System.Drawing.Size(100, 27);
            this.cmb_tcvatandaslik.TabIndex = 55;
            // 
            // txb_yakinad
            // 
            this.txb_yakinad.Location = new System.Drawing.Point(416, 209);
            this.txb_yakinad.Name = "txb_yakinad";
            this.txb_yakinad.Size = new System.Drawing.Size(100, 26);
            this.txb_yakinad.TabIndex = 54;
            // 
            // mtb_yakintelefon
            // 
            this.mtb_yakintelefon.Location = new System.Drawing.Point(416, 243);
            this.mtb_yakintelefon.Mask = "(999) 000-0000";
            this.mtb_yakintelefon.Name = "mtb_yakintelefon";
            this.mtb_yakintelefon.Size = new System.Drawing.Size(100, 26);
            this.mtb_yakintelefon.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(289, 251);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 19);
            this.label13.TabIndex = 52;
            this.label13.Text = "Yakını Telefon No:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 212);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 19);
            this.label12.TabIndex = 51;
            this.label12.Text = "Yakını Adı Soyadı:";
            // 
            // rtb_adres
            // 
            this.rtb_adres.Location = new System.Drawing.Point(380, 47);
            this.rtb_adres.Name = "rtb_adres";
            this.rtb_adres.Size = new System.Drawing.Size(171, 111);
            this.rtb_adres.TabIndex = 50;
            this.rtb_adres.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 50);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 19);
            this.label11.TabIndex = 49;
            this.label11.Text = "Hasta Adres:";
            // 
            // cmb_sigorta
            // 
            this.cmb_sigorta.FormattingEnabled = true;
            this.cmb_sigorta.Location = new System.Drawing.Point(149, 355);
            this.cmb_sigorta.Name = "cmb_sigorta";
            this.cmb_sigorta.Size = new System.Drawing.Size(100, 27);
            this.cmb_sigorta.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(39, 363);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 19);
            this.label10.TabIndex = 47;
            this.label10.Text = "Sigorta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 170);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "TC Vantandaşlık:";
            // 
            // txb_hastaid
            // 
            this.txb_hastaid.Location = new System.Drawing.Point(149, 50);
            this.txb_hastaid.Name = "txb_hastaid";
            this.txb_hastaid.Size = new System.Drawing.Size(100, 26);
            this.txb_hastaid.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(39, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 44;
            this.label8.Text = "Hasta id:";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(261, 449);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(100, 27);
            this.btn_sil.TabIndex = 43;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // mtb_hastatc
            // 
            this.mtb_hastatc.Location = new System.Drawing.Point(149, 205);
            this.mtb_hastatc.Mask = "00000000000";
            this.mtb_hastatc.Name = "mtb_hastatc";
            this.mtb_hastatc.Size = new System.Drawing.Size(100, 26);
            this.mtb_hastatc.TabIndex = 42;
            // 
            // mtb_hastatelefon
            // 
            this.mtb_hastatelefon.Location = new System.Drawing.Point(149, 398);
            this.mtb_hastatelefon.Mask = "(999) 000-0000";
            this.mtb_hastatelefon.Name = "mtb_hastatelefon";
            this.mtb_hastatelefon.Size = new System.Drawing.Size(100, 26);
            this.mtb_hastatelefon.TabIndex = 41;
            // 
            // cmb_cinsiyet
            // 
            this.cmb_cinsiyet.FormattingEnabled = true;
            this.cmb_cinsiyet.Location = new System.Drawing.Point(149, 243);
            this.cmb_cinsiyet.Name = "cmb_cinsiyet";
            this.cmb_cinsiyet.Size = new System.Drawing.Size(100, 27);
            this.cmb_cinsiyet.TabIndex = 40;
            // 
            // mtb_dogum
            // 
            this.mtb_dogum.Location = new System.Drawing.Point(149, 281);
            this.mtb_dogum.Mask = "00/00/0000";
            this.mtb_dogum.Name = "mtb_dogum";
            this.mtb_dogum.Size = new System.Drawing.Size(100, 26);
            this.mtb_dogum.TabIndex = 39;
            this.mtb_dogum.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_kangrubu
            // 
            this.cmb_kangrubu.FormattingEnabled = true;
            this.cmb_kangrubu.Location = new System.Drawing.Point(149, 318);
            this.cmb_kangrubu.Name = "cmb_kangrubu";
            this.cmb_kangrubu.Size = new System.Drawing.Size(100, 27);
            this.cmb_kangrubu.TabIndex = 38;
            // 
            // txb_hastasoyadi
            // 
            this.txb_hastasoyadi.Location = new System.Drawing.Point(149, 122);
            this.txb_hastasoyadi.Name = "txb_hastasoyadi";
            this.txb_hastasoyadi.Size = new System.Drawing.Size(100, 26);
            this.txb_hastasoyadi.TabIndex = 37;
            // 
            // txb_Hastaadi
            // 
            this.txb_Hastaadi.Location = new System.Drawing.Point(149, 87);
            this.txb_Hastaadi.Name = "txb_Hastaadi";
            this.txb_Hastaadi.Size = new System.Drawing.Size(100, 26);
            this.txb_Hastaadi.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(39, 405);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Telefon No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 251);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Cinsiyet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Kan Grubu: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Hasta Tc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Hasta Soyadı: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Hasta Adı:";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(380, 449);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(100, 27);
            this.btn_guncelle.TabIndex = 56;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // HastaSilGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(606, 522);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.cmb_tcvatandaslik);
            this.Controls.Add(this.txb_yakinad);
            this.Controls.Add(this.mtb_yakintelefon);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rtb_adres);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb_sigorta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txb_hastaid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.mtb_hastatc);
            this.Controls.Add(this.mtb_hastatelefon);
            this.Controls.Add(this.cmb_cinsiyet);
            this.Controls.Add(this.mtb_dogum);
            this.Controls.Add(this.cmb_kangrubu);
            this.Controls.Add(this.txb_hastasoyadi);
            this.Controls.Add(this.txb_Hastaadi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HastaSilGuncelleForm";
            this.Text = "HastaSilGuncelleForm";
            this.Load += new System.EventHandler(this.HastaSilGuncelleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_tcvatandaslik;
        private System.Windows.Forms.TextBox txb_yakinad;
        private System.Windows.Forms.MaskedTextBox mtb_yakintelefon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rtb_adres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_sigorta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_hastaid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.MaskedTextBox mtb_hastatc;
        private System.Windows.Forms.MaskedTextBox mtb_hastatelefon;
        private System.Windows.Forms.ComboBox cmb_cinsiyet;
        private System.Windows.Forms.MaskedTextBox mtb_dogum;
        private System.Windows.Forms.ComboBox cmb_kangrubu;
        private System.Windows.Forms.TextBox txb_hastasoyadi;
        private System.Windows.Forms.TextBox txb_Hastaadi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_guncelle;
    }
}