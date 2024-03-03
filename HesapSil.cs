using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace nesne1._1
{
    public partial class HesapSil : Form
    {
        public HesapSil()
        {
            InitializeComponent();
        }

        private void hesapSil_btn_Click(object sender, EventArgs e)
        {
            int silinecek_hesap = Convert.ToInt32(hesap_sil_maskedTextBox.Text);

           
                foreach (var musteri in girisEkrani.personel.MusteriListele())
                        {
                            foreach (var hesap in musteri.HesapListele())
                            {
                                if (hesap.HesapNo == silinecek_hesap)
                                {

                        musteri.HesapSil(silinecek_hesap);

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

            hesap_sil_maskedTextBox.Clear();


        }
    }
}
