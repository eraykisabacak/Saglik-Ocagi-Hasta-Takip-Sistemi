using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOHATS.DB;
namespace SOHATS
{
    class DatabaseControl
    {
        public DatabaseControl()
        {

        }

        public List<bool> kullaniciGirisi(string kullaniciAdi, string sifre)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                kullanici kullanici;
                try
                {
                    kullanici = context.kullanici.Where(p => p.username == kullaniciAdi && p.sifre == sifre).First();
                }
                catch (System.InvalidOperationException)
                {
                    return new List<bool> { false, false };
                }
                if(Convert.ToBoolean(kullanici.yetki))
                {
                    return new List<bool> { true, true };
                }
                else
                {
                    return new List<bool> { true, false };
                }
            }
        }

        public sevk GetSevk(string dosyaNo)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                try{
                    return context.sevk.Where(p => p.dosyano == dosyaNo).First();
                }
                catch (System.InvalidOperationException)
                {
                    return new sevk { dosyano = null };

                }
            }
        }

        public List<DateTime> GetOncekiİslemler(string dosyaNo)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                var sorgu = context.sevk.Where(p => p.dosyano == dosyaNo).Distinct().ToList();
                var sorgu2 = sorgu.Select(p => p.sevktarihi).Distinct().ToList();
                
                return sorgu2;
            }
        }

        public hasta GetHasta(string dosyaNo)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                return context.hasta.Where(p => p.dosyano == dosyaNo).First();
            }
        }

        public kullanici GetKullanici(string kullaniciKodu)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                return context.kullanici.Where(p => p.username == kullaniciKodu).First();         
            }
        }

        public int GetKullaniciKodu()
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                return context.kullanici.Max(p => p.kodu);
            }
        }

        public List<kullanici> GetKullanici(bool doktor)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                return context.kullanici.Where(p => p.unvan.ToUpper() == "DOKTOR").ToList();
            }
        }

        public List<islem> GetIslem()
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                return context.islem.ToList();
            }
        }

        public islem GetFiyat(string islem)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                return context.islem.Where(p => p.islemAdi == islem).First();
            }
        }

        public sevk Sira(string poliklinik)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                List<sevk> sevkler = context.sevk.Where(p => p.poliklinik == poliklinik).ToList();
                sevk sevk = new sevk();
                foreach(sevk sevki in sevkler)
                {
                    sevk.sira = sevki.sira;
                }
                return sevk;
            }
        }

        public void AddSevk(sevk sevk)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                var entity = context.Entry(sevk);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<sevk> GetYapilanTahlilİslemler(string dosyaNo,DateTime tarih)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                DateTime dt = Convert.ToDateTime(tarih);
                return context.sevk.Where(p => p.dosyano == dosyaNo && p.sevktarihi == tarih).ToList();
            }
        }

        public List<string> GetUnvan()
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                return context.kullanici.Select(x => x.unvan).Distinct().ToList();
            }
        }

        public List<kullanici> GetKullanici()
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                var kullanicis = context.kullanici.ToList();
                return kullanicis;
            }
        }

        public void DeleteKullanici(kullanici kullanici1)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                var entity = context.Entry(kullanici1);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void UpdateKullanici(kullanici kullanici1)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                var entity = context.Entry(kullanici1);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void AddKullanici(kullanici kullanici1)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                var entity = context.Entry(kullanici1);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<poliklinik> GetPoliklinik()
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                var poliks = context.poliklinik.ToList();
                return poliks;
            }
        }

        public List<poliklinik> GetPoliklinik(bool deger)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                return context.poliklinik.Where(p => p.durum.Equals("true")).ToList();
            }
        }

        public poliklinik GetPoliklinik(string poliklinikAdi)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                try
                {
                    return context.poliklinik.Where(p => p.poliklinikadi == poliklinikAdi).First();
                }
                catch (InvalidOperationException)
                {
                    return new poliklinik { poliklinikadi = null };
                }
            }
        }

        public void AddPoliklinik(poliklinik poliklinik)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                var entity = context.Entry(poliklinik);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void UpdatePoliklinik(poliklinik polik)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                var entity = context.Entry(polik);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        internal void DeleteHasta(hasta hasta)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                var entity = context.Entry(hasta);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void DeletePoliklinik(poliklinik polik)
        {
            using(SOHATSEntities3 context = new SOHATSEntities3())
            {
                var entity = context.Entry(polik);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public kullanici DoktorAdi(int Kodu)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                return context.kullanici.Where(p => p.kodu == Kodu).First();
            }
        }

        public int GetYeniDosyaNumarasi()
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                var hastalar = context.hasta.Max(p => p.dosyano);
                return Convert.ToInt16(hastalar) + 1;
            }
        }

        public void addHasta(hasta hasta)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                var entity = context.Entry(hasta);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void UpdateHasta(hasta hasta)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                var entity = context.Entry(hasta);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        internal void DeleteIslem(sevk sevk)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                var entity = context.Entry(sevk);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public hasta GetHastaKimlikNo(string kimlikNo)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                try
                {
                    return context.hasta.Where(p => p.tckimlikno == kimlikNo).First();
                }
                catch (System.InvalidOperationException)
                {
                    return new hasta { tckimlikno = "0" };
                }
            }
        }

        public hasta GetHastaKurumSicilNo(string kurumSicilNo)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                try
                {
                    return context.hasta.Where(p => p.kurumsicilno == kurumSicilNo).First();
                }
                catch (System.InvalidOperationException)
                {
                    return new hasta { tckimlikno = "0" };
                }
            }
        }

        public hasta GetHastaDosyaNo(string dosyaNo)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                try
                {
                    return context.hasta.Where(p => p.dosyano == dosyaNo).First();
                }
                catch (System.InvalidOperationException)
                {
                    return new hasta { tckimlikno = "0" };
                }
            }
        }

        public List<hasta> GetHastaAdSoyad(string ad,string soyad,bool durum)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                try
                {
                    if (durum)
                    {
                        return context.hasta.Where(p => p.ad == ad && p.soyad == soyad).ToList();
                    }
                    else
                    {
                        return context.hasta.Where(p => p.ad == ad || p.soyad == soyad).ToList();
                    }
                }
                catch (System.InvalidOperationException)
                {
                    List<hasta> hastas = new List<hasta>();
                    return hastas;
                }
            }
        }

        public void AddCikis(cikis cikis)
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                var entity = context.Entry(cikis);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public int GetCikisId()
        {
            using (SOHATSEntities3 context = new SOHATSEntities3())
            {
                return (context.cikis.Select(p => p.id).Max()) + 1;
            }
        }
    }
}
