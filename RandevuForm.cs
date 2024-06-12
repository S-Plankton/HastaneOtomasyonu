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
    public partial class RandevuForm : Form
    {
        public RandevuForm()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim(); 
        private void RandevuForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneOtomasyonuDataSet2.Randevular' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.randevularTableAdapter.Fill(this.hastaneOtomasyonuDataSet2.Randevular);
            SqlCommand komut = new SqlCommand("select HstAd from Hasta", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cb_hst_Ad.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("select HstTC from Hasta", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cb_hst_tc.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand komut3 = new SqlCommand("select DoktorAdı from DoktorBilgileri", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                cb_dkt_Ad.Items.Add(oku3[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand komut4 = new SqlCommand("select RandevuTuru from RandevuTuru", bgl.baglanti());
            SqlDataReader oku4 = komut4.ExecuteReader();
            while(oku4.Read())
            {
                cb_rdv_turu.Items.Add(oku4[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand komut5 = new SqlCommand("select DoktorUzmanlık from DoktorBilgileri", bgl.baglanti());
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                cb_bolum.Items.Add(oku5[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand komut6 = new SqlCommand("select RandevuDurumu from RandevuDurumu", bgl.baglanti());
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                cb_rdv_durum.Items.Add(oku6[0].ToString());
            }
            bgl.baglanti().Close();

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand baglan = new SqlCommand("insert into Randevular (HastaAd, HastaTC, DoktorAd, RandevuTarihi, RandevuTuru, Bolum, RandevuDurumu)values (@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                baglan.Parameters.AddWithValue("@p2", cb_hst_Ad.Text);
                baglan.Parameters.AddWithValue("@p3", cb_hst_tc.Text);
                baglan.Parameters.AddWithValue("@p4", cb_dkt_Ad.Text);
                baglan.Parameters.AddWithValue("@p5", cb_rdv_trh.Text);
                baglan.Parameters.AddWithValue("@p6", cb_rdv_turu.Text);
                baglan.Parameters.AddWithValue("@p7", cb_bolum.Text);
                baglan.Parameters.AddWithValue("@p8", cb_rdv_durum.Text);
                baglan.ExecuteNonQuery();
                bgl.baglanti();

                MessageBox.Show("Randevu başarılı bir şekilde eklendi..");

            }
            catch
            {
                MessageBox.Show("Randevu yapılırken hata oluştu..");
            }

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand baglan = new SqlCommand("delete from Randevular where Randevuid=@p1", bgl.baglanti());
                baglan.Parameters.AddWithValue("@p1", tx_rdv_id.Text);
                baglan.ExecuteNonQuery();
                bgl.baglanti();

                MessageBox.Show("Silme işlemi başarılı bir şekilde yapıldı..");


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
                SqlCommand baglan = new SqlCommand("update Randevular set HastaAd=@p2, HastaTC=@p3, DoktorAd=@p4, RandevuTarihi=@p5, Bolum=@p7, RandevuDurumu=@p8 where Randevuid=@p1", bgl.baglanti());
                baglan.Parameters.AddWithValue("@p1", tx_rdv_id.Text);
                baglan.Parameters.AddWithValue("@p2", cb_hst_Ad.Text);
                baglan.Parameters.AddWithValue("@p3", cb_hst_tc.Text);
                baglan.Parameters.AddWithValue("@p4", cb_dkt_Ad.Text);
                baglan.Parameters.AddWithValue("@p5", cb_rdv_trh.Text);
                baglan.Parameters.AddWithValue("@p6", cb_rdv_turu.Text);
                baglan.Parameters.AddWithValue("@p7", cb_bolum.Text);
                baglan.Parameters.AddWithValue("@p8", cb_rdv_durum.Text);
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
        public string id, hstad, hsttc, dktad, rdvtrh, rdvtr, bolum, rdvdrm;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].ToString();
            hstad = dataGridView1.Rows[secilen].Cells[1].ToString();
            hsttc = dataGridView1.Rows[secilen].Cells[2].ToString();
            dktad = dataGridView1.Rows[secilen].Cells[3].ToString();
            rdvtrh = dataGridView1.Rows[secilen].Cells[4].ToString();
            rdvtr = dataGridView1.Rows[secilen].Cells[5].ToString();
            bolum = dataGridView1.Rows[secilen].Cells[6].ToString();
            rdvdrm = dataGridView1.Rows[secilen].Cells[7].ToString();

            tx_rdv_id.Text = id;
            cb_hst_Ad.Text = hstad;
            cb_hst_tc.Text = hsttc;
            cb_dkt_Ad.Text = dktad;
            cb_rdv_trh.Text = rdvtrh;
            cb_rdv_turu.Text = rdvtr;
            cb_bolum.Text = bolum;
            cb_rdv_durum.Text = rdvdrm;

        }
    }
}
