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
    public partial class HastaSilGuncelleForm : Form
    {
        public HastaSilGuncelleForm()
        {
            InitializeComponent();
        }
        public string id, ad, soyad, vatandas, tc, cinsiyet, dogum, kan, sigorta, telefon, adres, vekaletad, vekalettelefon;
        SqlBaglantim bgl = new SqlBaglantim();

        private void HastaSilGuncelleForm_Load(object sender, EventArgs e)
        {
            txb_hastaid.Text = id;
            txb_Hastaadi.Text = ad;
            txb_hastasoyadi.Text = soyad;
            cmb_tcvatandaslik.Text = vatandas;
            mtb_hastatc.Text = tc;
            cmb_cinsiyet.Text = cinsiyet;
            mtb_dogum.Text = dogum;
            cmb_kangrubu.Text = kan;
            cmb_sigorta.Text = sigorta;
            mtb_hastatelefon.Text = telefon;
            rtb_adres.Text = adres;
            txb_yakinad.Text = vekaletad;
            mtb_yakintelefon.Text = vekalettelefon;

            SqlCommand komut = new SqlCommand("select CinsiyetAd from Cinsiyet", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmb_cinsiyet.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("select KanAd from Kangrubu", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmb_kangrubu.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand komut3 = new SqlCommand("select SigortaAd from Sigorta", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                cmb_sigorta.Items.Add(oku3[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand komut4 = new SqlCommand("select Vatandaslik from Vatandas", bgl.baglanti());
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                cmb_tcvatandaslik.Items.Add(oku4[0].ToString());
            }
            bgl.baglanti().Close();

        }
        
        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand baglan = new SqlCommand("delete from Hasta where Hastaid=@p1", bgl.baglanti());
            baglan.Parameters.AddWithValue("@p1", txb_hastaid.Text);
            baglan.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kayıt Başarıyla Silindi");
            this.Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand baglan = new SqlCommand("update Hasta set HstAd=@p2, HstSoyad=@p3, HstVatandas=@p4, HstTC=@p5, HstCinsiyet=@p6, HstDogum=@p7, HstKan=@p8, HstSigorta=@p9, HstTelefon=@p10, HstAdres=@p11, HstVekalet=@p12, HstVekaletTelefon=@p13 where Hastaid=@p1", bgl.baglanti());
            baglan.Parameters.AddWithValue("@p1", txb_hastaid.Text);
            baglan.Parameters.AddWithValue("@p2", txb_Hastaadi.Text);
            baglan.Parameters.AddWithValue("@p3", txb_hastasoyadi.Text);
            baglan.Parameters.AddWithValue("@p4", cmb_tcvatandaslik.Text);
            baglan.Parameters.AddWithValue("@p5", mtb_hastatc.Text);
            baglan.Parameters.AddWithValue("@p6", cmb_cinsiyet.Text);
            baglan.Parameters.AddWithValue("@p7", mtb_dogum.Text);
            baglan.Parameters.AddWithValue("@p8", cmb_kangrubu.Text);
            baglan.Parameters.AddWithValue("@p9", cmb_sigorta.Text);
            baglan.Parameters.AddWithValue("@p10", mtb_hastatelefon.Text);
            baglan.Parameters.AddWithValue("@p11", rtb_adres.Text);
            baglan.Parameters.AddWithValue("@p12", txb_yakinad.Text);
            baglan.Parameters.AddWithValue("@p13", mtb_yakintelefon.Text);

            baglan.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Güncellendi..");
            this.Close();

        }

    }
}
