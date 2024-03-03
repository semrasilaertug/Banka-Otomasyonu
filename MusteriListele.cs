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
    public partial class MusteriListele : Form
    {
        public MusteriListele()
        {
            InitializeComponent();
        }
        
        private void musteri_listele_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 11;

            dataGridView1.Columns[0].Name = "Müşteri Çeşidi";
            dataGridView1.Columns[1].Name = "Müşteri No";
            dataGridView1.Columns[2].Name = "Şifre";
            dataGridView1.Columns[3].Name = "Ad";
            dataGridView1.Columns[4].Name = "Soyad";
            dataGridView1.Columns[5].Name = "TC Kimlik No";
            dataGridView1.Columns[6].Name = "Doğum Tarihi";
            dataGridView1.Columns[7].Name = "Doğum Yeri";
            dataGridView1.Columns[8].Name = "Telefon";
            dataGridView1.Columns[9].Name = "Email";
            dataGridView1.Columns[10].Name = "Adres";

            foreach (Musteri musteri in girisEkrani.personel.MusteriListele())
            {
                if(musteri.MusteriTuru == true)
                {
                    dataGridView1.Rows.Add("Bireysel Müşteri" , musteri.MusteriNo, musteri.Sifre, musteri.kimlikBilgisi.Ad, musteri.kimlikBilgisi.Soyad,
                    musteri.kimlikBilgisi.TcKimlikNo, musteri.kimlikBilgisi.DogumTarihi, musteri.kimlikBilgisi.DogumYeri,
                    musteri.Telefon, musteri.Email, musteri.Adres);
                }
                else if (musteri.MusteriTuru == false)
                {
                    dataGridView1.Rows.Add("Ticari Müşteri" , musteri.MusteriNo, musteri.Sifre, musteri.kimlikBilgisi.Ad, musteri.kimlikBilgisi.Soyad,
                    musteri.kimlikBilgisi.TcKimlikNo, musteri.kimlikBilgisi.DogumTarihi, musteri.kimlikBilgisi.DogumYeri,
                    musteri.Telefon, musteri.Email, musteri.Adres);
                }
               
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
