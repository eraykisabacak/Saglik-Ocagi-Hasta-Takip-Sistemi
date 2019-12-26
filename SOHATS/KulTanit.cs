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
    public partial class KulTanit : Form
    {
        public KulTanit(AnaForm anaForm, FormControl formControl)
        {
            InitializeComponent();

            this.anaForm = anaForm;
            this.formControl = formControl;
        }
        
        AnaForm anaForm;
        FormControl formControl;
        DatabaseControl databaseControl = new DatabaseControl();

        private void KulTanit_Load(object sender, EventArgs e)
        {
            List<kullanici> kullanicis = databaseControl.GetKullanici();
            foreach (var kullanci in kullanicis)
            {
                cbKullaniciKodu.Items.Add(kullanci.username);
            }
        }

        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            KullaniciPage kullaniciPage = new KullaniciPage();
            kullaniciPage.btnGuncelle.Text = "Kaydet";
            this.Close();
            formControl.Open(kullaniciPage);

        }

        private void cbKullaniciKodu_SelectedValueChanged(object sender, EventArgs e)
        {
            string kullaniciKodu = cbKullaniciKodu.Text;
            kullanici kullanicis = databaseControl.GetKullanici(kullaniciKodu);
            formControl.Open(new KullaniciPage(kullanicis));
        }
    }
}
