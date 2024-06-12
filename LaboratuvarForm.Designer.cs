namespace HastaneOtomasyonu
{
    partial class LaboratuvarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaboratuvarForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_sonuc_id = new System.Windows.Forms.TextBox();
            this.mtb_test_trh = new System.Windows.Forms.MaskedTextBox();
            this.mtb_sonuc_trh = new System.Windows.Forms.MaskedTextBox();
            this.rtb_sonuc = new System.Windows.Forms.RichTextBox();
            this.rtb_yorum = new System.Windows.Forms.RichTextBox();
            this.rtb_deger = new System.Windows.Forms.RichTextBox();
            this.cb_hst_ad = new System.Windows.Forms.ComboBox();
            this.cb_hst_tc = new System.Windows.Forms.ComboBox();
            this.txb_test_ad = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btbn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.hastaneOtomasyonuDataSet4 = new HastaneOtomasyonu.HastaneOtomasyonuDataSet4();
            this.laboratuvarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laboratuvarTableAdapter = new HastaneOtomasyonu.HastaneOtomasyonuDataSet4TableAdapters.LaboratuvarTableAdapter();
            this.sonucidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonucTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yorumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degerlendirmeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratuvarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sonuc id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Test Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Test Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sonuc Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sonuc:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Yorum:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Degerlendirme:";
            // 
            // txb_sonuc_id
            // 
            this.txb_sonuc_id.Location = new System.Drawing.Point(129, 22);
            this.txb_sonuc_id.Name = "txb_sonuc_id";
            this.txb_sonuc_id.Size = new System.Drawing.Size(100, 26);
            this.txb_sonuc_id.TabIndex = 9;
            // 
            // mtb_test_trh
            // 
            this.mtb_test_trh.Location = new System.Drawing.Point(129, 199);
            this.mtb_test_trh.Mask = "00/00/0000 90:00";
            this.mtb_test_trh.Name = "mtb_test_trh";
            this.mtb_test_trh.Size = new System.Drawing.Size(100, 26);
            this.mtb_test_trh.TabIndex = 10;
            this.mtb_test_trh.ValidatingType = typeof(System.DateTime);
            // 
            // mtb_sonuc_trh
            // 
            this.mtb_sonuc_trh.Location = new System.Drawing.Point(129, 245);
            this.mtb_sonuc_trh.Mask = "00/00/0000 90:00";
            this.mtb_sonuc_trh.Name = "mtb_sonuc_trh";
            this.mtb_sonuc_trh.Size = new System.Drawing.Size(100, 26);
            this.mtb_sonuc_trh.TabIndex = 11;
            this.mtb_sonuc_trh.ValidatingType = typeof(System.DateTime);
            // 
            // rtb_sonuc
            // 
            this.rtb_sonuc.Location = new System.Drawing.Point(129, 288);
            this.rtb_sonuc.Name = "rtb_sonuc";
            this.rtb_sonuc.Size = new System.Drawing.Size(100, 51);
            this.rtb_sonuc.TabIndex = 12;
            this.rtb_sonuc.Text = "";
            // 
            // rtb_yorum
            // 
            this.rtb_yorum.Location = new System.Drawing.Point(129, 352);
            this.rtb_yorum.Name = "rtb_yorum";
            this.rtb_yorum.Size = new System.Drawing.Size(100, 51);
            this.rtb_yorum.TabIndex = 13;
            this.rtb_yorum.Text = "";
            // 
            // rtb_deger
            // 
            this.rtb_deger.Location = new System.Drawing.Point(129, 425);
            this.rtb_deger.Name = "rtb_deger";
            this.rtb_deger.Size = new System.Drawing.Size(100, 51);
            this.rtb_deger.TabIndex = 14;
            this.rtb_deger.Text = "";
            // 
            // cb_hst_ad
            // 
            this.cb_hst_ad.FormattingEnabled = true;
            this.cb_hst_ad.Location = new System.Drawing.Point(129, 65);
            this.cb_hst_ad.Name = "cb_hst_ad";
            this.cb_hst_ad.Size = new System.Drawing.Size(100, 27);
            this.cb_hst_ad.TabIndex = 15;
            // 
            // cb_hst_tc
            // 
            this.cb_hst_tc.FormattingEnabled = true;
            this.cb_hst_tc.Location = new System.Drawing.Point(129, 111);
            this.cb_hst_tc.Name = "cb_hst_tc";
            this.cb_hst_tc.Size = new System.Drawing.Size(100, 27);
            this.cb_hst_tc.TabIndex = 16;
            // 
            // txb_test_ad
            // 
            this.txb_test_ad.Location = new System.Drawing.Point(129, 158);
            this.txb_test_ad.Name = "txb_test_ad";
            this.txb_test_ad.Size = new System.Drawing.Size(100, 26);
            this.txb_test_ad.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sonucidDataGridViewTextBoxColumn,
            this.hastaAdDataGridViewTextBoxColumn,
            this.hastaTCDataGridViewTextBoxColumn,
            this.testAdDataGridViewTextBoxColumn,
            this.testTarihiDataGridViewTextBoxColumn,
            this.sonucTarihiDataGridViewTextBoxColumn,
            this.sonucDataGridViewTextBoxColumn,
            this.yorumDataGridViewTextBoxColumn,
            this.degerlendirmeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.laboratuvarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(249, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 454);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btbn_ekle
            // 
            this.btbn_ekle.Location = new System.Drawing.Point(37, 519);
            this.btbn_ekle.Name = "btbn_ekle";
            this.btbn_ekle.Size = new System.Drawing.Size(75, 31);
            this.btbn_ekle.TabIndex = 19;
            this.btbn_ekle.Text = "Ekle";
            this.btbn_ekle.UseVisualStyleBackColor = true;
            this.btbn_ekle.Click += new System.EventHandler(this.btbn_ekle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(143, 519);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(75, 31);
            this.btn_guncelle.TabIndex = 20;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // hastaneOtomasyonuDataSet4
            // 
            this.hastaneOtomasyonuDataSet4.DataSetName = "HastaneOtomasyonuDataSet4";
            this.hastaneOtomasyonuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // laboratuvarBindingSource
            // 
            this.laboratuvarBindingSource.DataMember = "Laboratuvar";
            this.laboratuvarBindingSource.DataSource = this.hastaneOtomasyonuDataSet4;
            // 
            // laboratuvarTableAdapter
            // 
            this.laboratuvarTableAdapter.ClearBeforeFill = true;
            // 
            // sonucidDataGridViewTextBoxColumn
            // 
            this.sonucidDataGridViewTextBoxColumn.DataPropertyName = "Sonucid";
            this.sonucidDataGridViewTextBoxColumn.HeaderText = "Sonucid";
            this.sonucidDataGridViewTextBoxColumn.Name = "sonucidDataGridViewTextBoxColumn";
            this.sonucidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaAdDataGridViewTextBoxColumn
            // 
            this.hastaAdDataGridViewTextBoxColumn.DataPropertyName = "HastaAd";
            this.hastaAdDataGridViewTextBoxColumn.HeaderText = "HastaAd";
            this.hastaAdDataGridViewTextBoxColumn.Name = "hastaAdDataGridViewTextBoxColumn";
            // 
            // hastaTCDataGridViewTextBoxColumn
            // 
            this.hastaTCDataGridViewTextBoxColumn.DataPropertyName = "HastaTC";
            this.hastaTCDataGridViewTextBoxColumn.HeaderText = "HastaTC";
            this.hastaTCDataGridViewTextBoxColumn.Name = "hastaTCDataGridViewTextBoxColumn";
            // 
            // testAdDataGridViewTextBoxColumn
            // 
            this.testAdDataGridViewTextBoxColumn.DataPropertyName = "TestAd";
            this.testAdDataGridViewTextBoxColumn.HeaderText = "TestAd";
            this.testAdDataGridViewTextBoxColumn.Name = "testAdDataGridViewTextBoxColumn";
            // 
            // testTarihiDataGridViewTextBoxColumn
            // 
            this.testTarihiDataGridViewTextBoxColumn.DataPropertyName = "TestTarihi";
            this.testTarihiDataGridViewTextBoxColumn.HeaderText = "TestTarihi";
            this.testTarihiDataGridViewTextBoxColumn.Name = "testTarihiDataGridViewTextBoxColumn";
            // 
            // sonucTarihiDataGridViewTextBoxColumn
            // 
            this.sonucTarihiDataGridViewTextBoxColumn.DataPropertyName = "SonucTarihi";
            this.sonucTarihiDataGridViewTextBoxColumn.HeaderText = "SonucTarihi";
            this.sonucTarihiDataGridViewTextBoxColumn.Name = "sonucTarihiDataGridViewTextBoxColumn";
            // 
            // sonucDataGridViewTextBoxColumn
            // 
            this.sonucDataGridViewTextBoxColumn.DataPropertyName = "Sonuc";
            this.sonucDataGridViewTextBoxColumn.HeaderText = "Sonuc";
            this.sonucDataGridViewTextBoxColumn.Name = "sonucDataGridViewTextBoxColumn";
            // 
            // yorumDataGridViewTextBoxColumn
            // 
            this.yorumDataGridViewTextBoxColumn.DataPropertyName = "Yorum";
            this.yorumDataGridViewTextBoxColumn.HeaderText = "Yorum";
            this.yorumDataGridViewTextBoxColumn.Name = "yorumDataGridViewTextBoxColumn";
            // 
            // degerlendirmeDataGridViewTextBoxColumn
            // 
            this.degerlendirmeDataGridViewTextBoxColumn.DataPropertyName = "Degerlendirme";
            this.degerlendirmeDataGridViewTextBoxColumn.HeaderText = "Degerlendirme";
            this.degerlendirmeDataGridViewTextBoxColumn.Name = "degerlendirmeDataGridViewTextBoxColumn";
            // 
            // LaboratuvarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(856, 588);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btbn_ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txb_test_ad);
            this.Controls.Add(this.cb_hst_tc);
            this.Controls.Add(this.cb_hst_ad);
            this.Controls.Add(this.rtb_deger);
            this.Controls.Add(this.rtb_yorum);
            this.Controls.Add(this.rtb_sonuc);
            this.Controls.Add(this.mtb_sonuc_trh);
            this.Controls.Add(this.mtb_test_trh);
            this.Controls.Add(this.txb_sonuc_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
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
            this.Name = "LaboratuvarForm";
            this.Text = "LaboratuvarForm";
            this.Load += new System.EventHandler(this.LaboratuvarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratuvarBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_sonuc_id;
        private System.Windows.Forms.MaskedTextBox mtb_test_trh;
        private System.Windows.Forms.MaskedTextBox mtb_sonuc_trh;
        private System.Windows.Forms.RichTextBox rtb_sonuc;
        private System.Windows.Forms.RichTextBox rtb_yorum;
        private System.Windows.Forms.RichTextBox rtb_deger;
        private System.Windows.Forms.ComboBox cb_hst_ad;
        private System.Windows.Forms.ComboBox cb_hst_tc;
        private System.Windows.Forms.TextBox txb_test_ad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btbn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private HastaneOtomasyonuDataSet4 hastaneOtomasyonuDataSet4;
        private System.Windows.Forms.BindingSource laboratuvarBindingSource;
        private HastaneOtomasyonuDataSet4TableAdapters.LaboratuvarTableAdapter laboratuvarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonucidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonucTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yorumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degerlendirmeDataGridViewTextBoxColumn;
    }
}