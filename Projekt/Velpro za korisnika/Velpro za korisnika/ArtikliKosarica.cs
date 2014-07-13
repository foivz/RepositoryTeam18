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

namespace Velpro_za_korisnika
{
    public partial class ArtikliKosarica : Form
    {
        public int idNarudzbenice;

        public ArtikliKosarica()
        {
            InitializeComponent();
        }

        private void ArtikliKosarica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't18_DBDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this.t18_DBDataSet.Artikli);

        }

        private void btnKosarica_Click(object sender, EventArgs e)
        {

            DataGridViewRow redak = new DataGridViewRow();
            redak = (DataGridViewRow)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Clone();
            DataGridViewColumn kolicina = dataGridView2.Columns[5];
            int index = 0;
            foreach (DataGridViewCell cell in dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells)
            {
                redak.Cells[index].Value = cell.Value;
                index++;
            }
            if (txtKolicina.Text == "")
            {
                redak.Cells[5].Value = 1.00;
            }
            else
            {
                redak.Cells[5].Value = txtKolicina.Text;
            }
            dataGridView2.Rows.Add(redak);
            dataGridView2.Refresh();
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            using (var db = new T18_DBEntities())
            {
                db.Database.Connection.Open();
                Narudzbenice narudzba = new Narudzbenice
                {
                    Adresa_dostave = txtAdresa.Text,
                    Datum_i_vrijeme = DateTime.Now,
                    ID_korisnika = Prijava.ID,
                    Aktivna = true,
                    Dobavljacis = null
                };
                db.Narudzbenices.Add(narudzba);
                db.SaveChanges();
                idNarudzbenice = narudzba.ID_narudzbenice;
            }
            using (var db = new T18_DBEntities())
            {
                NumberStyles style;
                style = NumberStyles.Integer;
                db.Database.Connection.Open();
                foreach (DataGridViewRow redak in this.dataGridView2.Rows)
                {
                    Stavke_narudzbe stavke = new Stavke_narudzbe
                    {
                        ID_artikla = (int)redak.Cells[0].Value,
                        Kolicina = decimal.Parse(redak.Cells[5].Value.ToString(),style),
                        ID_narudzbenice = idNarudzbenice
                    };
                    db.Stavke_narudzbe.Add(stavke);
                    db.SaveChanges();
                }
            }
            Close();
        }

        private void txtAdresa_TextChanged(object sender, EventArgs e)
        {
            if (txtAdresa.Text == "")
            {
                btnNaruci.Enabled = false;
            }
            else
            {
                btnNaruci.Enabled = true;
            }
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            int i = dataGridView2.CurrentCell.RowIndex;

            if (i > 0)
            {
                dataGridView2.Rows.RemoveAt(i);
                dataGridView2.Refresh();
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }


    }
}
