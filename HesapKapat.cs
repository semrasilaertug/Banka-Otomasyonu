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
    public partial class HesapKapat : Form
    {
        public HesapKapat()
        {
            InitializeComponent();
        }

        private void hesabi_kapat_btn_Click(object sender, EventArgs e)
        {
            int silinecek_hesap = Convert.ToInt32(hesap_kapat_maskedTextBox.Text);

            foreach (var p in girisEkrani.personel.MusteriListele())
            {
                foreach (var hesap in p.HesapListele())
                {
                    if (hesap.HesapNo == silinecek_hesap)
                    {
       
                        girisEkrani.Musteri.HesapKapat(silinecek_hesap);

                        HesapOzeti hesapOzeti = new HesapOzeti();
                        hesapOzeti.Bakiye = hesap.Bakiye;
                        hesapOzeti.IslemTarihi = DateTime.Now;
                        hesapOzeti.YapilanIslem = "Hesap Kapatma";
                        hesapOzeti.IslemUcreti = 0;
                        hesap.HesapOzetiGoruntule(hesapOzeti);
                    }
                    break;
                }

            }
        }
    }
}
