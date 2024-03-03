using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesne1._1
{
    public class Musteri : Kisi
    {
        public int MusteriNo { get; set; }
        public List<Hesap> Hesaplar { get; set; }
        public int Sifre { get; set; }
        public bool MusteriTuru { get; set; }

        public Musteri()
        {
            Hesaplar = new List<Hesap>();
            kimlikBilgisi = new KimlikBilgisi();

        }

        public void HesapKapat(int hesap)
        {
            foreach (Hesap h in Hesaplar)
            {
                
                if (hesap == h.HesapNo)
                {

                    if (h.Bakiye == 0) //Hesapta para yoksa 
                    {
                        Hesaplar.Remove(h);
                        MessageBox.Show("'" + hesap + "' numaralı hesap başarıyla silindi.");
                        break;
                    }
                    else
                        MessageBox.Show("'" + hesap + "' numaralı hesap silinebilmesi için bakiyesi 0 TL olmalıdır. \n Mevcut Bakiye: '" + h.Bakiye);
                }
            }
        }

        public void HesapAc(Hesap hesap)
        {
            Random r = new Random();
            int no = r.Next(100, 1000);
            if (this.Hesaplar.Count == 0)
            {

                hesap.HesapNo = no;

            }
            else
            {
                foreach (var hesap1 in this.Hesaplar)
                {
                    Random r1 = new Random();
                    int no1 = r1.Next(100, 1000);
                    if (hesap1.HesapNo != no1)
                    {

                        hesap.HesapNo = no;

                    }

                }
            }
            this.Hesaplar.Add(hesap);

        }

        public void HesapSil(int hesap)
        {
            foreach (Hesap h in this.Hesaplar)
            {
                if (hesap == h.HesapNo)
                {
                    if (h.Bakiye == 0) //Hesapta para yoksa 
                    {
                        this.Hesaplar.Remove(h);
                        MessageBox.Show("'" + hesap + "' numaralı hesap başarıyla silindi.");
                        break;
                    }
                    else
                        MessageBox.Show("'" + hesap + "' numaralı hesap silinebilmesi için bakiyesi 0 TL olmalıdır. \n Mevcut Bakiye: '" + h.Bakiye);
                }

                else
                {
                    MessageBox.Show("'" + hesap + "' numaralı hesap mevcut değil.");
                }
            }

        }

        public List<Hesap> HesapListele()
        {
            return this.Hesaplar;
        }

    }
}
