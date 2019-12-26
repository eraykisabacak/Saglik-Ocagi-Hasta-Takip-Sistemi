using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOHATS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            DatabaseControl databaseControl = new DatabaseControl();
            string kullanici_adi = txtKullanici.Text;
            string sifre = txtSifre.Text;
            if (kullanici_adi == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adını Giriniz");
                return;
            }
            if (sifre == "")
            {
                MessageBox.Show("Lütfen Şifre Giriniz");
                return;
            }

            List<bool> kontrol = databaseControl.kullaniciGirisi(kullanici_adi, sifre);

            if (kontrol[0])
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                if (kontrol[1])
                {
                    FormControl.AnaForm.referanslar.Enabled = true;
                }
                FormControl.AnaForm.menuStrip1.Enabled = true;
                FormControl.AnaForm.referanslar.Visible = true;
                this.Close();
            }
            else
            {
                if (!kontrol[2])
                {
                    MessageBox.Show("Veri tabanında sıkıntı oluştu");
                    Application.Exit();
                }
                MessageBox.Show("Yanlış Kullanıcı ad ve/veya şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKullanici.Text = "";
                txtSifre.Text = "";
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            MdiParent.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKullanici.Clear();
            txtSifre.Clear();
        }

        private void txtKullanici_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                btnGiris_Click(this, new EventArgs());
            }
        }
    }
}
