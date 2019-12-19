using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOHATS
{
    public class FormControl
    {
        private AnaForm anaForm;
        private static Form aktif;
        public static Form Aktif { get => aktif; set => aktif = value; }

        public static AnaForm AnaForm { get; set; }

        public FormControl() { }

        public FormControl(AnaForm anaForm)
        {
            this.anaForm = anaForm;
            AnaForm = anaForm;
        }

        public void Open(Form form)
        {
            if (aktif != null)
                aktif.Close();
            Aktif = form;
            form.MdiParent = anaForm;
            form.StartPosition = FormStartPosition.CenterScreen;
            Aktif.Show();
        }
    }
}
