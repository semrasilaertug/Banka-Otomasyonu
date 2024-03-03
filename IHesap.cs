using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne1._1
{
    public interface IHesap
    {
        string ParaYatir(decimal yatirilanMiktar);

        string ParaCek(decimal cekilenMiktar);

        void Havale(decimal havaleMiktari, int gonderenHesapNo, int gonderilecekHesapNo);

        void HesapOzetiGoruntule(HesapOzeti hesap);
    }
}
