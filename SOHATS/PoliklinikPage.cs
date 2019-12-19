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
    public partial class PoliklinikPage : Form
    {
        int id;
        public PoliklinikPage(int Id,string poliklinikAdi,bool gecerli,string aciklama)
        {
            InitializeComponent();
            id = Id;
            if(poliklinikAdi != null)
            {
                txtPoliklinik.Text = poliklinikAdi;
            }
            cbGecerli.Checked = gecerli;
            if (aciklama != null)
            {
                txtAciklama.Text = aciklama;
            }
        }

        DatabaseControl databaseControl = new DatabaseControl();

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            databaseControl.DeletePoliklinik(new poliklinik
            {
                id = id
            });
            MessageBox.Show("Poliklinik Silindi");
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            databaseControl.UpdatePoliklinik(new poliklinik {
                id = id,
                poliklinikadi = txtPoliklinik.Text,
                durum = cbGecerli.Checked ? "True" : "False",
                aciklama = txtAciklama.Text
            });
            MessageBox.Show("Poliklinik Güncellendi");
        }
    }
}
