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
    public partial class HesapListele : Form
    {
        int MusteriNumarasi;

        public HesapListele()
        {
            InitializeComponent();
        }

        private void hesap_listele_btn_Click(object sender, EventArgs e)
        {

            dgrid_hesapListele.ColumnCount = 6;

            dgrid_hesapListele.Columns[0].Name = "Hesap Numarası";
            dgrid_hesapListele.Columns[1].Name = "Müşteri Numarası"; 
            dgrid_hesapListele.Columns[2].Name = "Müşteri Adı"; 
            dgrid_hesapListele.Columns[3].Name = "Müşteri Soyadı";
            dgrid_hesapListele.Columns[4].Name = "Bakiye";
            dgrid_hesapListele.Columns[5].Name = "Açılış Tarihi";


            foreach (Musteri musteri in girisEkrani.personel.MusteriListele())
            {
                foreach (var hesap in musteri.Hesaplar)
                {
                    dgrid_hesapListele.Rows.Add(hesap.HesapNo, musteri.MusteriNo,
                                                musteri.kimlikBilgisi.Ad, musteri.kimlikBilgisi.Soyad,
                                                hesap.Bakiye, hesap.AcilisTarihi);
                }
            }


        }
    }
}
