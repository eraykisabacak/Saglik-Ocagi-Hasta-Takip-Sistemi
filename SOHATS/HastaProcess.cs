﻿using SOHATS.DB;
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
                if (hastam == null)
                {
                    MessageBox.Show("Hasta Yok");
                }
                else
                {
                    txtHastaAdi.Text = hastam.ad;
                    txtSoyadi.Text = hastam.soyad;
                    txtKurumAdi.Text = hastam.kurumadi;
                    sevk sevk = databaseControl.GetSevk(dosyaNo);
                    if (sevk.dosyano == null)
                    {
                        return;
                    }
                    else
                    {
                        txtHastaAdi.Text = hastam.ad;
                        txtSoyadi.Text = hastam.soyad;
                        txtKurumAdi.Text = hastam.kurumadi;
                    }
                }
                
                

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
            if(dgwTahlilveİslemler.Rows.Count < 2)
            {
                MessageBox.Show("Lütfen veri giriniz");
                return;
            }
            printDocument1.Print();
        }
        
        Font baslik = new Font("Verdana", 20, FontStyle.Bold);
        Font govde = new Font("Verdana", 12);
        SolidBrush brush = new SolidBrush(Color.Black);

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //DGV
            int j = 800;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Rapor Tarih : " + DateTime.Now.Date.ToLongDateString(), govde, brush, 70, 20);
            e.Graphics.DrawString("Hasta Sevk İşlemleri: " + txtHastaAdi.Text.ToUpper() + " " + txtSoyadi.Text.ToUpper() + " \n- Tahlil ve İşlem Sonuçları", baslik, brush,50,70);
            e.Graphics.DrawString("Poliklinik       Sıra No     Saat          İşlem     Dr.Kodu     Miktar     Birim", govde, brush, 70, 170);
            e.Graphics.DrawString("---------------------------------------------------------------------------------", govde, brush, 70, 190);
            for (int i = 0; i < dgwTahlilveİslemler.Rows.Count; i++)
            {
                e.Graphics.DrawString(dgwTahlilveİslemler.Rows[i].Cells[0].Value + "\t" +
                                      dgwTahlilveİslemler.Rows[i].Cells[1].Value + "\t" + 
                                      dgwTahlilveİslemler.Rows[i].Cells[2].Value + "\t" +
                                      dgwTahlilveİslemler.Rows[i].Cells[3].Value + "\t\t" + 
                                      dgwTahlilveİslemler.Rows[i].Cells[4].Value + "\t" +
                                      dgwTahlilveİslemler.Rows[i].Cells[5].Value + "\t" + 
                                      dgwTahlilveİslemler.Rows[i].Cells[6].Value + "\t", 
                                      govde, brush, 70, 210 + (i * 30));
                j = i;
            }
            e.Graphics.DrawString("  **Toplam Tutar : " + lblTutar.Text, govde, brush, 100, 210 + (j * 30) + 50);
            kullanici doktor = databaseControl.DoktorAdi(int.Parse(dgwTahlilveİslemler.Rows[0].Cells[4].Value.ToString()));
            e.Graphics.DrawString("Doktor Adı : " + doktor.ad + " " + doktor.soyad, govde, brush, 70, 38);
            
        }

        private void btnBaskiOnizleme_Click(object sender, EventArgs e)
        {
            if (dgwTahlilveİslemler.Rows.Count < 2)
            {
                MessageBox.Show("Lütfen veri giriniz");
                return;
            }
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            /*
            int height = dgwTahlilveİslemler.Height;
            dgwTahlilveİslemler.Height = dgwTahlilveİslemler.RowCount * dgwTahlilveİslemler.RowTemplate.Height * 2;
            bitmap = new Bitmap(dgwTahlilveİslemler.Width, dgwTahlilveİslemler.Height);
            dgwTahlilveİslemler.DrawToBitmap(bitmap, new Rectangle(0, 0, dgwTahlilveİslemler.Width, dgwTahlilveİslemler.Height));
            dgwTahlilveİslemler.Height = height;
            printPreviewDialog1.ShowDialog();*/
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            HastaBilgileri hastaBilgileri = new HastaBilgileri(anaForm,formControl,databaseControl.GetYeniDosyaNumarasi(),"new");
            hastaBilgileri.MdiParent = anaForm;
            hastaBilgileri.Visible = true;
        }
    }
}