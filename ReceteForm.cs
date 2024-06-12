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
    public partial class ReceteForm : Form
    {
        public ReceteForm()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void ReceteForm_Load(object sender, EventArgs e)
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
        }

        private void bnt_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand baglan = new SqlCommand("insert into Receteler (ReceteTarihi, HastaAd, HastaTC, Tani, Recetelenenilac, Dozaj)values (@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                baglan.Parameters.AddWithValue("@p2", msb_recete_trh.Text);
                baglan.Parameters.AddWithValue("@p3", cb_hst_ad.Text);
                baglan.Parameters.AddWithValue("@p4", cb_hst_tc.Text);
                baglan.Parameters.AddWithValue("@p5", rtb_tani.Text);
                baglan.Parameters.AddWithValue("@p6", rtb_recete_ilac.Text);
                baglan.Parameters.AddWithValue("@p7", rtb_dozaj.Text);
                baglan.ExecuteNonQuery();
                bgl.baglanti();

                MessageBox.Show("Receteleme başarıyla eklendi..");
            }
            catch
            {
                MessageBox.Show("Ekle yapılırken hata oluştu..");
            }
        }
    }
}
