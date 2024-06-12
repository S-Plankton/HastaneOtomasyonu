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
    public partial class FrmHstKayit : Form
    {
        public FrmHstKayit()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komutkayıt = new SqlCommand("insert into Hasta (HstAd, HstSoyad, HstVatandas, HstTC, HstCinsiyet, HstDogum, HstKan, HstSigorta, HstTelefon, HstAdres, HstVekalet, HstVekaletTelefon)values (@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13)", bgl.baglanti());

                komutkayıt.Parameters.AddWithValue("@p2", txb_Hastaadi.Text);
                komutkayıt.Parameters.AddWithValue("@p3", txb_hastasoyadi.Text);
                komutkayıt.Parameters.AddWithValue("@p4", cmb_tcvatandaslik.Text);
                komutkayıt.Parameters.AddWithValue("@p5", mtb_hastatc.Text);
                komutkayıt.Parameters.AddWithValue("@p6", cmb_cinsiyet.Text);
                komutkayıt.Parameters.AddWithValue("@p7", mtb_dogum.Text);
                komutkayıt.Parameters.AddWithValue("@p8", cmb_kangrubu.Text);
                komutkayıt.Parameters.AddWithValue("@p9", cmb_sigorta.Text);
                komutkayıt.Parameters.AddWithValue("@p10", mtb_hastatelefon.Text);
                komutkayıt.Parameters.AddWithValue("@p11", rtb_adres.Text);
                komutkayıt.Parameters.AddWithValue("@p12", txb_yakinad.Text);
                komutkayıt.Parameters.AddWithValue("@p13", mtb_yakintelefon.Text);
                komutkayıt.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Hasta Eklendi..");

            }
            catch
            {
                MessageBox.Show("Hasta Eklenirken Hata oluştu..");
            }
        }
    }
}
