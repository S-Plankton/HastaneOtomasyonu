using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHstKayit kayit = new FrmHstKayit();
            kayit.Show();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaDuzenleForm kayit = new HastaDuzenleForm();
            kayit.Show();
        }

        private void doktorlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoktorForm kayit = new DoktorForm();
            kayit.Show();
        }

        private void randevuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandevuForm kayit = new RandevuForm();
            kayit.Show();
        }

        private void faturaVeÖdemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturalarForm kayit = new FaturalarForm();
            kayit.Show();
        }

        private void yatakYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YatakYonetimForm kayit = new YatakYonetimForm();
            kayit.Show();
        }

        private void ameliyatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmeliyatForm kayit = new AmeliyatForm();
            kayit.Show();
        }

        private void doktorEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TedaviForm kayit = new TedaviForm();
            kayit.Show();
        }

        private void labaratuvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaboratuvarForm kayit = new LaboratuvarForm();
            kayit.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text=DateTime.Now.ToLongDateString();
            label2.Text=DateTime.Now.ToLongTimeString();
        }

        private void hastalarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
