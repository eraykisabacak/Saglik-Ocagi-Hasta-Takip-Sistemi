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
        public static SqlConnection _connection;
        public static SqlCommand _command;
        public static SqlDataReader _reader;

        public DatabaseControl()
        {
            _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb; Initial Catalog=SOHATS;Integrated Security=true");
            _command = new SqlCommand();
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public bool kullaniciGirisi(string kullaniciAdi, string sifre)
        {
            ConnectionControl();

            bool durum = false;
            _command.Connection = _connection;
            _command.CommandText = "SELECT * FROM kullanici where username='" + kullaniciAdi + "' AND sifre='" + sifre + "'";
            _reader = _command.ExecuteReader();
            if (_reader.Read())
                durum = true;
            return durum;
        }

        public sevk GetSevk(string dosyaNo)
        {
            using (SOHATSEntities2 context = new SOHATSEntities2())
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

        public List<cikis> GetOncekiİslemler(string dosyaNo)
        {
            using (SOHATSEntities2 context = new SOHATSEntities2())
            {
                return context.cikis.Where(p => p.dosyano == dosyaNo).ToList();
            }
        }

        public hasta GetHasta(string dosyaNo)
        {
            using (SOHATSEntities2 context = new SOHATSEntities2())
            {
                return context.hasta.Where(p => p.dosyano == dosyaNo).First();
            }
        }

        public kullanici GetKullanici(string kullaniciKodu)
        {
            using (SOHATSEntities2 context = new SOHATSEntities2())
            {
                return context.kullanici.Where(p => p.username == kullaniciKodu).First();         
            }
        }

        public List<sevk> GetYapilanTahlilİslemler(string dosyaNo,string tarih)
        {
            using (SOHATSEntities2 context = new SOHATSEntities2())
            {
                return context.sevk.Where(p => p.dosyano == dosyaNo && p.sevktarihi == tarih).ToList();
            }
        }

        public List<string> GetUnvan()
        {
            using (SOHATSEntities2 context = new SOHATSEntities2())
            {
                return context.kullanici.Select(x => x.unvan).Distinct().ToList();
            }
        }

        public List<kullanici> GetKullanici()
        {
            using (SOHATSEntities2 context = new SOHATSEntities2())
            {
                var kullanicis = context.kullanici.ToList();
                return kullanicis;
            }
        }

        public void DeleteKullanici(kullanici kullanici1)
        {
            using (SOHATSEntities2 context = new SOHATSEntities2())
            {
                var entity = context.Entry(kullanici1);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void UpdateKullanici(kullanici kullanici1)
        {
            using (SOHATSEntities2 context = new SOHATSEntities2())
            {
                var entity = context.Entry(kullanici1);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void AddKullanici(kullanici kullanici1)
        {
            using (SOHATSEntities2 context = new SOHATSEntities2())
            {
                var entity = context.Entry(kullanici1);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<poliklinik> GetPoliklinik()
        {
            using (SOHATSEntities2 context = new SOHATSEntities2())
            {
                var poliks = context.poliklinik.ToList();
                return poliks;
            }
            
        }

        public poliklinik GetPoliklinik(string poliklinikAdi)
        {
            using (SOHATSEntities2 context = new SOHATSEntities2())
            {
                return context.poliklinik.Where(p => p.poliklinikadi == poliklinikAdi).First();
            }
        }

        public void UpdatePoliklinik(poliklinik polik)
        {
            using (SOHATSEntities2 context = new SOHATSEntities2())
            {
                var entity = context.Entry(polik);
                entity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }

        public void DeletePoliklinik(poliklinik polik)
        {
            using(SOHATSEntities2 context = new SOHATSEntities2())
            {
                var entity = context.Entry(polik);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public kullanici DoktorAdi(int Kodu)
        {
            using (SOHATSEntities2 context = new SOHATSEntities2())
            {
                return context.kullanici.Where(p => p.kodu == Kodu).First();
            }
        }

        public int GetYeniDosyaNumarasi()
        {
            using (SOHATSEntities2 context = new SOHATSEntities2())
            {
                var hastalar = context.hasta.Max(p => p.dosyano);
                return Convert.ToInt16(hastalar) + 1;
            }
        }

        public void addHasta(hasta hasta)
        {
            using (SOHATSEntities2 context = new SOHATSEntities2())
            {
                var entity = context.Entry(hasta);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

    }
}
