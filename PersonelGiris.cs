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
    public partial class PersonelGiris : Form
    {
        public PersonelGiris()
        {
            InitializeComponent();
        }

        private void personel_giris_btn_Click(object sender, EventArgs e)
        {
            int sayac = 0;

            if (personel_no_textbox.Text == "admin")
            {
                sayac++;
                if (personel_sifre_textbox.Text == "1234")
                {
                    PersonelSecenek personel_secenek = new PersonelSecenek();
                    personel_secenek.Show();
                }
                else
                {
                    MessageBox.Show("Şifrenizi yanlış girdiniz.Lütfen kontrol ediniz.");
                }

            }

            if (sayac == 0)
            {
                MessageBox.Show("Personel Kullanıcı adınızı yanlış girdiniz. Lütfen kontrol ediniz.");
            }

            personel_no_textbox.Clear();
            personel_sifre_textbox.Clear();
        }
    }
}
