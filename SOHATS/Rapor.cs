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
    public partial class Rapor : Form
    {
        public Rapor(AnaForm anaForm, FormControl formControl)
        {
            InitializeComponent();
            this.anaForm = anaForm;
            this.formControl = formControl;
            dtpBitis.MaxDate = DateTime.Today;
            dtpBaslangic.MaxDate = DateTime.Today;
        }
        AnaForm anaForm;
        FormControl formControl;
        DatabaseControl databaseControl = new DatabaseControl();

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dgwHasta.Rows.Clear();
            dtpBaslangic.Value = DateTime.Today;
            dtpBitis.Value = DateTime.Today;
            rbTaburcuOlmus.Checked = true;
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            dgwHasta.Rows.Clear();
            DateTime baslangic = dtpBaslangic.Value;
            DateTime bitis = dtpBitis.Value;
            List<RaporTaburcu> sevks = new List<RaporTaburcu>();

            if (rbHepsi.Checked)
            {
                sevks = databaseControl.GetTaburcu(baslangic,bitis);
            }
            else if (rbTaburcuOlmus.Checked)
            {
                sevks = databaseControl.GetTaburcu(true,baslangic, bitis);
            }
            else if (rbTaburcuOlmamis.Checked)
            {
                sevks = databaseControl.GetTaburcu(false, baslangic, bitis);
            }
            else
            {
                MessageBox.Show("Lütfen bir durum seçiniz");
                return;
            }

            if(sevks.Count < 1)
            {
                MessageBox.Show("Herhangi bir veri bulunamadı");
            }

            foreach (RaporTaburcu rapor in sevks)
            {
                dgwHasta.Rows.Add(rapor.Dosyano,
                                  rapor.Ad,
                                  rapor.Soyad,
                                  rapor.Sevktarihi,
                                  rapor.Poliklinik,
                                  rapor.Doktoradi,
                                  rapor.Doktorsoyad);
            }

        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if(dgwHasta.Rows.Count < 2)
            {
                MessageBox.Show("Lütfen tabloya değer giriniz");
                return;
            }
            printDocument1.Print();
            PrintDialog yazdir = new PrintDialog();
            yazdir.Document = printDocument1;
            yazdir.UseEXDialog = true;
            if (yazdir.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        Font baslik = new Font("Verdana", 20, FontStyle.Bold);
        Font govde = new Font("Verdana", 12);
        SolidBrush brush = new SolidBrush(Color.Black);

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Rapor Tarih : " + DateTime.Now.Date.ToLongDateString(), govde, brush, 50, 20);
            e.Graphics.DrawString("Taburcular Raporu", baslik, brush, 50, 70);
            e.Graphics.DrawString("Dosya No       Ad     Soyad          Sevk Tarihi     Poliklinik     Doktor Adı     Doktor Soyadı", govde, brush, 50, 170);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------", govde, brush, 50, 190);
            for (int i = 0; i < dgwHasta.Rows.Count-1; i++)
            {
                DateTime tarih = DateTime.Parse(dgwHasta.Rows[i].Cells[3].Value.ToString());
                e.Graphics.DrawString(dgwHasta.Rows[i].Cells[0].Value + "     " +
                                      dgwHasta.Rows[i].Cells[1].Value + "\t" +
                                      dgwHasta.Rows[i].Cells[2].Value + "\t" +
                                      tarih.ToShortDateString()+ "\t" +
                                      dgwHasta.Rows[i].Cells[4].Value + "\t" +
                                      dgwHasta.Rows[i].Cells[5].Value + "\t" +
                                      dgwHasta.Rows[i].Cells[6].Value + "\t",
                                      govde, brush, 50, 210 + (i * 30));
            }
        }

        private void btnOnizleme_Click(object sender, EventArgs e)
        {
            if (dgwHasta.Rows.Count < 2)
            {
                MessageBox.Show("Lütfen veri giriniz");
                return;
            }
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
