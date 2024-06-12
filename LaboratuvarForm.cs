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
    public partial class LaboratuvarForm : Form
    {
        public LaboratuvarForm()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void LaboratuvarForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneOtomasyonuDataSet4.Laboratuvar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.laboratuvarTableAdapter.Fill(this.hastaneOtomasyonuDataSet4.Laboratuvar);
            SqlCommand komut = new SqlCommand("select HastaAd from Randevular", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cb_hst_ad.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("select HastaTC from Randevular", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cb_hst_tc.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

        }

        private void btbn_ekle_Click(object sender, EventArgs e)
        {
           try
            {
                SqlCommand baglan = new SqlCommand("insert into Laboratuvar (HastaAd, HastaTC, TestAd, TestTarihi, SonucTarihi, Sonuc, Yorum, Degerlendirme) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                baglan.Parameters.AddWithValue("@p1", cb_hst_ad.Text);
                baglan.Parameters.AddWithValue("@p2", cb_hst_tc.Text);
                baglan.Parameters.AddWithValue("@p3", txb_test_ad.Text);
                baglan.Parameters.AddWithValue("@p4", mtb_test_trh.Text);
                baglan.Parameters.AddWithValue("@p5", mtb_sonuc_trh.Text);
                baglan.Parameters.AddWithValue("@p6", rtb_sonuc.Text);
                baglan.Parameters.AddWithValue("@p7", rtb_yorum.Text);
                baglan.Parameters.AddWithValue("@p8", rtb_deger.Text);
                baglan.ExecuteNonQuery();
                bgl.baglanti();
                MessageBox.Show("Laboratuvar kayıt eklendi");
            }
            catch 
            {
                MessageBox.Show("Laboratuvar ekleme yapılırken Hata oluşmuştur.");
            }

        }
        public int secilen;
        public string lab_id, hasta_ad, hasta_tc, test_ad, test_trh, sonuc_trh, sonuc, yorum, deger;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            lab_id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            hasta_ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            hasta_tc = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            test_ad = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            test_trh = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            sonuc_trh = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            sonuc = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            yorum = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            deger = dataGridView1.Rows[secilen].Cells[8].Value.ToString();

            txb_sonuc_id.Text = lab_id;
            cb_hst_ad.Text = hasta_ad;
            cb_hst_tc.Text = hasta_tc;
            txb_test_ad.Text = test_ad;
            mtb_test_trh.Text = test_trh;
            mtb_sonuc_trh.Text = sonuc_trh;
            rtb_sonuc.Text = sonuc;
            rtb_yorum.Text = yorum;
            rtb_deger.Text = deger;


        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand baglan = new SqlCommand("update Laboratuvar set HastaAd =@p1, HastaTC =@p2, TestAd =@p3, TestTarihi =@p4, SonucTarihi =@p5, Sonuc =@p6, Yorum =@p7, Degerlendirme =@p8 where Sonucid =@p9", bgl.baglanti());
                baglan.Parameters.AddWithValue("@p1", cb_hst_ad.Text);
                baglan.Parameters.AddWithValue("@p2", cb_hst_tc.Text);
                baglan.Parameters.AddWithValue("@p3", txb_test_ad.Text);
                baglan.Parameters.AddWithValue("@p4", mtb_test_trh.Text);
                baglan.Parameters.AddWithValue("@p5", mtb_sonuc_trh.Text);
                baglan.Parameters.AddWithValue("@p6", rtb_sonuc.Text);
                baglan.Parameters.AddWithValue("@p7", rtb_yorum.Text);
                baglan.Parameters.AddWithValue("@p8", rtb_deger.Text);
                baglan.Parameters.AddWithValue("@p9", txb_sonuc_id.Text);
                baglan.ExecuteNonQuery();
                bgl.baglanti();
                MessageBox.Show("Laboratuvar güncelleme yapılmıştır");

            }
            catch 
            {
                MessageBox.Show("Laboratuvar güncelleme yapılırken Hata oluşmuştur.");
            }
        }
    }
}
