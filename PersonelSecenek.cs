using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesne1._1
{
    public partial class PersonelSecenek : Form
    {
        public PersonelSecenek()
        {
            InitializeComponent();
        }

        private void müşteriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MusteriEkle musteri_ekle = new MusteriEkle();
            musteri_ekle.MdiParent = this;
            musteri_ekle.Show();
        }

        private void müşteriToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            musteriSil musteri_sil = new musteriSil();
            musteri_sil.MdiParent = this;
            musteri_sil.Show();
        }

        private void hesapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapEkle hesapEkle = new HesapEkle();
            hesapEkle.MdiParent = this;
            hesapEkle.Show();
        }

        private void hesapToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            HesapSil hesapSil = new HesapSil();
            hesapSil.MdiParent = this;
            hesapSil.Show();
        }

        private void müşteriToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MusteriListele musteri_listele = new MusteriListele();
            musteri_listele.MdiParent = this;
            musteri_listele.Show();
        }

        private void hesapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HesapListele hesap_listele = new HesapListele();
            hesap_listele.MdiParent = this;
            hesap_listele.Show();
        }

        private void gelirGiderRaporuGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GelirGiderRaporu gelir_gider_raporu = new GelirGiderRaporu();
            gelir_gider_raporu.MdiParent = this;
            gelir_gider_raporu.Show();
        }

        private void çIKIŞYAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {   
            }
        }
    }
}
