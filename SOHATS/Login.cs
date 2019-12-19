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
            txtKullanici.Text = "k1";
            txtSifre.Text = "212121";
            if (txtKullanici.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adını Giriniz");
                return;
            }
            if (txtSifre.Text == "")
            {
                MessageBox.Show("Lütfen Şifre Giriniz");
                return;
            }

            string kullanici_adi = txtKullanici.Text;
            string sifre = txtSifre.Text;

            if (databaseControl.kullaniciGirisi(kullanici_adi, sifre))
            {
                //MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                FormControl.AnaForm.menuStrip1.Enabled = true;
                FormControl.AnaForm.referanslar.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı ad ve/veya şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
