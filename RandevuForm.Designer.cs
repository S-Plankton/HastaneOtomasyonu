namespace HastaneOtomasyonu
{
    partial class RandevuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tx_rdv_id = new System.Windows.Forms.TextBox();
            this.cb_hst_Ad = new System.Windows.Forms.ComboBox();
            this.cb_hst_tc = new System.Windows.Forms.ComboBox();
            this.cb_dkt_Ad = new System.Windows.Forms.ComboBox();
            this.cb_rdv_turu = new System.Windows.Forms.ComboBox();
            this.cb_bolum = new System.Windows.Forms.ComboBox();
            this.cb_rdv_durum = new System.Windows.Forms.ComboBox();
            this.cb_rdv_trh = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.hastaneOtomasyonuDataSet2 = new HastaneOtomasyonu.HastaneOtomasyonuDataSet2();
            this.randevularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.randevularTableAdapter = new HastaneOtomasyonu.HastaneOtomasyonuDataSet2TableAdapters.RandevularTableAdapter();
            this.randevuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuDurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Randevu id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doktor Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Randevu Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Randevu Türü:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bölüm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Randevu Durumu:";
            // 
            // tx_rdv_id
            // 
            this.tx_rdv_id.Location = new System.Drawing.Point(138, 48);
            this.tx_rdv_id.Name = "tx_rdv_id";
            this.tx_rdv_id.Size = new System.Drawing.Size(121, 26);
            this.tx_rdv_id.TabIndex = 8;
            // 
            // cb_hst_Ad
            // 
            this.cb_hst_Ad.FormattingEnabled = true;
            this.cb_hst_Ad.Location = new System.Drawing.Point(138, 88);
            this.cb_hst_Ad.Name = "cb_hst_Ad";
            this.cb_hst_Ad.Size = new System.Drawing.Size(121, 27);
            this.cb_hst_Ad.TabIndex = 9;
            // 
            // cb_hst_tc
            // 
            this.cb_hst_tc.FormattingEnabled = true;
            this.cb_hst_tc.Location = new System.Drawing.Point(138, 128);
            this.cb_hst_tc.Name = "cb_hst_tc";
            this.cb_hst_tc.Size = new System.Drawing.Size(121, 27);
            this.cb_hst_tc.TabIndex = 10;
            // 
            // cb_dkt_Ad
            // 
            this.cb_dkt_Ad.FormattingEnabled = true;
            this.cb_dkt_Ad.Location = new System.Drawing.Point(138, 175);
            this.cb_dkt_Ad.Name = "cb_dkt_Ad";
            this.cb_dkt_Ad.Size = new System.Drawing.Size(121, 27);
            this.cb_dkt_Ad.TabIndex = 11;
            // 
            // cb_rdv_turu
            // 
            this.cb_rdv_turu.FormattingEnabled = true;
            this.cb_rdv_turu.Location = new System.Drawing.Point(138, 269);
            this.cb_rdv_turu.Name = "cb_rdv_turu";
            this.cb_rdv_turu.Size = new System.Drawing.Size(121, 27);
            this.cb_rdv_turu.TabIndex = 12;
            // 
            // cb_bolum
            // 
            this.cb_bolum.FormattingEnabled = true;
            this.cb_bolum.Location = new System.Drawing.Point(138, 314);
            this.cb_bolum.Name = "cb_bolum";
            this.cb_bolum.Size = new System.Drawing.Size(121, 27);
            this.cb_bolum.TabIndex = 13;
            // 
            // cb_rdv_durum
            // 
            this.cb_rdv_durum.FormattingEnabled = true;
            this.cb_rdv_durum.Location = new System.Drawing.Point(138, 362);
            this.cb_rdv_durum.Name = "cb_rdv_durum";
            this.cb_rdv_durum.Size = new System.Drawing.Size(121, 27);
            this.cb_rdv_durum.TabIndex = 14;
            // 
            // cb_rdv_trh
            // 
            this.cb_rdv_trh.FormattingEnabled = true;
            this.cb_rdv_trh.Location = new System.Drawing.Point(138, 221);
            this.cb_rdv_trh.Name = "cb_rdv_trh";
            this.cb_rdv_trh.Size = new System.Drawing.Size(121, 27);
            this.cb_rdv_trh.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.randevuidDataGridViewTextBoxColumn,
            this.hastaAdDataGridViewTextBoxColumn,
            this.hastaTCDataGridViewTextBoxColumn,
            this.doktorAdDataGridViewTextBoxColumn,
            this.randevuTarihiDataGridViewTextBoxColumn,
            this.randevuTuruDataGridViewTextBoxColumn,
            this.bolumDataGridViewTextBoxColumn,
            this.randevuDurumuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.randevularBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(268, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 341);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(16, 431);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(76, 34);
            this.btn_ekle.TabIndex = 17;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(138, 430);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(78, 33);
            this.btn_sil.TabIndex = 18;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(263, 430);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(78, 32);
            this.btn_guncelle.TabIndex = 19;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // hastaneOtomasyonuDataSet2
            // 
            this.hastaneOtomasyonuDataSet2.DataSetName = "HastaneOtomasyonuDataSet2";
            this.hastaneOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randevularBindingSource
            // 
            this.randevularBindingSource.DataMember = "Randevular";
            this.randevularBindingSource.DataSource = this.hastaneOtomasyonuDataSet2;
            // 
            // randevularTableAdapter
            // 
            this.randevularTableAdapter.ClearBeforeFill = true;
            // 
            // randevuidDataGridViewTextBoxColumn
            // 
            this.randevuidDataGridViewTextBoxColumn.DataPropertyName = "Randevuid";
            this.randevuidDataGridViewTextBoxColumn.HeaderText = "Randevuid";
            this.randevuidDataGridViewTextBoxColumn.Name = "randevuidDataGridViewTextBoxColumn";
            this.randevuidDataGridViewTextBoxColumn.ReadOnly = true;
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
            // doktorAdDataGridViewTextBoxColumn
            // 
            this.doktorAdDataGridViewTextBoxColumn.DataPropertyName = "DoktorAd";
            this.doktorAdDataGridViewTextBoxColumn.HeaderText = "DoktorAd";
            this.doktorAdDataGridViewTextBoxColumn.Name = "doktorAdDataGridViewTextBoxColumn";
            // 
            // randevuTarihiDataGridViewTextBoxColumn
            // 
            this.randevuTarihiDataGridViewTextBoxColumn.DataPropertyName = "RandevuTarihi";
            this.randevuTarihiDataGridViewTextBoxColumn.HeaderText = "RandevuTarihi";
            this.randevuTarihiDataGridViewTextBoxColumn.Name = "randevuTarihiDataGridViewTextBoxColumn";
            // 
            // randevuTuruDataGridViewTextBoxColumn
            // 
            this.randevuTuruDataGridViewTextBoxColumn.DataPropertyName = "RandevuTuru";
            this.randevuTuruDataGridViewTextBoxColumn.HeaderText = "RandevuTuru";
            this.randevuTuruDataGridViewTextBoxColumn.Name = "randevuTuruDataGridViewTextBoxColumn";
            // 
            // bolumDataGridViewTextBoxColumn
            // 
            this.bolumDataGridViewTextBoxColumn.DataPropertyName = "Bolum";
            this.bolumDataGridViewTextBoxColumn.HeaderText = "Bolum";
            this.bolumDataGridViewTextBoxColumn.Name = "bolumDataGridViewTextBoxColumn";
            // 
            // randevuDurumuDataGridViewTextBoxColumn
            // 
            this.randevuDurumuDataGridViewTextBoxColumn.DataPropertyName = "RandevuDurumu";
            this.randevuDurumuDataGridViewTextBoxColumn.HeaderText = "RandevuDurumu";
            this.randevuDurumuDataGridViewTextBoxColumn.Name = "randevuDurumuDataGridViewTextBoxColumn";
            // 
            // RandevuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(817, 491);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_rdv_trh);
            this.Controls.Add(this.cb_rdv_durum);
            this.Controls.Add(this.cb_bolum);
            this.Controls.Add(this.cb_rdv_turu);
            this.Controls.Add(this.cb_dkt_Ad);
            this.Controls.Add(this.cb_hst_tc);
            this.Controls.Add(this.cb_hst_Ad);
            this.Controls.Add(this.tx_rdv_id);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RandevuForm";
            this.Text = "RandevuForm";
            this.Load += new System.EventHandler(this.RandevuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox tx_rdv_id;
        private System.Windows.Forms.ComboBox cb_hst_Ad;
        private System.Windows.Forms.ComboBox cb_hst_tc;
        private System.Windows.Forms.ComboBox cb_dkt_Ad;
        private System.Windows.Forms.ComboBox cb_rdv_turu;
        private System.Windows.Forms.ComboBox cb_bolum;
        private System.Windows.Forms.ComboBox cb_rdv_durum;
        private System.Windows.Forms.ComboBox cb_rdv_trh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private HastaneOtomasyonuDataSet2 hastaneOtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource randevularBindingSource;
        private HastaneOtomasyonuDataSet2TableAdapters.RandevularTableAdapter randevularTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuDurumuDataGridViewTextBoxColumn;
    }
}