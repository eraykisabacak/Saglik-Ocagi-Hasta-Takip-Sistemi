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
        public DosyaBul()
        {
            InitializeComponent();
        }

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
            if(cbSecenek.SelectedIndex == 0)
            {
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;


            }
            else if(cbSecenek.SelectedIndex == 1)
            {
                string kimlikNo = txtArama.Text;
            }
            else if (cbSecenek.SelectedIndex == 2)
            {
                string kurumSicilNo = txtArama.Text;
            }
            else if (cbSecenek.SelectedIndex == 3)
            {
                string dosyaNo = txtArama.Text;
            }
        }
    }
}
