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
    public partial class ParaCek : Form
    {
        
        public int seciliMusteriNo;

        public ParaCek()
        {
            InitializeComponent();
        }

        
        private void para_cek_btn_Click(object sender, EventArgs e)
        {
            int seciliMusteriNo = Convert.ToInt32(musteriNo_txtbox.Text);
            int seciliHesapNo = Convert.ToInt32(txtBox_cekilecekHesapNo.Text);
            decimal cekilecekTutar = Convert.ToDecimal(cekilecek_textbox.Text);


            foreach (Musteri musteri in girisEkrani.personel.MusteriListele())
            {

                if (musteri.MusteriNo == seciliMusteriNo)
                {

                    foreach (var h in musteri.Hesaplar) 
                    {
                        if (h.HesapNo == seciliHesapNo)
                        {
                            MessageBox.Show(h.ParaCek(cekilecekTutar));
                            
                            guncel_bakiye_textBox.Text = h.Bakiye.ToString() + "TL";

                            HesapOzeti hesapOzeti = new HesapOzeti();
                            hesapOzeti.Bakiye = h.Bakiye;
                            hesapOzeti.IslemTutari = -cekilecekTutar;
                            hesapOzeti.YapilanIslem = "Para Çekme";
                            hesapOzeti.IslemTarihi = DateTime.Now;
                            hesapOzeti.IslemUcreti = 0;
                            h.HesapOzetiGoruntule(hesapOzeti);
                        }
                       
                    }
                }
            }

            musteriNo_txtbox.Clear();
            cekilecek_textbox.Clear();
            txtBox_cekilecekHesapNo.Clear();
        }
    }
}
