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
    public partial class HesapEkle : Form
    {
        public HesapEkle()
        {
            InitializeComponent();
        }

        private void hesapEkle_btn_Click(object sender, EventArgs e)
        {
            int seciliMusteriNo, sayac = 0;

            if (hesap_ekle_maskedTextBox.Text == "")
            {

                MessageBox.Show("Lütfen müşteri numarası giriniz.");

            }
            else
            {

                seciliMusteriNo = Convert.ToInt32(hesap_ekle_maskedTextBox.Text);
                foreach (var musteri in girisEkrani.personel.MusteriListele())
                {
                    if (musteri.MusteriNo == seciliMusteriNo)
                    {
                        sayac++;
                        Hesap hesap = new Hesap();

                        musteri.HesapAc(hesap);

                        MessageBox.Show("Hesap açma işlemi başarıyla gerçekleştirildi." + seciliMusteriNo +
                            " numaralı müşterinin yeni hesap numarası :" + hesap.HesapNo);

                    }
                }
                if (sayac == 0)
                {

                    MessageBox.Show("Böyle bir müşteri bulunamadı.");

                }
            }
            hesap_ekle_maskedTextBox.Clear();
        }
        
    }
}
