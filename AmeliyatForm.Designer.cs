namespace HastaneOtomasyonu
{
    partial class AmeliyatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmeliyatForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_ameliyat_idi = new System.Windows.Forms.TextBox();
            this.txb_ameliyat_turui = new System.Windows.Forms.TextBox();
            this.mtb_ameliyat_trhi = new System.Windows.Forms.MaskedTextBox();
            this.cb_hst_adi = new System.Windows.Forms.ComboBox();
            this.cb_hst_tci = new System.Windows.Forms.ComboBox();
            this.cb_dkt_adi = new System.Windows.Forms.ComboBox();
            this.cb_anestezi_turui = new System.Windows.Forms.ComboBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ameliyatidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ameliyatTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ameliyatTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anesteziTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ameliyatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneOtomasyonuDataSet3 = new HastaneOtomasyonu.HastaneOtomasyonuDataSet3();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.ameliyatTableAdapter = new HastaneOtomasyonu.HastaneOtomasyonuDataSet3TableAdapters.AmeliyatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ameliyatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ameliyat id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doktor Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ameliyat Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ameliyat Turu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Anestezi Turu:";
            // 
            // txb_ameliyat_idi
            // 
            this.txb_ameliyat_idi.Location = new System.Drawing.Point(136, 56);
            this.txb_ameliyat_idi.Name = "txb_ameliyat_idi";
            this.txb_ameliyat_idi.Size = new System.Drawing.Size(121, 26);
            this.txb_ameliyat_idi.TabIndex = 7;
            // 
            // txb_ameliyat_turui
            // 
            this.txb_ameliyat_turui.Location = new System.Drawing.Point(136, 222);
            this.txb_ameliyat_turui.Name = "txb_ameliyat_turui";
            this.txb_ameliyat_turui.Size = new System.Drawing.Size(121, 26);
            this.txb_ameliyat_turui.TabIndex = 8;
            // 
            // mtb_ameliyat_trhi
            // 
            this.mtb_ameliyat_trhi.Location = new System.Drawing.Point(136, 189);
            this.mtb_ameliyat_trhi.Mask = "00/00/0000 90:00";
            this.mtb_ameliyat_trhi.Name = "mtb_ameliyat_trhi";
            this.mtb_ameliyat_trhi.Size = new System.Drawing.Size(121, 26);
            this.mtb_ameliyat_trhi.TabIndex = 9;
            this.mtb_ameliyat_trhi.ValidatingType = typeof(System.DateTime);
            // 
            // cb_hst_adi
            // 
            this.cb_hst_adi.FormattingEnabled = true;
            this.cb_hst_adi.Location = new System.Drawing.Point(136, 89);
            this.cb_hst_adi.Name = "cb_hst_adi";
            this.cb_hst_adi.Size = new System.Drawing.Size(121, 27);
            this.cb_hst_adi.TabIndex = 10;
            // 
            // cb_hst_tci
            // 
            this.cb_hst_tci.FormattingEnabled = true;
            this.cb_hst_tci.Location = new System.Drawing.Point(136, 122);
            this.cb_hst_tci.Name = "cb_hst_tci";
            this.cb_hst_tci.Size = new System.Drawing.Size(121, 27);
            this.cb_hst_tci.TabIndex = 11;
            // 
            // cb_dkt_adi
            // 
            this.cb_dkt_adi.FormattingEnabled = true;
            this.cb_dkt_adi.Location = new System.Drawing.Point(136, 155);
            this.cb_dkt_adi.Name = "cb_dkt_adi";
            this.cb_dkt_adi.Size = new System.Drawing.Size(121, 27);
            this.cb_dkt_adi.TabIndex = 12;
            // 
            // cb_anestezi_turui
            // 
            this.cb_anestezi_turui.FormattingEnabled = true;
            this.cb_anestezi_turui.Location = new System.Drawing.Point(136, 254);
            this.cb_anestezi_turui.Name = "cb_anestezi_turui";
            this.cb_anestezi_turui.Size = new System.Drawing.Size(121, 27);
            this.cb_anestezi_turui.TabIndex = 13;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(16, 305);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(78, 31);
            this.btn_ekle.TabIndex = 14;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(107, 305);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(79, 31);
            this.btn_sil.TabIndex = 15;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ameliyatidDataGridViewTextBoxColumn,
            this.hastaAdDataGridViewTextBoxColumn,
            this.hastaTCDataGridViewTextBoxColumn,
            this.doktorAdDataGridViewTextBoxColumn,
            this.ameliyatTarihiDataGridViewTextBoxColumn,
            this.ameliyatTuruDataGridViewTextBoxColumn,
            this.anesteziTuruDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ameliyatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(284, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 280);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ameliyatidDataGridViewTextBoxColumn
            // 
            this.ameliyatidDataGridViewTextBoxColumn.DataPropertyName = "Ameliyatid";
            this.ameliyatidDataGridViewTextBoxColumn.HeaderText = "Ameliyatid";
            this.ameliyatidDataGridViewTextBoxColumn.Name = "ameliyatidDataGridViewTextBoxColumn";
            this.ameliyatidDataGridViewTextBoxColumn.ReadOnly = true;
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
            // ameliyatTarihiDataGridViewTextBoxColumn
            // 
            this.ameliyatTarihiDataGridViewTextBoxColumn.DataPropertyName = "AmeliyatTarihi";
            this.ameliyatTarihiDataGridViewTextBoxColumn.HeaderText = "AmeliyatTarihi";
            this.ameliyatTarihiDataGridViewTextBoxColumn.Name = "ameliyatTarihiDataGridViewTextBoxColumn";
            // 
            // ameliyatTuruDataGridViewTextBoxColumn
            // 
            this.ameliyatTuruDataGridViewTextBoxColumn.DataPropertyName = "AmeliyatTuru";
            this.ameliyatTuruDataGridViewTextBoxColumn.HeaderText = "AmeliyatTuru";
            this.ameliyatTuruDataGridViewTextBoxColumn.Name = "ameliyatTuruDataGridViewTextBoxColumn";
            // 
            // anesteziTuruDataGridViewTextBoxColumn
            // 
            this.anesteziTuruDataGridViewTextBoxColumn.DataPropertyName = "AnesteziTuru";
            this.anesteziTuruDataGridViewTextBoxColumn.HeaderText = "AnesteziTuru";
            this.anesteziTuruDataGridViewTextBoxColumn.Name = "anesteziTuruDataGridViewTextBoxColumn";
            // 
            // ameliyatBindingSource
            // 
            this.ameliyatBindingSource.DataMember = "Ameliyat";
            this.ameliyatBindingSource.DataSource = this.hastaneOtomasyonuDataSet3;
            // 
            // hastaneOtomasyonuDataSet3
            // 
            this.hastaneOtomasyonuDataSet3.DataSetName = "HastaneOtomasyonuDataSet3";
            this.hastaneOtomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(199, 305);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(79, 31);
            this.btn_guncelle.TabIndex = 17;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // ameliyatTableAdapter
            // 
            this.ameliyatTableAdapter.ClearBeforeFill = true;
            // 
            // AmeliyatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(729, 393);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.cb_anestezi_turui);
            this.Controls.Add(this.cb_dkt_adi);
            this.Controls.Add(this.cb_hst_tci);
            this.Controls.Add(this.cb_hst_adi);
            this.Controls.Add(this.mtb_ameliyat_trhi);
            this.Controls.Add(this.txb_ameliyat_turui);
            this.Controls.Add(this.txb_ameliyat_idi);
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
            this.Name = "AmeliyatForm";
            this.Text = "AmeliyatForm";
            this.Load += new System.EventHandler(this.AmeliyatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ameliyatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet3)).EndInit();
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
        private System.Windows.Forms.TextBox txb_ameliyat_idi;
        private System.Windows.Forms.TextBox txb_ameliyat_turui;
        private System.Windows.Forms.MaskedTextBox mtb_ameliyat_trhi;
        private System.Windows.Forms.ComboBox cb_hst_adi;
        private System.Windows.Forms.ComboBox cb_hst_tci;
        private System.Windows.Forms.ComboBox cb_dkt_adi;
        private System.Windows.Forms.ComboBox cb_anestezi_turui;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_guncelle;
        private HastaneOtomasyonuDataSet3 hastaneOtomasyonuDataSet3;
        private System.Windows.Forms.BindingSource ameliyatBindingSource;
        private HastaneOtomasyonuDataSet3TableAdapters.AmeliyatTableAdapter ameliyatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ameliyatidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ameliyatTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ameliyatTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anesteziTuruDataGridViewTextBoxColumn;
    }
}