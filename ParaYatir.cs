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
    public partial class ParaYatir : Form
    {
        public int musteriNO;
        
        public ParaYatir()
        {
            InitializeComponent();
        }


        private void para_yatir_btn_Click(object sender, EventArgs e)
        {
            int seciliMusteriNo = Convert.ToInt32(musteriNo_txtbox.Text);
            int seciliHesapno = Convert.ToInt32(txtBox_paraYatirilacakHesap.Text);
            decimal yatirilacakMiktar = Convert.ToDecimal(mtxtBox_yatirilacakTutar.Text);
           

            foreach(Musteri musteri in girisEkrani.personel.MusteriListele())
            {
                if (musteri.MusteriNo == seciliMusteriNo)
                {

                    foreach (var hesap in musteri.Hesaplar)
                    {
                        if (hesap.HesapNo == seciliHesapno)
                        {
                            MessageBox.Show(hesap.ParaYatir(yatirilacakMiktar));
                            guncel_bakiye_textBox.Text = hesap.Bakiye.ToString() + "TL";

                            
                                HesapOzeti hesapOzeti = new HesapOzeti();
                                hesapOzeti.Bakiye = hesap.Bakiye;
                                hesapOzeti.IslemTutari = yatirilacakMiktar;
                                hesapOzeti.IslemTarihi = DateTime.Now;
                                hesapOzeti.YapilanIslem = "Para Yatırma";
                                hesapOzeti.IslemUcreti = 0;
                                hesap.HesapOzetiGoruntule(hesapOzeti);
                            
                        }

                    }
                }

            }
            musteriNo_txtbox.Clear();
            txtBox_paraYatirilacakHesap.Clear();
            mtxtBox_yatirilacakTutar.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
