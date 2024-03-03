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
    public partial class HesapOzetiGoruntule : Form
    {
        int secilimusteriNo;
        
        public HesapOzetiGoruntule()
        {
            InitializeComponent();
        }


        private void hesap_ozet_btn_Click(object sender, EventArgs e)
        {
            int hesapNo = 0;
            if (txtBox_HesapOzeti.Text != "")//Hesap Özeti Listeleme TextViewi boş bırakılırsa hata vermemesi için
            {
                hesapNo = Convert.ToInt32(txtBox_HesapOzeti.Text);

                DateTime timeBaslangic = baslangic_dateTime.Value;
                DateTime timeBitis = bitis_dateTime.Value;

                int BaslangicGun = timeBaslangic.Day;
                int BitisGun = timeBitis.Day;

                List<HesapOzeti> GosterilecekHesapOzeti = new List<HesapOzeti>();

                foreach (Musteri m in girisEkrani.personel.MusteriListele())
                {
                    foreach (Hesap h in m.Hesaplar)
                    {
                        if (hesapNo == h.HesapNo)
                        {
                            foreach (HesapOzeti r in h.HesapOzeti)
                            {
                                TimeSpan t = timeBitis - r.IslemTarihi;//Seçilen bitiş tarihi ile işlem tarihi arasındaki farkı alıyoruz.
                                int baslangicDegeri = t.Days; //Farkı güne çeviriyoruz.
                                TimeSpan t2 = r.IslemTarihi - timeBaslangic;
                                int bitisDegeri = t2.Days;

                                if (baslangicDegeri >= 0 && bitisDegeri >= 0)//Eğer ki farklar - değer değilse yani belirtilen aralık arasındaysa 
                                {
                                    GosterilecekHesapOzeti.Add(r);
                                }
                            }
                        }
                    }

                }
               
                dGridView_hesapOzeti.DataSource = GosterilecekHesapOzeti;
            }
            else
                MessageBox.Show("Lütfen hesap numarası giriniz.");

        }
    }
}//hesapListesi add olan her yere hesaplar add yap!!!!!!
