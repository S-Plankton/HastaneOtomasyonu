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
            HstDuzenleForm kayit = new HstDuzenleForm();
            kayit.Show();
        }

        private void doktorlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoktorForm kayit = new DoktorForm();
            kayit.Show();
        }

        private void randevuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
