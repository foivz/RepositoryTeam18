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
    public partial class DodajKorisnika : Form
    {
        public DodajKorisnika()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void DodajKorisnika_Load(object sender, EventArgs e)
        {

        }

        private void Uredu_Click(object sender, EventArgs e)
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
                    Uloga = 3
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
    }
}
