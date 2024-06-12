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
    public partial class TedaviForm : Form
    {
        public TedaviForm()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void TedaviForm_Load(object sender, EventArgs e)
        {
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

            SqlCommand komut3 = new SqlCommand("select DoktorAd from Randevular", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                cb_dkt_ad.Items.Add(oku3[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand baglan = new SqlCommand("insert into TibbiKayitlar (HastaAd, HastaTC, DoktoAd, KayitTarihi, Teshis, Tedavi, TibbiGecmis)values (@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                baglan.Parameters.AddWithValue("@p2", cb_hst_ad.Text);
                baglan.Parameters.AddWithValue("@p3", cb_hst_tc.Text);
                baglan.Parameters.AddWithValue("@p4", cb_dkt_ad.Text);
                baglan.Parameters.AddWithValue("@p5", mtb_kyt_trh.Text);
                baglan.Parameters.AddWithValue("@p6", rtb_teshis.Text);
                baglan.Parameters.AddWithValue("@p7", rtb_tedavi.Text);
                baglan.Parameters.AddWithValue("@p8", rtb_tibb_gecmis.Text);
                baglan.ExecuteNonQuery();
                bgl.baglanti();

                MessageBox.Show("Tedavi başarıyla eklendi..");

            }
            catch 
            {
                MessageBox.Show("Ekle yapılırken hata oluştu..");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand baglan = new SqlCommand("update TibbiKayitlar set HastaAd=@p2, HastaTC=@p3, DoktoAd=@p4, KayitTarihi=@p5, Teshis=@p6, Tedavi=@p7, TibbiGecmis=@p8 where Kayitid=@p1", bgl.baglanti());
                baglan.Parameters.AddWithValue("@p1", txb_kayit_id.Text);
                baglan.Parameters.AddWithValue("@p2", cb_hst_ad.Text);
                baglan.Parameters.AddWithValue("@p3", cb_hst_tc.Text);
                baglan.Parameters.AddWithValue("@p4", cb_dkt_ad.Text);
                baglan.Parameters.AddWithValue("@p5", mtb_kyt_trh.Text);
                baglan.Parameters.AddWithValue("@p6", rtb_teshis.Text);
                baglan.Parameters.AddWithValue("@p7", rtb_tedavi.Text);
                baglan.Parameters.AddWithValue("@p8", rtb_tibb_gecmis.Text);
                baglan.ExecuteNonQuery();
                bgl.baglanti();

                MessageBox.Show("Güncelleme işlemi başarılı bir şekilde yapıldı..");


            }
            catch
            {
                MessageBox.Show("Güncelleme yapılırken hata oluştu..");
            }
        }

        private void btn_recete_Click(object sender, EventArgs e)
        {
            ReceteForm kayit = new ReceteForm();
            kayit.Show();
        }

        private void btn_laboratuvar_Click(object sender, EventArgs e)
        {
            LaboratuvarForm kayit = new LaboratuvarForm();
            kayit.Show();
        }
    }
}
