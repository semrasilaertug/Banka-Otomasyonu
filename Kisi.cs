using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesne1._1
{
    public abstract class Kisi
    {
        public KimlikBilgisi kimlikBilgisi { get; set; }    

        public string Adres { get; set; }

        public string Email { get; set; }

        public ulong Telefon { get; set; }

        public Kisi()
        {
            kimlikBilgisi = new KimlikBilgisi();
        }
    }
}
