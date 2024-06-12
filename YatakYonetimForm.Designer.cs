namespace HastaneOtomasyonu
{
    partial class YatakYonetimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YatakYonetimForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txb_ytk_id = new System.Windows.Forms.TextBox();
            this.cb_oda_no = new System.Windows.Forms.ComboBox();
            this.cb_hst_ad = new System.Windows.Forms.ComboBox();
            this.cb_hst_tc = new System.Windows.Forms.ComboBox();
            this.cb_ytk_sayısı = new System.Windows.Forms.ComboBox();
            this.cb_ytk_durumu = new System.Windows.Forms.ComboBox();
            this.cb_temizlik = new System.Windows.Forms.ComboBox();
            this.bnt_sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yatak id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oda No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasta TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yatak Sayısı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yatak Durumu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Temizlik:";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(84, 335);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(76, 29);
            this.btn_ekle.TabIndex = 9;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txb_ytk_id
            // 
            this.txb_ytk_id.Location = new System.Drawing.Point(134, 37);
            this.txb_ytk_id.Name = "txb_ytk_id";
            this.txb_ytk_id.Size = new System.Drawing.Size(121, 26);
            this.txb_ytk_id.TabIndex = 10;
            // 
            // cb_oda_no
            // 
            this.cb_oda_no.FormattingEnabled = true;
            this.cb_oda_no.Location = new System.Drawing.Point(134, 77);
            this.cb_oda_no.Name = "cb_oda_no";
            this.cb_oda_no.Size = new System.Drawing.Size(121, 27);
            this.cb_oda_no.TabIndex = 11;
            // 
            // cb_hst_ad
            // 
            this.cb_hst_ad.FormattingEnabled = true;
            this.cb_hst_ad.Location = new System.Drawing.Point(134, 117);
            this.cb_hst_ad.Name = "cb_hst_ad";
            this.cb_hst_ad.Size = new System.Drawing.Size(121, 27);
            this.cb_hst_ad.TabIndex = 12;
            // 
            // cb_hst_tc
            // 
            this.cb_hst_tc.FormattingEnabled = true;
            this.cb_hst_tc.Location = new System.Drawing.Point(134, 157);
            this.cb_hst_tc.Name = "cb_hst_tc";
            this.cb_hst_tc.Size = new System.Drawing.Size(121, 27);
            this.cb_hst_tc.TabIndex = 13;
            // 
            // cb_ytk_sayısı
            // 
            this.cb_ytk_sayısı.FormattingEnabled = true;
            this.cb_ytk_sayısı.Location = new System.Drawing.Point(134, 197);
            this.cb_ytk_sayısı.Name = "cb_ytk_sayısı";
            this.cb_ytk_sayısı.Size = new System.Drawing.Size(121, 27);
            this.cb_ytk_sayısı.TabIndex = 14;
            // 
            // cb_ytk_durumu
            // 
            this.cb_ytk_durumu.FormattingEnabled = true;
            this.cb_ytk_durumu.Location = new System.Drawing.Point(134, 237);
            this.cb_ytk_durumu.Name = "cb_ytk_durumu";
            this.cb_ytk_durumu.Size = new System.Drawing.Size(121, 27);
            this.cb_ytk_durumu.TabIndex = 15;
            // 
            // cb_temizlik
            // 
            this.cb_temizlik.FormattingEnabled = true;
            this.cb_temizlik.Location = new System.Drawing.Point(134, 277);
            this.cb_temizlik.Name = "cb_temizlik";
            this.cb_temizlik.Size = new System.Drawing.Size(121, 27);
            this.cb_temizlik.TabIndex = 16;
            // 
            // bnt_sil
            // 
            this.bnt_sil.Location = new System.Drawing.Point(179, 335);
            this.bnt_sil.Name = "bnt_sil";
            this.bnt_sil.Size = new System.Drawing.Size(76, 29);
            this.bnt_sil.TabIndex = 17;
            this.bnt_sil.Text = "Sil";
            this.bnt_sil.UseVisualStyleBackColor = true;
            this.bnt_sil.Click += new System.EventHandler(this.bnt_sil_Click);
            // 
            // YatakYonetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(343, 428);
            this.Controls.Add(this.bnt_sil);
            this.Controls.Add(this.cb_temizlik);
            this.Controls.Add(this.cb_ytk_durumu);
            this.Controls.Add(this.cb_ytk_sayısı);
            this.Controls.Add(this.cb_hst_tc);
            this.Controls.Add(this.cb_hst_ad);
            this.Controls.Add(this.cb_oda_no);
            this.Controls.Add(this.txb_ytk_id);
            this.Controls.Add(this.btn_ekle);
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
            this.Name = "YatakYonetimForm";
            this.Text = "YatakYonetimForm";
            this.Load += new System.EventHandler(this.YatakYonetimForm_Load);
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
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txb_ytk_id;
        private System.Windows.Forms.ComboBox cb_oda_no;
        private System.Windows.Forms.ComboBox cb_hst_ad;
        private System.Windows.Forms.ComboBox cb_hst_tc;
        private System.Windows.Forms.ComboBox cb_ytk_sayısı;
        private System.Windows.Forms.ComboBox cb_ytk_durumu;
        private System.Windows.Forms.ComboBox cb_temizlik;
        private System.Windows.Forms.Button bnt_sil;
    }
}