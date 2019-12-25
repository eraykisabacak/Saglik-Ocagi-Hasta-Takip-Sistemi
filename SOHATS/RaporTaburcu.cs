using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOHATS
{
    class RaporTaburcu
    {
        string dosyano;
        string ad;
        string soyad;
        DateTime sevktarihi;
        string poliklinik;
        string doktoradi;
        string doktorsoyad;

        public RaporTaburcu() { }

        public RaporTaburcu(string dosyano, string ad, string soyad, DateTime sevktarihi, string poliklinik, string doktoradi, string doktorsoyad)
        {
            this.Dosyano = dosyano;
            this.Ad = ad;
            this.Soyad = soyad;
            this.Sevktarihi = sevktarihi;
            this.Poliklinik = poliklinik;
            this.Doktoradi = doktoradi;
            this.Doktorsoyad = doktorsoyad;
        }

        public string Dosyano { get => dosyano; set => dosyano = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public DateTime Sevktarihi { get => sevktarihi; set => sevktarihi = value; }
        public string Poliklinik { get => poliklinik; set => poliklinik = value; }
        public string Doktoradi { get => doktoradi; set => doktoradi = value; }
        public string Doktorsoyad { get => doktorsoyad; set => doktorsoyad = value; }
    }
}
