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
    public partial class Havale : Form
    {
        public Havale()
        {
            InitializeComponent();
        }

        private void havale_btn_Click(object sender, EventArgs e)
        {
            
            decimal Miktar;
            
            int gonderenHesapNo = Convert.ToInt32(txtBox_gonderenHesapNo.Text);
            int gonderilecekHesapNo = Convert.ToInt32(gonderilenHesap_textBox.Text);

            if (gonderenHesapNo == gonderilecekHesapNo)
            {
                MessageBox.Show("Aynı hesaba havale yapamazsınız.");
            }
            else
            {
                Miktar = Convert.ToDecimal(mtxtBox_havaleMiktari.Text);
                
                foreach (Musteri musteri2 in girisEkrani.personel.MusteriListele())
                {
                    foreach (var hesap2 in musteri2.Hesaplar) 
                    {
                        if (hesap2.HesapNo == gonderilecekHesapNo)
                        {
                            hesap2.Bakiye += Miktar;
                            //MessageBox.Show(gonderilecekHesapNo + " hesabına Havale işlemi başarıyla gerçekleşti.");
                           
                            HesapOzeti hesapOzeti_gonderilen = new HesapOzeti();
                            hesapOzeti_gonderilen.Bakiye = hesap2.Bakiye;
                            hesapOzeti_gonderilen.IslemTutari = Miktar;
                            hesapOzeti_gonderilen.IslemTarihi = DateTime.Now;
                            hesapOzeti_gonderilen.YapilanIslem = "Gelen Havale";
                            hesap2.HesapOzetiGoruntule(hesapOzeti_gonderilen);


                            foreach (Musteri musteri1 in girisEkrani.personel.MusteriListele())
                            {
                                foreach (var hesap1 in musteri1.Hesaplar)
                                {
                                    if (hesap1.HesapNo == gonderenHesapNo)
                                    {
                                        if (musteri1.MusteriTuru.ToString() == "False")
                                        {
                                            hesap1.Havale(Miktar, gonderenHesapNo, gonderilecekHesapNo);
                                            hesap1.Bakiye -= Miktar;
                                            guncel_bakiye_textBox.Text = hesap1.Bakiye.ToString();
                                            //MessageBox.Show(gonderenHesapNo + " hesabından Havale işlemi başarıyla gerçekleşti.");

                                            HesapOzeti hesapOzeti_gonderen = new HesapOzeti();
                                            hesapOzeti_gonderen.IslemTarihi = DateTime.Now;
                                            hesapOzeti_gonderen.YapilanIslem = "Giden Havale";
                                            hesapOzeti_gonderen.IslemTutari = -Miktar;
                                            hesapOzeti_gonderen.Bakiye = hesap1.Bakiye;
                                            hesapOzeti_gonderen.IslemUcreti = 0;
                                            hesap1.HesapOzetiGoruntule(hesapOzeti_gonderen);

                                            break;
                                        }
                                        else
                                        {
                                            hesap1.Havale(Miktar, gonderenHesapNo, gonderilecekHesapNo);
                                            hesap1.Bakiye -= Miktar + (Miktar * 2 / 100);

                                            guncel_bakiye_textBox.Text = hesap1.Bakiye.ToString();
                                            HesapOzeti hesapOzeti_gonderen = new HesapOzeti();
                                            hesapOzeti_gonderen.IslemTarihi = DateTime.Now;
                                            hesapOzeti_gonderen.YapilanIslem = "Giden Havale";
                                            hesapOzeti_gonderen.IslemTutari = -Miktar;
                                            hesapOzeti_gonderen.IslemUcreti -= Miktar * 2 / 100;
                                            hesapOzeti_gonderen.Bakiye = hesap1.Bakiye;
                                            hesap1.HesapOzetiGoruntule(hesapOzeti_gonderen);

                                        }
                                    }

                                }

                            }

                        }
                       
                    }


                }
            }
        }
    }
}
