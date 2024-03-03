using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne1._1
{
    internal class Banka
    {
        public string BankaAdi { get; set; }

        public decimal Gelir { get; set; }              //Yatırılan Paralar ve Havale Ücreti 
        public decimal Gider { get; set; }              //Çekilen Paralar
        public decimal BankaToplamPara { get; set; }    //Bankada bulunan Toplam para
        public decimal islemUcretiToplam { get; set; }

        public void RaporHazirla(decimal yatirilan, decimal islemUcreti , decimal cekilen) 
        {
            Gelir += yatirilan + islemUcreti;
            Gider += cekilen;
            BankaToplamPara += Gelir + Gider;

        }
    }
}
