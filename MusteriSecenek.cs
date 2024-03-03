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
   
    public partial class MusteriSecenek : Form
    {       
        public MusteriSecenek()
        {
            InitializeComponent();
        }

        private void paraYatırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParaYatir para_yatir= new ParaYatir();
            para_yatir.MdiParent = this;
            para_yatir.Show();
        }

        private void paraÇekToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            ParaCek para_cek = new ParaCek();
            para_cek.MdiParent = this;
            para_cek.Show();
        }

        private void havaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Havale havale_yap = new Havale();
            havale_yap.MdiParent = this;
            havale_yap.Show();
        }

        private void hesapÖzetiGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapOzetiGoruntule hesap_ozeti = new HesapOzetiGoruntule();
            hesap_ozeti.MdiParent = this;
            hesap_ozeti.Show();
        }

        private void çIKIŞYAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Çıkış Yapmak istediğinize emin misiniz?", "", MessageBoxButtons.YesNo);
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
