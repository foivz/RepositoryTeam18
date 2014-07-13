using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velpro_za_korisnika
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArtikliKosarica forma = new ArtikliKosarica();
            forma.ShowDialog();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            ListaZelja forma = new ListaZelja();
            forma.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GlavnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
