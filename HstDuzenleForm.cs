using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class HstDuzenleForm : Form
    {
        public HstDuzenleForm()
        {
            InitializeComponent();
        }
        private void HstDuzenleForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneOtomasyonuDataSet.Hasta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaTableAdapter.Fill(this.hastaneOtomasyonuDataSet.Hasta);

        }
        public int secilen;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            HastaSilGuncelleForm fr = new HastaSilGuncelleForm();

            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.vatandas = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.tc = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.cinsiyet = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.dogum = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.kan = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.sigorta = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            fr.telefon = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            fr.adres = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            fr.vekaletad = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            fr.vekalettelefon = dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            fr.Show();

        }

        
    }
}
