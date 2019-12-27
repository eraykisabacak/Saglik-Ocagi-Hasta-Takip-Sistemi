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
            dtpSevkTarihi.MinDate = DateTime.Today;
            dtpSevkTarihi.Value = DateTime.Today;
        }
        AnaForm anaForm;
        FormControl formControl;

        DatabaseControl databaseControl = new DatabaseControl();

        private void btnBul_Click(object sender, EventArgs e)
        {
            dgwTahlilveİslemler.Rows.Clear();
            if(txtDosyaNo.Text == "")
            {
                DosyaBul dosyaBul = new DosyaBul(anaForm,formControl);
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
                
                List<DateTime> oncekiler = databaseControl.GetOncekiİslemler(dosyaNo);
                cbOncekiIslemler.Text = " ";
                cbOncekiIslemler.Items.Clear();
                foreach(DateTime dt in oncekiler)
                {
                    cbOncekiIslemler.Items.Add(dt);
                }
            }

        }

        private void txtDosyaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnBul_Click(this, new EventArgs());
            }
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            dgwTahlilveİslemler.Rows.Clear();
            if(cbOncekiIslemler.Text == null)
            {
                MessageBox.Show("Lütfen bir tarih seçiniz");
                return;
            }
            GetTahlil();
        }

        private void GetTahlil()
        {
            string dosyaNo = txtDosyaNo.Text;
            DateTime tarih = Convert.ToDateTime(cbOncekiIslemler.Text);
            int miktar = 0;

            List<sevk> sevkler = databaseControl.GetYapilanTahlilİslemler(dosyaNo, tarih);
            foreach (sevk sevk in sevkler)
            {
                dgwTahlilveİslemler.Rows.Add(sevk.poliklinik,
                                             sevk.sira,
                                             sevk.saat,
                                             sevk.yapilanislem,
                                             sevk.drkod,
                                             sevk.miktar,
                                             sevk.birimfiyat,
                                             sevk.id);        
                miktar += Convert.ToInt32(sevk.birimfiyat);
            }
            if(sevkler.Count != 0)
            {
                if (sevkler[0].taburcu != null && sevkler[0].taburcu.ToUpper() == "TRUE")
                {
                    MessageBox.Show("Hasta bu sevkten taburcu edilmiştir");
                }
            }
            lblTutar.Text = miktar + " TL";
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if(dgwTahlilveİslemler.Rows.Count < 2)
            {
                MessageBox.Show("Lütfen veri giriniz");
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
                                      dgwTahlilveİslemler.Rows[i].Cells[2].Value + "\t\t" +
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
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
            HastaBilgileri hastaBilgileri = new HastaBilgileri(anaForm,formControl,databaseControl.GetYeniDosyaNumarasi(),"new");
            hastaBilgileri.MdiParent = anaForm;
            hastaBilgileri.Visible = true;
        }

        private void Temizle()
        {
            txtDosyaNo.Text = "";
            dtpSevkTarihi.Value = DateTime.Today;
            cbOncekiIslemler.Text = "";
            txtHastaAdi.Text = "";
            txtSoyadi.Text = "";
            txtKurumAdi.Text = "";
            cbPoliklinik.Text = "";
            txtSiraNo.Text = "";
            cbYapilanİslem.Text = "";
            cbDrKodu.Text = "";
            nudMiktar.Text = "";
            txtBirimFiyat.Text = "";
            dgwTahlilveİslemler.Rows.Clear();
            lblTutar.Text = "0 TL";
        }

        private void btnHastaBilgileri_Click(object sender, EventArgs e)
        {
            if(txtDosyaNo.Text != "")
            {
                HastaBilgileri hastaBilgileri = new HastaBilgileri(anaForm, formControl, int.Parse(txtDosyaNo.Text));
                hastaBilgileri.MdiParent = anaForm;
                hastaBilgileri.Visible = true;
            }
            else
            {
                MessageBox.Show("Lütfen bir hasta yazınız");
            }
        }

        private void btnSecSil_Click(object sender, EventArgs e)
        {
            if(dgwTahlilveİslemler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir satır seçiniz (Polikliniğin Soluna tıklayınız)");
                return;
            }
            foreach (DataGridViewRow drow in dgwTahlilveİslemler.SelectedRows)  
            {
                databaseControl.DeleteIslem(new sevk() { id = int.Parse(drow.Cells[7].Value.ToString()) });
                MessageBox.Show("Seçilen İşlem silinmiştir");
                dgwTahlilveİslemler.Rows.Clear();
                GetTahlil();
            }
        }

        private void HastaProcess_Load(object sender, EventArgs e)
        {
            List<poliklinik> polikliniks = databaseControl.GetPoliklinik(true);
            foreach(poliklinik poli in polikliniks)
            {
                cbPoliklinik.Items.Add(poli.poliklinikadi);
            }

            List<kullanici> doktorlar = databaseControl.GetKullanici(true);
            foreach (kullanici doktor in doktorlar)
            {
                cbDrKodu.Items.Add(doktor.kodu);
            }

            List<islem> islemler = databaseControl.GetIslem();
            foreach(islem islem in islemler)
            {
                cbYapilanİslem.Items.Add(islem.islemAdi);
            }
        }

        private void cbPoliklinik_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbPoliklinik.Text == "")            
                return;
            sevk sevk = databaseControl.Sira(cbPoliklinik.Text,dtpSevkTarihi.Value);

            if(sevk == null)
            {
                txtSiraNo.Text = "1";
            }
            else
            {
                txtSiraNo.Text = (Convert.ToInt16(sevk.sira) + 1).ToString();
            }       
        }

        private void cbYapilanİslem_SelectedValueChanged(object sender, EventArgs e)
        {
            islem islem = databaseControl.GetFiyat(cbYapilanİslem.Text);
            txtBirimFiyat.Text = islem.birimFiyat;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(txtDosyaNo.Text == "")
            {
                MessageBox.Show("Lütfen öncelikle hastayı seçiniz");
                return;
            }
            bool durum = YeniIslemKontrol();
            if (!durum)
            {
                MessageBox.Show("Lütfen sol taraftaki alanları doldurunuz");
                return;
            }
            sevk sevk = new sevk()
            {
                sevktarihi = DateTime.Today,
                dosyano = txtDosyaNo.Text,
                poliklinik = cbPoliklinik.Text,
                saat = DateTime.Now.Hour + ":" + DateTime.Now.Minute,
                yapilanislem = cbYapilanİslem.Text,
                drkod = cbDrKodu.Text,
                miktar = nudMiktar.Text,
                birimfiyat = txtBirimFiyat.Text,
                sira = txtSiraNo.Text,
                toplamtutar = (int.Parse(txtBirimFiyat.Text) * int.Parse(nudMiktar.Text)).ToString(),
                taburcu = false.ToString()
            };
            databaseControl.AddSevk(sevk);
            MessageBox.Show("Sevk Eklenmiştir");
            SevkTemizle();
            TabloDoldur(sevk);
        }

        private bool YeniIslemKontrol()
        {
            bool durum = true;
            if(cbPoliklinik.Text == "")
            {
                durum = false;
            }
            if(txtSiraNo.Text == "")
            {
                durum = false;
            }
            if(cbYapilanİslem.Text == "")
            {
                cbYapilanİslem.SelectedItem = 0;
                durum = false;
            }
            if(cbDrKodu.Text == "")
            {
                durum = false;
            }
            return durum;
        }

        int tutar = 0;

        private void TabloDoldur(sevk sevk)
        {
            dgwTahlilveİslemler.Rows.Add(sevk.poliklinik,
                                         sevk.sira,
                                         sevk.saat,
                                         sevk.yapilanislem,
                                         sevk.drkod,
                                         sevk.miktar,
                                         sevk.birimfiyat,
                                         sevk.id);
            tutar += int.Parse(sevk.birimfiyat) * int.Parse(sevk.miktar);
            lblTutar.Text = tutar + " TL";
        }

        private void SevkTemizle()
        {
            cbPoliklinik.Text = "";
            txtSiraNo.Text = "";
            cbYapilanİslem.Text = "";
            cbDrKodu.Text = "";
            nudMiktar.Value = 1;
        }

        private void btnTaburcu_Click(object sender, EventArgs e)
        {
            List<sevk> sevkler;

            if (txtDosyaNo.Text == "")
            {
                MessageBox.Show("Lütfen hastanın dosya numarasını giriniz");
                return;
            }
            if(dgwTahlilveİslemler.Rows.Count < 2)
            {
                MessageBox.Show("Lütfen kayıtları giriniz");
                return;
            }
            if (dgwTahlilveİslemler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir satır seçiniz (Polikliniğin Soluna tıklayınız)");
                return;
            }
            else
            {
                // Datagridviewda olanlar taburcu olmuş mu
                string dosyaNo = txtDosyaNo.Text;
                if(cbOncekiIslemler.Text == "")
                {
                    sevkler = databaseControl.GetYapilanTahlilİslemler(dosyaNo, Convert.ToDateTime(DateTime.Now.ToShortDateString()));
                }
                else
                {
                    DateTime tarih = Convert.ToDateTime(cbOncekiIslemler.Text);
                    sevkler = databaseControl.GetYapilanTahlilİslemler(dosyaNo, tarih);
                }
                if(sevkler.Count != 0 && sevkler[0].taburcu.ToUpper() == "TRUE")
                {
                    MessageBox.Show("Hasta zaten taburcu olmuştur");
                    return;
                }
            }
            string tutar = lblTutar.Text;
            string dosyano = txtDosyaNo.Text;
            
            Taburcu taburcu = new Taburcu(formControl,tutar,dosyano,sevkler);
            taburcu.MdiParent = anaForm;
            taburcu.Visible = true;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
