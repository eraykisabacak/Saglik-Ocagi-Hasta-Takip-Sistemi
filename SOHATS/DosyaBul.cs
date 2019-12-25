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
    public partial class DosyaBul : Form
    {
        public DosyaBul(AnaForm anaForm, FormControl formControl)
        {
            InitializeComponent();
            this.anaForm = anaForm;
            this.formControl = formControl;
        }

        AnaForm anaForm;
        FormControl formControl;
        DatabaseControl databaseControl = new DatabaseControl();

        private void cbSecenek_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbSecenek.SelectedIndex == 0)
            {
                pnlAd.Visible = true;
                pnlOther.Visible = false;
            }
            else
            {
                pnlAd.Visible = false;
                pnlOther.Visible = true;
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            dgwHasta.Rows.Clear();
            if(cbSecenek.Text == "")
            {
                MessageBox.Show("Lütfen bir seçim yapınız");
                return;
            }
            if(cbSecenek.SelectedIndex == 0)
            {
                string ad = txtAd.Text != "" ? txtAd.Text : "0";
                string soyad = txtSoyad.Text != "" ? txtSoyad.Text : "0";

                if (cbVe.Checked)
                {
                    if (ad.Equals("0"))
                    {
                        MessageBox.Show("Lütfen adını giriniz veya 've' işaretlemeyiz");
                        return;
                    }
                    if (soyad.Equals("0"))
                    {
                        MessageBox.Show("Lütfen Soyadını giriniz veya 've' işaretlemeyiz");
                        return;
                    }
                    // VE 
                    List<hasta> hastas = databaseControl.GetHastaAdSoyad(ad, soyad,true);
                    if (hastas.Count < 1)
                    {
                        MessageBox.Show("Kişi bulunamadı");
                        return;
                    }
                    foreach (hasta hasta in hastas)
                    {
                        dgwHasta.Rows.Add(hasta.tckimlikno,
                                  hasta.dosyano,
                                  hasta.ad,
                                  hasta.soyad,
                                  hasta.dogumyeri,
                                  hasta.dogumtarihi,
                                  hasta.babaadi,
                                  hasta.anneadi,
                                  hasta.cinsiyet);
                    }         
                }
                else
                {
                    // VEYA
                    List<hasta> hastas = databaseControl.GetHastaAdSoyad(ad, soyad, false);
                    if (hastas.Count < 1)
                    {
                        MessageBox.Show("Kişi bulunamadı");
                        return;
                    }
                    foreach (hasta hasta in hastas)
                    {
                        dgwHasta.Rows.Add(hasta.tckimlikno,
                                  hasta.dosyano,
                                  hasta.ad,
                                  hasta.soyad,
                                  hasta.dogumyeri,
                                  hasta.dogumtarihi,
                                  hasta.babaadi,
                                  hasta.anneadi,
                                  hasta.cinsiyet);
                    }

                }
            }
            else if(cbSecenek.SelectedIndex == 1)
            {
                string kimlikNo = txtArama.Text;
                hasta hastas = databaseControl.GetHastaKimlikNo(kimlikNo);

                bool durum = HastaYok(hastas);
                if (!durum)
                    return;

                dgwHasta.Rows.Add(hastas.tckimlikno,
                                  hastas.dosyano,
                                  hastas.ad,
                                  hastas.soyad,
                                  hastas.dogumyeri,
                                  hastas.dogumtarihi,
                                  hastas.babaadi,
                                  hastas.anneadi,
                                  hastas.cinsiyet);
            }
            else if (cbSecenek.SelectedIndex == 2)
            {
                string kurumSicilNo = txtArama.Text;
                hasta hastas = databaseControl.GetHastaKurumSicilNo(kurumSicilNo);

                bool durum = HastaYok(hastas);
                if (!durum)
                    return;

                dgwHasta.Rows.Add(hastas.tckimlikno,
                                  hastas.dosyano,
                                  hastas.ad,
                                  hastas.soyad,
                                  hastas.dogumyeri,
                                  hastas.dogumtarihi,
                                  hastas.babaadi,
                                  hastas.anneadi,
                                  hastas.cinsiyet);
            }
            else if (cbSecenek.SelectedIndex == 3)
            {
                string dosyaNo = txtArama.Text;

                hasta hastas = databaseControl.GetHastaDosyaNo(dosyaNo);

                bool durum = HastaYok(hastas);
                if (!durum)
                    return;

                dgwHasta.Rows.Add(hastas.tckimlikno,
                                  hastas.dosyano,
                                  hastas.ad,
                                  hastas.soyad,
                                  hastas.dogumyeri,
                                  Convert.ToDateTime(hastas.dogumtarihi).ToShortDateString(),
                                  hastas.babaadi,
                                  hastas.anneadi,
                                  hastas.cinsiyet);
            }
        }

        private bool HastaYok(hasta hastas)
        {
            if (hastas.tckimlikno == "0")
            {
                MessageBox.Show("Kişi bulunamadı");
                return false;
            }
            return true;
        }
    }
}
