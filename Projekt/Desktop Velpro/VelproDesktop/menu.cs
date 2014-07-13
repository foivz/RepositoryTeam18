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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Azuriraj_Click(object sender, EventArgs e)
        {
            Zaposlenici formaZaposlenika = new Zaposlenici();
            formaZaposlenika.Show();
        }

        private void PregledAktivne_Click(object sender, EventArgs e)
        {
            AktivneNarudzbe formaAktivne = new AktivneNarudzbe();
            formaAktivne.Show();
        }

        private void PregledArhiva_Click(object sender, EventArgs e)
        {
            ArhivaNarudzbi formaArhive = new ArhivaNarudzbi();
            formaArhive.Show();
        }

        private void PregledSkladiste_Click(object sender, EventArgs e)
        {
            Skladiste formaSkladiste = new Skladiste();
            formaSkladiste.Show();
        }

        private void PregledZelje_Click(object sender, EventArgs e)
        {
            ListaZelja formaZelje = new ListaZelja();
            formaZelje.Show();
        }

        private void NarucitiDobavljac_Click(object sender, EventArgs e)
        {
            Naruciti formaNaruciti = new Naruciti();
            formaNaruciti.Show();
        }

        private void Statistika_Click(object sender, EventArgs e)
        {
            Statistike formaStatistike = new Statistike();
            formaStatistike.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            
        }

        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
