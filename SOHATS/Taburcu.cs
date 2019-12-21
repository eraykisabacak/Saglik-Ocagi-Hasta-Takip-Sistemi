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
    public partial class Taburcu : Form
    {
        public Taburcu(FormControl formControl,string tutar,string dosyano)
        {
            InitializeComponent();
            this.formControl = formControl;
            this.tutar = tutar;
            this.dosyano = dosyano;
        }

        FormControl formControl;
        string tutar;
        string dosyano;

        DatabaseControl databaseControl = new DatabaseControl();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Taburcu_Load(object sender, EventArgs e)
        {
            txtDosyaNo.Text = dosyano;
            txtTutar.Text = tutar;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            cikis cikis = new cikis()
            {
                id = databaseControl.GetCikisId(),
                dosyano = txtDosyaNo.Text,
                sevktarihi = dtpSevkTarihi.Value.ToShortDateString().ToString(),
                cikissaati = DateTime.Now,
                odeme = cbOdeme.Text,
                toplamtutar = txtTutar.Text
            };
            databaseControl.AddCikis(cikis);
            MessageBox.Show("Çıkışınız Tamamlanmıştır");
        }
    }
}
