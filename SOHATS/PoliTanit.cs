using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOHATS.DB;
namespace SOHATS
{
    public partial class PoliTanit : Form
    {
        public PoliTanit(AnaForm anaForm,FormControl formControl)
        {
            InitializeComponent();
            this.anaForm = anaForm;
            this.formControl = formControl;
           
        }
        AnaForm anaForm;
        FormControl formControl;
        DatabaseControl databaseControl = new DatabaseControl();

        private void PoliTanit_Load(object sender, EventArgs e)
        {
            SOHATSEntities3 context = new SOHATSEntities3();
            
            List<poliklinik> poliks = context.poliklinik.ToList();
            foreach (var polik in poliks)
            {
                cbPoliklinikAdi.Items.Add(polik.poliklinikadi);
            }

        }

        private void cbPoliklinikAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string poliklinikAdi = cbPoliklinikAdi.Text;
                poliklinik p = databaseControl.GetPoliklinik(poliklinikAdi);
                if(p.poliklinikadi == null)
                {
                    poliklinik poli = new poliklinik
                    {
                        poliklinikadi = poliklinikAdi,
                        durum = "True",
                        aciklama = null
                    };
                    databaseControl.AddPoliklinik(poli);
                    formControl.Open(new PoliklinikPage(poli.id, poli.poliklinikadi, Convert.ToBoolean(poli.durum), poli.aciklama));
                }
                else
                {
                    formControl.Open(new PoliklinikPage(p.id, p.poliklinikadi, Convert.ToBoolean(p.durum), p.aciklama));
                }
            }
        }
    }
}
