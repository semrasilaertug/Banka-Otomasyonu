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
    public partial class MusteriGiris : Form
    {
        public static Musteri Musteri = new Musteri();

        public MusteriGiris()
        {
            InitializeComponent();
        }

        private void musteri_giris_btn_Click(object sender, EventArgs e)
        {
            
            int sayac = 0;

            foreach (var musteri in girisEkrani.personel.MusteriListele())
            {

                if (musteri.MusteriNo == Convert.ToInt32(musteri_no_textbox.Text))
                {
                    sayac++;
                    if (musteri.Sifre == Convert.ToInt32(musteri_sifre_textbox.Text))
                    {
                        MusteriSecenek musteri_secenek = new MusteriSecenek();
                        musteri_secenek.Show();

                    }
                    else
                    {
                        MessageBox.Show("Müşteri şifrenizi yanlış girdiniz.Lütfen kontrol ediniz.");
                    }

                }
               
            }

            if (sayac == 0)
            {
                MessageBox.Show("Müşteri Numaranızı Yanlış Girdiniz.");

            }

            
            musteri_no_textbox.Clear();
            musteri_sifre_textbox.Clear();
        }
    }
}
