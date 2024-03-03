using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesne1._1
{
    
    public class Personel
    {
        public string PersonelAdi { get; set; }

        public int Sifre { get; set; }

        public List<Musteri> MusteriListesi { get; set; }

        //public List<Hesap> HesapListesi { get; set; }


        public Personel()
        {
            MusteriListesi = new List<Musteri>();
        }

        public void MusteriEkle(Musteri musteri)
        {
            if (MusteriListesi.Count == 0)
            {
                Random r = new Random();
                musteri.MusteriNo = r.Next(1, 1000);
                Random r1 = new Random();
                musteri.Sifre = r1.Next(1000, 9999);
            }
            else
            {
                foreach (var musteri1 in MusteriListesi)
                {
                    Random r = new Random();
                    int musteri_no = r.Next(10, 99);
                    Random r1 = new Random();
                    int sifre = r1.Next(1000, 9999);
                    if (musteri_no != musteri1.MusteriNo)
                    {

                        musteri.MusteriNo = musteri_no;

                    }
                    if (sifre != musteri1.Sifre)
                    {

                        musteri.Sifre = sifre;

                    }
                }
            }
            MusteriListesi.Add(musteri);
        }

        public void MusteriSil(Musteri musteri)
        {
            MusteriListesi.Remove(musteri);
        }

        public List<Musteri> MusteriListele()
        {
            return MusteriListesi;
        }
    }
}
