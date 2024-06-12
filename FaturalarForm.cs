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
    public partial class FaturalarForm : Form
    {
        public FaturalarForm()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FaturalarForm_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select HstTC from Hasta", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cb_hst_tc.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("select HstAd from Hasta", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cb_hst_ad.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand komut3 = new SqlCommand("select OdemeSekli from OdemeSekli", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                cb_odm_sekli.Items.Add(oku3[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand baglan = new SqlCommand("insert into Faturalar (HastaTC, HastaAd, FaturaTarihi, OdemeSekli, YapılanTedavi1, YapılanTedavi2, YapılanTedavi3, ToplamTutar)values (@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                baglan.Parameters.AddWithValue("@p2", cb_hst_tc.Text);
                baglan.Parameters.AddWithValue("@p3", cb_hst_ad.Text);
                baglan.Parameters.AddWithValue("@p4", mtb_ftr_tarihi.Text);
                baglan.Parameters.AddWithValue("@p5", cb_odm_sekli.Text);
                baglan.Parameters.AddWithValue("@p6", txb_ypl_tdv.Text);
                baglan.Parameters.AddWithValue("@p7", txb_ypl_tdv2.Text);
                baglan.Parameters.AddWithValue("@p8", txb_ypl_tdv3.Text);
                baglan.Parameters.AddWithValue("@p9", txb_toplam_tutar.Text);
                baglan.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Fatura oluşturuldu..");
            }
            catch 
            {
                MessageBox.Show("Fatura oluşturmada hata oluştu..");
            }
        }
    }
}
