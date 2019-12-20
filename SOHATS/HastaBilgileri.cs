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
                dosyano = txtDosyaNo.Text,
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
            databaseControl.addHasta(hasta);
            txtIslem.Text = "< İŞLEM TAMAMLANDI >";
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
    }
}
