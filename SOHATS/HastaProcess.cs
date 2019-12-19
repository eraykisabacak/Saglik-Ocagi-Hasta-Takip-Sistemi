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
    public partial class HastaProcess : Form
    {
        public HastaProcess(AnaForm anaForm, FormControl formControl)
        {
            InitializeComponent();
            this.anaForm = anaForm;
            this.formControl = formControl;
            dtpSevkTarihi.MaxDate = DateTime.Today;
            dtpSevkTarihi.Value = DateTime.Today;
        }
        AnaForm anaForm;
        FormControl formControl;

        DatabaseControl databaseControl = new DatabaseControl();

        private void btnBul_Click(object sender, EventArgs e)
        {
            if(txtDosyaNo.Text == "")
            {
                DosyaBul dosyaBul = new DosyaBul();
                dosyaBul.MdiParent = anaForm;
                dosyaBul.Visible = true;
            }
            else
            {
                string dosyaNo = txtDosyaNo.Text;

                hasta hastam = databaseControl.GetHasta(dosyaNo);
                sevk sevk = databaseControl.GetSevk(dosyaNo);
                txtHastaAdi.Text = hastam.ad;
                txtSoyadi.Text = hastam.soyad;
                txtKurumAdi.Text = hastam.kurumadi;

                List<cikis> cikislar = databaseControl.GetOncekiİslemler(dosyaNo);
                cbOncekiIslemler.Text = " ";
                cbOncekiIslemler.Items.Clear();
                foreach (cikis cikis in cikislar)
                {
                    cbOncekiIslemler.Items.Add(cikis.sevktarihi);
                }
            }

        }

        private void txtDosyaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            dgwTahlilveİslemler.Rows.Clear();
            if(cbOncekiIslemler.Text == null)
            {
                MessageBox.Show("Lütfen bir tarih seçiniz");
                return;
            }
            string dosyaNo = txtDosyaNo.Text;
            string tarih = cbOncekiIslemler.Text;
            int miktar = 0;

            List <sevk> sevkler = databaseControl.GetYapilanTahlilİslemler(dosyaNo,tarih);
            foreach (sevk sevk in sevkler)
            {
                dgwTahlilveİslemler.Rows.Add(sevk.poliklinik,
                                             sevk.sira,
                                             sevk.saat,
                                             sevk.yapilanislem,
                                             sevk.drkod,
                                             sevk.miktar,
                                             sevk.birimfiyat);
                if (sevk.taburcu.ToUpper() == "TRUE")
                {
                    MessageBox.Show("Hasta bu sevkten taburcu edilmiştir");
                }
                miktar += Convert.ToInt32(sevk.birimfiyat);
            }
            lblTutar.Text = miktar + " YTL";

        }
        Bitmap bitmap;

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgwTahlilveİslemler.Width, this.dgwTahlilveİslemler.Height);
            dgwTahlilveİslemler.DrawToBitmap(bm, new Rectangle(0, 0, this.dgwTahlilveİslemler.Width, this.dgwTahlilveİslemler.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnBaskiOnizleme_Click(object sender, EventArgs e)
        {
            int height = dgwTahlilveİslemler.Height;
            dgwTahlilveİslemler.Height = dgwTahlilveİslemler.RowCount * dgwTahlilveİslemler.RowTemplate.Height * 2;
            bitmap = new Bitmap(dgwTahlilveİslemler.Width, dgwTahlilveİslemler.Height);
            dgwTahlilveİslemler.DrawToBitmap(bitmap, new Rectangle(0, 0, dgwTahlilveİslemler.Width, dgwTahlilveİslemler.Height));
            dgwTahlilveİslemler.Height = height;
            printPreviewDialog1.ShowDialog();
        }
    }
}
