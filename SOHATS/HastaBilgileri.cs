using SOHATS.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOHATS
{
    public partial class HastaBilgileri : Form
    {
        public HastaBilgileri()
        {
            InitializeComponent();
            dogumTarihi.MaxDate = DateTime.Today;
        }

        int dosyaNumarasi;

        public HastaBilgileri(AnaForm anaForm, FormControl formControl, int dosyaNumarasi)
        {
            InitializeComponent();
            this.anaForm = anaForm;
            this.formControl = formControl;
            this.dosyaNumarasi = dosyaNumarasi;
            txtDosyaNo.Enabled = false;
            txtTC.Enabled = false;
            plNew.Visible = false;
            plHastaBilgi.Visible = true;
            dogumTarihi.MaxDate = DateTime.Today;
            bilgileriGetir();
        }

        private void bilgileriGetir()
        {
            hasta hasta = databaseControl.GetHasta(dosyaNumarasi.ToString());
            txtTC.Text = hasta.tckimlikno;
            txtAd.Text = hasta.ad;
            txtSoyad.Text = hasta.soyad;
            txtDogumYeri.Text = hasta.dogumyeri;
            dogumTarihi.Value = Convert.ToDateTime(hasta.dogumtarihi);
            txtBabaAdi.Text = hasta.babaadi;
            txtAnneAdi.Text = hasta.anneadi;
            cinsiyet.Text = hasta.cinsiyet;
            kanGrubu.Text = hasta.kangrubu;
            medeniHal.Text = hasta.medenihal;
            txtAdres.Text = hasta.adres;
            txtTelefonNo.Text = hasta.tel;
            txtKurumSicilNo.Text = hasta.kurumsicilno;
            txtKurumSicilAdi.Text = hasta.kurumadi;
            txtYakinTelefonNo.Text = hasta.yakintel;
            txtYakinKurumSicilNo.Text = hasta.yakinkurumsicilno;
            txtYakinKurumAdi.Text = hasta.yakinkurumadi;
        }

        public HastaBilgileri(AnaForm anaForm, FormControl formControl,int dosyaNumarasi,string kayit)
        {
            InitializeComponent();
            this.anaForm = anaForm;
            this.formControl = formControl;
            this.dosyaNumarasi = dosyaNumarasi;
            txtDosyaNo.Enabled = false;
            plNew.Visible = true;
            plHastaBilgi.Visible = false;
            dogumTarihi.MaxDate = DateTime.Today;
        }
        AnaForm anaForm;
        FormControl formControl;

        DatabaseControl databaseControl = new DatabaseControl();

        private void HastaBilgileri_Load(object sender, EventArgs e)
        {
            txtDosyaNo.Text = dosyaNumarasi.ToString();
            dogumTarihi.Value = DateTime.Today;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(kontrol() != "")
            {
                MessageBox.Show(kontrol());
                return;
            }
            hasta hasta = new hasta
            {
                tckimlikno = txtTC.Text,
                dosyano = int.Parse(txtDosyaNo.Text),
                ad = txtAd.Text,
                soyad = txtSoyad.Text,
                dogumyeri = txtDogumYeri.Text,
                dogumtarihi = Convert.ToDateTime(dogumTarihi.Value),
                babaadi = txtBabaAdi.Text,
                anneadi = txtAnneAdi.Text,
                cinsiyet = cinsiyet.Text,
                kangrubu = kanGrubu.Text,
                medenihal = medeniHal.Text,
                adres = txtAdres.Text,

                tel = txtTelefonNo.Text,
                kurumsicilno = txtKurumSicilNo.Text,
                kurumadi = txtKurumSicilAdi.Text,
                yakintel = txtYakinTelefonNo.Text,
                yakinkurumsicilno = txtYakinKurumSicilNo.Text,
                yakinkurumadi = txtYakinKurumAdi.Text
            };
            bool durum = databaseControl.addHasta(hasta);
            if (durum)
            {
                txtIslem.Text = "< İŞLEM TAMAMLANDI >";
            }
            else
            {
                MessageBox.Show("Bu TC numarası kayıtlıdır");
            }
        }
        

        private string kontrol()
        {
            StringBuilder uyari = new StringBuilder();
            if (txtTC.Text == "")
            {
                uyari.Append("Lütfen TC giriniz\n");
            }
            if(txtAd.Text == "")
            {
                uyari.Append("Lütfen Ad giriniz\n");
            }
            if (txtSoyad.Text == "")
            {
                uyari.Append("Lütfen Soyad giriniz\n");
            }
            if (txtDogumYeri.Text == "")
            {
                uyari.Append("Lütfen Doğum Yeri giriniz\n");
            }
            if (dogumTarihi.Text == "")
            {
                uyari.Append("Lütfen Doğum Tarihi Ad giriniz\n");
            }
            if (txtBabaAdi.Text == "")
            {
                uyari.Append("Lütfen Baba Ad giriniz\n");
            }
            if (txtAnneAdi.Text == "")
            {
                uyari.Append("Lütfen Anne Adı giriniz\n");
            }
            if (cinsiyet.Text == "")
            {
                uyari.Append("Lütfen Cinsiyet giriniz\n");
            }
            if (kanGrubu.Text == "")
            {
                uyari.Append("Lütfen Kan grubu giriniz\n");
            }
            if (medeniHal.Text == "")
            {
                uyari.Append("Lütfen Medeni Hal giriniz\n");
            }
            if (txtAdres.Text == "")
            {
                uyari.Append("Lütfen Adres giriniz\n");
            }

            return uyari.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            databaseControl.DeleteHasta(new hasta{ dosyano = int.Parse(txtDosyaNo.Text),tckimlikno = txtTC.Text });
            MessageBox.Show("Hasta Silindi");
            this.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewKayit_Click(object sender, EventArgs e)
        {
            HastaBilgileri hastaBilgileri = new HastaBilgileri(anaForm, formControl, databaseControl.GetYeniDosyaNumarasi(), "new");
            hastaBilgileri.MdiParent = anaForm;
            hastaBilgileri.Visible = true;
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            sadeceRakamGirisi(e);
        }

        private void sadeceRakamGirisi(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTelefonNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            sadeceRakamGirisi(e);
        }

        private void txtYakinTelefonNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            sadeceRakamGirisi(e);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (kontrol() != "")
            {
                MessageBox.Show(kontrol());
                return;
            }
            hasta hasta = new hasta
            {
                tckimlikno = txtTC.Text,
                dosyano = int.Parse(txtDosyaNo.Text),
                ad = txtAd.Text,
                soyad = txtSoyad.Text,
                dogumyeri = txtDogumYeri.Text,
                dogumtarihi = Convert.ToDateTime(dogumTarihi.Value),
                babaadi = txtBabaAdi.Text,
                anneadi = txtAnneAdi.Text,
                cinsiyet = cinsiyet.Text,
                kangrubu = kanGrubu.Text,
                medenihal = medeniHal.Text,
                adres = txtAdres.Text,

                tel = txtTelefonNo.Text,
                kurumsicilno = txtKurumSicilNo.Text,
                kurumadi = txtKurumSicilAdi.Text,
                yakintel = txtYakinTelefonNo.Text,
                yakinkurumsicilno = txtYakinKurumSicilNo.Text,
                yakinkurumadi = txtYakinKurumAdi.Text
            };
            databaseControl.UpdateHasta(hasta);
            txtIslemGuncelleme.Text = "< İŞLEM TAMAMLANDI >";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Close();
            HastaBilgileri hastaBilgileri = new HastaBilgileri(anaForm, formControl, databaseControl.GetYeniDosyaNumarasi(), "new");
            hastaBilgileri.MdiParent = anaForm;
            hastaBilgileri.Visible = true;
        }
    }
}
