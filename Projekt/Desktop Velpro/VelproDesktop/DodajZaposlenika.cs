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
    public partial class DodajZaposlenika : Form
    {
        public DodajZaposlenika()
        {
            InitializeComponent();
          //  this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void DodajZaposlenika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't18_DBDataSet6.Uloge' table. You can move, or remove it, as needed.
           this.ulogeTableAdapter.Fill(this.t18_DBDataSet6.Uloge);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new T18_DBEntities1())
            {
                db.Database.Connection.Open();
                Korisnici Korisnik = new Korisnici
                {
                    Ime = Ime.Text,
                    Prezime = Prezime.Text,
                    Korisnicko_ime = korIme.Text,
                    Lozinka = Lozinka.Text,
                    E_mail = mail.Text,
                    Broj_telefona = brTel.Text,
                    Uloga = 2
                };
                db.Korisnici.Add(Korisnik);
                db.SaveChanges();
                MessageBox.Show("Uspješno unešeno!");
                this.Close();
            }
        }

        private void Odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lozinka_TextChanged(object sender, EventArgs e)
        {

        }

        private void korIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
