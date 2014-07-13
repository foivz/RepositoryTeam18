using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelproDesktop
{
    public partial class Dodaj_Narudzbu : Form
    {
        public int IDNarudzbe;
        public Dodaj_Narudzbu()
        {
            InitializeComponent();
        }

        private void Dodaj_Narudzbu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't18_DBDataSet16.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter1.Fill(this.t18_DBDataSet16.Artikli);
            // TODO: This line of code loads data into the 't18_DBDataSet15.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this.t18_DBDataSet15.Artikli);
            // TODO: This line of code loads data into the 't18_DBDataSet14.Dobavljaci' table. You can move, or remove it, as needed.
            this.dobavljaciTableAdapter1.Fill(this.t18_DBDataSet14.Dobavljaci);
            // TODO: This line of code loads data into the 't18_DBDataSet13.Dobavljaci' table. You can move, or remove it, as needed.
            this.dobavljaciTableAdapter.Fill(this.t18_DBDataSet13.Dobavljaci);

        }

        private void Odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Uredu_Click(object sender, EventArgs e)
        {
            using (var db = new T18_DBEntities())
            {
                db.Database.Connection.Open();
                Stavke_narudzbe sn = new Stavke_narudzbe
                {

                };
                Narudzbenice Narudzba = new Narudzbenice
                {
                    Adresa_dostave = Adresa.Text,
                    ID_korisnika = Form1.ID,
                    Datum_i_vrijeme = DateTime.Now,
                    Aktivna = true,
                    ID_dobavljaca = int.Parse(Dobavljac.SelectedValue.ToString())
                };
                db.Narudzbenice.Add(Narudzba);
                db.SaveChanges();
                IDNarudzbe = Narudzba.ID_narudzbenice;
            }
            using (var db = new T18_DBEntities())
            {
                NumberStyles style;
                style = NumberStyles.Integer;
                db.Database.Connection.Open();
                foreach (DataGridViewRow redak in this.Naruceno.Rows)
                {
                    Stavke_narudzbe stavke = new Stavke_narudzbe
                    {
                        ID_artikla = (int)redak.Cells[0].Value,
                        Kolicina = decimal.Parse(redak.Cells[5].Value.ToString(), style),
                        ID_narudzbenice = IDNarudzbe
                    };
                    db.Stavke_narudzbe.Add(stavke);
                    db.SaveChanges();
                }
            }
            Close();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            DataGridViewRow redak = new DataGridViewRow();
            redak = (DataGridViewRow)Artikli.Rows[Artikli.CurrentCell.RowIndex].Clone();
            DataGridViewColumn kolicina = Naruceno.Columns[5];
            int index = 0;
            foreach (DataGridViewCell cell in Artikli.Rows[Artikli.CurrentCell.RowIndex].Cells)
            {
                redak.Cells[index].Value = cell.Value;
                index++;
            }
            if (KolicinaArtikla.Text == "")
            {
                redak.Cells[5].Value = 1.00;
            }
            else
            {
                redak.Cells[5].Value = KolicinaArtikla.Text;
            }
            Naruceno.Rows.Add(redak);
            Naruceno.Refresh();
        }

        private void KolicinaArtikla_TextChanged(object sender, EventArgs e)
        {

        }

        private void obrisi_Click(object sender, EventArgs e)
        {
            int i = Naruceno.CurrentCell.RowIndex;

            if (i >= 0)
            {
                Naruceno.Rows.RemoveAt(i);
                Naruceno.Refresh();
            }
        }

        private void obrisiSve_Click(object sender, EventArgs e)
        {
            Naruceno.Rows.Clear();
        }
    }
}
