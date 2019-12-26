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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            formControl = new FormControl(this);
        }

        FormControl formControl;

        private void AnaForm_Load(object sender, EventArgs e)
        {
            formControl.Open(new Login());
        }

        public void GirisBasarisiz()
        {
            menuStrip1.Enabled = false;
            referanslar.Visible = false;
            referanslar.Enabled = false;
        }

        private void poliklinikTanitma_Click(object sender, EventArgs e)
        {
            formControl.Open(new PoliTanit(this,formControl));
        }

        private void kullanıcıTanıtma_Click(object sender, EventArgs e)
        {
            formControl.Open(new KulTanit(this, formControl));
        }

        private void logout_Click(object sender, EventArgs e)
        {
            GirisBasarisiz();
            formControl.Open(new Login());
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hastaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(menuStrip1.Enabled != false)
            {
                formControl.Open(new HastaProcess(this, formControl));
            }
        }

        private void rapor1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formControl.Open(new Rapor(this, formControl));
        }
    }
}
