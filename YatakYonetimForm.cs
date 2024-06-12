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
    public partial class YatakYonetimForm : Form
    {
        public YatakYonetimForm()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void YatakYonetimForm_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select HstAd from Hasta", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cb_hst_ad.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("select HstTC from Hasta", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cb_hst_tc.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Yataklar (OdaNo, HastaAd, HastaTC, YatakSayısı, Aktif, Temizlik)values (@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p2", cb_oda_no.Text);
                komut.Parameters.AddWithValue("@p3", cb_hst_ad.Text);
                komut.Parameters.AddWithValue("@p4", cb_hst_tc.Text);
                komut.Parameters.AddWithValue("@p5", cb_ytk_sayısı.Text);
                komut.Parameters.AddWithValue("@p6", cb_ytk_durumu.Text);
                komut.Parameters.AddWithValue("@p7", cb_temizlik.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Yatak oluşturuldu..");
            }
            catch
            {
                MessageBox.Show("Yatak oluşturulurken hata oluştu..");
            }
        }

        private void bnt_sil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("delete from Yataklar where Yatakid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txb_ytk_id.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti();

                MessageBox.Show("Silme işlemi başarılı bir şekilde yapıldı..");
            }
            catch
            {
                MessageBox.Show("Silme işlemi yapılırken hata oluştu..");
            }
        }
    }
}
