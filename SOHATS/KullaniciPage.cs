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
    public partial class KullaniciPage : Form
    {  
        public KullaniciPage(kullanici kullanicis)
        {
            InitializeComponent();
            kullanici = kullanicis;

            dtpİseBaslama.MaxDate = DateTime.Today.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute);
            dtpDogumTarihi.MaxDate = DateTime.Today.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute);
            
        }

        public KullaniciPage()
        {
            InitializeComponent();

            dtpİseBaslama.MaxDate = DateTime.Today;
            dtpDogumTarihi.MaxDate = DateTime.Today;
            txtKullaniciKodu.Enabled = false;

        }

        DatabaseControl databaseControl = new DatabaseControl();
        kullanici kullanici;

        private void KullaniciPage_Load(object sender, EventArgs e)
        {
            List<string> unvanlar = databaseControl.GetUnvan();
            foreach (string unvan in unvanlar)
            {
                if (unvan != null && unvan != System.String.Empty)
                    cbUnvan.Items.Add(unvan);
            }

            int kullaniciKodu = databaseControl.GetKullaniciKodu();

            txtKullaniciKodu.Text = (kullaniciKodu + 1).ToString();

            if (kullanici == null)
            {
                return;
            }
            
            txtKullaniciKodu.Text = kullanici.kodu.ToString();
            
            txtTC.Text = kullanici.tckimlikno;
            txtDogumYeri.Text = kullanici.dogumyeri; 
            txtBabaAdi.Text = kullanici.babaad;
            txtAnneAdi.Text = kullanici.annead;
            txtGSM.Text = kullanici.ceptel;
            txtTelefonNo.Text = kullanici.evtel;
            if (Convert.ToBoolean(kullanici.yetki) == true)
                cbYetkili.Checked = true;
            txtAdres.Text = kullanici.adres;
            txtKullaniciAdi.Text = kullanici.username;
            txtSifre.Text = kullanici.sifre;

            txtAd.Text = kullanici.ad;
            txtSoyad.Text = kullanici.soyad;
            txtMaas.Text = kullanici.maas;
            dtpİseBaslama.Text = kullanici.isebaslama.ToString();
            dtpDogumTarihi.Text = kullanici.dogumtarihi.ToString();
            cbUnvan.Text = kullanici.unvan;
            cbCinsiyet.Text = kullanici.cinsiyet;
            cbMedeniHali.Text = kullanici.medenihal;
            cbKanGrubu.Text = kullanici.kangrubu;
            

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtTC.Text = "";
            txtDogumYeri.Text = "";
            txtBabaAdi.Text = "";
            txtAnneAdi.Text = "";
            txtGSM.Text = "";
            txtTelefonNo.Text = "";
            cbYetkili.Checked = false;
            txtAdres.Text = "";
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtMaas.Text = "";
            dtpİseBaslama.Text = "";
            dtpDogumTarihi.Text = "";
            cbUnvan.Text = "";
            cbCinsiyet.Text = "";
            cbMedeniHali.Text = "";
            cbKanGrubu.Text = "";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            databaseControl.DeleteKullanici(new kullanici
            {
                kodu = Convert.ToInt32(txtKullaniciKodu.Text)
            });
            MessageBox.Show("Kullanıcı Sİlindi");
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!Kontrol())
            {
                MessageBox.Show("Lütfen tüm yerleri doldurunuz");
                return;
            }
            
            if (btnGuncelle.Text == "Güncelle")
            {
                databaseControl.UpdateKullanici(new kullanici
                {
                    kodu = Convert.ToInt32(txtKullaniciKodu.Text),
                    ad = txtAd.Text,
                    soyad = txtSoyad.Text,
                    sifre = txtSifre.Text,
                    yetki = cbYetkili.Checked ? "true" : "false",
                    evtel = txtTelefonNo.Text,
                    ceptel = txtGSM.Text,
                    adres = txtAdres.Text,
                    unvan = cbUnvan.Text,
                    isebaslama = dtpİseBaslama.Value,
                    maas = txtMaas.Text,
                    dogumyeri = txtDogumYeri.Text,
                    annead = txtAnneAdi.Text,
                    babaad = txtBabaAdi.Text,
                    cinsiyet = cbCinsiyet.Text,
                    kangrubu = cbKanGrubu.Text,
                    medenihal = cbMedeniHali.Text,
                    dogumtarihi = dtpDogumTarihi.Value,
                    tckimlikno = txtTC.Text,
                    username = txtKullaniciAdi.Text
                });
                MessageBox.Show("Kullanıcı Güncelledi");
                this.Close();
            }
            else
            {
                databaseControl.AddKullanici(new kullanici
                {
                    ad = txtAd.Text,
                    soyad = txtSoyad.Text,
                    sifre = txtSifre.Text,
                    yetki = cbYetkili.Checked ? "true" : "false",
                    evtel = txtTelefonNo.Text,
                    ceptel = txtGSM.Text,
                    adres = txtAdres.Text,
                    unvan = cbUnvan.Text,
                    isebaslama = dtpİseBaslama.Value,
                    maas = txtMaas.Text,
                    dogumyeri = txtDogumYeri.Text,
                    annead = txtAnneAdi.Text,
                    babaad = txtBabaAdi.Text,
                    cinsiyet = cbCinsiyet.Text,
                    kangrubu = cbKanGrubu.Text,
                    medenihal = cbMedeniHali.Text,
                    dogumtarihi = dtpDogumTarihi.Value,
                    tckimlikno = txtTC.Text,
                    username = txtKullaniciAdi.Text
                });
                MessageBox.Show("Kullanıcı Kaydedildi");
                this.Close();
            }
            
        }

        private void txtMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDogumYeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private bool Kontrol()
        {
            if (txtTC.Text == "" |
                txtAd.Text == "" ||
                txtSoyad.Text == "" ||
                txtAdres.Text == "" ||
                cbCinsiyet.Text == "" ||
                txtGSM.Text == "" ||
                txtKullaniciAdi.Text == "" ||
                txtSifre.Text == "")
                return false;
            return true;
        }
    }
}
