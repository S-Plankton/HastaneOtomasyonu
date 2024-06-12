using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class AmeliyatForm : Form
    {
        public AmeliyatForm()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void AmeliyatForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneOtomasyonuDataSet3.Ameliyat' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ameliyatTableAdapter.Fill(this.hastaneOtomasyonuDataSet3.Ameliyat);
            SqlCommand baglan = new SqlCommand("select HstAd from Hasta", bgl.baglanti());
            SqlDataReader oku = baglan.ExecuteReader();
            while (oku.Read())
            {
                cb_hst_adi.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand baglan2 = new SqlCommand("select HstTC from Hasta", bgl.baglanti());
            SqlDataReader oku2 = baglan2.ExecuteReader();
            while (oku2.Read())
            {
                cb_hst_tci.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand baglan3 = new SqlCommand("select DoktorAdı from DoktorBilgileri", bgl.baglanti());
            SqlDataReader oku3 = baglan3.ExecuteReader();
            while (oku3.Read())
            {
                cb_dkt_adi.Items.Add(oku3[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand baglan4 = new SqlCommand("select AnesteziTuru from Anestezi", bgl.baglanti());
            SqlDataReader oku4 = baglan4.ExecuteReader();
            while (oku4.Read())
            {
                cb_anestezi_turui.Items.Add(oku4[0].ToString());
            }
            bgl.baglanti().Close();

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut1 = new SqlCommand("insert into Ameliyat (HastaAd, HastaTC, DoktorAd, AmeliyatTarihi, AmeliyatTuru, AnesteziTuru)values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", cb_hst_adi.Text);
                komut1.Parameters.AddWithValue("@p2", cb_hst_tci.Text);
                komut1.Parameters.AddWithValue("@p3", cb_dkt_adi.Text);
                komut1.Parameters.AddWithValue("@p4", mtb_ameliyat_trhi.Text);
                komut1.Parameters.AddWithValue("@p5", txb_ameliyat_turui.Text);
                komut1.Parameters.AddWithValue("@p6", cb_anestezi_turui.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti();

                MessageBox.Show("Ameliyat Başarılı bir şekilde eklendi..");

            }
            catch 
            {
                MessageBox.Show("Ekleme yapılırken hata oluştu..");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand baglan = new SqlCommand("delete from Ameliyat where Ameliyatid=@p1", bgl.baglanti());
                baglan.Parameters.AddWithValue("@p1", txb_ameliyat_idi.Text);
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
                SqlCommand baglan = new SqlCommand("update Bolumler set HastaAd=@p2, HastaTC=@p3, DoktorAd=@p4, AmeliyatTarihi=@p5, AmeliyatTuru=@p6, AnesteziTuru=@p7 where Ameliyatid=@p1", bgl.baglanti());
                baglan.Parameters.AddWithValue("@p1", txb_ameliyat_idi.Text);
                baglan.Parameters.AddWithValue("@p2", cb_hst_adi.Text);
                baglan.Parameters.AddWithValue("@p3", cb_hst_tci.Text);
                baglan.Parameters.AddWithValue("@p4", cb_dkt_adi.Text);
                baglan.Parameters.AddWithValue("@p5", mtb_ameliyat_trhi.Text);
                baglan.Parameters.AddWithValue("@p6", txb_ameliyat_turui.Text);
                baglan.Parameters.AddWithValue("@p7", cb_anestezi_turui.Text);
                baglan.ExecuteNonQuery();
                bgl.baglanti();

                MessageBox.Show("Güncelleme başarılı bir şekilde yapıldı..");
            }
            catch 
            {
                MessageBox.Show("Güncelleme işlemi yapılırken hata oluştu..");
            }
        }
        public int secilen;
        public string ameliyat_id, hstad, hsttc, dktad, ameliyat_trh, ameliyat_turu, anestezi_turu;


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            ameliyat_id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            hstad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            hsttc = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            dktad = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            ameliyat_trh = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            ameliyat_turu = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            anestezi_turu = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            txb_ameliyat_idi.Text =  ameliyat_id;
            cb_hst_adi.Text = hstad;
            cb_hst_tci.Text = hsttc;
            cb_dkt_adi.Text = dktad;
            mtb_ameliyat_trhi.Text = ameliyat_trh;
            txb_ameliyat_turui.Text = ameliyat_turu;
            cb_anestezi_turui.Text = anestezi_turu;

        }
    }
}
