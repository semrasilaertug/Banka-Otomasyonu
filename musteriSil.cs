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
    public partial class musteriSil : Form
    {
        public musteriSil()
        {
            InitializeComponent();
        }

        private void musteriAd_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            int silinecekMusteriNo;
            silinecekMusteriNo = Convert.ToInt32(musteri_sil_maskedTextBox.Text);

            foreach (Musteri musteri in girisEkrani.personel.MusteriListele())
            {
                DialogResult result1 = MessageBox.Show("Müşteriyi silmek istediğinize emin misiniz?","", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    if (musteri.MusteriNo == silinecekMusteriNo)
                    {
                        girisEkrani.personel.MusteriSil(musteri);

                        MessageBox.Show(musteri_sil_maskedTextBox.Text + " numaralı müşteri başarıyla silinmiştir.");
                        break;

                    }
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
