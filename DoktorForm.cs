using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyonu
{
    public partial class DoktorForm : Form
    {
        public DoktorForm()
        {
            InitializeComponent();
        }

        private void DoktorForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneOtomasyonuDataSet1.DoktorBilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.doktorBilgileriTableAdapter.Fill(this.hastaneOtomasyonuDataSet1.DoktorBilgileri);

        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand baglan = new SqlCommand("insert into DoktorBilgileri (DoktorAdı, DoktorSoyad, DoktorUzmanlık, DoktorTelefon)values (@p2,@p3,@p4,@p5)", bgl.baglanti());
                baglan.Parameters.AddWithValue("@p2", txb_dkt_ad.Text);
                baglan.Parameters.AddWithValue("@p3", txb_dkt_soyad.Text);
                baglan.Parameters.AddWithValue("@p4", txb_dkt_uzmanlik.Text);
                baglan.Parameters.AddWithValue("@p5", mtb_dkt_telefon.Text);
                baglan.ExecuteNonQuery();
                bgl.baglanti();

                MessageBox.Show("Doktor Başarıyla Eklendi..");
                this.doktorBilgileriTableAdapter.Fill(this.hastaneOtomasyonuDataSet1.DoktorBilgileri);

            }
            catch
            {
                MessageBox.Show("Ekle Yapılırken Hata Oluştu..");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand baglan = new SqlCommand("delete from DoktorBilgileri where Doktorid=@p1", bgl.baglanti());
                baglan.Parameters.AddWithValue("@p1", txb_dkt_id.Text);
                baglan.ExecuteNonQuery();
                bgl.baglanti();

                MessageBox.Show("Silme işlemi başarılı bir şekilde yapıldı..");
                this.doktorBilgileriTableAdapter.Fill(this.hastaneOtomasyonuDataSet1.DoktorBilgileri);

            }
            catch
            {
                MessageBox.Show("Silme işlemi yapılırken hata oluştu..");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand baglan = new SqlCommand("update DoktorBilgileri set DoktorAdı=@p2, DoktorSoyad=@p3, DoktorUzmanlık=@p4, DoktorTelefon=@p5 where Doktorid=@p1", bgl.baglanti());
                baglan.Parameters.AddWithValue("@p1", txb_dkt_id.Text);
                baglan.Parameters.AddWithValue("@p2", txb_dkt_ad.Text);
                baglan.Parameters.AddWithValue("@p3", txb_dkt_soyad.Text);
                baglan.Parameters.AddWithValue("@p4", txb_dkt_uzmanlik.Text);
                baglan.Parameters.AddWithValue("@p5", mtb_dkt_telefon.Text);
                baglan.ExecuteNonQuery();
                bgl.baglanti();

                MessageBox.Show("Güncelleme işlemi başarılı bir şekilde yapıldı..");


            }
            catch
            {
                MessageBox.Show("Güncelleme işlemi yapılırken hata oluştu..");
            }
        }
        public int secilen;
        public string id, ad, soyad, uzmanlik, telefon;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            uzmanlik = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            txb_dkt_id.Text = id;
            txb_dkt_ad.Text = ad;
            txb_dkt_soyad.Text = soyad;
            txb_dkt_uzmanlik.Text = uzmanlik;
            mtb_dkt_telefon.Text = telefon;

        }
    }
}
