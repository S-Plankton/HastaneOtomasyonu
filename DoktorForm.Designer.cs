namespace HastaneOtomasyonu
{
    partial class DoktorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_dkt_id = new System.Windows.Forms.TextBox();
            this.txb_dkt_ad = new System.Windows.Forms.TextBox();
            this.txb_dkt_soyad = new System.Windows.Forms.TextBox();
            this.txb_dkt_uzmanlik = new System.Windows.Forms.TextBox();
            this.mtb_dkt_telefon = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.hastaneOtomasyonuDataSet = new HastaneOtomasyonu.HastaneOtomasyonuDataSet();
            this.hastaneOtomasyonuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneOtomasyonuDataSet1 = new HastaneOtomasyonu.HastaneOtomasyonuDataSet1();
            this.doktorBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doktorBilgileriTableAdapter = new HastaneOtomasyonu.HastaneOtomasyonuDataSet1TableAdapters.DoktorBilgileriTableAdapter();
            this.doktoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorUzmanlıkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBilgileriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktor id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doktor Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doktor Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doktor Uzmanlık:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doktor Telefon:";
            // 
            // txb_dkt_id
            // 
            this.txb_dkt_id.Location = new System.Drawing.Point(134, 99);
            this.txb_dkt_id.Name = "txb_dkt_id";
            this.txb_dkt_id.Size = new System.Drawing.Size(100, 26);
            this.txb_dkt_id.TabIndex = 5;
            // 
            // txb_dkt_ad
            // 
            this.txb_dkt_ad.Location = new System.Drawing.Point(134, 141);
            this.txb_dkt_ad.Name = "txb_dkt_ad";
            this.txb_dkt_ad.Size = new System.Drawing.Size(100, 26);
            this.txb_dkt_ad.TabIndex = 6;
            // 
            // txb_dkt_soyad
            // 
            this.txb_dkt_soyad.Location = new System.Drawing.Point(134, 177);
            this.txb_dkt_soyad.Name = "txb_dkt_soyad";
            this.txb_dkt_soyad.Size = new System.Drawing.Size(100, 26);
            this.txb_dkt_soyad.TabIndex = 7;
            // 
            // txb_dkt_uzmanlik
            // 
            this.txb_dkt_uzmanlik.Location = new System.Drawing.Point(134, 217);
            this.txb_dkt_uzmanlik.Name = "txb_dkt_uzmanlik";
            this.txb_dkt_uzmanlik.Size = new System.Drawing.Size(100, 26);
            this.txb_dkt_uzmanlik.TabIndex = 8;
            // 
            // mtb_dkt_telefon
            // 
            this.mtb_dkt_telefon.Location = new System.Drawing.Point(134, 259);
            this.mtb_dkt_telefon.Mask = "(999) 000-0000";
            this.mtb_dkt_telefon.Name = "mtb_dkt_telefon";
            this.mtb_dkt_telefon.Size = new System.Drawing.Size(100, 26);
            this.mtb_dkt_telefon.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doktoridDataGridViewTextBoxColumn,
            this.doktorAdıDataGridViewTextBoxColumn,
            this.doktorSoyadDataGridViewTextBoxColumn,
            this.doktorUzmanlıkDataGridViewTextBoxColumn,
            this.doktorTelefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doktorBilgileriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(264, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 303);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(34, 383);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 31);
            this.btn_ekle.TabIndex = 11;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(132, 383);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(76, 31);
            this.btn_sil.TabIndex = 12;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(233, 383);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(77, 31);
            this.btn_guncelle.TabIndex = 13;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // hastaneOtomasyonuDataSet
            // 
            this.hastaneOtomasyonuDataSet.DataSetName = "HastaneOtomasyonuDataSet";
            this.hastaneOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaneOtomasyonuDataSetBindingSource
            // 
            this.hastaneOtomasyonuDataSetBindingSource.DataSource = this.hastaneOtomasyonuDataSet;
            this.hastaneOtomasyonuDataSetBindingSource.Position = 0;
            // 
            // hastaneOtomasyonuDataSet1
            // 
            this.hastaneOtomasyonuDataSet1.DataSetName = "HastaneOtomasyonuDataSet1";
            this.hastaneOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doktorBilgileriBindingSource
            // 
            this.doktorBilgileriBindingSource.DataMember = "DoktorBilgileri";
            this.doktorBilgileriBindingSource.DataSource = this.hastaneOtomasyonuDataSet1;
            // 
            // doktorBilgileriTableAdapter
            // 
            this.doktorBilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // doktoridDataGridViewTextBoxColumn
            // 
            this.doktoridDataGridViewTextBoxColumn.DataPropertyName = "Doktorid";
            this.doktoridDataGridViewTextBoxColumn.HeaderText = "Doktorid";
            this.doktoridDataGridViewTextBoxColumn.Name = "doktoridDataGridViewTextBoxColumn";
            this.doktoridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doktorAdıDataGridViewTextBoxColumn
            // 
            this.doktorAdıDataGridViewTextBoxColumn.DataPropertyName = "DoktorAdı";
            this.doktorAdıDataGridViewTextBoxColumn.HeaderText = "DoktorAdı";
            this.doktorAdıDataGridViewTextBoxColumn.Name = "doktorAdıDataGridViewTextBoxColumn";
            // 
            // doktorSoyadDataGridViewTextBoxColumn
            // 
            this.doktorSoyadDataGridViewTextBoxColumn.DataPropertyName = "DoktorSoyad";
            this.doktorSoyadDataGridViewTextBoxColumn.HeaderText = "DoktorSoyad";
            this.doktorSoyadDataGridViewTextBoxColumn.Name = "doktorSoyadDataGridViewTextBoxColumn";
            // 
            // doktorUzmanlıkDataGridViewTextBoxColumn
            // 
            this.doktorUzmanlıkDataGridViewTextBoxColumn.DataPropertyName = "DoktorUzmanlık";
            this.doktorUzmanlıkDataGridViewTextBoxColumn.HeaderText = "DoktorUzmanlık";
            this.doktorUzmanlıkDataGridViewTextBoxColumn.Name = "doktorUzmanlıkDataGridViewTextBoxColumn";
            // 
            // doktorTelefonDataGridViewTextBoxColumn
            // 
            this.doktorTelefonDataGridViewTextBoxColumn.DataPropertyName = "DoktorTelefon";
            this.doktorTelefonDataGridViewTextBoxColumn.HeaderText = "DoktorTelefon";
            this.doktorTelefonDataGridViewTextBoxColumn.Name = "doktorTelefonDataGridViewTextBoxColumn";
            // 
            // DoktorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mtb_dkt_telefon);
            this.Controls.Add(this.txb_dkt_uzmanlik);
            this.Controls.Add(this.txb_dkt_soyad);
            this.Controls.Add(this.txb_dkt_ad);
            this.Controls.Add(this.txb_dkt_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DoktorForm";
            this.Text = "DoktorForm";
            this.Load += new System.EventHandler(this.DoktorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBilgileriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_dkt_id;
        private System.Windows.Forms.TextBox txb_dkt_ad;
        private System.Windows.Forms.TextBox txb_dkt_soyad;
        private System.Windows.Forms.TextBox txb_dkt_uzmanlik;
        private System.Windows.Forms.MaskedTextBox mtb_dkt_telefon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private HastaneOtomasyonuDataSet hastaneOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource hastaneOtomasyonuDataSetBindingSource;
        private HastaneOtomasyonuDataSet1 hastaneOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource doktorBilgileriBindingSource;
        private HastaneOtomasyonuDataSet1TableAdapters.DoktorBilgileriTableAdapter doktorBilgileriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorUzmanlıkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorTelefonDataGridViewTextBoxColumn;
    }
}