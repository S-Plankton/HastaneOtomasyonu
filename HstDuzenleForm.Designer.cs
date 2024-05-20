namespace HastaneOtomasyonu
{
    partial class HstDuzenleForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hastaneOtomasyonuDataSet = new HastaneOtomasyonu.HastaneOtomasyonuDataSet();
            this.hastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaTableAdapter = new HastaneOtomasyonu.HastaneOtomasyonuDataSetTableAdapters.HastaTableAdapter();
            this.hastaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hstAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hstSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hstVatandasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hstTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hstCinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hstDogumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hstKanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hstSigortaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hstTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hstAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hstVekaletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hstVekaletTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hastaidDataGridViewTextBoxColumn,
            this.hstAdDataGridViewTextBoxColumn,
            this.hstSoyadDataGridViewTextBoxColumn,
            this.hstVatandasDataGridViewTextBoxColumn,
            this.hstTCDataGridViewTextBoxColumn,
            this.hstCinsiyetDataGridViewTextBoxColumn,
            this.hstDogumDataGridViewTextBoxColumn,
            this.hstKanDataGridViewTextBoxColumn,
            this.hstSigortaDataGridViewTextBoxColumn,
            this.hstTelefonDataGridViewTextBoxColumn,
            this.hstAdresDataGridViewTextBoxColumn,
            this.hstVekaletDataGridViewTextBoxColumn,
            this.hstVekaletTelefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hastaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hastaneOtomasyonuDataSet
            // 
            this.hastaneOtomasyonuDataSet.DataSetName = "HastaneOtomasyonuDataSet";
            this.hastaneOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaBindingSource
            // 
            this.hastaBindingSource.DataMember = "Hasta";
            this.hastaBindingSource.DataSource = this.hastaneOtomasyonuDataSet;
            // 
            // hastaTableAdapter
            // 
            this.hastaTableAdapter.ClearBeforeFill = true;
            // 
            // hastaidDataGridViewTextBoxColumn
            // 
            this.hastaidDataGridViewTextBoxColumn.DataPropertyName = "Hastaid";
            this.hastaidDataGridViewTextBoxColumn.HeaderText = "Hastaid";
            this.hastaidDataGridViewTextBoxColumn.Name = "hastaidDataGridViewTextBoxColumn";
            this.hastaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hstAdDataGridViewTextBoxColumn
            // 
            this.hstAdDataGridViewTextBoxColumn.DataPropertyName = "HstAd";
            this.hstAdDataGridViewTextBoxColumn.HeaderText = "HstAd";
            this.hstAdDataGridViewTextBoxColumn.Name = "hstAdDataGridViewTextBoxColumn";
            // 
            // hstSoyadDataGridViewTextBoxColumn
            // 
            this.hstSoyadDataGridViewTextBoxColumn.DataPropertyName = "HstSoyad";
            this.hstSoyadDataGridViewTextBoxColumn.HeaderText = "HstSoyad";
            this.hstSoyadDataGridViewTextBoxColumn.Name = "hstSoyadDataGridViewTextBoxColumn";
            // 
            // hstVatandasDataGridViewTextBoxColumn
            // 
            this.hstVatandasDataGridViewTextBoxColumn.DataPropertyName = "HstVatandas";
            this.hstVatandasDataGridViewTextBoxColumn.HeaderText = "HstVatandas";
            this.hstVatandasDataGridViewTextBoxColumn.Name = "hstVatandasDataGridViewTextBoxColumn";
            // 
            // hstTCDataGridViewTextBoxColumn
            // 
            this.hstTCDataGridViewTextBoxColumn.DataPropertyName = "HstTC";
            this.hstTCDataGridViewTextBoxColumn.HeaderText = "HstTC";
            this.hstTCDataGridViewTextBoxColumn.Name = "hstTCDataGridViewTextBoxColumn";
            // 
            // hstCinsiyetDataGridViewTextBoxColumn
            // 
            this.hstCinsiyetDataGridViewTextBoxColumn.DataPropertyName = "HstCinsiyet";
            this.hstCinsiyetDataGridViewTextBoxColumn.HeaderText = "HstCinsiyet";
            this.hstCinsiyetDataGridViewTextBoxColumn.Name = "hstCinsiyetDataGridViewTextBoxColumn";
            // 
            // hstDogumDataGridViewTextBoxColumn
            // 
            this.hstDogumDataGridViewTextBoxColumn.DataPropertyName = "HstDogum";
            this.hstDogumDataGridViewTextBoxColumn.HeaderText = "HstDogum";
            this.hstDogumDataGridViewTextBoxColumn.Name = "hstDogumDataGridViewTextBoxColumn";
            // 
            // hstKanDataGridViewTextBoxColumn
            // 
            this.hstKanDataGridViewTextBoxColumn.DataPropertyName = "HstKan";
            this.hstKanDataGridViewTextBoxColumn.HeaderText = "HstKan";
            this.hstKanDataGridViewTextBoxColumn.Name = "hstKanDataGridViewTextBoxColumn";
            // 
            // hstSigortaDataGridViewTextBoxColumn
            // 
            this.hstSigortaDataGridViewTextBoxColumn.DataPropertyName = "HstSigorta";
            this.hstSigortaDataGridViewTextBoxColumn.HeaderText = "HstSigorta";
            this.hstSigortaDataGridViewTextBoxColumn.Name = "hstSigortaDataGridViewTextBoxColumn";
            // 
            // hstTelefonDataGridViewTextBoxColumn
            // 
            this.hstTelefonDataGridViewTextBoxColumn.DataPropertyName = "HstTelefon";
            this.hstTelefonDataGridViewTextBoxColumn.HeaderText = "HstTelefon";
            this.hstTelefonDataGridViewTextBoxColumn.Name = "hstTelefonDataGridViewTextBoxColumn";
            // 
            // hstAdresDataGridViewTextBoxColumn
            // 
            this.hstAdresDataGridViewTextBoxColumn.DataPropertyName = "HstAdres";
            this.hstAdresDataGridViewTextBoxColumn.HeaderText = "HstAdres";
            this.hstAdresDataGridViewTextBoxColumn.Name = "hstAdresDataGridViewTextBoxColumn";
            // 
            // hstVekaletDataGridViewTextBoxColumn
            // 
            this.hstVekaletDataGridViewTextBoxColumn.DataPropertyName = "HstVekalet";
            this.hstVekaletDataGridViewTextBoxColumn.HeaderText = "HstVekalet";
            this.hstVekaletDataGridViewTextBoxColumn.Name = "hstVekaletDataGridViewTextBoxColumn";
            // 
            // hstVekaletTelefonDataGridViewTextBoxColumn
            // 
            this.hstVekaletTelefonDataGridViewTextBoxColumn.DataPropertyName = "HstVekaletTelefon";
            this.hstVekaletTelefonDataGridViewTextBoxColumn.HeaderText = "HstVekaletTelefon";
            this.hstVekaletTelefonDataGridViewTextBoxColumn.Name = "hstVekaletTelefonDataGridViewTextBoxColumn";
            // 
            // HstDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HstDuzenleForm";
            this.Text = "HstDuzenleForm";
            this.Load += new System.EventHandler(this.HstDuzenleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HastaneOtomasyonuDataSet hastaneOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource hastaBindingSource;
        private HastaneOtomasyonuDataSetTableAdapters.HastaTableAdapter hastaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hstAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hstSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hstVatandasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hstTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hstCinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hstDogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hstKanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hstSigortaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hstTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hstAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hstVekaletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hstVekaletTelefonDataGridViewTextBoxColumn;
    }
}