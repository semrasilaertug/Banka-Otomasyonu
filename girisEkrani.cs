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
    public partial class girisEkrani : Form
    {
        public static Personel personel = new Personel();  
        public static Musteri Musteri = new Musteri();
        public static Hesap Hesap = new Hesap();
        
        public girisEkrani()
        {
            InitializeComponent();
        }

        private void personel_btn_Click(object sender, EventArgs e)
        {
            PersonelGiris personel_giris = new PersonelGiris();
            personel_giris.Show();
        }

        private void musteri_btn_Click(object sender, EventArgs e)
        {
            MusteriGiris musteri_giris = new MusteriGiris();
            musteri_giris.Show();
        }
    }
}
