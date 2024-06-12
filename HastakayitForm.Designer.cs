namespace HastaneOtomasyonu
{
    partial class FrmHstKayit
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHstKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_Hastaadi = new System.Windows.Forms.TextBox();
            this.txb_hastasoyadi = new System.Windows.Forms.TextBox();
            this.cmb_kangrubu = new System.Windows.Forms.ComboBox();
            this.mtb_dogum = new System.Windows.Forms.MaskedTextBox();
            this.cmb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.mtb_hastatelefon = new System.Windows.Forms.MaskedTextBox();
            this.mtb_hastatc = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_hastaid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_sigorta = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rtb_adres = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.mtb_yakintelefon = new System.Windows.Forms.MaskedTextBox();
            this.txb_yakinad = new System.Windows.Forms.TextBox();
            this.cmb_tcvatandaslik = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta Soyadı: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta Tc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kan Grubu: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cinsiyet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(38, 400);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefon No:";
            // 
            // txb_Hastaadi
            // 
            this.txb_Hastaadi.Location = new System.Drawing.Point(148, 82);
            this.txb_Hastaadi.Name = "txb_Hastaadi";
            this.txb_Hastaadi.Size = new System.Drawing.Size(100, 26);
            this.txb_Hastaadi.TabIndex = 7;
            // 
            // txb_hastasoyadi
            // 
            this.txb_hastasoyadi.Location = new System.Drawing.Point(148, 117);
            this.txb_hastasoyadi.Name = "txb_hastasoyadi";
            this.txb_hastasoyadi.Size = new System.Drawing.Size(100, 26);
            this.txb_hastasoyadi.TabIndex = 8;
            // 
            // cmb_kangrubu
            // 
            this.cmb_kangrubu.FormattingEnabled = true;
            this.cmb_kangrubu.Location = new System.Drawing.Point(148, 313);
            this.cmb_kangrubu.Name = "cmb_kangrubu";
            this.cmb_kangrubu.Size = new System.Drawing.Size(100, 27);
            this.cmb_kangrubu.TabIndex = 10;
            // 
            // mtb_dogum
            // 
            this.mtb_dogum.Location = new System.Drawing.Point(148, 276);
            this.mtb_dogum.Mask = "00/00/0000";
            this.mtb_dogum.Name = "mtb_dogum";
            this.mtb_dogum.Size = new System.Drawing.Size(100, 26);
            this.mtb_dogum.TabIndex = 11;
            this.mtb_dogum.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_cinsiyet
            // 
            this.cmb_cinsiyet.FormattingEnabled = true;
            this.cmb_cinsiyet.Location = new System.Drawing.Point(148, 238);
            this.cmb_cinsiyet.Name = "cmb_cinsiyet";
            this.cmb_cinsiyet.Size = new System.Drawing.Size(100, 27);
            this.cmb_cinsiyet.TabIndex = 12;
            // 
            // mtb_hastatelefon
            // 
            this.mtb_hastatelefon.Location = new System.Drawing.Point(148, 393);
            this.mtb_hastatelefon.Mask = "(999) 000-0000";
            this.mtb_hastatelefon.Name = "mtb_hastatelefon";
            this.mtb_hastatelefon.Size = new System.Drawing.Size(100, 26);
            this.mtb_hastatelefon.TabIndex = 13;
            // 
            // mtb_hastatc
            // 
            this.mtb_hastatc.Location = new System.Drawing.Point(148, 200);
            this.mtb_hastatc.Mask = "00000000000";
            this.mtb_hastatc.Name = "mtb_hastatc";
            this.mtb_hastatc.Size = new System.Drawing.Size(100, 26);
            this.mtb_hastatc.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(38, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Hasta id:";
            // 
            // txb_hastaid
            // 
            this.txb_hastaid.Enabled = false;
            this.txb_hastaid.Location = new System.Drawing.Point(148, 45);
            this.txb_hastaid.Name = "txb_hastaid";
            this.txb_hastaid.Size = new System.Drawing.Size(100, 26);
            this.txb_hastaid.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 165);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "TC Vantandaşlık:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(38, 358);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Sigorta:";
            // 
            // cmb_sigorta
            // 
            this.cmb_sigorta.FormattingEnabled = true;
            this.cmb_sigorta.Location = new System.Drawing.Point(148, 350);
            this.cmb_sigorta.Name = "cmb_sigorta";
            this.cmb_sigorta.Size = new System.Drawing.Size(100, 27);
            this.cmb_sigorta.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 45);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Hasta Adres:";
            // 
            // rtb_adres
            // 
            this.rtb_adres.Location = new System.Drawing.Point(379, 42);
            this.rtb_adres.Name = "rtb_adres";
            this.rtb_adres.Size = new System.Drawing.Size(171, 111);
            this.rtb_adres.TabIndex = 23;
            this.rtb_adres.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(288, 207);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "Yakını Adı Soyadı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(288, 246);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 19);
            this.label13.TabIndex = 25;
            this.label13.Text = "Yakını Telefon No:";
            // 
            // mtb_yakintelefon
            // 
            this.mtb_yakintelefon.Location = new System.Drawing.Point(415, 238);
            this.mtb_yakintelefon.Mask = "(999) 000-0000";
            this.mtb_yakintelefon.Name = "mtb_yakintelefon";
            this.mtb_yakintelefon.Size = new System.Drawing.Size(100, 26);
            this.mtb_yakintelefon.TabIndex = 26;
            // 
            // txb_yakinad
            // 
            this.txb_yakinad.Location = new System.Drawing.Point(415, 204);
            this.txb_yakinad.Name = "txb_yakinad";
            this.txb_yakinad.Size = new System.Drawing.Size(100, 26);
            this.txb_yakinad.TabIndex = 27;
            // 
            // cmb_tcvatandaslik
            // 
            this.cmb_tcvatandaslik.FormattingEnabled = true;
            this.cmb_tcvatandaslik.Location = new System.Drawing.Point(148, 162);
            this.cmb_tcvatandaslik.Name = "cmb_tcvatandaslik";
            this.cmb_tcvatandaslik.Size = new System.Drawing.Size(100, 27);
            this.cmb_tcvatandaslik.TabIndex = 28;
            // 
            // FrmHstKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 537);
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
            this.Controls.Add(this.button1);
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
            this.Name = "FrmHstKayit";
            this.Text = "Hasta Kayıt Formu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_Hastaadi;
        private System.Windows.Forms.TextBox txb_hastasoyadi;
        private System.Windows.Forms.ComboBox cmb_kangrubu;
        private System.Windows.Forms.MaskedTextBox mtb_dogum;
        private System.Windows.Forms.ComboBox cmb_cinsiyet;
        private System.Windows.Forms.MaskedTextBox mtb_hastatelefon;
        private System.Windows.Forms.MaskedTextBox mtb_hastatc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_hastaid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_sigorta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtb_adres;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mtb_yakintelefon;
        private System.Windows.Forms.TextBox txb_yakinad;
        private System.Windows.Forms.ComboBox cmb_tcvatandaslik;
    }
}

