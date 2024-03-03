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
    public partial class GelirGiderRaporu : Form
    {
        public GelirGiderRaporu()
        {
            InitializeComponent();
        }

        private void gelir_gider_btn_Click(object sender, EventArgs e)
        {
            decimal yatirilan = 0, cekilen = 0, islemUcreti = 0;

            foreach (Musteri musteri in girisEkrani.personel.MusteriListele())
            {
                foreach (var hesap in musteri.Hesaplar)
                {
                    foreach (var hesapOzeti in hesap.HesapOzeti)
                    {
                        if (hesapOzeti.YapilanIslem == "Para Çekme")
                        {
                            
                            cekilen += Convert.ToDecimal(hesapOzeti.IslemTutari);
                        }
                        else if (hesapOzeti.YapilanIslem == "Para Yatırma")
                        {
                            yatirilan += Convert.ToDecimal(hesapOzeti.IslemTutari);
                        }
                        else if (hesapOzeti.YapilanIslem == "Gelen Havale" || hesapOzeti.YapilanIslem == "Giden Havale")
                        {
                            islemUcreti -= Convert.ToDecimal(hesapOzeti.IslemUcreti);
                        }
                    }
                }
                
            }

            Banka banka = new Banka();
            banka.RaporHazirla( yatirilan,  islemUcreti,  cekilen);


            gelir_gider_dataGridView.ColumnCount = 4;

            gelir_gider_dataGridView.Columns[0].Name = "Toplam Gelir";
            gelir_gider_dataGridView.Columns[1].Name = "İşlem Ücreti Gelirleri";
            gelir_gider_dataGridView.Columns[2].Name = "Toplam Gider";
            gelir_gider_dataGridView.Columns[3].Name = "Toplam Para";

            gelir_gider_dataGridView.Rows.Add(banka.Gelir.ToString(), islemUcreti.ToString(), banka.Gider.ToString(), banka.BankaToplamPara.ToString());
            
        }
    }
}
