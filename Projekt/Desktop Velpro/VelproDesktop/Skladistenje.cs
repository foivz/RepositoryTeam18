using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelproDesktop
{
    public partial class Skladistenje : Form
    {
        public Skladistenje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Skladiste formaSkladiste = new Skladiste();
            formaSkladiste.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrimanjeRobe formaPrimanje = new PrimanjeRobe();
            formaPrimanje.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OtpremaRobe formaOtprema = new OtpremaRobe();
            formaOtprema.Show();
        }
    }
}
