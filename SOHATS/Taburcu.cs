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
        public Taburcu(FormControl formControl,string tutar,string dosyano,List<sevk> sevkler)
        {
            InitializeComponent();
            this.formControl = formControl;
            this.tutar = tutar;
            this.dosyano = dosyano;
            this.sevkler = sevkler;    
        }

        FormControl formControl;
        string tutar;
        string dosyano;
        List<sevk> sevkler;

        DatabaseControl databaseControl = new DatabaseControl();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Taburcu_Load(object sender, EventArgs e)
        {
            txtDosyaNo.Text = dosyano;
            txtTutar.Text = tutar;
            dtpSevkTarihi.Text = sevkler[0].sevktarihi.ToShortDateString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(cbOdeme.Text == "")
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi giriniz");
                return;
            }
            cikis cikis = new cikis()
            {
                id = databaseControl.GetCikisId(),
                dosyano = int.Parse(txtDosyaNo.Text),
                sevktarihi = dtpSevkTarihi.Value.ToShortDateString().ToString(),
                cikissaati = DateTime.Now,
                odeme = cbOdeme.Text,
                toplamtutar = txtTutar.Text
            };
            databaseControl.AddCikis(cikis);

            foreach(sevk sevk in sevkler)
            {
                sevk s = databaseControl.GetSevkId(sevk.id);
                s.taburcu = "True";
                databaseControl.UpdateSevk(s,true);
            }

            MessageBox.Show("Çıkışınız Tamamlanmıştır");
            this.Close();
        }
    }
}
