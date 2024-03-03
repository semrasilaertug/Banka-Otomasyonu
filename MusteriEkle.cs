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
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            string Ad, Soyad, DogumYeri, Adres, Email;
            ulong Telefon = 0, TcKimlikNo = 0;
            DateTime DogumTarihi;
            Boolean MusteriTuru;
            Ad = musteriAd_txtbox.Text;
            Soyad = musteriSoyad_txtbox.Text;
            DogumYeri = dogumYeri_txtbox.Text;
            Adres = adres_txtbox.Text;
            Email = eMail_txtbox.Text;
            if (bireysel_checkBox.Checked)
            {
                MusteriTuru = true;
            }
            else
            {
                MusteriTuru = false;
            }
            if ((tckimlikNo_txtbox.Text != "" && tckimlikNo_txtbox.Text != "Tc Kimlik Numarası") && (telefonNo_textbox.Text != "" && telefonNo_textbox.Text != "Telefon"))
            {
                Telefon = Convert.ToUInt64(telefonNo_textbox.Text);
                TcKimlikNo = Convert.ToUInt64(tckimlikNo_txtbox.Text);
            }
            DogumTarihi = Convert.ToDateTime(dogumTarihi_datetime.Value);

            if (Ad == "Ad" || Ad == "" || Soyad == "Soyad" || Soyad == "" || DogumYeri == "Doğum Yeri" || DogumYeri == "" || Adres == "Adres" || Adres == "" || Email == "Email" || Email == "" || tckimlikNo_txtbox.Text == "Tc Kimlik Numarası" || tckimlikNo_txtbox.Text == "" || DogumTarihi == null)
            {

                MessageBox.Show("Lütfen boş alan bırakmayınız..");
            }
            else
            {
                if (MusteriTuru == true)
                {
                    BireyselMusteri musteri = new BireyselMusteri();
                    musteri.kimlikBilgisi.Ad = Ad;
                    musteri.kimlikBilgisi.Soyad = Soyad;
                    musteri.kimlikBilgisi.DogumTarihi = DogumTarihi;
                    musteri.kimlikBilgisi.DogumYeri = DogumYeri;

                    musteri.kimlikBilgisi.TcKimlikNo = TcKimlikNo;

                    musteri.Adres = Adres;

                    musteri.Email = Email;

                    musteri.Telefon = Telefon;

                    girisEkrani.personel.MusteriEkle(musteri);


                    MessageBox.Show(musteri.kimlikBilgisi.Ad + " " + musteri.kimlikBilgisi.Soyad + " kişisi eklendi.");

                    MessageBox.Show("Musteri Numarası : " + musteri.MusteriNo + "\nMusterinin Sifresi : " + musteri.Sifre);


                }
                else
                {

                    TicariMusteri musteri = new TicariMusteri();
                    musteri.kimlikBilgisi.Ad = Ad;
                    musteri.kimlikBilgisi.Soyad = Soyad;
                    musteri.kimlikBilgisi.DogumTarihi = DogumTarihi;
                    musteri.kimlikBilgisi.DogumYeri = DogumYeri;

                    musteri.kimlikBilgisi.TcKimlikNo = TcKimlikNo;

                    musteri.Adres = Adres;

                    musteri.Email = Email;

                    musteri.Telefon = Telefon;

                    girisEkrani.personel.MusteriEkle(musteri);

                    MessageBox.Show(musteri.kimlikBilgisi.Ad + " " + musteri.kimlikBilgisi.Soyad + " kişisi eklendi." );

                    MessageBox.Show("Musteri Numarası : " + musteri.MusteriNo + "\nMusterinin Sifresi : " + musteri.Sifre);

                }
            }

            musteriAd_txtbox.Clear();
            musteriSoyad_txtbox.Clear();
            tckimlikNo_txtbox.Clear();
            dogumYeri_txtbox.Clear();
            eMail_txtbox.Clear();
            adres_txtbox.Clear();
            telefonNo_textbox.Clear();
            ticari_checkBox.Checked = false;
            bireysel_checkBox.Checked = false; 
        }
    }
}
   

