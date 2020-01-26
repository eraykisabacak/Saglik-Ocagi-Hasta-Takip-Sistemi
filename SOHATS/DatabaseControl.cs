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
            using (SOHATSEntities context = new SOHATSEntities())
            {
                kullanici kullanici;
                try
                {
                    kullanici = context.kullanici.Where(p => p.username == kullaniciAdi && p.sifre == sifre).First();
                }
                catch (System.Data.Entity.Core.EntityException)
                {
                    return new List<bool> { false, false, false };
                }
                catch (System.InvalidOperationException)
                {
                    return new List<bool> { false, false, true };
                }
                
                if(Convert.ToBoolean(kullanici.yetki))
                {
                    return new List<bool> { true, true, true };
                }
                else
                {
                    return new List<bool> { true, false, true };
                }
            }
        }

        public sevk GetSevk(string dosyaNo)
        {
            using (SOHATSEntities context = new SOHATSEntities())
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

        public sevk GetSevkLast(string dosyaNo)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                try
                {
                    return context.sevk.Where(p => p.dosyano == dosyaNo).Max();
                }
                catch (System.InvalidOperationException)
                {
                    return new sevk { dosyano = null };
                }
            }
        }

        public sevk GetSevkId(int id)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                try
                {
                    return context.sevk.Where(p => p.id == id).First();
                }
                catch (System.InvalidOperationException)
                {
                    return new sevk { dosyano = null };

                }
            }
        }

        public List<DateTime> GetOncekiİslemler(string dosyaNo)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                var sorgu = context.sevk.Where(p => p.dosyano == dosyaNo).Distinct().ToList();
                var sorgu2 = sorgu.Select(p => p.sevktarihi).Distinct().ToList();
                
                return sorgu2;
            }
        }

        public hasta GetHasta(string dosyaNo)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                int dosya = Convert.ToInt32(dosyaNo);
                return context.hasta.Where(p => p.dosyano == dosya).First();
            }
        }

        public kullanici GetKullanici(string kullaniciKodu)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                return context.kullanici.Where(p => p.username == kullaniciKodu).First();         
            }
        }

        public int GetKullaniciKodu()
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                return context.kullanici.Max(p => p.kodu);
            }
        }

        public List<kullanici> GetKullanici(bool doktor)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                return context.kullanici.Where(p => p.unvan.ToUpper() == "DOKTOR").ToList();
            }
        }

        public List<islem> GetIslem()
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                return context.islem.ToList();
            }
        }

        public islem GetFiyat(string islem)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                return context.islem.Where(p => p.islemAdi == islem).First();
            }
        }

        public sevk Sira(string poliklinik,DateTime sevkTarihi)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                List<sevk> sevkler = context.sevk.Where(p => p.poliklinik == poliklinik && p.sevktarihi == sevkTarihi).ToList();
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
            using (SOHATSEntities context = new SOHATSEntities())
            {
                var entity = context.Entry(sevk);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<sevk> GetYapilanTahlilİslemler(string dosyaNo,DateTime tarih)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                DateTime dt = Convert.ToDateTime(tarih);
                return context.sevk.Where(p => p.dosyano == dosyaNo && p.sevktarihi == tarih).ToList();
            }
        }

        public List<string> GetUnvan()
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                return context.kullanici.Select(x => x.unvan).Distinct().ToList();
            }
        }

        public List<kullanici> GetKullanici()
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                var kullanicis = context.kullanici.ToList();
                return kullanicis;
            }
        }

        public void DeleteKullanici(kullanici kullanici1)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                var entity = context.Entry(kullanici1);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void UpdateKullanici(kullanici kullanici1)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                var entity = context.Entry(kullanici1);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void UpdateSevk(sevk s, bool durum)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                var entity = context.Entry(s);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void AddKullanici(kullanici kullanici1)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                var entity = context.Entry(kullanici1);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<poliklinik> GetPoliklinik()
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                var poliks = context.poliklinik.ToList();
                return poliks;
            }
        }

        public List<poliklinik> GetPoliklinik(bool deger)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                return context.poliklinik.Where(p => p.durum.Equals("true")).ToList();
            }
        }

        public poliklinik GetPoliklinik(string poliklinikAdi)
        {
            using (SOHATSEntities context = new SOHATSEntities())
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
            using (SOHATSEntities context = new SOHATSEntities())
            {
                var entity = context.Entry(poliklinik);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void UpdatePoliklinik(poliklinik polik)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                var entity = context.Entry(polik);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        internal void DeleteHasta(hasta hasta)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                var entity = context.Entry(hasta);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void DeletePoliklinik(poliklinik polik)
        {
            using(SOHATSEntities context = new SOHATSEntities())
            {
                var entity = context.Entry(polik);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public kullanici DoktorAdi(int Kodu)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                return context.kullanici.Where(p => p.kodu == Kodu).First();
            }
        }

        public int GetYeniDosyaNumarasi()
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                var hastalar = context.hasta.Max(p => p.dosyano);
                return Convert.ToInt16(hastalar) + 1;
            }
        }

        public bool addHasta(hasta hasta)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                try
                {
                    var entity = context.Entry(hasta);
                    entity.State = EntityState.Added;
                    context.SaveChanges();
                    return true;
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException)
                {
                    return false;
                }
            }
        }

        public void UpdateHasta(hasta hasta)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                var entity = context.Entry(hasta);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        internal void DeleteIslem(sevk sevk)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                var entity = context.Entry(sevk);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public hasta GetHastaKimlikNo(string kimlikNo)
        {
            using (SOHATSEntities context = new SOHATSEntities())
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
            using (SOHATSEntities context = new SOHATSEntities())
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
            using (SOHATSEntities context = new SOHATSEntities())
            {
                try
                {
                    return context.hasta.Where(p => p.dosyano == int.Parse(dosyaNo)).First();
                }
                catch (System.InvalidOperationException)
                {
                    return new hasta { tckimlikno = "0" };
                }
            }
        }

        public List<hasta> GetHastaAdSoyad(string ad,string soyad,bool durum)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                try
                {
                    if (durum)
                    {
                        return context.hasta.Where(p => p.ad.Contains(ad) && p.soyad.Contains(soyad)).ToList();
                    }
                    else
                    {
                        return context.hasta.Where(p => p.ad.Contains(ad) || p.soyad.Contains(soyad)).ToList();
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
            using (SOHATSEntities context = new SOHATSEntities())
            {
                var entity = context.Entry(cikis);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public int GetCikisId()
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                return (context.cikis.Select(p => p.id).Max()) + 1;
            }
        }

        public List<RaporTaburcu> GetTaburcu(DateTime baslangic,DateTime bitis)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                List<RaporTaburcu> raporTaburcu = new List<RaporTaburcu>();

                List<sevk> sevks =context.sevk.Where(t => t.sevktarihi > baslangic && 
                                                     t.sevktarihi < bitis)
                                                     .ToList();

                foreach (sevk sevk in sevks)
                {
                    RaporTaburcu hasta = new RaporTaburcu();

                    hasta.Dosyano = sevk.dosyano;
                    hasta.Ad = this.GetHasta(sevk.dosyano).ad;
                    hasta.Soyad = this.GetHasta(sevk.dosyano).soyad;
                    hasta.Sevktarihi = sevk.sevktarihi;
                    hasta.Poliklinik = sevk.poliklinik;
                    hasta.Doktoradi = this.DoktorAdi(int.Parse(sevk.drkod)).ad;
                    hasta.Doktorsoyad = this.DoktorAdi(int.Parse(sevk.drkod)).soyad;
                    raporTaburcu.Add(hasta);
                }
                return raporTaburcu;
            }
        }

        public List<RaporTaburcu> GetTaburcu(bool durum, DateTime baslangic, DateTime bitis)
        {
            using (SOHATSEntities context = new SOHATSEntities())
            {
                List<RaporTaburcu> raporTaburcu = new List<RaporTaburcu>();
                List<sevk> sevks = context.sevk.Where(p => p.sevktarihi > baslangic &&
                                               p.sevktarihi < bitis &&
                                               p.taburcu == durum.ToString())
                                               .ToList();
                foreach (sevk sevk in sevks)
                {
                    RaporTaburcu hasta = new RaporTaburcu();

                    hasta.Dosyano = sevk.dosyano;
                    hasta.Ad = this.GetHasta(sevk.dosyano).ad;
                    hasta.Soyad = this.GetHasta(sevk.dosyano).soyad;
                    hasta.Sevktarihi = sevk.sevktarihi;
                    hasta.Poliklinik = sevk.poliklinik;
                    hasta.Doktoradi = this.DoktorAdi(int.Parse(sevk.drkod)).ad;
                    hasta.Doktorsoyad = this.DoktorAdi(int.Parse(sevk.drkod)).soyad;
                    raporTaburcu.Add(hasta);
                }
                return raporTaburcu;
            }
        }
    }
}
