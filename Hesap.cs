using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesne1._1
{
    public class Hesap: IHesap
    {
        public int HesapNo { get; set; }

        public decimal Bakiye { get; set; }
        public DateTime AcilisTarihi { get; set; }

        public List<HesapOzeti> HesapOzeti { get; set; }

        public Hesap()
        {
            AcilisTarihi = DateTime.Now;
            HesapOzeti = new List<HesapOzeti>();
        }

        public string ParaCek(decimal cekilenMiktar)
        {

            if (cekilenMiktar > Bakiye)
            {

                return "Bakiyeniz yeterli değil.\nPara çekme işlemini ek hesabınızdan yapınız.";
            }
            else if (cekilenMiktar > 750)
            {
                return "750₺ den fazla çekemezsiniz.";
            }
            else
            {

                this.Bakiye -= cekilenMiktar;

                return "Para çekme işleminiz başarıyla gerçekleştirildi";

            }
        }

        public string ParaYatir(decimal yatirilanMiktar)
        {

            this.Bakiye += yatirilanMiktar;

            return "Para Yatırma İşleminiz başarıyla gerçekleştirildi.\n" + yatirilanMiktar + " TL hesabınıza eklendi.";
        }

        public void Havale(decimal havaleMiktari, int gonderenHesapNo, int gonderilecekHesapNo)
        {
            MessageBox.Show(gonderenHesapNo + " numaralı hesaptan " + gonderilecekHesapNo + " numaralı hesaba " +
                havaleMiktari + " TL havale gerçekleştirildi.");
            
        }

        public void HesapOzetiGoruntule(HesapOzeti hesap)
        {
            HesapOzeti.Add(hesap);
        }

    }
}
